using System;

namespace PM
{
    class Program
    {
        static void Main(string[] args)
        {
        
     
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
            return (dynamic)x+(dynamic)y;   
        }
         public static U  multiply<U>(U x,U y)
        {
            return (dynamic)x*(dynamic)y;   
        }

        
  
    }
}
