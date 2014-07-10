﻿using CrystalQuartz.Core;
using CrystalQuartz.Web.Comands.Inputs;
using CrystalQuartz.Web.Comands.Outputs;
using CrystalQuartz.Web.Helpers;
using CrystalQuartz.WebFramework.Commands;

namespace CrystalQuartz.Web.Comands
{
    public class GetDataCommand : AbstractCommand<NoInput, SchedulerDataOutput>
    {
        private readonly ISchedulerDataProvider _schedulerDataProvider;

        public GetDataCommand(ISchedulerDataProvider schedulerDataProvider)
        {
            _schedulerDataProvider = schedulerDataProvider;
        }

        protected override void InternalExecute(NoInput input, SchedulerDataOutput output)
        {
            _schedulerDataProvider.Data.MapToOutput(output);
        }
    }
}