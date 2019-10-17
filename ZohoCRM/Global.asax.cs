using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ZohoCRM.Services;

namespace ZohoCRM
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //Start();
            IScheduler defaultScheduler = StdSchedulerFactory.GetDefaultScheduler();
            defaultScheduler.Start();
            //IJobDetail AutoJob = JobBuilder.Create<AutoInsertUpdateJob>().WithIdentity("AutoJob", "Group1").Build();
            //ITrigger Trigger = SimpleScheduleTriggerBuilderExtensions.WithSimpleSchedule(
            //    TriggerBuilder.Create().WithIdentity("AutoJob", "Group1").StartNow(),
            //    x => x.WithIntervalInHours(24).RepeatForever()
            //    ).Build();
            IJobDetail job = JobBuilder.Create<AutoInsertUpdateJob>().Build();
            ITrigger trigger = TriggerBuilder.Create().WithDailyTimeIntervalSchedule(s => s.WithIntervalInHours(24).OnEveryDay()
                    .StartingDailyAt(TimeOfDay.HourAndMinuteOfDay(6, 0))).Build();
            ITrigger trigger1 = TriggerBuilder.Create().WithDailyTimeIntervalSchedule(s => s.WithIntervalInHours(24).OnEveryDay()
                    .StartingDailyAt(TimeOfDay.HourAndMinuteOfDay(15, 0))).Build();
            ITrigger trigger2 = TriggerBuilder.Create().WithDailyTimeIntervalSchedule(s => s.WithIntervalInHours(24).OnEveryDay()
                    .StartingDailyAt(TimeOfDay.HourAndMinuteOfDay(18, 0))).Build();
            defaultScheduler.ScheduleJob(job, trigger);
            //defaultScheduler.ScheduleJob(job, trigger1);
            //defaultScheduler.ScheduleJob(job, trigger2);
        }

       
        public static void Start()

        {

            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();

            scheduler.Start();
            IJobDetail job = JobBuilder.Create<AutoInsertUpdateJob>().Build();
            ITrigger trigger = TriggerBuilder.Create().WithDailyTimeIntervalSchedule(s => s.WithIntervalInHours(24).OnEveryDay()

                    .StartingDailyAt(TimeOfDay.HourAndMinuteOfDay(6, 0))).Build();



            scheduler.ScheduleJob(job, trigger);

        }
    }
}
