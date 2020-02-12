using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmailSender
{
    public class CookiesWorker
    {
        private const int COOKIE_SAVE_DAYS = 300;
        private readonly HttpRequest _request;

        public CookiesWorker(HttpRequest request)
        {
            _request = request;
        }

        public string GetByName(string name)
        {
            string result = string.Empty;

            if (_request.Cookies[name] != null)
            {
                result = _request.Cookies[name].Value;
            }
            if (result == null)
            {
                return string.Empty;
            }

            return result; 
        }

        public HttpCookie CreateCookie(string name, string value)
        {
            HttpCookie cookie = new HttpCookie(name)
            {
                Expires = DateTime.UtcNow.AddDays(COOKIE_SAVE_DAYS),
                Value = value
            };

            return cookie;
        }
    }
}