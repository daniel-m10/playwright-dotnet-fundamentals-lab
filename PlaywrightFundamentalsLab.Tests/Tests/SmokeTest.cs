using System.Text.RegularExpressions;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework.Interfaces;
using PlaywrightFundamentalsLab.Tests.Pages;

namespace PlaywrightFundamentalsLab.Tests.Tests;

[TestFixture]
public class SmokeTest : PageTest
{
    private PlaywrightHomePage _homePage = null!;

    [SetUp]
    public async Task Setup()
    {
        await Context.Tracing.StartAsync(new TracingStartOptions
        {
            Screenshots = true,
            Snapshots = true,
            Sources = true
        });

        _homePage = new PlaywrightHomePage(Page);
    }

    [TearDown]
    public async Task TearDown()
    {
        var testFailed = TestContext.CurrentContext.Result.Outcome.Status
                         == TestStatus.Failed;

        if (testFailed)
        {
            var tracePath = Path.Combine(
                TestContext.CurrentContext.WorkDirectory,
                "playwright-traces",
                $"{TestContext.CurrentContext.Test.Name}.zip");

            await Context.Tracing.StopAsync(new TracingStopOptions { Path = tracePath });
        }
        else
        {
            await  Context.Tracing.StopAsync(new TracingStopOptions());
        }
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