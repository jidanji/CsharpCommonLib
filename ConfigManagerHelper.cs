using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;


namespace MathSoftCommonLib
{
    public class ConfigManagerHelper
    {
        /// <summary>
        /// 通过可以获取AppSettings中的值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static String GetValueByKey(String key)
        {
            string retString = String.Empty;
            if (ConfigurationManager.AppSettings.AllKeys.Contains(key))
            {
                retString = ConfigurationManager.AppSettings[key];
            }
            return retString;
        }
    }
}
