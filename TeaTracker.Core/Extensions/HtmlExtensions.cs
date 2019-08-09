using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace TeaTracker.Core.Extensions
{
    public static class HtmlExtensions
    {
        public static string GetEnumDescription(this Enum @enum)
        {
            Type enumType = @enum.GetType();
            return ((DescriptionAttribute)enumType.GetMember(@enum.ToString())
                .FirstOrDefault(m => m.DeclaringType == enumType)
                .GetCustomAttributes(typeof(DescriptionAttribute), false)
                .FirstOrDefault())?.Description ?? @enum.ToString();
        }

        public static IEnumerable<SelectListItem> GetEnumList<T>(this IHtmlHelper helper) where T : Enum
        {
            List<SelectListItem> selectList = new List<SelectListItem>();
            T[] enumValues = (T[])Enum.GetValues(typeof(T));

            foreach (T enumValue in enumValues)
            {
                selectList.Add(new SelectListItem() { Value = Array.IndexOf(enumValues, enumValue).ToString(), Text = enumValue.GetEnumDescription() });
            }

            return selectList;
        }
    }
}
