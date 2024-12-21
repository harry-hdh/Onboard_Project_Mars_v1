using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.BrowsingContext;
using OpenQA.Selenium.Support.UI;
using static System.Net.Mime.MediaTypeNames;

namespace Testing_Project_Mars_SpecFlow.Utilities
{
    internal class CustomMethods
    {
        public static void Click(IWebDriver driver, By locator, string clickType)
        {
            switch (clickType)
            {
                case "just_click":
                    try
                    {
                        driver.FindElement(locator).Click();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    break;
                case "wait_click":
                    CustomWait.WaitToBeClickable(driver, locator, 15);
                    try
                    {
                        driver.FindElement(locator).Click();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    break;
                default:
                    throw new NotImplementedException();
            }


        }

        public static void ClearTxt(IWebDriver driver, By locator)
        {
            CustomWait.WaitToBeVisible(driver, locator, 10);
            driver.FindElement(locator).Clear();
        }

        public static void ClosePopUp(IWebDriver driver)
        {
            Click(driver, By.XPath("//a[@class='ns-close']"), "wait_click");
        }

        public static void Submit(IWebDriver driver, By locator)
        {
            CustomWait.WaitToBeClickable(driver, locator, 10);
            driver.FindElement(locator).Submit();
        }

        public static void EnterTextPressEnter(IWebDriver driver, By locator, string text)
        {
            CustomWait.WaitToBeClickable(driver, locator, 15);
            var txtbox = driver.FindElement(locator);
            try
            {
                txtbox.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            txtbox.Clear();
            //might need another click
            txtbox.SendKeys(text);

            txtbox.SendKeys(Keys.Enter);
        }

        public static void ClearEnterText(IWebDriver driver, By locator, string text)
        {
            CustomWait.WaitToBeClickable(driver, locator, 15);
            var txtbox = driver.FindElement(locator);
            try
            {
                txtbox.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            txtbox.Clear();
            //might need another click
            txtbox.SendKeys(text);
        }

        public static void EnterText(IWebDriver driver, By locator, string text)
        {
            CustomWait.WaitToBeVisible(driver, locator, 10);
            var txtbox = driver.FindElement(locator);
            try
            {
                txtbox.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            txtbox.SendKeys(text);
        }

        public static void UploadFile(IWebDriver driver, By locator, string path)
        {
            driver.FindElement(locator).SendKeys(path);
            Thread.Sleep(1000);
        }

        public static void AcceptAlert(IWebDriver driver)
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }

        public static string GetText(IWebDriver driver, By locator)
        {
            CustomWait.WaitToBeVisible(driver, locator, 15);
            IWebElement result = driver.FindElement(locator);

            return result.Text;
        }

        public static string GetNotificationTxt(IWebDriver driver)
        {


            var popupXpath = By.XPath("//div[contains(@class, 'ns-box-inner')]");

            CustomWait.WaitToBeVisible(driver, popupXpath, 15);

            IWebElement result = driver.FindElement(popupXpath);

            return result.Text;
        }

        public static void SwitchToPopUp(IWebDriver driver, int frameNumber)
        {
            driver.SwitchTo().Frame(frameNumber);
        }

        public static void SwitchBackToDefault(IWebDriver driver)
        {
            driver.SwitchTo().DefaultContent();
        }

        public static void SelectDropDown(IWebDriver driver, By locator, string value, string selectType)
        {
            CustomWait.WaitToBeVisible(driver, locator, 10);
            var dropdown = driver.FindElement(locator);
            var selectElement = new SelectElement(dropdown);

            switch(selectType)
            {
                case "by value":
                    selectElement.SelectByValue(value);
                    break;
                case "by text":
                    selectElement.SelectByText(value);
                    break;
                default:
                    throw new NotImplementedException();

            }
        }


        public static void CheckAndRemoveElement(IWebDriver driver, By locator, By removeLocator)
        {
            CustomWait.WaitToBeVisible(driver, locator, 10);

            List<IWebElement> elements = new List<IWebElement>();

            elements.AddRange(driver.FindElements(locator));
            //Console.WriteLine(elements.Count());
            foreach (var _ in elements)
            {
                if (elements.Count > 0)
                {
                    driver.FindElement(removeLocator).Click();

                }
            }

        }

        public static void EnterRandomEmail(IWebDriver driver, By locator, string firstName, string lastname)
        {
            CustomWait.WaitToBeVisible(driver, locator, 10);
            var emailTxtbox = driver.FindElement(locator);

            Random random = new Random();

            int randomId = random.Next(0, 1000);

            try
            {
                emailTxtbox.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            emailTxtbox.SendKeys(firstName + "_" + lastname + randomId + "@gmail.com");
        }

        public static void CleanTable(IWebDriver driver, By tableLocator, By rowLocator, By removeBtnLocator)
        {
            CustomWait.WaitToBeVisible(driver, tableLocator, 10);
            IWebElement table = driver.FindElement(tableLocator);
            var closePopUpBtn = By.XPath("//div/a[@class='ns-close']");
         
            while (true)
            {
                try
                {
                    // Find rows in the table
                    var rows = table.FindElements(rowLocator);

                    if (rows.Count == 0)
                        break;

                    // Assume each row has a delete button in a specific column
                    IWebElement deleteButton = rows[0].FindElement(removeBtnLocator); 
                    deleteButton.Click();

                    CustomWait.WaitToBeClickable(driver, closePopUpBtn, 10);
                    driver.FindElement(closePopUpBtn).Click();
                    CustomWait.WaitUntil(driver, closePopUpBtn, 10);
                }
                catch (NoSuchElementException)
                {
                    break;
                }
            }

        }
    }
}
