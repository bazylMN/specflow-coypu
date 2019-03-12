using specflow_coypu.Assertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace specflow_coypu.Steps
{
    [Binding]
    class SpecFlowFeature2Steps
    {

        private SpecFlowFeature1Assertions _specFlowFeature1Assertions;

        public SpecFlowFeature2Steps(SpecFlowFeature1Assertions specFlowFeature1Assertions)
        {
            _specFlowFeature1Assertions = specFlowFeature1Assertions;
        }

        [Then]
        public void ThenShouldBeOn_P0_Page(string pageUrl)
        {
            _specFlowFeature1Assertions.AssertPageUrlName(pageUrl);
        }

    }
}
