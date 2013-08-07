using SelenoTest.UiTests.PageComponents;
using TestStack.Seleno.PageObjects;
using TestStack.Seleno.PageObjects.Locators;

namespace SelenoTest.UiTests.PageObjects
{
	public class HomePage : Page
	{
		public RegisterPage GoToRegisterPage()
		{
			return this.Navigate().To<RegisterPage>(By.LinkText("Register"));
		}

		public LoginPanel LoginPanel
		{
			get { return this.GetComponent<LoginPanel>(); }
		}
	}
}