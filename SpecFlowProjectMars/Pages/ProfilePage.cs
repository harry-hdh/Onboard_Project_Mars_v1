using NUnit.Framework;
using OpenQA.Selenium;
using Testing_Project_Mars_SpecFlow.Utilities;


namespace Testing_Project_Mars_SpecFlow.Pages
{
    internal class ProfilePage
    {

        private By GetByLocation(string location)
        {
            return location switch
            {
                "languages tab" => By.XPath("//a[contains(text(), 'Languages')]"),

                "skills tab" => By.XPath("//a[contains(text(), 'Skills')]"),

                "edit table" => By.XPath("//td/span/i[contains(@class, 'outline write')]"),

                "add button" => By.XPath("//input[contains(@value,'Add')]"),

                "update button" => By.XPath("//input[contains(@value,'Update')]"),

                "add new language" => By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"),

                "add new skill" => By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"),

                "edit language btn" => By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"),

                "remove language btn" => By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"),

                "remove language btns" => By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"), 

                "edit skill btn" => By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]"),

                "remove skill btn" => By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]"),

                "language textbox" => By.XPath("//input[contains(@placeholder,'Add Language')]"),

                "level dropdown" => By.Name("level"),

                "skill textbox" => By.XPath("//input[contains(@placeholder,'Add Skill')]"),


                "language" => By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"),

                "language level" => By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"),

                "language row" => By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody"),

                "skill" => By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"),

                "skill level" => By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"),

                _ => throw new NotImplementedException()
            };
        }

        public void CleanRecords(IWebDriver driver, string locator, string removeBtnLocator)
        {
            CustomMethods.CheckAndRemoveElement(driver, GetByLocation(locator), GetByLocation(removeBtnLocator));
        }

        public void ClickSpecific(IWebDriver driver, string location, string type)
        {

            CustomMethods.Click(driver, GetByLocation(location), type);

        }

        public void EnterTxt(IWebDriver driver, string location, string text)
        {
            CustomMethods.ClearEnterText(driver, GetByLocation(location), text);
        }

        public void SelectOption(IWebDriver driver, string location, string option)
        {
            CustomMethods.SelectDropDown(driver, GetByLocation(location), option);
        }

        public void EnterTxtLangOrSkill(IWebDriver driver, string txtBoxLocation, string dropDownLocation, string text, string opt)
        {
            CustomMethods.ClearEnterText(driver, GetByLocation(txtBoxLocation), text);

            CustomMethods.SelectDropDown(driver, GetByLocation(dropDownLocation), opt);
        }

        public void AssertPopUp(IWebDriver driver, string text, string message) 
        {

            Assert.That(CustomMethods.GetNotificationTxt(driver).Contains(text), message);
        }

        public void AssertDisplayTxt(IWebDriver driver, string location, string text, string message)
        {
            Assert.That(CustomMethods.GetText(driver, GetByLocation(location)).Equals(text), message);
        }

    }
}
