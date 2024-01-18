double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine());

double addingResult = firstNumber + secondNumber;
double substractionResult = firstNumber - secondNumber;
double multiplicationResult = firstNumber * secondNumber;
double divisionResult = firstNumber / secondNumber;

Console.WriteLine($"{firstNumber:F2} + {secondNumber:F2} = {addingResult:F2}");
Console.WriteLine($"{firstNumber:F2} - {secondNumber:F2} = {substractionResult:F2}");
Console.WriteLine($"{firstNumber:F2} * {secondNumber:F2} = {multiplicationResult:F2}");
Console.WriteLine($"{firstNumber:F2} / {secondNumber:F2} = {divisionResult:F2}");