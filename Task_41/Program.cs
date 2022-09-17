Console.Write($"Введите число M, которому соответствует количество чисел: "); //условие задачи
int n = Convert.ToInt32(Console.ReadLine()); // задаём переменную n и присваиваем ей следующие значения
int[] massiveNumbers = new int[n]; // задаём массив

void InputNumbers(int n){ //метод поска числа
for (int i = 0; i < n; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Comparison(int[] massiveNumbers) //метод создания массива
{
  int count = 0;
  for (int i = 0; i < massiveNumbers.Length; i++)
  {
    if(massiveNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(n);

Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} "); // конечный результат