using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace SportsStore.WebUI.Infrastructure.Concrete
{
	public class FormsAuthProvider : IAuthProvider
	{
		public bool Authenticate(string username, string password)
		{
			// bool result = Membership.ValidateUser(username, password);
			// 이 코드로 진행을 해야한다 -> 안되는 이유를 찾아보자

			bool result = FormsAuthentication.Authenticate(username, password);
			
			if (result)
			{
				FormsAuthentication.SetAuthCookie(username, false);
			}
			return result;
		}
	}
}