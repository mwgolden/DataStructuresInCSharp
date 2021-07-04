using System;

namespace ds {
    public interface IList<T> {
        bool add(T newItem);
        bool add(int position, T newItem);
        T remove(int position);
        void clear();
        bool replace(int position, T newItem);
        T get(int position);
        int contains(T item);
        int length();
        bool isEmpty();
        bool isFull();
        void display();
    }
}