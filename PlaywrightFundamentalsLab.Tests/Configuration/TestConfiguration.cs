namespace PlaywrightFundamentalsLab.Tests.Configuration;

public static class TestConfiguration
{
    public static string BaseUrl => Environment.GetEnvironmentVariable("BASE_URL")
                                    ?? "https://playwright.dev/dotnet/";
}