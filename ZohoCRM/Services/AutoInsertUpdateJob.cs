using Quartz;
using ZohoCRM.Services;

namespace ZohoCRM.Services
{
    public class AutoInsertUpdateJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            ZohoService fm = new ZohoService();
            fm.Post();
        }
    }
}