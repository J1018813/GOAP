﻿using CrashKonijn.Goap.Behaviours;
using CrashKonijn.Goap.Enums;
using CrashKonijn.Goap.Interfaces;

namespace Packages.LamosInteractive.Goap.Unity.Tests.UnitTests.Data
{
    public class Action : ActionBase<Action.Data>
    {

        public override void OnStart(IMonoAgent agent, Data data)
        {
        }

        public override ActionRunState Perform(IMonoAgent agent, Data data)
        {
            return ActionRunState.Stop;
        }

        public override void OnEnd(IMonoAgent agent, Data data)
        {
        }
        public class Data : IActionData
        {
            public ITarget Target { get; set; }
        }
    }
}