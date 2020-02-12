using System;
using System.Web;

namespace EmailSender
{
    public class CookiesWorker : ICookiesWorker
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

        public HttpCookie CreateCookie(string name, string value, int saveDays = COOKIE_SAVE_DAYS)
        {
            HttpCookie cookie = new HttpCookie(name)
            {
                Expires = DateTime.UtcNow.AddDays(saveDays),
                Value = value
            };

            return cookie;
        }
    }
}