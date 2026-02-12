// See https://aka.ms/new-console-template for more information
using System;
Console.WriteLine("Arithmetic Operators perform common mathematical operations.");

int x = 10; 
int y = 5;
Console.WriteLine(x+y);
Console.WriteLine(x-y);
Console.WriteLine(x/y);
Console.WriteLine(x%y);

Console.WriteLine("Relation Operators compare two values.");

int a = 10;
int b = 20;
Console.WriteLine(a==b);
Console.WriteLine(a != b);
Console.WriteLine(a > b);
Console.WriteLine(a < b);

Console.WriteLine("Logical Operators perform bit-level operations.");
bool p= true, q = false;
Console.WriteLine(p && q);
Console.WriteLine(p || q);
Console.WriteLine(!p);

Console.WriteLine("Bitwise Operators perform bit-level operations.");
int m = 5;
int n = 3;
Console.WriteLine(m & n);
Console.WriteLine(m | n);
Console.WriteLine(m ^ n );
Console.WriteLine("The conditional operator returns one of two value base on a Boolean expression.");
int d = (a > b ) ? a : b;
Console. WriteLine(d);


