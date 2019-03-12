using specflow_coypu.WebDrivers;
using TechTalk.SpecFlow;

namespace specflow_coypu.PageObjects
{
    [Binding]
    public class SpecFlowFeature1PageObject
    {
        private BrowserSessionManager _browserSessionManager;

        public SpecFlowFeature1PageObject(BrowserSessionManager browserSessionManager)
        {
            _browserSessionManager = browserSessionManager;
        }

        private const string LINK_NAME = "li.av-menu-button";

        public void GetUrl(string url)
        {
            _browserSessionManager.Browser().Visit(url);
        }

        public bool GetPageUrlName(string pageUrl)
        {
           return _browserSessionManager.Browser().Location.Equals(pageUrl);
        }

        public void ClickLink()
        {
            _browserSessionManager.Browser().FindCss(LINK_NAME).Click();
        }

    }
}
