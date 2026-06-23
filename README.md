# playwright-dotnet-fundamentals-lab

A focused learning repository for Playwright .NET fundamentals using C#, NUnit, and .NET 10 LTS.

## Purpose

This repository is part of the Playwright .NET SDET Portfolio Program. It exists to build foundational Playwright .NET
skills including locators, assertions, auto-waiting, Page Object Model, and test organization before moving to the main
portfolio framework.

## Tech Stack

- C#
- .NET 10 LTS
- Playwright .NET
- NUnit
- Microsoft.Playwright.NUnit
- Rider (recommended IDE)
- GitHub Actions
- dotnet CLI

## Project Structure

```text
PlaywrightFundamentalsLab.Tests/
  Pages/        # Page Objects encapsulating locators and interactions
  Tests/        # NUnit test classes describing scenarios
```

## Setup

```powershell
dotnet restore
dotnet build
pwsh PlaywrightFundamentalsLab.Tests/bin/Debug/net10.0/playwright.ps1 install
```

## Running Tests

```powershell
dotnet test
```

## Test Coverage

| Test                         | Description                                                         |
|------------------------------|---------------------------------------------------------------------|
| ShouldLoadPlaywrightHomepage | Verifies the Playwright .NET docs homepage loads with correct title |
| ShouldShowGetStartedLink     | Verifies the Get Started link is visible on the homepage            |

## Architecture Notes

Page Object Model is used from the beginning. Tests describe scenarios. Page Objects encapsulate locators and
interactions. No raw locators appear in test methods.

## Next Improvements

- Add more locator and assertion examples
- Add navigation flow tests
- Add GitHub Actions CI workflow