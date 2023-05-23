#pragma warning disable
class SphereSegment
{
    public string Text
    {
        get => text;
        set => text = value;
    }
    public double Radius
    {
        get { return radius; }
        private set
        {
            while (value <= 0)
            {
                Console.WriteLine("Радиус должен быть положительным.");
                value = InputRadius();
            }
            radius = value;
        }
    }
    public double Height
    {
        get { return height; }
        private set
        {
            while (value <= 0)
            {
                Console.WriteLine("Высота должна быть положительной");
                value = InputHeight();
            }
            while (value > 2 * radius)
            {
                Console.WriteLine("Высота должна быть не больше диаметра");
                Radius = InputRadius();
                value = InputHeight();
            }
            height = value;
        }
    }

    public SphereSegment()
    {
        Radius = InputRadius();
        Height = InputHeight();
        Text = InputText();
        Console.WriteLine();
    }
    public SphereSegment(double radius = 1.0, double height = 1.0, string text = "Undefined")
    {
        Radius = radius;
        Height = height;
        Text = text;
        if (text == "Undefined") Text = InputText();
    }
    public string InputText()
    {
        Console.Write("Введите надпись о фигуре: ");
        return Console.ReadLine();
    }
    public double InputRadius()
    {
        Console.Write("Введите радиус: ");
        return Math.Round(Convert.ToDouble(Console.ReadLine()));
    }
    public double InputHeight()
    {
        Console.Write("Введите высоту: ");
        return Math.Round(Convert.ToDouble(Console.ReadLine()));
    }
    public void PrintRadius() { Console.WriteLine("Радиус = " + radius); }
    public void PrintHeight() { Console.WriteLine("Высота = " + height); }
    public void PrintText() { Console.WriteLine("Надпись о фигуре: " + text); }
    public void PrintArea() { Console.WriteLine("Площадь поверхности = " + Area()); }
    public void PrintVolume() { Console.WriteLine("Объем = " + Volume()); }
    public void PrintAll()
    {
        PrintText();
        PrintRadius();
        PrintHeight();
        PrintArea();
        PrintVolume();
        Console.WriteLine();
    }

    public double Area() { return Math.Round(2 * Math.PI * radius * height + 
        Math.PI * (radius * radius - Math.Pow(radius - height, 2)), 3); }
    public double Volume() { return Math.Round(Math.PI * height * height * (radius - height / 3), 3); }

    private string text;
    private double radius, height;
}

