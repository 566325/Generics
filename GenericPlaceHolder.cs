using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProject
{
    public class GenericPlaceHolder<S>  where S: IComparable
    { 
        public  S Num1, Num2, Num3 ;

        public GenericPlaceHolder(S Num1,S Num2, S Num3)
        {
            this.Num1 = Num1;
            this.Num2 = Num2;
            this.Num3 = Num3;

        }
    
        public  S MaxGeneric()
        {
            if (Num1.CompareTo(Num2) > 0 && Num1.CompareTo(Num3) > 0 ||
                Num1.CompareTo(Num2) >= 0 && Num1.CompareTo(Num3) > 0 ||
                Num1.CompareTo(Num2) > 0 && Num1.CompareTo(Num3) >= 0)
            {
                return Num1;
            }
            if (Num2.CompareTo(Num1) > 0 && Num2.CompareTo(Num3) > 0 ||
                Num2.CompareTo(Num1) >= 0 && Num2.CompareTo(Num3) > 0 ||
                Num2.CompareTo(Num1) > 0 && Num2.CompareTo(Num3) >= 0)
            {
                return Num2;
            }
            if (Num3.CompareTo(Num3) > 0 && Num3.CompareTo(Num2) > 0 ||
                Num3.CompareTo(Num3) >= 0 && Num3.CompareTo(Num2) > 0 ||
                Num3.CompareTo(Num3) > 0 && Num3.CompareTo(Num2) >= 0)
            {
                return Num3;
            }
            throw new Exception("Num1 ,Num2,Num3 are same");

        }
    }
}
