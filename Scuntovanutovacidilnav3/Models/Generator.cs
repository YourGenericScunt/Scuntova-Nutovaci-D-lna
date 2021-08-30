using System;
using System.Runtime.InteropServices;

public class Generator
{
    private Random random = new Random();

    public int VratCislo()
    {
        return random.Next(100);
    }
}
