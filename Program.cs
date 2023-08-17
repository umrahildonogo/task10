//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1


Console.WriteLine ("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int secondDigit = seconddigit (number);
Console.WriteLine(secondDigit);

int seconddigit (int num)
{
    int firstdigit = num / 100;
    int seconddigit = num / 10;
    int result = (num - num / 100 * 100 - num % 10) / 10; //я не знаю, как оно сработало, но оно сработало
    return result;
}