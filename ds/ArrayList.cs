using System;
using System.Text;
using SortingExtensions;

namespace ds {
    
    public class ArrayList<T> : IList<T> {
        private T[] _list;
        private int _listCursor;
        private int _initialSize;
        public ArrayList(int initialSize = 10){
            _listCursor = 0;
            _initialSize = initialSize;
            _list = new T[initialSize];
        }
        private void expandArray(){
            int newSize = _list.Length * 2;
            T[] newArray = new T[newSize];
            _list.CopyTo(newArray, 0);
            _list = newArray;
        }
        public bool add(T newItem){

            if(_listCursor > _list.Length - 1){
                this.expandArray();
            }
            _list[_listCursor] = newItem;
            _listCursor++;
            return true;
        }
        public bool add(int index, T newItem){
            if(index > _list.Length - 1){
                throw new IndexOutOfRangeException();
            }
            if(_list[index] == null){
                _list[index] = newItem;
                _listCursor++;
            }
            if(index + 1 >= _list.Length){
                expandArray();
            }
            if(_list[index] != null){
                int next = index + 1;
                add(next, _list[index]);
               _list[index] = newItem;
            }
            return true;
        }
        public T remove(int index){
            if(index < 0 || index > _listCursor){
                throw new IndexOutOfRangeException();
            }
            if(index == _listCursor){
                _listCursor--;
                return _list[index];
            }
            T item = _list[index];
            int next = index + 1;
            _list[index] = remove(next);
            return item;
        }
        public void clear(){
            _list = new T[_initialSize];
            _listCursor = 0;
        }
        public bool replace(int index, T item){
            if(index < 0 || index > _listCursor){
                throw new IndexOutOfRangeException();
            }
            _list[index] = item;
            return true;
        }
        public T get(int index){
            if(index < 0 || index > _listCursor){
                throw new IndexOutOfRangeException();
            }
            return _list[index];
        }
        public int contains(T item){
            
            for(int i = 0; i < _listCursor; i++){
                if(item.Equals(_list[i])){
                    return i;
                }
            } 
            return -1;
        }
        public int length(){
           return _listCursor;
        }
        public bool isEmpty(){
            return _listCursor == 0;
        }
        public bool isFull(){
            throw new NotImplementedException();
        }
        public void display(){
            StringBuilder sb = new StringBuilder();
            sb.Append("Array: {");
            for(int i = 0; i < _listCursor; i++){
                sb.Append(_list[i]).ToString();
                if(i < _listCursor - 1)
                    sb.Append(", ");
            }
            sb.Append("}");
            Console.WriteLine(sb.ToString());
        }
        public T[] ToArray(){
            T[] retVal = new T[_listCursor];
            Array.Copy(_list, retVal, _listCursor);
            return retVal;
        }
    }
}