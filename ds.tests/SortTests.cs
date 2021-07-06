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

            arr.SelectionSort<int>();

            Assert.True(arr.get(0) == -2 && arr.get(1) == 10 && arr.get(2) == 32, "Array successfully sorted");
        }
        [Fact]
        public void SortRandomListUsinfSelectionSort(){
            ArrayList<int> arr = new ArrayList<int>();
            var random = new Random();
            for(int i = 0; i < 100; i++){
                arr.add(random.Next(101));
            }

            arr.SelectionSort();
            for(int i = 0; i < arr.length() - 1; i++){
                Assert.True(arr.get(i) <= arr.get(i + 1), "Array preceding value is less than or equal to the next value");
            }
        }
        [Fact]
        public void SortRandomListUsingInsertionSort(){
            ArrayList<int> arr = new ArrayList<int>();
            var random = new Random();
            for(int i = 0; i < 100; i++){
                arr.add(random.Next(101));
            }
            
            arr.InsertionSort();

            for(int i = 0; i < arr.length() - 1; i++){
                Assert.True(arr.get(i) <= arr.get(i + 1), "Array preceding value is less than or equal to the next value");
            }
        }
        [Fact]
        public void SortRandomListUsingShellSort(){
            ArrayList<int> arr = new ArrayList<int>();
            var random = new Random();
            for(int i = 0; i < 100; i++){
                arr.add(random.Next(101));
            }
            Console.WriteLine("List elements before shell sort:");
            arr.display();

            arr.ShellSort<int>();

            Console.WriteLine("List elements after shell sort:");
            arr.display();

            for(int i = 0; i < arr.length() - 1; i++){
                Assert.True(arr.get(i) <= arr.get(i + 1), "Array preceding value is less than or equal to the next value");
            }
        }

    }
}