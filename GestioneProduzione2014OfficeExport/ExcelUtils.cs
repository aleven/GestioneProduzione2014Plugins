using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Excel;

namespace GestioneProduzione2014OfficeExport
{
    class ExcelUtils
    {
        /// <summary>
        /// Get Row Number from Cell Name
        /// </summary>
        /// <param name="cellName">Es. A3</param>
        /// <returns>then row number</returns>
        public static int getRow(string cellName)
        {
            return int.Parse(Regex.Match(cellName, @"[0-9]+").Value);
        }

        /// <summary>
        /// Get Columna Name from Cell Name
        /// </summary>
        /// <param name="cellName">Es. A3</param>
        /// <returns>the column name</returns>
        public static string getCol(string cellName)
        {
            return Regex.Match(cellName, @"[a-zA-Z]+").Value;
        }

        public static Range getRange(Worksheet worksheet, string cellName)
        {
            return worksheet.get_Range(cellName, System.Type.Missing);
        }

        public static Range getRange(Worksheet worksheet, string fromCell, string toCell)
        {
            return worksheet.get_Range(fromCell, toCell);

        }
        public static Range getRangeEntireRow(Worksheet worksheet, string cellName)
        {
            return worksheet.get_Range(cellName, cellName).EntireRow;
        }

        private static Range setValueObject(Worksheet worksheet, string cellName, object value)
        {
            Range range = getRange(worksheet, cellName);
            if (range != null)
            {
                range.Value2 = value;
            }
            return range;
        }

        public static Range setValue(Worksheet worksheet, string cellName, string value)
        {
            return setValueObject(worksheet, cellName, value);
        }

        public static Range setValue(Worksheet worksheet, string cellName, double value)
        {
            return setValueObject(worksheet, cellName, value);
        }

        public static Range setValue(Worksheet worksheet, string cellName, decimal value)
        {
            return setValueObject(worksheet, cellName, value);
        }

        public static Range setValue(Worksheet worksheet, string cellName, DateTime value)
        {
            return setValueObject(worksheet, cellName, value.ToShortDateString());
        }

        //public static object missing()
        //{
        //    return Type.Missing;
        //}

        public static readonly object missing = Type.Missing;
    }
}
