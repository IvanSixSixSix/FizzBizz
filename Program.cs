Console.WriteLine("Введите целое число");

var input = Console.ReadLine();

var value = Convert.ToUInt64(input);

long[] array = new long[value];
var i = value - value;
do
{
    array[i] = (uint)i +1;
    if(array[i] % 3 != 0 & array[i] % 5 != 0)
    {
        array[i].ToString();
        Console.WriteLine($"{array[i]}");
    }
    if (array[i] % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    if (array[i] % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    if (array[i] % 3 == 0 & array[i] % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    i++;
}
while ((int)i != (int)value -1 );
Console.ReadLine();







