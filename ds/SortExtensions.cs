using System; 
using ds;

namespace SortingExtensions {
    public static class SortExtensions {
        public static void BubbleSort<T>(this IList<T> collection) where T : IComparable {
            int passes = collection.length();
            bool swapped;
            do {
                swapped = false;
                for(int i = 1; i < passes; i++){
                    T prev = collection.get(i -1);
                    T cur = collection.get(i);
                    if(prev.CompareTo(cur) > 0){
                        collection.replace(i -1, cur);
                        collection.replace(i, prev);
                        swapped = true;
                    }
                }

            } while(swapped == true);
        }
    }
}