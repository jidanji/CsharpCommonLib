using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathSoftCommonLib
{
    public static class FileStringHelper
    {
        public static String GetFileName(this string fileFullName)
        {
            try
            {
                string[] fileArray = fileFullName.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
                int count = fileArray.Length;
                string fileName = fileArray[count - 1];

                return fileName;

            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }

        public static bool IsFullNameSomeExtentions(this string fileFullName, ref IEnumerable<String> SomeExtentions)
        {
            try
            {
                string[] fileArray = fileFullName.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
                int count = fileArray.Length;
                string fileName = fileArray[count - 1];
                return fileName.IsFileNameSomeExtentions(ref SomeExtentions);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="SomeExtentions"></param>
        /// <returns></returns>
        public static bool IsFileNameSomeExtentions(this string fileName,ref  IEnumerable<String> SomeExtentions)
        {
            try
            {
                string[] fileArray = fileName.Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries);
                int count = fileArray.Length;
                string fileExtention = fileArray[count - 1].ToLower();
                var AfterSomeExtentions = SomeExtentions.Select(item => item.ToLower()).ToList<String>();
                return AfterSomeExtentions.Any(item => item == fileExtention);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
