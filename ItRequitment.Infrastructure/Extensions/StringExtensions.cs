using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItRequitment.Infrastructure.Extensions
{
    public static class StringExtensions
    {
        public static bool Empty(this string value) => String.IsNullOrEmpty(value);       

    }
}