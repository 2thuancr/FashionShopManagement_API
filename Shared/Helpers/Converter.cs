using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Helpers
{
    public static class Converter
    {
        public static decimal ToDecimal(this object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return 0;
            }
            return Convert.ToDecimal(value);
        }

        public static decimal? ToDecimalNullable(this object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return null;
            }
            return Convert.ToDecimal(value);
        }

        public static int ToInt32(this object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return 0;
            }
            return Convert.ToInt32(value);
        }

        public static long ToInt64(this object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return 0;
            }
            return Convert.ToInt64(value);
        }

        public static int? ToInt32Nullable(this object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return null;
            }
            return Convert.ToInt32(value);
        }

        public static long? ToInt64Nullable(this object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return null;
            }
            return Convert.ToInt64(value);
        }

        public static bool ToBoolean(this object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return false;
            }
            return Convert.ToBoolean(value);
        }

        public static bool? ToBooleanNullable(this object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return null;
            }
            return Convert.ToBoolean(value);
        }

        public static DateTime ToDateTime(this object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return DateTime.MinValue;
            }
            return Convert.ToDateTime(value);
        }

        public static DateTime? ToDateTimeNullable(this object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return null;
            }
            return Convert.ToDateTime(value);
        }

        public static double ToDouble(this object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return 0;
            }
            return Convert.ToDouble(value);
        }

        public static double? ToDoubleNullable(this object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return null;
            }
            return Convert.ToDouble(value);
        }

        public static string ToString(this object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return null;
            }
            return Convert.ToString(value);
        }

        public static byte[] ToByteArray(this object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return null;
            }
            return (byte[])value;
        }

        public static Guid ToGuid(this object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return Guid.Empty;
            }
            return (Guid)value;
        }

        public static object ToObject(this object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return null;
            }
            return value;
        }

        public static T ToEnum<T>(this object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return default(T);
            }
            return (T)Enum.Parse(typeof(T), value.ToString());
        }

        public static T ToEnum<T>(this object value, T defaultValue)
        {
            if (value == null || value == DBNull.Value)
            {
                return defaultValue;
            }
            return (T)Enum.Parse(typeof(T), value.ToString());
        }
    }
}
