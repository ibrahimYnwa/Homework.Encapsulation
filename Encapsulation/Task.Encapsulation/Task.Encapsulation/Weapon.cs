using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Encapsulation
{
    class Weapon
    {
        private int MaxNumbers;
        private int CurNumber = 30;

        public int curNumber 
        { 
            get { return CurNumber; }  
        }
        public int maxNumbers
        {
            get { return MaxNumbers; }
            set
            {
                if (value < 30) 
                {
                    MaxNumbers = 30;
                }
                else
                {
                    MaxNumbers = value;

                }
            }
        }
        public void Shoot()
        {
            if (CurNumber>0)
            {
                CurNumber -= 1;

            }
        }
        public void Reload()
        {
            if (CurNumber<MaxNumbers)
            {
                CurNumber = MaxNumbers;

            }
        }
    }
}
