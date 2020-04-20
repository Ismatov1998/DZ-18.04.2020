using System;

namespace PM
{
    class Program
    {
        delegate T Message<T>(T x, T y);
        static void Main(string[] args)
        {
          
        Console.WriteLine("Вводите первый число:");
        double n1=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Вводите второе число:");
        double n2=Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine(@"Выберите операцию который хотите выполнить:
+
-
/
*");
        Message<double> mes;
        string s=Console.ReadLine();
        switch(s)
        {
            case "+":
              mes=plus;
              Console.WriteLine(mes.Invoke(n1,n2));
            break;

            case "-":
               mes=minus;
               Console.WriteLine(mes.Invoke(n1,n2));
            break;

            case "/":
              mes=division;
              Console.WriteLine(mes.Invoke(n1,n2));
            break;

            case "*":
              mes=multiply;
              Console.WriteLine(mes.Invoke(n1,n2));
            break;
        }
     
        }
        
        
        public static U minus<U>(U x, U y)
        {
          return (dynamic)x-(dynamic)y; 
        }

        public static U  plus<U>(U x,U y)
        {
            return (dynamic)x+(dynamic)y;   
        }
         public static U  division<U>(U x,U y)
        {
            return (dynamic)x/(dynamic)y;   
        }
         public static U  multiply<U>(U x,U y)
        {
            return (dynamic)x*(dynamic)y;   
        }

        
  
    }
}
