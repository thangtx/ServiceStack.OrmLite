using System;
using ServiceStack.OrmLite.Converters;

namespace ServiceStack.OrmLite.SqlServer.Converters
{
    public class SqlServerDateTimeConverter : DateTimeConverter
    {
        public override string ToQuotedString(object value)
        {
            return DateTimeFmt((DateTime)value, "yyyyMMdd HH:mm:ss.fff");
        }
    }
}