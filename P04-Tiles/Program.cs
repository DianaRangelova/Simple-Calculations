double bathroomWidth  = double.Parse(Console.ReadLine());
double bathroomHeight  = double.Parse(Console.ReadLine());
double tileWidth = double.Parse(Console.ReadLine());
double tileHeight = double.Parse(Console.ReadLine());

double bathroomArea = bathroomWidth * bathroomHeight;
double surplus = bathroomArea * 10/100;
double totalBathroomArea = bathroomArea + surplus;
double tileArea = tileWidth * tileHeight;
double countOfTiles = totalBathroomArea / tileArea;

Console.WriteLine($"{countOfTiles:F0}");