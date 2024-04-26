using System.Numerics;

int length = 100;
BigInteger previous = 0;
BigInteger current = 1;

Console.WriteLine(previous);
Console.WriteLine(current);
for (int i = 0; i < length; i++)
{
    BigInteger next = previous + current;
    Console.WriteLine(next);
    previous = current;
    current = next;
}
