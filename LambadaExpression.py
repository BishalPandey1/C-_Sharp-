using System;
public class LambadaExpression{
    public delegate void Value(int x, int y);
    public static void Main(string [] args){
        Value obb = (a, b) => Console.WriteLine(a + b);
        obb(1, 6);  
    }
}
