using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.API.Data.Helpers
{
    public interface IDBHelper
    {
        object ValueOrDbNull();
        int GetIntValue(string columnName);
        short GetShortValue(string columnName);
        long? GetNullableLongValue(string columnName);
        long GetLongValue(string columnName);
        decimal GetDecimalValue(string columnName);
        decimal? GetNullableDecimalValue(string columnName);
        bool GetBooleanValue(string columnName);
        Guid GetGuidValue(string columnName);
        string GetStringValue(string columnName);
        DateTime GetDateTimeValue(string columnName);
        DateTime? GetNullableDate(string columnName);
        int? GetNullableIntValue(string columnName);
        short? GetNullableShortValue(string columnName);  
    }
}
