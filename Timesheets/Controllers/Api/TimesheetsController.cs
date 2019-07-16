using Barebone.Controllers;
using Data.Entities;
using Timesheets.Data.Abstractions;
using Timesheets.Data.Entities;
using Timesheets.ViewModels.Timesheet;
using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Timesheets.Controllers.Api
{
    //[Authorize]
    [Route("api/timesheets")]
    public class TimesheetsController : ControllerBaseApi
    {
        public TimesheetsController(IStorage storage) : base(storage)
        {
        }

        [HttpGet]
        public IActionResult Get(int page = 0, int size = 25)
        {
            IEnumerable<Timesheet> data = new TimesheetModelFactory().LoadAll(this.Storage, page, size)?.Timesheets;
            int count = data.Count();

            return Ok(new
            {
                success = true,
                data,
                count,
                totalPage = ((int)count / size) + 1
            });
        }

        [HttpPost]
        public IActionResult Post(TimesheetCreateViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                Timesheet timesheet = model.ToEntity();
                var repo = this.Storage.GetRepository<ITimesheetRepository>();

                repo.Create(timesheet, GetCurrentUserName());
                this.Storage.Save();

                return Ok(new { success = true });
            }

            return BadRequest(new { success = false });
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var repo = this.Storage.GetRepository<ITimesheetRepository>();

            Timesheet timesheet = repo.WithKey(id);
            if (timesheet == null)
                return this.NotFound(new { success = false });

            return Ok(new { success = true, data = timesheet });
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, TimesheetUpdateViewModel model)
        {
            var repo = this.Storage.GetRepository<ITimesheetRepository>();

            Timesheet timesheet = repo.WithKey(id);
            if (timesheet == null)
                return this.NotFound(new { success = false });

            if (this.ModelState.IsValid)
            {
                model.ToEntity(timesheet, this.GetCurrentUserName());
                repo.Edit(timesheet, GetCurrentUserName());
                this.Storage.Save();

                return Ok(new { success = true });
            }

            return BadRequest(new { success = false });
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var repo = this.Storage.GetRepository<ITimesheetRepository>();

            Timesheet timesheet = repo.WithKey(id);
            if (timesheet == null)
                return this.NotFound(new { success = false });

            repo.Delete(timesheet, GetCurrentUserName());
            this.Storage.Save();

            return Ok(new { success = true });
        }
    }
}
