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
        public static void SelectionSort<T>(this IList<T> collection) where T : IComparable {
            for(int i = 0; i < collection.length() - 1; i++){                
                T min = collection.get(i);
                int minIndex = i;
                for(int k = i + 1; k < collection.length(); k++){
                    if(collection.get(k).CompareTo(min) < 0){
                        minIndex = k;
                        min = collection.get(minIndex);
                    }
                        
                }
                T temp = collection.get(i);
                collection.replace(i, min);
                collection.replace(minIndex, temp);
            }
        }
    }
}