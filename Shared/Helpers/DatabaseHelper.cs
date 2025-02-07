using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Helpers
{
    public static class DatabaseHelper
    {
        public static string GetTableName<T>()
        {
            return typeof(T).Name;
        }

        public static string GetColumnName<T>(string propertyName)
        {
            return typeof(T).GetProperty(propertyName).Name;
        }

        public static string GetStringValue(this SqlDataReader reader, int index)
        {
            return reader.IsDBNull(index) ? null : reader.GetString(index);
        }

        public static int GetIntValue(this SqlDataReader reader, int index)
        {
            return reader.IsDBNull(index) ? 0 : reader.GetInt32(index);
        }

        public static bool GetBooleanValue(this SqlDataReader reader, int index)
        {
            return reader.IsDBNull(index) ? false : reader.GetBoolean(index);
        }

        public static DateTime GetDateTimeValue(this SqlDataReader reader, int index)
        {
            return reader.IsDBNull(index) ? DateTime.MinValue : reader.GetDateTime(index);
        }

        public static DateTime? GetDateTimeValueNullable(this SqlDataReader reader, int index)
        {
            return reader.IsDBNull(index) ? null : (DateTime?)reader.GetDateTime(index);
        }

        public static double GetDoubleValue(this SqlDataReader reader, int index)
        {
            return reader.IsDBNull(index) ? 0 : reader.GetDouble(index);
        }

        public static decimal GetDecimalValue(this SqlDataReader reader, int index)
        {
            return reader.IsDBNull(index) ? 0 : reader.GetDecimal(index);
        }

        public static byte[] GetByteArrayValue(this SqlDataReader reader, int index)
        {
            return reader.IsDBNull(index) ? null : (byte[])reader.GetValue(index);
        }

        public static Guid GetGuidValue(this SqlDataReader reader, int index)
        {
            return reader.IsDBNull(index) ? Guid.Empty : reader.GetGuid(index);
        }

        public static object GetObjectValue(this SqlDataReader reader, int index)
        {
            return reader.IsDBNull(index) ? null : reader.GetValue(index);
        }

        public static T GetEnumValue<T>(this SqlDataReader reader, int index)
        {
            return reader.IsDBNull(index) ? default(T) : (T)Enum.Parse(typeof(T), reader.GetString(index));
        }
    }
}
