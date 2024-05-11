using OpenQA.Selenium;

namespace bookingTest.Locators;

    public static class PageLocators 
    {
        public static By Dialogue = By.CssSelector("div[role='dialog']");
        public static By CloseDialogueButton = By.CssSelector("button[aria-label='Dismiss sign-in info.']");

    }
    public static class HomePageLocators
    {
        public static By SearchTextField = By.CssSelector("input[placeholder='Where are you going?']");
        public static By SearchButton = By.CssSelector("button[type='submit']");
        public static By datesButton = By.CssSelector("div[data-testid='searchbox-dates-container']");
        public static By currentDayCalender = By.XPath("//table[1]//td[span[contains(@class, 'f9bebc3246')]]");
        public static By tenthDayCalender = By.XPath("//table[1]//td[span[contains(@class, 'f9bebc3246')]]/following::td[10]");
        public static By OccupancyPopUpDoneButton = By.XPath("//div[@data-testid='occupancy-popup']//button/span[text()='Done']");
        public static By OccupancyPopUpInputRange = By.CssSelector("input#group_adults");
        public static By OccupancyConfigButton = By.CssSelector("button[data-testid='occupancy-config']");

    }

    public static class ResultsPageLocators
    {
        public static By SearchResultElements = By.XPath("(//div[@data-testid='property-card'])[position() <= 5]");
        public static By SearchResultAddress = By.XPath(".//span[@data-testid='address']");
         public static By SearchResultDaysAndResidents = By.XPath("//div[@data-testid='price-for-x-nights']");
    
        

    }
