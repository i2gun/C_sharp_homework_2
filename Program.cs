// Task 10
int number =  0;
while (number < 100 || number > 999) {
    Console.Write("Please, enter a three digit number: ");
    number =  Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(((number - number % 10) % 100) / 10);

// -----------------------------------------------------------------------------------------------------------
// Task 13
Console.Write("Please, enter a number: ");
int num =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num);
if (num > 99) {
    Console.WriteLine(num / 100 % 10);
} else {
    Console.WriteLine("no third digit");
}

// -----------------------------------------------------------------------------------------------------------
// Task 15
int day =  0;
while (day < 1 || day > 7) {
    Console.Write("Please, enter the number corresponding to the day of the week: ");
    day =  Convert.ToInt32(Console.ReadLine());
}
if (day > 5) {
    Console.WriteLine("Yes");
} else {
    Console.WriteLine("No");
}