using Microsoft.Playwright;
using PlaywrightFundamentalsLab.Tests.Configuration;

namespace PlaywrightFundamentalsLab.Tests.Pages;

public class PlaywrightHomePage(IPage page)
{
    // Locators - defined as properties using role-based and user-facing strategies
    public ILocator GetStartedLink =>
        page.GetByRole(AriaRole.Link, new PageGetByRoleOptions { Name = "Get started" });

    public ILocator HeroHeading =>
        page.GetByRole(AriaRole.Heading, new PageGetByRoleOptions { Name = "Playwright enables reliable" });

    public ILocator SearchButton => page.GetByLabel("Search");

    public async Task GotoAsync() => await page.GotoAsync(TestConfiguration.BaseUrl);

    public async Task ClickGetStartedAsync() => await GetStartedLink.ClickAsync();
}