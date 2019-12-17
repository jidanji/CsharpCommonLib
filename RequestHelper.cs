using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Reflection;


namespace MathSoftCommonLib
{
    public class RequestHelper
    {
        public T Request2Object<T>(HttpRequest Requst) where T : new()
        {
            T t = new T();
            Type Ts = t.GetType();
            PropertyInfo[] properts = Ts.GetProperties();
            foreach (PropertyInfo item in properts)
            {
            }
            return t;
        }
    }
}
