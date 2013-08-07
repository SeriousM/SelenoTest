using TestStack.Seleno.PageObjects;
using TestStack.Seleno.PageObjects.Locators;

namespace SelenoTest.UiTests.PageComponents
{
	public class LoginPanel : UiComponent
	{
		public bool IsLoggedIn
		{
			get { return this.Find().OptionalElement(By.Id("login-panel")) == null; }
		}

		public string LoggedInUserName
		{
			get { return this.Find().Element(By.Id("login-username")).Text; }
		}
	}
}