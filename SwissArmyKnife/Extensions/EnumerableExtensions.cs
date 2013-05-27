using System;
using System.Collections.Generic;
using System.Linq;

namespace SwissArmyKnife.Extensions
{
    public static class EnumerableExtensions
    {
        /*
         * Thanks to Matthew Vines: http://stackoverflow.com/questions/8582344/does-c-sharp-have-isnullorempty-for-list-ienumerable
         */
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null)
            {
                return true;
            }

            /* If this is a list, use the Count property for efficiency. 
             * The Count property is O(1) while IEnumerable.Count() is O(N). */
            var collection = enumerable as ICollection<T>;
            if (collection != null)
            {
                return collection.Count < 1;
            }
            return !enumerable.Any();
        }

        public static void Shuffle<T>(this IList<T> enumerable)
        {
            Random rng = new Random();
            int n = enumerable.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = enumerable[k];
                enumerable[k] = enumerable[n];
                enumerable[n] = value;
            }
        }
    }
}
