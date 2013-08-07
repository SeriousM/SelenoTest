using NUnit.Framework;
using SelenoTest.UiTests.Engine;
using SelenoTest.UiTests.Factory;
using SelenoTest.UiTests.PageObjects;
using TestStack.Seleno.Configuration;

namespace SelenoTest.UiTests.Tests
{
	[TestFixture]
	public class RegistrationTests
	{
		[SetUp]
		public void Setup()
		{
			AppHost.Start();
		}

		[Test]
		public void GivenAUserIsntRegistered_WhenRegisteringThem_TheyEndUpBackOnTheHomepageAndLoggedIn()
		{
			var page = SelenoHost.NavigateToInitialPage<HomePage>()
			                     .GoToRegisterPage()
			                     .RegisterUser(ObjectMother.NewUser);

			Assert.That(page.Title, Is.EqualTo("Home"));
			Assert.That(page.LoginPanel.IsLoggedIn, Is.True);
			Assert.That(page.LoginPanel.LoggedInUserName, Is.EqualTo(ObjectMother.NewUser.UserName));
		}
	}
}