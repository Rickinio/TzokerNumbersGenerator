var uniqueNumbers = new HashSet<int>() {14,23,27,29,31,5,10,18,22,30,44,6,1,6,25,30,31,11,2,11,15,23,28,10,6,9,14,15,30,3,5,14,25,36,41,9,7,12,28,42,44,15,10,13,14,28,35,19,9,20,28,41,42,9,12,32,34,35,42,18,1,38,40,43,44,9,2,9,11,23,33,6 };
//var uniqueNumbers = new HashSet<int>();
var uniqueTzokerNumbers = new HashSet<int>();
var randomizer = new Random(new Random().Next());

//do
//{
//    var number = randomizer.Next(1, 46);
//    uniqueNumbers.Add(number);

//} while (uniqueNumbers.Count < 30);

do
{
    var number = randomizer.Next(1, 21);
    uniqueTzokerNumbers.Add(number);

} while (uniqueTzokerNumbers.Count < 6);

//TEST COMMIT

for(int i = 0; i < 6; i++)
{
    var numbers = new HashSet<int>();

    do
    {
        var number = randomizer.Next(0, uniqueNumbers.Count);
        numbers.Add(uniqueNumbers.ElementAt(number));

    } while (numbers.Count < 5);

    //var tzoker = uniqueTzokerNumbers.ElementAt(randomizer.Next(0, 6));
    var tzoker = randomizer.Next(1, 21);

    Console.WriteLine($"{string.Join(" - ", numbers.OrderBy(n => n))}  -  Tzoker: {tzoker}");
    Console.WriteLine();
    Console.WriteLine();
}

Console.ReadLine();
