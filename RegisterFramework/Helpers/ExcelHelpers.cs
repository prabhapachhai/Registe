using Dapper;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Text;

namespace RegisterFramework.Helpers
{

    public static class ExcelHelpers
    {
        public static string TestDataFile(string excelName)
        {
            //var fileName = @"C:\Users\Vaibhav\source\repos\AutomationPracticeQA1005\AutomationPracticeFramework\TestData\" + excelName + ".xlsx";
            var fileName = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"\..\..\..\TestData\" + excelName + ".xlsx");
            var connection = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {0}; Extended Properties=Excel 12.0", fileName);
            return connection;
        }



        public static List<T> GetTestData<T>(string NewMicrosoftWorksheet, string verifyregisterpage)
        {

            using (var connection = new OleDbConnection(TestDataFile(NewMicrosoftWorksheet)))
            {
               connection.Open();
                var query = "select * from [" + verifyregisterpage + "$]";
                var value = connection.Query<T>(query).AsList();
                connection.Close();
                return value;
            }
        }
    }
}
    

