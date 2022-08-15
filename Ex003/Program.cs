// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Prompt(string messege)
{
    Console.Write(messege);           //Ввыводит сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат
}

int value = Prompt("Введите число: ");
if (value > 99)
{
    while (value > 100)
    {
        value = value / 10;
    }
    int result = value % 10;
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Нет третьей цифры ");
}