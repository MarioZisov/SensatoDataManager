using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SensatoWebService.Models.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class ASCIIAttribute : ValidationAttribute
    {
        private const string Pattern = @"^[\x20-\x7E]+$";

        public override bool IsValid(object value)
        {
            string hiveName = value.ToString();

            if (Regex.IsMatch(hiveName, Pattern))
            {
                return true;
            }

            return false;
        }
    }
}