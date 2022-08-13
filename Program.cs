// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 5; b = 25 -> да 
//a = 2 b = 10 -> нет 
//a = 9; b = -3 -> нет 
//a = -3 b = 9 -> да
//2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//	3 -> Среда 
//5 -> Пятница

int Prompt(string message)
{
    System.Console.Write(message);         // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue);     // Преобразует строку в целое число
    return result;                         // Возвращает результат 
}

int value1;
int value2;
value1 = Prompt("Введите первое число >");
value2 = Prompt("Введите второе число >");
if (value1 * value1 == value2){
    System.Console.WriteLine("Да");
}else{
   System.Console.WriteLine("Нет");
}


int daynum;
daynum = Prompt("Введите число дня недели: ");
if (daynum == 1){
    System.Console.WriteLine("Понеделшьник");
}if (daynum == 2){
    System.Console.WriteLine("Вторник");
}if (daynum == 3){
    System.Console.WriteLine("Среда");
}if (daynum == 4){
    System.Console.WriteLine("Четверг");
}if (daynum == 5){
    System.Console.WriteLine("Пятница");
}if (daynum == 6){
    System.Console.WriteLine("Суббота");
}if (daynum == 7){
    System.Console.WriteLine("Воскресение");
}else{
    System.Console.WriteLine("Такого дня недели не существует!");
}

int N;
N = Prompt("Введите число N ");
for (int i = -N; i <= N; i++)
{
Console.WriteLine(i);
}