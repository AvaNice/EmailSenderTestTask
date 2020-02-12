using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace EmailSender
{
    public class AddressValidator
    {
        public bool IsValideAddress(string address)
        {
            return true;
            //try
            //{
            //    return Regex.IsMatch(address,
            //        @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
            //        @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
            //        RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            //}
            //catch (RegexMatchTimeoutException)
            //{
            //    return false;
            //}
        }
    }
}