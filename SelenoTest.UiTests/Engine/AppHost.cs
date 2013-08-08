using Castle.Core.Logging;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SelenoTest.App.App_Start;
using TestStack.Seleno.Configuration;

namespace SelenoTest.UiTests.Engine
{
	public static class AppHost
	{
		private static FirefoxDriver GetFirefoxDriver()
		{
			var profile = new FirefoxProfile();
			profile.SetPreference("browser.private.browsing.autostart", true);
			
			var driver = new FirefoxDriver(profile);

			return driver;
		}

		private static ChromeDriver GetChromeDriver()
		{
			var options = new ChromeOptions();
			options.AddArgument("-incognito");

			var driver = new ChromeDriver(options);

			return driver;
		}

		public static void Start()
		{
			SelenoHost.Run(@"SelenoTest.App", 12346, c => c
				.UsingLoggerFactory(new ConsoleFactory())
				.WithRouteConfig(RouteConfig.RegisterRoutes)
				.WithRemoteWebDriver(GetChromeDriver)
				);
		}

		public static void Stop()
		{
			SelenoHost.Host.WebServer.Stop();
			SelenoHost.Host.Browser.Close();
			SelenoHost.Host.ShutDown();
		}
	}
}