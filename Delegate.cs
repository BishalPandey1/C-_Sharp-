using System;
public class Delegate{
    public delegate void Value(int x, int y);
    public void Add(int a, int b){
        Console.WriteLine(a +b);
    }
    public static void Main(string[] args){
        Delegate obj = new Delegate();
        Value obb = new Value(obj.Add);
        obb(1,2);
    }
}
