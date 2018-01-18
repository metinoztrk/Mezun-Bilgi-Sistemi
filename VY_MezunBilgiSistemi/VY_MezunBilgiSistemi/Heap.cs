using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY_MezunBilgiSistemi
{
    public class Heap
    {
        public HeapNode[] HeapArray;
        private int Size=10;
        public int heapindis = 0;
        public int currentSize { get; set; }

      
        public Heap()
        {
            HeapArray = new HeapNode[Size];
        }

        public bool IsEmpty()
        {
            return currentSize == 0;
        }
        public bool Insert(Ogrencino deger)
        {
            if (currentSize == Size)
                return false;
    
            if (HeapArray[heapindis]==null)
            {
                HeapNode newHeapDugumu = new HeapNode(deger);
                HeapArray[currentSize] = newHeapDugumu;
                currentSize++;
                   
            }
            else
            {
                HeapArray[currentSize - 1].HeapBaglıliste.InsertLast(deger);
                if ((HeapArray[currentSize - 1].HeapBaglıliste.Size == 1))
                {
                    EgitimBilgileri e = new EgitimBilgileri();
                    e = (EgitimBilgileri)deger;
                    if (e.BasariBelgesi == true)
                    {
                        HeapArray[currentSize - 1].Basarıderecesi = Convert.ToSingle(e.Ortalama + 10);
                    }
                    else
                    {
                        HeapArray[currentSize - 1].Basarıderecesi = Convert.ToSingle(e.Ortalama);
                    }

                }
                else
                {
                    MoveToUp(heapindis);
                    heapindis++;
                    
                }
            }
            return true;
        }
        public void MoveToUp(int index)
        {
            int parent = (index - 1) / 2;
            HeapNode bottom = HeapArray[index];

            while (index > 0 && (HeapArray[parent].Basarıderecesi<bottom.Basarıderecesi))
            {
                HeapArray[index] = HeapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            HeapArray[index] = bottom;
        }
        public void MoveToDown(int index)
        {
            int largerChild;
            HeapNode top = HeapArray[index];
            while (index < currentSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;
                if (rightChild < currentSize && HeapArray[leftChild].Basarıderecesi<HeapArray[rightChild].Basarıderecesi)
                    largerChild = rightChild;
                else
                    largerChild = leftChild;
                if (rightChild < currentSize && HeapArray[leftChild].Basarıderecesi >HeapArray[rightChild].Basarıderecesi)
                    break;
                HeapArray[index] = HeapArray[largerChild];
                index = largerChild;
            }
            HeapArray[index] = top;
        }

    }
}
