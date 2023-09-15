using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProject
{
    internal class Maximum
    {
        public static int MaxInteger(int Num1, int Num2, int Num3)
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
        public static float Maxfloat(float N1, float N2, float N3)
        {
            if (N1.CompareTo(N2) > 0 && N1.CompareTo(N3) > 0 ||
                N1.CompareTo(N2) >= 0 && N1.CompareTo(N3) > 0 ||
                N1.CompareTo(N2) > 0 && N1.CompareTo(N3) >= 0)
            {
                return N1;
            }
            if (N2.CompareTo(N1) > 0 && N2.CompareTo(N3) > 0 ||
                N2.CompareTo(N1) >= 0 && N2.CompareTo(N3) > 0 ||
                N2.CompareTo(N1) > 0 && N2.CompareTo(N3) >= 0)
            {
                return N2;
            }
            if (N3.CompareTo(N3) > 0 && N3.CompareTo(N2) > 0 ||
                N3.CompareTo(N3) >= 0 && N3.CompareTo(N2) > 0 ||
                N3.CompareTo(N3) > 0 && N3.CompareTo(N2) >= 0)
            {
                return N3;
            }
            throw new Exception("N1 ,N2,N3 are same");
        }
        public static string Maxstring(string Str1, string Str2, string Str3)
        {
            if (Str1.CompareTo(Str2) > 0 && Str1.CompareTo(Str3) > 0 ||
                Str1.CompareTo(Str2) >= 0 && Str1.CompareTo(Str3) > 0 ||
                Str1.CompareTo(Str2) > 0 && Str1.CompareTo(Str3) >= 0)
            {
                return Str1;
            }
            if (Str2.CompareTo(Str1) > 0 && Str2.CompareTo(Str3) > 0 ||
                Str2.CompareTo(Str1) >= 0 && Str2.CompareTo(Str3) > 0 ||
                Str2.CompareTo(Str1) > 0 && Str2.CompareTo(Str3) >= 0)
            {
                return Str2;
            }
            if (Str3.CompareTo(Str3) > 0 && Str3.CompareTo(Str2) > 0 ||
                Str3.CompareTo(Str3) >= 0 && Str3.CompareTo(Str2) > 0 ||
                Str3.CompareTo(Str3) > 0 && Str3.CompareTo(Str2) >= 0)
            {
                return Str3;
            }
            throw new Exception("str1 ,Str2,Str3 are same");
        }

    }
    
}