using System.Web;

namespace EmailSender
{
    public interface ICookiesWorker
    {
        HttpCookie CreateCookie(string name, string value, int saveDays = 300);
        string GetByName(string name);
    }
}