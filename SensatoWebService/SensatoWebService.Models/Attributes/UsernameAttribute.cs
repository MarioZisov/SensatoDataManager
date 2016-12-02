using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace SensatoWebService.Models.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class UsernameAttribute : ValidationAttribute
    {
        private const string Pattern = @"^[A-Za-z0-9]+[\w-]+[a-zA-Z]+[\w-]+$";

        public override bool IsValid(object value)
        {
            string username = value.ToString();

            if (Regex.IsMatch(username, Pattern))
            {
                return true;
            }

            return false;
        }
    }
}