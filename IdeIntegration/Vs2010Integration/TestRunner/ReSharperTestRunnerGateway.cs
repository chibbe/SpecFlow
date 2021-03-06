﻿using EnvDTE;
using TechTalk.SpecFlow.IdeIntegration.Tracing;

namespace TechTalk.SpecFlow.Vs2010Integration.TestRunner
{
    public class ReSharperTestRunnerGateway : CommandBasedTestRunnerGateway
    {
        protected override string GetRunInCurrentContextCommand(bool debug)
        {
            if (debug)
                return "ReSharper.ReSharper_UnitTest_ContextDebug";

            return "ReSharper.ReSharper_UnitTest_ContextRun";
        }

        public ReSharperTestRunnerGateway(DTE dte, IIdeTracer tracer)
            : base(dte, tracer)
        {
        }
    }
}