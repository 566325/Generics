namespace GenericsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int value=Maximum.MaxInteger(20, 60, 40);
            //Console.WriteLine("Maximum integer is :" + value);

            //float Value1 = Maximum.Maxfloat(32.0f, 61.6f, 80.7f);
            //Console.WriteLine("Maximum float value is :" + Value1);

            //String Value2 = Maximum.Maxstring("Sireesha","MadhuDanyasi","Havi");
            //Console.WriteLine("Maximum sting value is : " + Value2);

            GenericPlaceHolder<int> obj=new GenericPlaceHolder<int>(35,58,70);
            var Value3 = obj.MaxGeneric();
            Console.WriteLine("The Value out of 3 is : " + Value3);


        }
    }
}