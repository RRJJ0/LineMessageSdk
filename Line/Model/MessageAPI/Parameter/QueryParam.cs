using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Line.Model.MessageAPI.Parameter
{
    public class QueryParam
    {
        public override string ToString()
        {
            Type type = GetType();
            PropertyInfo[] properties = type.GetProperties();
            StringBuilder queryString = new StringBuilder("?");
            foreach (var property in properties)
            {
                if (Attribute.IsDefined(property, typeof(JsonIgnoreAttribute))) continue;
                object? propertyValue = property.GetValue(this);
                string name = property.Name;
                if (propertyValue != null)
                {
                    if (Attribute.IsDefined(property, typeof(JsonPropertyAttribute)))
                    {
                        var attr = property.GetCustomAttribute(typeof(JsonPropertyAttribute));
                        if (attr != null & attr is JsonPropertyAttribute)
                        {
                            name = ((JsonPropertyAttribute)attr!).PropertyName ?? name;
                        }

                    }
                    if (propertyValue is IEnumerable enumerableValue && propertyValue is not string)
                    {
                        foreach (var item in enumerableValue)
                        {
                            if (item is DateTime date)
                            {
                                queryString.Append($"{name}={HttpUtility.UrlEncode(date.ToString("yyyy-MM-dd HH:mm:ss"))}&");
                            }
                            else
                            {
                                queryString.Append($"{name}={HttpUtility.UrlEncode(item.ToString())}&");
                            }

                        }
                    }
                    else
                    {
                        if (propertyValue is DateTime date)
                        {
                            queryString.Append($"{name}[]={HttpUtility.UrlEncode(date.ToString("yyyy-MM-dd HH:mm:ss"))}&");
                        }
                        else
                        {
                            queryString.Append($"{name}[]={HttpUtility.UrlEncode(propertyValue.ToString())}&");
                        }
                    }

                }
            }

            if (queryString.Length > 1)
            {
                queryString.Length--;
            }

            return queryString.ToString();
        }
    }
}
