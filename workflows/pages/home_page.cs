using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using bookingTest.Locators;
using bookingTest.DriverUtilities;
using static bookingTest.Logger.LoggerUtils;

namespace bookingTest.Pages;
public class HomePage : Page {
    /**
    class to define Home page elements and methods
    */

     public HomePage(ChromeDriver driver) : base(driver){
     }
    
    public IWebElement SearchButton()
    {
        return  driver.FindElement(HomePageLocators.SearchButton);
    }
    public IWebElement SearchTextField()
    {
        return  driver.FindElement(HomePageLocators.SearchTextField);
    }
    public IWebElement datesButton()
    {
        return  driver.FindElement(HomePageLocators.datesButton);
    }
    public IWebElement tenthDayCalender()
    {
        return  driver.FindElement(HomePageLocators.tenthDayCalender);
    }
    public IWebElement currentDayCalender()
    {
        return  driver.FindElement(HomePageLocators.currentDayCalender);
    }
    public IWebElement OccupancyPopUpInputRange()
    {
        return  driver.FindElement(HomePageLocators.OccupancyPopUpInputRange);
    }
    

    public void NavigateToBookingSite()
    {
        Console.WriteLine("Go to Booking.com ");
        driver.Navigate().GoToUrl("https://www.booking.com/");
        Console.WriteLine("Close Dialogue if it's present ... ");
        CloseHomePageDialogue();


    }

    public void TypeLocation(string location)
    {
        Console.WriteLine("typing location: "+ location +" in Search Box");
        SearchTextField().SendKeys(location);

    }
    public void SelectTenDaysStay()
    {
        Console.WriteLine("Choosing Number of days to stay");
        utilities.ClickElement(HomePageLocators.datesButton);
        utilities.ClickElement(HomePageLocators.currentDayCalender);
        utilities.ClickElement(HomePageLocators.tenthDayCalender);

    }
    public void SelectNumberOfResidents()
    {
        Console.WriteLine("Choosing Number of People to stay in the Apartment");
        utilities.ClickElement(HomePageLocators.OccupancyConfigButton);
        IWebElement rangInput = OccupancyPopUpInputRange();
        int value = Int32.Parse(rangInput.GetAttribute("value"));
        if (value != 2){
            rangInput.Clear();
            rangInput.SendKeys("2");
        }
        
        utilities.ClickElement(HomePageLocators.OccupancyPopUpDoneButton);
        

    }
    public void ClickonSearch(){
        utilities.ClickElement(HomePageLocators.SearchButton);
    }

}