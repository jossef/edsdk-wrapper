using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDSDKWrapper.Framework.Miscellaneous
{
    public static class EnumUtilities
    {
        public static IEnumerable<EnumType> GetEnumValues<EnumType>()
            where EnumType : struct, IConvertible
        {
            Array enumValues = Enum.GetValues(typeof(EnumType));

            return enumValues.Cast<EnumType>();
        }
    }
}
