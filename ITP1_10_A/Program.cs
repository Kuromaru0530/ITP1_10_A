using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ');
        var x1 = double.Parse(input[0]);
        var y1 = double.Parse(input[1]);
        var x2 = double.Parse(input[2]);
        var y2 = double.Parse(input[3]);

        var l = Math.Pow(y2 - y1, 2);
        var r = Math.Pow(x2 - x1, 2);

        var ans = Math.Sqrt(l + r);
        Console.WriteLine(ans);
    }
}