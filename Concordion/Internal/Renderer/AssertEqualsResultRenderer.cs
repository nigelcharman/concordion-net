﻿// Copyright 2009 Jeffrey Cameron
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Concordion.Api;

namespace Concordion.Internal.Renderer
{
    public class AssertEqualsResultRenderer : IAssertEqualsListener
    {
        #region IAssertEqualsListener Members

        public void SuccessReportedEventHandler(object sender, global::Concordion.Internal.Commands.SuccessReportedEventArgs e)
        {
            e.Element
                .AddStyleClass("success")
                .AppendNonBreakingSpaceIfBlank();
        }

        public void FailureReportedEventHandler(object sender, global::Concordion.Internal.Commands.FailureReportedEventArgs e)
        {
            Element element = e.Element;
            element.AddStyleClass("failure");
            
            Element spanExpected = new Element("del");
            spanExpected.AddStyleClass("expected");
            element.MoveChildrenTo(spanExpected);
            element.AppendChild(spanExpected);
            spanExpected.AppendNonBreakingSpaceIfBlank();
            
            Element spanActual = new Element("ins");
            spanActual.AddStyleClass("actual");
            if (e.Actual != null)
            {
                spanActual.AppendText(e.Actual.ToString());
            }
            else
            {
                spanActual.AppendText("(null)");
            }
            spanActual.AppendNonBreakingSpaceIfBlank();
            
            element.AppendText("\n");
            element.AppendChild(spanActual);   
        }

        #endregion
    }
}
