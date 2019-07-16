using Barebone.Controllers;
using Data.Entities;
using Reimburses.Data.Abstractions;
using Reimburses.Data.Entities;
using Reimburses.ViewModels.RequestOvertime;
using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Reimburses.Controllers.Api
{
    //[Authorize]
    [Route("api/requestovertimes")]
    public class RequestOvertimesController : ControllerBaseApi
    {
        public RequestOvertimesController(IStorage storage) : base(storage)
        {
        }

        [HttpGet]
        public IActionResult Get(int page = 0, int size = 25)
        {
            IEnumerable<RequestOvertime> data = new RequestOvertimeModelFactory().LoadAll(this.Storage, page, size)?.RequestOvertimes;
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
        public IActionResult Post(RequestOvertimeCreateViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                RequestOvertime requestOvertime = model.ToEntity();
                var repo = this.Storage.GetRepository<IRequestOvertimeRepository>();

                repo.Create(requestOvertime, GetCurrentUserName());
                this.Storage.Save();

                return Ok(new { success = true });
            }

            return BadRequest(new { success = false });
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var repo = this.Storage.GetRepository<IRequestOvertimeRepository>();

            RequestOvertime requestOvertime = repo.WithKey(id);
            if (requestOvertime == null)
                return this.NotFound(new { success = false });

            return Ok(new { success = true, data = requestOvertime });
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, RequestOvertimeUpdateViewModel model)
        {
            var repo = this.Storage.GetRepository<IRequestOvertimeRepository>();

            RequestOvertime requestOvertime = repo.WithKey(id);
            if (requestOvertime == null)
                return this.NotFound(new { success = false });

            if (this.ModelState.IsValid)
            {
                model.ToEntity(requestOvertime, this.GetCurrentUserName());
                repo.Edit(requestOvertime, GetCurrentUserName());
                this.Storage.Save();

                return Ok(new { success = true });
            }

            return BadRequest(new { success = false });
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var repo = this.Storage.GetRepository<IRequestOvertimeRepository>();

            RequestOvertime requestOvertime = repo.WithKey(id);
            if (requestOvertime == null)
                return this.NotFound(new { success = false });

            repo.Delete(requestOvertime, GetCurrentUserName());
            this.Storage.Save();

            return Ok(new { success = true });
        }
    }
}
