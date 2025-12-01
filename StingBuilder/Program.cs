using System;
class StringBuilder
{
    static void main()
    { 
        //append
         StringBuilder sb = new StringBuilder("Hello");
         sb.Append("Bishal");
         Console.WriteLine(sb.ToString());

// Insert
         StringBuilder sb = new StringBuilder("Hello World!");
         sb.Insert(6,"Beutiful");
         Console.WriteLine(sb.ToString());

         // Remove
         StringBuilder sb = new StringBuilder("Hello Beautful World! ");
         sb.Remove(6,10);
         Console.WriteLine(sb.ToString());

    }
}