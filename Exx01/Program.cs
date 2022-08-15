// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.


int Prompt(string messege)
{
    Console.Write(messege);           //Ввыводит сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат
}

int number = Prompt("Введите трехзначное число ");
if (number >= 100 && number < 1000)
{
    int result = number / 10 % 10;
    Console.Write(result);
}
else
{
    Console.Write("Число не трехзначное! ");
}
