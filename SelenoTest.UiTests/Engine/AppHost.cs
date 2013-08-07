using Castle.Core.Logging;
using SelenoTest.App.App_Start;
using TestStack.Seleno.Configuration;

namespace SelenoTest.UiTests.Engine
{
	public static class AppHost
	{
		public static void Start()
		{
			SelenoHost.Run(@"SelenoTest.App", 12346, c => c
				.UsingLoggerFactory(new ConsoleFactory())
				// If you are using MVC then do this where RouteConfig is the class that registers your routes in the "Name.Of.Your.Web.Project" project
				// If you aren't using MVC then don't include this line
				.WithRouteConfig(RouteConfig.RegisterRoutes)
				);
		}
	}
}