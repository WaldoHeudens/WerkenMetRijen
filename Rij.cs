using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WerkenMetRijen
{
     internal class Rij <T>
    {
        List<T> container;

        internal Rij()
        {
            container = new List<T>();
        }

        public void Toevoegen(T i)
        {
            container.Add(i);
        }


        public bool IsLeeg()
        { 
            return container.Count == 0; 
        }

        public T Uithalen()
        {
            //if (container.Count == 0)
            //    return int.MinValue;
            T even = container[0];
            container.RemoveAt(0);
            return even;
        }

        public void MaakLeeg()
        {
            container.Clear();
        }

        public override string ToString()
        {
            string s = "";
            foreach(T i in container) 
            {
                s += i.ToString() + "\n";
            }
            return s;
        }

    }
}
