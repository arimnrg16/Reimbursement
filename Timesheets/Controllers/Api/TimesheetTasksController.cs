using Barebone.Controllers;
using Data.Entities;
using Timesheets.Data.Abstractions;
using Timesheets.Data.Entities;
using Timesheets.ViewModels.TimesheetTask;
using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Timesheets.Controllers.Api
{
    //[Authorize]
    [Route("api/timesheettasks")]
    public class TimesheetTasksController : ControllerBaseApi
    {
        public TimesheetTasksController(IStorage storage) : base(storage)
        {
        }

        [HttpGet]
        public IActionResult Get(int page = 0, int size = 25)
        {
            IEnumerable<TimesheetTask> data = new TimesheetTaskModelFactory().LoadAll(this.Storage, page, size)?.TimesheetTasks;
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
        public IActionResult Post(TimesheetTaskCreateViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                TimesheetTask timesheetTask = model.ToEntity();
                var repo = this.Storage.GetRepository<ITimesheetTaskRepository>();

                repo.Create(timesheetTask, GetCurrentUserName());
                this.Storage.Save();

                return Ok(new { success = true });
            }

            return BadRequest(new { success = false });
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var repo = this.Storage.GetRepository<ITimesheetTaskRepository>();

            TimesheetTask timesheetTask = repo.WithKey(id);
            if (timesheetTask == null)
                return this.NotFound(new { success = false });

            return Ok(new { success = true, data = timesheetTask });
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, TimesheetTaskUpdateViewModel model)
        {
            var repo = this.Storage.GetRepository<ITimesheetTaskRepository>();

            TimesheetTask timesheetTask = repo.WithKey(id);
            if (timesheetTask == null)
                return this.NotFound(new { success = false });

            if (this.ModelState.IsValid)
            {
                model.ToEntity(timesheetTask, this.GetCurrentUserName());
                repo.Edit(timesheetTask, GetCurrentUserName());
                this.Storage.Save();

                return Ok(new { success = true });
            }

            return BadRequest(new { success = false });
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var repo = this.Storage.GetRepository<ITimesheetTaskRepository>();

            TimesheetTask timesheetTask = repo.WithKey(id);
            if (timesheetTask == null)
                return this.NotFound(new { success = false });

            repo.Delete(timesheetTask, GetCurrentUserName());
            this.Storage.Save();

            return Ok(new { success = true });
        }
    }
}
