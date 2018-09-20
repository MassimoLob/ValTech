using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Training_1
{
    [Binding]
    public sealed class ValtechStepDefinition1
    {
        [Given(@"I am on the Valtech Homepage")]
        public void GivenIAmOnTheValtechHomepage()
        {
            ValtechPage page = new ValtechPage();
            page.GoToHomepage();
        }

        [Given(@"I have asserted that the Recent Blogs text is present")]
        public void GivenIHaveAssertedThatTheRecentBlogsTextIsPresent()
        {
            ValtechPage page = new ValtechPage();
            page.AssertBlogText();
        }

        [Then(@"I navigate to the About, Services and Work pages and assert the titles")]
        public void ThenINavigateToTheAboutServicesAndWorkPagesAndAssertTheTitles()
        {
            ValtechPage page = new ValtechPage();
            page.NavigatePages();
        }

        [Then(@"I navigate to the Contact Us page and return the total number of offices")]
        public void ThenINavigateToTheContactUsPageAndReturnTheTotalNumberOfOffices()
        {
            ValtechPage page = new ValtechPage();
            page.NumberOffices();
        }

    }
}
