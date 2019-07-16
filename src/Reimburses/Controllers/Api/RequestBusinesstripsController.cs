using Barebone.Controllers;
using Data.Entities;
using Reimburses.Data.Abstractions;
using Reimburses.Data.Entities;
using Reimburses.ViewModels.RequestBusinesstrip;
using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Reimburses.Controllers.Api
{
    //[Authorize]
    [Route("api/requestbusinesstrips")]
    public class RequestBusinesstripsController : ControllerBaseApi
    {
        public RequestBusinesstripsController(IStorage storage) : base(storage)
        {
        }

        [HttpGet]
        public IActionResult Get(int page = 0, int size = 25)
        {
            IEnumerable<RequestBusinesstrip> data = new RequestBusinesstripModelFactory().LoadAll(this.Storage, page, size)?.RequestBusinesstrips;
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
        public IActionResult Post(RequestBusinesstripCreateViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                RequestBusinesstrip requestBusinesstrip = model.ToEntity();
                var repo = this.Storage.GetRepository<IRequestBusinesstripRepository>();

                repo.Create(requestBusinesstrip, GetCurrentUserName());
                this.Storage.Save();

                return Ok(new { success = true });
            }

            return BadRequest(new { success = false });
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var repo = this.Storage.GetRepository<IRequestBusinesstripRepository>();

            RequestBusinesstrip requestBusinesstrip = repo.WithKey(id);
            if (requestBusinesstrip == null)
                return this.NotFound(new { success = false });

            return Ok(new { success = true, data = requestBusinesstrip });
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, RequestBusinesstripUpdateViewModel model)
        {
            var repo = this.Storage.GetRepository<IRequestBusinesstripRepository>();

            RequestBusinesstrip requestBusinesstrip = repo.WithKey(id);
            if (requestBusinesstrip == null)
                return this.NotFound(new { success = false });

            if (this.ModelState.IsValid)
            {
                model.ToEntity(requestBusinesstrip, this.GetCurrentUserName());
                repo.Edit(requestBusinesstrip, GetCurrentUserName());
                this.Storage.Save();

                return Ok(new { success = true });
            }

            return BadRequest(new { success = false });
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var repo = this.Storage.GetRepository<IRequestBusinesstripRepository>();

            RequestBusinesstrip requestBusinesstrip = repo.WithKey(id);
            if (requestBusinesstrip == null)
                return this.NotFound(new { success = false });

            repo.Delete(requestBusinesstrip, GetCurrentUserName());
            this.Storage.Save();

            return Ok(new { success = true });
        }
    }
}
