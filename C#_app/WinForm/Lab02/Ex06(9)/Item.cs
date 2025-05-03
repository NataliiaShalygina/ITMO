using System;

namespace MyClass
{
    abstract class Item : IComparable
    {
        protected long invNumber; 
        protected bool taken;
        
        abstract public  void Return(); 

        public Item(long invNumber, bool taken)
        {
            this.invNumber = invNumber;
            this.taken = taken;
        }

        public Item()
        {
            this.taken = true;
        }
           
   public bool IsAvailable()
      {
          if (taken == true)
              return true;
          else
              return false;
      }

   public long GetInvNumber()
      {
          return invNumber;
      }


   private void Take()
        {
            taken = false;
        }

   public void TakeItem()
   {
       if (this.IsAvailable())
           this.Take();
   }


   public override string ToString()
   {
       if (taken)
       return "Состояние хранения: Инвентарный номер: " + invNumber + ". В наличии";
       else
           return "Состояние хранения: Инвентарный номер: " + invNumber + ". Нет в наличии";
   }


   int IComparable.CompareTo(object obj)
   {
       Item it = (Item)obj;
       if (this.invNumber == it.invNumber) return 0;
       else if (this.invNumber > it.invNumber) return 1;
       else return -1;
   }


  }
}
