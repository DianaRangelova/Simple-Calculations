int PackagesOfPens = int.Parse(Console.ReadLine());
int PaketsOfMarkers = int.Parse(Console.ReadLine());
int BoardCleaner = int.Parse(Console.ReadLine());
int discount = int.Parse(Console.ReadLine());

double PricePackagesOfPens = PackagesOfPens * 5.80;
double PricePaketsOfMarkers = PaketsOfMarkers * 7.20;
double PriceBoardCleaner = BoardCleaner * 1.20;
double PriceOfAllMaterials = PricePackagesOfPens + PricePaketsOfMarkers + PriceBoardCleaner;
double TotalPrice = PriceOfAllMaterials - (PriceOfAllMaterials * discount / 100);

Console.WriteLine(TotalPrice);
