// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int numN = int.Parse(Console.ReadLine()??"0");
if(numN<0) numN = -numN;
for(int i=  -numN; i <= numN; i++)
{
    Console.Write(i);
    Console.Write(",");
}
