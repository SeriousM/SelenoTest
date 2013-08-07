using SelenoTest.App.Models;
using TestStack.Seleno.PageObjects;
using TestStack.Seleno.PageObjects.Locators;

namespace SelenoTest.UiTests.PageObjects
{
	public class RegisterPage : Page<RegisterModel>
	{
		public HomePage RegisterUser(RegisterModel registerModel)
		{
			this.Input().ReplaceInputValueWith("UserName", "test");
			this.Input().Model(registerModel);
			return this.Navigate().To<HomePage>(By.CssSelector("input[type=submit]"));
		}
	}
}