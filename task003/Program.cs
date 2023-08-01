Console.WriteLine("insertNumidk");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    number = -number;
}
int count = -number;
while (count <= number)
{
    Console.Write($"{count}, ");
    count++;
}
