using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SDET_dotnet_MstestV2.Base;
using SeleniumExtras.PageObjects;

namespace SDET_dotnet_MstestV2.POM
{
  public class BlogPage : UnoPages

    {
        [FindsBy(How = How.XPath, Using = "//a[.= 'Blog' and @class = 'nav-link']")]
        private IWebElement BlogMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id = 'search-bar']")]
        private IWebElement SearchField { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class= 'breadcrumb-container']/h1")]
        private IWebElement BlogTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='side-bar-container']/form[@action='https://info.unosquare.com/blog-search']//img[@class='search-icon']")]
        private IWebElement SearchIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[.='Quality Assurance Questions to Ask in Agile Software Development']")]
        private IWebElement SearchRes { get; set; }

        public BlogPage() : base()
        {

        }

        public BlogPage GoToBlog()
        {
            browser.Click(BlogMenu);            
            return this;
        }

        public String CompareTitleBlog()
        {
            String title=browser.GetText(BlogTitle);
            Console.Write(browser.GetText(BlogTitle));
            return title;
        }

        public BlogPage SearchText(String text)
        {
            browser.typeText(SearchField, text);
            return this;
        }

        public BlogPage SearchClick()
        {
            browser.Click(SearchIcon);
            return this;
        }

        public String CompareSearchResult()
        {
            String title = browser.GetText(SearchRes);
            Console.Write(browser.GetText(SearchRes));
            return title;
        }

    }


}
