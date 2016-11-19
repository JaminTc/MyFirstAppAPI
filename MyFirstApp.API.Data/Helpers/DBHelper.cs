using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.API.Data.Helpers
{
    public class DBHelper : IDBHelper
    {
        IDataReader reader;
        object @object;

        public DBHelper(object obj)
        {
            @object = obj;
            reader = obj as IDataReader;
        }
        
        public bool GetBooleanValue(string columnName)
        {
            var ordinal = reader.GetOrdinal(columnName);
            return !reader.IsDBNull(ordinal) && reader.GetBoolean(ordinal);
        }

        public DateTime GetDateTimeValue(string columnName)
        {
            var ordinal = reader.GetOrdinal(columnName);
            return reader.IsDBNull(ordinal) ? default(DateTime) : reader.GetDateTime(ordinal);
        }

        public decimal GetDecimalValue(string columnName)
        {
            var ordinal = reader.GetOrdinal(columnName);
            return reader.IsDBNull(ordinal) ? default(decimal) : reader.GetDecimal(ordinal);
        }

        public Guid GetGuidValue(string columnName)
        {
            var ordinal = reader.GetOrdinal(columnName);
            return reader.IsDBNull(ordinal) ? Guid.Empty : reader.GetGuid(ordinal);
        }

        public int GetIntValue(string columnName)
        {
            var ordinal = reader.GetOrdinal(columnName);
            return reader.IsDBNull(ordinal) ? default(int) : reader.GetInt32(ordinal);
        }

        public long GetLongValue(string columnName)
        {
            var ordinal = reader.GetOrdinal(columnName);
            return reader.IsDBNull(ordinal) ? default(long) : reader.GetInt64(ordinal);
        }

        public DateTime? GetNullableDate(string columnName)
        {
            var retValue = default(DateTime?);
            var ordinal = reader.GetOrdinal(columnName);
            if (!reader.IsDBNull(ordinal))
            {
                retValue = reader.GetDateTime(ordinal);
            }
            return retValue;
        }

        public decimal? GetNullableDecimalValue(string columnName)
        {
            var retValue = default(decimal?);
            var oridnal = reader.GetOrdinal(columnName);
            if (!reader.IsDBNull(oridnal))
            {
                retValue = reader.GetDecimal(oridnal);
            }
            return retValue;
        }

        public int? GetNullableIntValue(string columnName)
        {
            var retValue = default(int?);
            var oridnal = reader.GetOrdinal(columnName);
            if (!reader.IsDBNull(oridnal))
            {
                retValue = reader.GetInt32(oridnal);
            }
            return retValue;
        }

        public long? GetNullableLongValue(string columnName)
        {
            var retValue = default(long?);
            var oridnal = reader.GetOrdinal(columnName);
            if (!reader.IsDBNull(oridnal))
            {
                retValue = reader.GetInt64(oridnal);
            }
            return retValue;
        }

        public short? GetNullableShortValue(string columnName)
        {
            var retValue = default(short?);
            var oridnal = reader.GetOrdinal(columnName);
            if (!reader.IsDBNull(oridnal))
            {
                retValue = reader.GetInt16(oridnal);
            }
            return retValue;
        }

        public short GetShortValue(string columnName)
        {
            var ordinal = reader.GetOrdinal(columnName);
            return reader.IsDBNull(ordinal) ? default(short) : reader.GetInt16(ordinal);
        }

        public string GetStringValue(string columnName)
        {
            var ordinal = reader.GetOrdinal(columnName);
            return reader.IsDBNull(ordinal) ? default(string) : reader.GetString(ordinal);
        }

        public object ValueOrDbNull()
        {
            if (@object == null)
                return DBNull.Value;
            if (@object is string)
                return string.IsNullOrWhiteSpace((string)@object) ? DBNull.Value : @object;
            if (@object is int)
                return (int)@object == 0 || (int)@object == int.MinValue ? DBNull.Value : @object;
            return @object;
        }
    }
}
