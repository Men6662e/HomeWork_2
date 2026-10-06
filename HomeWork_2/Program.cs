Console.WriteLine("--- Калькулятор Индекса Массы Тела (ИМТ) ---");

// Запрашиваем у пользователя вес в килограммах
Console.Write("Введите ваш вес в килограммах: ");
string? weightInput = Console.ReadLine();
// Заменяем точку на запятую, чтобы программа не вылетала при любом вводе дробного числа
string safeWeight = weightInput!.Replace(".", ",");
double weight = Convert.ToDouble(safeWeight);

// Запрашиваем у пользователя рост в метрах
Console.Write("Введите ваш рост в метрах (например, 1.75): ");
string? heightInput = Console.ReadLine();
// Делаем такую же замену точки на запятую для корректной конвертации роста
string safeHeight = heightInput!.Replace(".", ",");
double height = Convert.ToDouble(safeHeight);

// Рассчитываем ИМТ по формуле: Вес / (Рост в квадрате)
double bmi = weight / (height * height);

Console.WriteLine("\n--- Ваш результат ---");
// Выводим итоговый результат на экран с помощью интерполяции строк ($"")
Console.WriteLine($"При весе {safeWeight} кг и росте {safeHeight} м, ваш ИМТ составляет: {bmi}");
Console.WriteLine("Конец программы!");
Console.ReadLine();