using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Text;

namespace Yyf.Core.Common.WCF.HtmlForm
{
    public class FormProcessingBehaviorElement : BehaviorExtensionElement
    {
        public override Type BehaviorType
        {
            get { return typeof(FormProcessingBehavior); }
        }

        protected override object CreateBehavior()
        {
            return new FormProcessingBehavior();
        }
    }
}
