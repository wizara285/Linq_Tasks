using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_tasks
{
    public static class Linq_Tasks
    {
        public static string TaskExample(IEnumerable<string> stringList)
        {
            return stringList.Aggregate<string>((x, y) => x + y);
        }


        public static IEnumerable<string> Task1(char c, IEnumerable<string> stringList)
        {
            return stringList.Where(str => str.Length >= 2 && str.First().Equals(c) && str.Last().Equals(c));
        }

        public static IEnumerable<int> Task2(IEnumerable<string> stringList)
        {
            return from str in stringList
                   orderby str.Length descending
                   select str.Length;
        }

        public static IEnumerable<string> Task3(IEnumerable<string> stringList)
        {
            return stringList.Select(str => str.First().ToString() + str.Last().ToString());
        }

        public static IEnumerable<string> Task4(int k, IEnumerable<string> stringList)
        {
            return from str in stringList
                   where str.Length == k && Char.IsNumber(str.Last())
                   orderby Convert.ToInt32(str.Last().ToString()) ascending
                   select str;
        }

        public static IEnumerable<string> Task5(IEnumerable<int> integerList)
        {
            return integerList.Where(x => x % 2 != 0).OrderBy(x => x).Select(x => x.ToString());
        }
    }
}
