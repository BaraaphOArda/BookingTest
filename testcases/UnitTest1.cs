using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using bookingTest.Pages;
using static bookingTest.Logger.LoggerUtils;

namespace bookingTest;

public class Tests
{
    private ChromeDriver driver;
    private HomePage homePage;
    private ResultsPage resultPage;
    [SetUp]
    public void Setup()
    {
        // specifying chrome web driver path
        string chromeDriverPath = "C:\\chromedriver-win64\\chromedriver.exe";
        // cofigure chrome options
        ChromeOptions options = new ChromeOptions();
        options.AddArgument("--start-maximized");
        // initialize web driver and pages
        driver = new ChromeDriver(chromeDriverPath, options);
        homePage = new HomePage(driver);
        resultPage = new ResultsPage(driver);

    }

    [Test]
    public void test_verify_search_apartments_istanbul_10_days_2_guests()
    {
        /**
        Steps: 1) Go to URL https://www.booking.com
               2) Enter location "Istanbul" in Where are you going? Field.
               3) Choose current day for check-in-date & the check-out-date for a 10 days stay.
               4) Set the Number of Adults field to 2.
               5) Click on Search.
               6) Verify that the results shown are available for location:Istanbul, Days: 10
                  and guest number: 2 adults.

        Expected Results: Search results should be shown for available apartments in Istanbul
                          location for a 10 days stay and for 2 adults.   
        */

        STEP("Go to URL https://www.booking.com");
        homePage.NavigateToBookingSite();
        STEP("Enter location Istanbul in Where are you going? Field.");
        homePage.TypeLocation("Istanbul");
        STEP("Choose current day for check-in-date & the check-out-date for a 10 days stay.");
        homePage.SelectTenDaysStay();
        homePage.SelectNumberOfResidents();
        STEP("Set the Number of Adults field to 2.");
        STEP("Click on Submit/Search button");
        homePage.ClickonSearch();
        STEP("Verify that the results shown are available for location:Istanbul, Days: 10"+
        "and guest number: 2 adults.");
        resultPage.VerifyResultsPageDetails("Istanbul", "10", "2");
        Thread.Sleep(3000);

    }
    [TearDown]
    public void TearDown(){
        driver.Close();
        driver.Quit();
    }
}