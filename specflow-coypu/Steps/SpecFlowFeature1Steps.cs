using specflow_coypu.PageObjects;
using TechTalk.SpecFlow;

namespace specflow_coypu.Steps
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private SpecFlowFeature1PageObject _specFlowFeature1PageObject;

        public SpecFlowFeature1Steps(SpecFlowFeature1PageObject specFlowFeature1PageObject)
        {
            _specFlowFeature1PageObject = specFlowFeature1PageObject;
        }

        [Given]
        public void GivenIGoTo_P0_Page(string url)
        {
            _specFlowFeature1PageObject.GetUrl(url);
        }

        [When(@"I click ""(.*)"" link")]
        public void WhenIClickLink(string linkName)
        {
            _specFlowFeature1PageObject.ClickLink();
        }

    }
}
