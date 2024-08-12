using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.MessageAPI.Parameter
{
    public class PathParam
    {

        public object[] GetArgs()
        {
            Type type = GetType();
            PropertyInfo[] properties = type.GetProperties();
            object[] args = new object[properties.Length];

            foreach (PropertyInfo property in properties)
            {
                int index = -1;
                object? propertyValue = property.GetValue(this);
                if (propertyValue == null) continue;
                if (Attribute.IsDefined(property, typeof(PathSequenceAttribute)))
                {
                    var attr = property.GetCustomAttribute(typeof(PathSequenceAttribute));
                    if (attr != null & attr is PathSequenceAttribute)
                    {
                        index = ((PathSequenceAttribute)attr!).Sequence;
                    }
                }
                else
                {
                    index = Array.FindIndex(args, it => it == null);
                    if (index == -1) throw new ArgumentException("PathParam Not Found Null Index");
                }
                args[index] = propertyValue;
            }


            return args;
        }
    }
}
