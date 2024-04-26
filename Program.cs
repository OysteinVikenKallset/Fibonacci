// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int length = 10;
int zeroIndex = 0;
int firstIndex = 1;
int currentNumber;

Console.WriteLine(zeroIndex); 
Console.WriteLine(firstIndex);   
for (int i = 0; i < length; i++)
{
currentNumber = firstIndex + zeroIndex;
zeroIndex = firstIndex;
firstIndex = currentNumber;
 Console.WriteLine(currentNumber); 
}

