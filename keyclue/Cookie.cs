using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;

namespace keyclue
{
    public static class Cookie
    {
		// Prototype.
		// Set the cookie to the specified timeout with the expiration in # of days.
		public static void Save(HttpResponse response, string key, string data, int exp)
		{
			HttpCookie accountCookie=new HttpCookie(key, data);
			DateTime dt=DateTime.Now;
			accountCookie.Expires=dt.AddDays(exp);
			response.Cookies.Add(accountCookie);
		}


		// Prototype.
		// Get the cookie of the specified key.
		public static string Load(HttpRequest request, string key)
		{
			HttpCookieCollection coll=request.Cookies;
			string ret="";
			if (coll != null && coll[key] != null)
			{
				ret=coll[key].Value;
			}
			return ret;
		}

        public static void Delete(HttpResponse response, string key)
        {
            Save(response, key, "", -1);
        }
	}
}