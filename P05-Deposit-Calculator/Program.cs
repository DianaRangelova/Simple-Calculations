double deposit = double.Parse(Console.ReadLine());
int months = int.Parse(Console.ReadLine());
double interest  = double.Parse(Console.ReadLine());

double totalinterest = deposit * interest / 100;
double monthlyInterest = totalinterest / 12;
double totalAmount = deposit + monthlyInterest * months;

Console.WriteLine(totalAmount);