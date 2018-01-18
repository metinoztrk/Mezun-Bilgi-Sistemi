using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY_MezunBilgiSistemi
{
       
    public class HashTable
    {
        int TableSize = 7;
        public Heap Bolum;
        public Heap[] Table;
        public HashTable()
        {
            Table = new Heap[TableSize];
            for (int i = 0; i < TableSize; i++)
                Table[i] = null;
        }
        public void Add(int key, Ogrencino value)
        {
            int hash = (key % 10);
            if (Table[hash] == null)
            {
                Bolum = new Heap();
                Bolum.Insert(value);
                Table[hash] = Bolum; 
            }
            else
            {
                Table[hash].Insert(value);
                
            }
        }
        public void Remove()
        {
            int hash = 0;
            while (hash < 7)
            {
                Table[hash] = null;
                hash++;
            }
        }
    }
}
