int totalPages = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int daysToFinishTheBook = int.Parse(Console.ReadLine());

int totalReadingTime = totalPages / pagesPerHour;
int requieredHoursPerDay = totalReadingTime / pagesPerHour;
int totalNumberOfHours = totalReadingTime / daysToFinishTheBook;

Console.WriteLine(totalNumberOfHours);
