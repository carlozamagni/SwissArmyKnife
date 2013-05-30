using System.Collections.Generic;
using System.Linq;

namespace SwissArmyKnife.Extensions
{
    public static class IntegerExtensions
    {
        public static bool In(this int subject, IEnumerable<int> list)
        {
            return list.Any(value => value == subject);
        }
    }
}
