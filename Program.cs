// Индивидуальные задания 2. Вариант 4

// 1 задание

//SphereSegment fig1 = new();
//fig1.PrintArea();
//fig1.PrintVolume();
//Console.WriteLine();
//SphereSegment fig2 = new(2, 5);
//fig2.PrintArea();
//fig2.PrintVolume();

//Console.WriteLine("\nНадпись о фигуре с наибольшим объемом");
//if (fig1.Volume() > fig2.Volume()) fig1.PrintText();
//else if (fig1.Volume() == fig2.Volume())
//{
//    Console.WriteLine("Объемы равны.");
//    fig1.PrintText();
//    fig2.PrintText();
//}
//else fig2.PrintText();

//if (Math.Abs(fig1.Area() - 100) < Math.Abs(fig2.Area() - 100)) Console.WriteLine("Площадь первой фигуры ближе к 100");
//else if (Math.Abs(fig1.Area() - 100) > Math.Abs(fig2.Area() - 100)) Console.WriteLine("Площадь второй фигуры ближе к 100");
//else Console.WriteLine("Площади равны");


// 2 задание

int n;
while (true)
{
    Console.WriteLine("Введите количество фигур: ");
    n = Convert.ToInt32(Console.ReadLine());
    if (n > 0) break;
    else Console.WriteLine("Число должно быть положительным");
}
SphereSegment[] arr = new SphereSegment[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"{i + 1} фигура");
    arr[i] = new SphereSegment();
}

int maxlen = arr[0].Text.Length;
for (int i = 1; i < n; i++) { if (arr[i].Text.Length > maxlen) maxlen = arr[i].Text.Length; }
Console.WriteLine("Данные фигур(ы) с самой длинной надписью");
for (int i = 0; i < n; i++) { if (arr[i].Text.Length == maxlen) arr[i].PrintAll(); }

Console.WriteLine("Новая фигура");
SphereSegment newfig = new(2 * arr[^1].Radius, 2 * arr[^1].Height);
newfig.PrintAll();

double minarea = arr[0].Area();
int count_more15 = 0;
double sum_vol = 0;
Console.WriteLine("Площади поверхности и обЪемы всех фигур в массиве ");
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"{i + 1} фигура");
    arr[i].PrintArea();
    arr[i].PrintVolume();
    if (arr[i].Area() < minarea) minarea = arr[i].Area();
    if (arr[i].Area() > 15) count_more15++;
    sum_vol += arr[i].Volume();
}

Console.WriteLine("Подписи фигур(ы) с наименьшей площадью");
for (int i = 0; i < n; i++)
{
    if (arr[i].Area() == minarea)
    {
        arr[i].Text = "MIN" + arr[i].Text;
        arr[i].PrintText();
    }
}

Console.WriteLine($"\nКоличество фигур с площадью больше 15 = {count_more15}");
Console.WriteLine("Сумма всех объемов в массиве = " + sum_vol);

// не использовать ввод в конструкторах и в свойствах класса
// вместо сравнения c переменной запоминать индексы