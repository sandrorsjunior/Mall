using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mall.Utils
{
    internal class Utility
    {
        public static string[] GetAttrAsStringArray(object obj)
        {
            Type type = obj.GetType();
            PropertyInfo[] property = type.GetProperties();
            int lengthOfpropertys = property.Length;
            string[] attrs = new string[lengthOfpropertys];
            for (int i = 0; i< lengthOfpropertys; i++)
            {
                attrs[i] = property[i].GetValue(obj).ToString();
            }
            return attrs;
        }
    }
}
