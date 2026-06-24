using System.Text.RegularExpressions;
using PlaywrightFundamentalsLab.Tests.Pages;

namespace PlaywrightFundamentalsLab.Tests.Tests;

[TestFixture]
[Category("Smoke")]
public class SmokeTest : BaseTest
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
        await Expect(_homePage.GetStartedLink).ToBeVisibleAsync();
    }

    [Test]
    public async Task ShouldShowHeroHeading()
    {
        await _homePage.GotoAsync();
        await Expect(_homePage.HeroHeading).ToBeVisibleAsync();
    }

    [Test]
    public async Task ShouldShowSearchButton()
    {
        await _homePage.GotoAsync();
        await Expect(_homePage.SearchButton).ToBeVisibleAsync();
    }
}