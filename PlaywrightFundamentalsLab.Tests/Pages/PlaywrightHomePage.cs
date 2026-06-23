using Microsoft.Playwright;

namespace PlaywrightFundamentalsLab.Tests.Pages;

public class PlaywrightHomePage(IPage page)
{
    private readonly IPage _page = page;
    private const string Url = "https://playwright.dev/dotnet";

    public async Task GotoAsync() => await _page.GotoAsync(Url);

    public async Task<string?> GetTitleAsync() => await _page.TitleAsync();

    public async Task ClickGetStartedAsync() =>
        await _page.GetByRole(AriaRole.Link, new PageGetByRoleOptions { Name = "Get started" }).ClickAsync();

    public async Task<bool> IsGetStartedLinkVisibleAsync() =>
        await _page.GetByRole(AriaRole.Link, new PageGetByRoleOptions { Name = "Get started" }).IsVisibleAsync();
}