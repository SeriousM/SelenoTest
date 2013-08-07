using System;
using SelenoTest.App.Models;

namespace SelenoTest.UiTests.Factory
{
	internal class ObjectMother
	{
		public static RegisterModel NewUser
		{
			get
			{
				var password = Guid.NewGuid().ToString();
				return new RegisterModel { UserName = Guid.NewGuid().ToString(), Password = password, ConfirmPassword = password };
			}
		}
	}
}