using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace bookingTest.DriverUtilities;

public class Utilities
{
    /**
    utility class to tp provide helper methods
    */
     private ChromeDriver driver;
     private WebDriverWait wait;

    public Utilities(ChromeDriver driver){
        this.driver = driver;
        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(6));
    }
    public void WaitUntilVisible(By locator)
{
    try
        {
            wait.Until(driver => driver.FindElement(locator).Displayed);
        }
        catch (WebDriverTimeoutException ex)
        {
            Console.WriteLine($"Timeout waiting for element: {ex} to be visible");
        }
    }
    public void ClickElement(By locator)
    {
        WaitUntilVisible(locator);
        try {   
        driver.FindElement(locator).Click();
        }
        catch (ElementClickInterceptedException ex){
            Console.WriteLine($"{ex}: Could not be clicked");
        }

    }
}