var uniqueNumbers = new HashSet<int>();
var uniqueTzokerNumbers = new HashSet<int>();
var randomizer = new Random(new Random().Next());

do
{
    var number = randomizer.Next(1, 46);
    uniqueNumbers.Add(number);

} while (uniqueNumbers.Count < 30);

do
{
    var number = randomizer.Next(1, 21);
    uniqueTzokerNumbers.Add(number);

} while (uniqueTzokerNumbers.Count < 6);



for(int i = 0; i < 6; i++)
{
    var numbers = new HashSet<int>();

    do
    {
        var number = randomizer.Next(0, 30);
        numbers.Add(uniqueNumbers.ElementAt(number));

    } while (numbers.Count < 5);

    //var tzoker = uniqueTzokerNumbers.ElementAt(randomizer.Next(0, 6));
    var tzoker = randomizer.Next(1, 21);

    Console.WriteLine($"{string.Join(" - ", numbers.OrderBy(n => n))}  -  Tzoker: {tzoker}");
    Console.WriteLine();
    Console.WriteLine();
}

Console.ReadLine();
