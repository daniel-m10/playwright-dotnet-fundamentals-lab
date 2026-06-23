using Microsoft.Playwright;

namespace PlaywrightFundamentalsLab.Tests.Pages;

public class PlaywrightHomePage(IPage page)
{
    private const string Url = "https://playwright.dev/dotnet";
    
    // Locators - defined as properties using role-based and user-facing strategies
    public ILocator GetStartedLink => 
        page.GetByRole(AriaRole.Link, new PageGetByRoleOptions { Name = "Get started" });
    
    public ILocator HeroHeading =>
        page.GetByRole(AriaRole.Heading, new PageGetByRoleOptions { Name = "Playwright enables reliable" });
    
    public ILocator SearchButton => page.GetByLabel("Search");

    public async Task GotoAsync() => await page.GotoAsync(Url);
}