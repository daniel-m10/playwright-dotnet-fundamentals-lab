using Microsoft.Playwright.NUnit;
using System.Text.RegularExpressions;

namespace PlaywrightFundamentalsLab.Tests;

[TestFixture]
public class SmokeTest : PageTest
{
    [Test]
    public async Task ShouldLoadPlaywrightHomepage()
    {
        await Page.GotoAsync("https://playwright.dev/dotnet");
        
        await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));
    }
}
