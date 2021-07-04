using System;
using Xunit;
using ds;
using SortingExtensions;


namespace ds.tests
{
    public class ArrayListTest
    {
        [Fact]
        public void CreateNewArrayList_Size_1()
        {
            ArrayList<int> lst = new ArrayList<int>(1);
            lst.add(2);
            Assert.True(lst.length() == 1,    "Adding 1 element to new list results in a 1 element list");
        }
        [Fact]
        public void ExpandArrayByAddingNewElement_ArrayListt_Size_1(){
            ArrayList<int> lst = new ArrayList<int>(1);
            lst.add(1);
            lst.add(2);
            Assert.True(lst.length() == 2,    "Adding new element to end of full list expands the arraylist");
        }
        [Fact]
        public void ErrorGettingItemByIndexOutOfBounds(){
            ArrayList<int> lst = new ArrayList<int>(1);
            lst.add(1);
            Assert.Throws<IndexOutOfRangeException>(() => lst.get(1));
        }
        [Theory]
        [InlineData(0)]
        [InlineData(2)]
        [InlineData(1)]
        public void RemoveFromListLocation(int index){
            ArrayList<int> lst = new ArrayList<int>(1);
            lst.add(1);
            lst.add(2);
            lst.add(3);
            int tst = lst.get(index);
            int val = lst.remove(index);
            Assert.True(val == tst,    "Removed expected value from list");
            Assert.True(lst.length() == 2, "Removing 1 element from 3 element list yields a list of length 2");
        }
        [Fact]
        public void checkEmptyList(){
            ArrayList<int> lst = new ArrayList<int>(10);
            Assert.True(lst.isEmpty() == true, "Validate empty list on list creation");
        }
        [Fact]
        public void checkEmptyListAfterRemovingAllItems(){
            ArrayList<int> lst = new ArrayList<int>(10);
            lst.add(5);
            lst.add(4);
            lst.add(3);
            lst.add(2);
            lst.add(1);
            Assert.True(lst.length() == 5, "Five elements were added to list");
            for(int i = 0; i < 5; i++){
                lst.remove(0);
            }
            Assert.True(lst.isEmpty() == true, "Validate empty list after removing all items");
        }
        [Fact]
        public void checkEmptyListOnListClear(){
            ArrayList<int> lst = new ArrayList<int>(10);
            lst.add(5);
            lst.add(4);
            lst.add(3);
            lst.add(2);
            lst.add(1);
            Assert.True(lst.length() == 5, "Five elements were added to list");
            lst.clear();
            Assert.True(lst.isEmpty() == true, "Validate empty list after clearing items");
        }
        [Fact]
        public void tryReplaceItemInList(){
            ArrayList<int> lst = new ArrayList<int>(10);
            for(int i = 0; i < 50; i++){
                lst.add(i);
            }
            int oldValue = lst.get(10); 
            lst.replace(10, 101);
            Assert.True(oldValue != lst.get(10), "Value at index was replaced with a different value");
            Assert.True(lst.get(10) == 101, "Replaced value at index is the expected value");
        }
        [Theory]
        [InlineData(10)]
        [InlineData(0)]
        [InlineData(5)]
        public void ValidateListContainsItem(int value){
            ArrayList<int> lst = new ArrayList<int>(10);
            for(int i = 0; i < 50; i++){
                lst.add(i);
            }
            int index = lst.contains(value);
            Assert.True(index >= 0, "Value was located in the list");
            Assert.True(lst.get(index) == value, "Value was located at the expected list index");
        }
        public void ValidateListDoesNotContainItem(){
            ArrayList<int> lst = new ArrayList<int>(10);
            for(int i = 0; i < 50; i++){
                lst.add(i);
            }
            int index = lst.contains(100);
            Assert.True(index < 0, "Value was not located in the list");
        }
        [Fact]
        public void SortArrayList() {

            ArrayList<int> lst = new ArrayList<int>(10);
            for(int i = 5; i >= 0; i--){
                lst.add(i);
            }
            lst.BubbleSort<int>();
            Assert.True(lst.get(0) == 0, "list was sorted");
        }
    }
}