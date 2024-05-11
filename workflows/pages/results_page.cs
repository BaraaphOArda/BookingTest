using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using bookingTest.Locators;
using bookingTest.DriverUtilities;

namespace bookingTest.Pages;

public class ResultsPage : Page {
    /**
    class to define Results page elements and methods
    */

    public ResultsPage(ChromeDriver driver): base(driver){
    }
    public void VerifyResultsPageDetails(string location, string days, string residents){
        
        CloseHomePageDialogue();
        List<IWebElement> firstFiveElements = driver
        .FindElements(ResultsPageLocators.SearchResultElements) // Find the first 5 input elements
        .ToList(); // convert the results to list
     
        foreach(IWebElement element in firstFiveElements){
            // Verifying location, Days and number of people
        string address = element.FindElement(ResultsPageLocators.SearchResultAddress).Text;
        string daysAndResident = element.FindElement(ResultsPageLocators.SearchResultDaysAndResidents).Text;
        
        Assert.IsTrue(address.Contains(location), $"Location {location} is not found in the details apartment");
        Assert.IsTrue(daysAndResident.Contains($"{days} nights"), $"Number of {days} is not correct in the details apartment");
        Assert.IsTrue(daysAndResident.Contains($"{residents} adults"), $"Number of {residents} is not correct in the details apartment");
        }
        
       
    }
}