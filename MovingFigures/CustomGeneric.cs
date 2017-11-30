using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingFigures
{
    public class CustomGeneric<T> : CollectionBase
{


        public bool Contains(T item)
        {
            return base.List.Contains(item);
        }

        public int IndexOf(T item)
        {
            return base.List.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            base.List.Insert(index, item);
        }

        public virtual int Add(T value)
        {
            return base.List.Add(value);
        }

        public void Remove(T item)
        {
            base.List.Remove(item);
        }

        public T Last()
        {
            int index = base.List.Count - 1;
            return (T)base.List[index];
        }

        
    }
}
