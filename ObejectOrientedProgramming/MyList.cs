using System.Collections.Generic;

namespace ObejectOrientedProgramming
{
    public class MyList<T>
    {
        private readonly IList<T> list = new List<T>();
        
        /*public void Add(T item)
        {
            list.Add(item);
        }*/
        
        
        public void Add(T item) => list.Add(item);

        /*public T Get(int index)
        {
            return list[index];
        }*/

        public T Get(int index) => list[index];

        /* public int Count
         {
             get { return list.Count; }
         }*/

        /// <summary>
        /// This Property used to get length of myList.
        /// </summary>
        public int Count => list.Count;

        /* public T this[int index] 
         {
             get { return list[index]; }
         } */

        /// <summary>
        /// This property used to get element from list based on index
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>T element</returns>
        public T this[int index] => list[index];

    }
}
