﻿double k1 = Input1("k1"); // ввод значения для переменной k1, для первой прямой
double b1 = Input1("b1"); // ввод значения для переменной b1, для первой прямой
double k2 = Input2("k2"); // ввод значения для переменной k2, для второй прямой
double b2 = Input2("b2"); // ввод значения для переменной b2, для второй прямой
if (k1 == k2) // если переменная k1=k2,
{
    Console.WriteLine("Прямые параллельны"); // то прямые параллельны
}
else // иначе
{
     double x = ResultX(b2,b1,k1,k2); // результат для оси ОХ   
     double y = ResultY(b2,b1,k1,k2); // результат для оси ОУ
     Console.WriteLine($"Координаты пересечения прямых ({x};{y})"); // ответ на решение задачи
}

double ResultX(double a2,double a1, double b1,double b2) // метод поиска результата для оси ОХ
{
    return (a2-a1)/(b1-b2);
}
double ResultY(double a2,double a1, double b1,double b2) // метод поиска результата для оси ОУ
{
    return b2*((a2-a1)/(b1-b2)) +a2;
}
double Input1(string k1) // метод ввода коэффициентов для функции первой прямой
{
    Console.Write($"Введите коэффициенты для функции первой прямой {k1} ");
    return Convert.ToDouble(Console.ReadLine());   
}
double Input2(string k2) // метод ввода коэффициентов для функции второй прямой
{
    Console.Write($"Введите коэффициенты для функции второй прямой {k2} ");
    return Convert.ToDouble(Console.ReadLine()); 
}