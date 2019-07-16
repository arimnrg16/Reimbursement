using Timesheets.Data.Abstractions;
using Timesheets.Data.Entities;
using Timesheets.ViewModels.Timesheet;
using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Timesheets.Controllers
{
    //[Authorize]
    public class TimesheetController : Barebone.Controllers.ControllerBase
    {
        public TimesheetController(IStorage storage) : base(storage)
        {
        }

        public ActionResult Index(int page = 0, int size = 25)
        {
            return View(new TimesheetModelFactory().LoadAll(this.Storage, page, size));
        }

        public ActionResult Create()
        {
            var model = new TimesheetCreateViewModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(TimesheetCreateViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                Timesheet timesheet = model.ToEntity();
                this.Storage.GetRepository<ITimesheetRepository>().Create(timesheet, this.GetCurrentUserName());
                this.Storage.Save();

                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}
