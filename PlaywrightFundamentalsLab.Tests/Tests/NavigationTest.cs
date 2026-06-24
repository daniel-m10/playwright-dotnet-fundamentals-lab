using System.Text.RegularExpressions;
using PlaywrightFundamentalsLab.Tests.Configuration;
using PlaywrightFundamentalsLab.Tests.Pages;

namespace PlaywrightFundamentalsLab.Tests.Tests;

[TestFixture]
[Category("Navigation")]
public class NavigationTest : BaseTest
{
    private PlaywrightHomePage _homePage = null!;

    [SetUp]
    public void Setup()
    {
        _homePage = new PlaywrightHomePage(Page);
    }

    [Test]
    public async Task ShouldNavigateToGetStartedPage()
    {
        await _homePage.GotoAsync();
        await _homePage.ClickGetStartedAsync();

        await Expect(Page).ToHaveURLAsync(new Regex("intro"));
    }

    [Test]
    public async Task ShouldHaveCorrectUrlAfterLoad()
    {
        await _homePage.GotoAsync();
        await Expect(Page).ToHaveURLAsync(TestConfiguration.BaseUrl);
    }
}