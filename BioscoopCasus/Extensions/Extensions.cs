using System;
namespace BioscoopCasus.Extensions
{
    public static class Extensions
    {
        public static bool IsWeekend(this DateTime dateTime)
        {
            return dateTime.DayOfWeek == DayOfWeek.Friday || dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday;
        }

        public static IEnumerable<IEnumerable<T>> SplitList<T>(this IEnumerable<T> source, int maxPerList)
        {
            var enumerable = source as IList<T> ?? source.ToList();
            if (!enumerable.Any())
            {
                return new List<IEnumerable<T>>();
            }
            return (new List<IEnumerable<T>>() { enumerable.Take(maxPerList) }).Concat(enumerable.Skip(maxPerList).SplitList<T>(maxPerList));
        }
    }
}

