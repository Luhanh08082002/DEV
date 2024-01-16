using OPP_2;
class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("Buddy", "Spaniel");
        Cat cat = new Cat("Whiskers");
        Duck duck = new Duck("Daffy");

        Console.WriteLine(dog.GetInfo());
        Console.WriteLine("Sound: " + dog.MakeSound());

        Console.WriteLine(cat.GetInfo());
        Console.WriteLine("Sound: " + cat.MakeSound());
        cat.Climb("a tree");

        Console.WriteLine(duck.GetInfo());
        Console.WriteLine("Sound: " + duck.MakeSound());
        duck.Swim("a pond");
    }
}
/*class Program
{
    static void Main(string[] args)
    {
        Shape line = new Line(0, 0, 10, 10);
        Shape circle = new Circle(5, 5, 3);
        Shape rectangle = new Rectangle(2, 2, 8, 6);
        Shape polyline = new PolyLine(0, 0, 2, 2, 6, 4, 10, 8);

        line.Show();
        circle.Show();
        rectangle.Show();
        polyline.Show();

        Console.WriteLine(line.ToString());
        Console.WriteLine(circle.ToString());
        Console.WriteLine(rectangle.ToString());
        Console.WriteLine(polyline.ToString());
    }
}*/