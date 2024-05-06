using ClassLibrary.Adapter;
using ClassLibrary.Bridge;
using ClassLibrary.Composite;
using ClassLibrary.CompositeFlyweight;
using ClassLibrary.Decorator;
using ClassLibrary.Proxy;
using System.Text;

Console.WriteLine();
//task 1
Console.WriteLine("Task 1");

// Створення об'єкта класу FileWriter
var fileWriter = new FileWriter();

// Створення адаптера для логування в файл
var fileLogger = new FileLoggerAdapter(fileWriter);

// Використання адаптера для логування в файл
fileLogger.Log("This is a log message");
fileLogger.Error("This is an error message");
fileLogger.Warn("This is a warning message");

Console.WriteLine();
//task 2
Console.WriteLine("Task 2");

// Створення базового героя
IHero warrior = new Warrior();
warrior.DisplayInfo();

// Додавання одягу до героя
warrior = new ArmorDecorator(warrior);
warrior.DisplayInfo();

// Додавання зброї до героя
warrior = new WeaponDecorator(warrior);
warrior.DisplayInfo();

Console.WriteLine();
//task 3
Console.WriteLine("Task 3");

// Рендерери
IRenderer vectorRenderer = new VectorRenderer();
IRenderer rasterRenderer = new RasterRenderer();

// Фігури
Shape circle = new Circle(vectorRenderer);
Shape square = new Square(rasterRenderer);
Shape triangle = new Triangle(vectorRenderer);

// Рендерінг
circle.Draw();    // Виведе: "Drawing Circle as vector"
square.Draw();    // Виведе: "Drawing Square as pixels"
triangle.Draw();  // Виведе: "Drawing Triangle as vector"

Console.WriteLine();
//task 4
Console.WriteLine("Task 4");

string filePath = "test.txt";

// Проксі з логуванням
ITextReader textChecker = new SmartTextChecker();
string[,] textArray = textChecker.ReadText(filePath);

// Проксі з обмеженням доступу до певних файлів
ITextReader textLocker = new SmartTextReaderLocker("test.txt");
textLocker.ReadText(filePath);


Console.WriteLine();
//task 5
Console.WriteLine("Task 5");

// Створення сторінки за допомогою LightHTML
LightElementNode body = new LightElementNode("body", "block", "closing", new List<string>());
LightElementNode header = new LightElementNode("header", "block", "closing", new List<string>());
LightElementNode h1 = new LightElementNode("h1", "block", "closing", new List<string>());
LightTextNode h1Text = new LightTextNode("Welcome to my page!");
h1.AddChild(h1Text);
header.AddChild(h1);
body.AddChild(header);

LightElementNode main = new LightElementNode("main", "block", "closing", new List<string>());
LightElementNode section = new LightElementNode("section", "block", "closing", new List<string>());
LightElementNode div = new LightElementNode("div", "block", "closing", new List<string>());
LightTextNode divText = new LightTextNode("This is a section of my page");
div.AddChild(divText);
section.AddChild(div);
main.AddChild(section);
body.AddChild(main);

LightElementNode footer = new LightElementNode("footer", "block", "closing", new List<string>());
LightElementNode p = new LightElementNode("p", "inline", "closing", new List<string>());
LightTextNode pText = new LightTextNode("© 2024 My Page");
p.AddChild(pText);
footer.AddChild(p);
body.AddChild(footer);

// Виведення HTML сторінки
Console.WriteLine(body.OuterHTML);


Console.WriteLine();
//task 6
Console.WriteLine("Task 6");


string filePath2 = "book.txt";
if (!File.Exists(filePath2))
{
    Console.WriteLine("File not found.");
    return;
}

// Зчитуємо вміст файлу
string[] lines = File.ReadAllLines(filePath2);

LightHTMLFactory factory = new LightHTMLFactory();

List<LightNode> nodes = new List<LightNode>();

for (int i = 0; i < lines.Length; i++)
{
    bool isFirstLine = (i == 0);
    LightNode node = factory.GetNode(lines[i], isFirstLine);
    if (node != null)
    {
        nodes.Add(node);
    }
}

// Виведення HTML сторінки
StringBuilder htmlBuilder = new StringBuilder();
foreach (var node in nodes)
{
    htmlBuilder.AppendLine(node.ToHTML());
}
string html = htmlBuilder.ToString();

Console.WriteLine(html);

// Підрахунок обсягу займаної пам'яті
int memoryUsage = html.Length * sizeof(char);
Console.WriteLine($"Memory Usage: {memoryUsage} bytes");