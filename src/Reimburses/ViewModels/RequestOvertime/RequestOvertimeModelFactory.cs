using System;
using Reimburses.Data.Abstractions;
using ExtCore.Data.Abstractions;

namespace Reimburses.ViewModels.RequestOvertime
{
    internal class RequestOvertimeModelFactory
    {
        public RequestOvertimeModelFactory()
        {
        }

        internal RequestOvertimeIndexViewModel LoadAll(IStorage storage, int page, int size)
        {
            var requestOvertimeRepo = storage.GetRepository<IRequestOvertimeRepository>();

            return new RequestOvertimeIndexViewModel(requestOvertimeRepo.All(page, size));
        }
    }
}

