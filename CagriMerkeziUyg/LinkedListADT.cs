using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CagriMerkeziUyg
{
    public abstract class LinkedListADT
    {
        public Node Head;
        
        public int Size = 0;
        public abstract void InsertFirst(Cagri value);
        public abstract void InsertLast(Cagri value);
        public abstract void InsertPos(int position, Cagri value);
        public abstract void DeleteFirst();
        public abstract void DeleteLast();
        public abstract void DeletePos(int position);
        public abstract Node GetElement(int position);
        public abstract Node GetElementById(int id);
        public abstract int GetPositionById(int id);
        public abstract string DisplayElements();
    }
}
