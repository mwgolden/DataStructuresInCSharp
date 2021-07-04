using System;
using Xunit;
using ds;
using SortingExtensions;

namespace ds.tests {
    public class SortTests {

        [Fact]
        public void SortListUsingSelectionSort() {
            ArrayList<int> arr = new ArrayList<int>();

            arr.add(32);
            arr.add(-2);
             arr.add(10);

            Console.WriteLine("List elements before selection sort:");
            arr.display();

            arr.SelectionSort<int>();

            Console.WriteLine("List elements after selection sort:");
            arr.display();

            Assert.True(arr.get(0) == -2 && arr.get(1) == 10 && arr.get(2) == 32, "Array successfully sorted");
        }

    }
}