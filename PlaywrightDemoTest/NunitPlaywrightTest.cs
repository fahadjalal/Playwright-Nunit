using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace PlaywrightDemo;

public class NunitPlaywrightTest:PageTest
{
    [SetUp]
    public async Task Setup()
    {
         await Page.GotoAsync("http://www.eaapp.somee.com");
    }

    [Test]
    public async Task EALoginTest()
    {
       
        await Page.ClickAsync("text=Login");
        await Page.ScreenshotAsync(new PageScreenshotOptions{
            Path = "D:\\Playwright_Nunit\\PlaywrightDemoTest\\Screenshots\\aa.jpg"
        });

        await Page.FillAsync("#UserName", value:"admin");
        await Page.FillAsync("#Password",value:"password");
        await Page.ClickAsync("text=Log in");
        await Expect(Page.Locator("text='Employee Details'")).ToBeVisibleAsync();
    }
}