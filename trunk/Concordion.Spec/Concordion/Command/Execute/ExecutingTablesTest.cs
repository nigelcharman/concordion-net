﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concordion.Spec.Concordion.Command.Execute
{
    public class ExecutingTablesTest
    {
        public Result process(string fragment)
        {
            ProcessingResult r = new TestRig()
                .WithFixture(this)
                .ProcessFragment(fragment);
            
            Result result = new Result();
            result.successCount = r.SuccessCount;
            result.failureCount = r.FailureCount;
            result.exceptionCount = r.ExceptionCount;
            
            // TODO - repair this
            //var lastEvent = r.getLastAssertEqualsFailureEvent();
            //if (lastEvent != null) 
            //{
            //    result.lastActualValue = lastEvent.getActual();
            //    result.lastExpectedValue = lastEvent.getExpected();
            //}
            
            return result;
        }

        public string generateUsername(string fullName) 
        {
            return fullName.Replace(" ", "").ToLower();
        }

        public struct Result 
        {
            public long successCount;
            public long failureCount;
            public long exceptionCount;
            public string lastExpectedValue;
            public object lastActualValue;
        }
    }
}
