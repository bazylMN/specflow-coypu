using NUnit.Framework;
using specflow_coypu.PageObjects;
using TechTalk.SpecFlow;

namespace specflow_coypu.Assertions
{
    [Binding]
    public class SpecFlowFeature1Assertions
    {
        private SpecFlowFeature1PageObject _specFlowFeature1PageObject;

        public SpecFlowFeature1Assertions(SpecFlowFeature1PageObject specFlowFeature1PageObject)
        {
            _specFlowFeature1PageObject = specFlowFeature1PageObject;
        }

        public void AssertPageUrlName(string pageUrl)
        {
            Assert.IsTrue(_specFlowFeature1PageObject.GetPageUrlName(pageUrl));
        }

    }
}
