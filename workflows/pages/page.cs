using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using bookingTest.Locators;
using bookingTest.DriverUtilities;

namespace bookingTest.Pages;

public class Page {
    protected ChromeDriver driver;
    protected Utilities utilities;
    public Page(ChromeDriver driver){
        this.driver = driver;
        utilities = new Utilities(driver);
    }

    public void CloseHomePageDialogue()
    {
        try {    
        utilities.WaitUntilVisible(PageLocators.Dialogue);
        utilities.ClickElement(PageLocators.CloseDialogueButton);
        }
        catch (NoSuchElementException ex) 
        {
            Console.WriteLine($"Couldn't Find element:{ex.Message}");

        }
    }
}