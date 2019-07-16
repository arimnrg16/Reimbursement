using Timesheets.Data.Abstractions;
using Timesheets.Data.Entities;
using Timesheets.ViewModels.TimesheetTask;
using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Timesheets.Controllers
{
    //[Authorize]
    public class TimesheetTaskController : Barebone.Controllers.ControllerBase
    {
        public TimesheetTaskController(IStorage storage) : base(storage)
        {
        }

        public ActionResult Index(int page = 0, int size = 25)
        {
            return View(new TimesheetTaskModelFactory().LoadAll(this.Storage, page, size));
        }

        public ActionResult Create()
        {
            var model = new TimesheetTaskCreateViewModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(TimesheetTaskCreateViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                TimesheetTask timesheetTask = model.ToEntity();
                this.Storage.GetRepository<ITimesheetTaskRepository>().Create(timesheetTask, this.GetCurrentUserName());
                this.Storage.Save();

                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}
