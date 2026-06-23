using System.Text.RegularExpressions;
using Microsoft.Playwright.NUnit;
using PlaywrightFundamentalsLab.Tests.Pages;

namespace PlaywrightFundamentalsLab.Tests.Tests;

[TestFixture]
public class SmokeTest : PageTest
{
    private PlaywrightHomePage _homePage = null!;

    [SetUp]
    public void Setup()
    {
        _homePage = new PlaywrightHomePage(Page);
    }
    
    [Test]
    public async Task ShouldLoadPlaywrightHomepage()
    {
        await _homePage.GotoAsync();
        await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));
    }

    [Test]
    public async Task ShouldShowGetStartedLink()
    {
        await _homePage.GotoAsync();
        Assert.That(await _homePage.IsGetStartedLinkVisibleAsync(), Is.True);
    }
}
