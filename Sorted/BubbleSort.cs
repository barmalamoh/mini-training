using Sorted.Interfaces;

namespace Sorted
{
    public class BubbleSort : ISorter
    {
        /// <summary>
        /// O(n) = n ^ 2
        /// </summary>
        public int[] Sort(int[] list)
        {
            for (var i = 0; i < list.Length; i++)
            {
                for (var j = 0; j < list.Length - i - 1; j++)
                {
                    if (list[j] <= list[j + 1]) continue;

                    var tmp = list[j + 1];
                    list[j + 1] = list[j];
                    list[j] = tmp;
                }
            }

            return list;
        }
    }
}