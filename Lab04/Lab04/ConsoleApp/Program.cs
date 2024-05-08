using ClassLibrary.CoR;
using ClassLibrary.Mediator;
using ClassLibrary.Memento;
using ClassLibrary.Observer;
using ClassLibrary.Observer.LightHTML;
using ClassLibrary.Strategy;

//task 1
Console.WriteLine("task 1");

// Створюємо ланцюжок обробників
SupportHandler level1Handler = new Level1SupportHandler();
SupportHandler level2Handler = new Level2SupportHandler();
SupportHandler level3Handler = new Level3SupportHandler();
SupportHandler level4Handler = new Level4SupportHandler();

// Налаштовуємо ланцюжок
level1Handler.SetNextHandler(level2Handler);
level2Handler.SetNextHandler(level3Handler);
level3Handler.SetNextHandler(level4Handler);

// Симулюємо запити користувачів на рівні підтримки
int[] userRequests = { 2, 3, 1, 4 };

foreach (var request in userRequests)
{
    Console.WriteLine($"User Request: Level {request}");
    level1Handler.HandleRequest(request);
    Console.WriteLine();
}

Console.WriteLine();

//task 2
Console.WriteLine("task 2");

var commandCentre = new CommandCentre();

// Створення злітно-посадкових смуг
var runway1 = new Runway();
var runway2 = new Runway();

// Реєстрація злітно-посадкових смуг у посереднику
commandCentre.RegisterRunway(runway1);

// Створення літаків
var aircraft1 = new Aircraft("Boeing 747", commandCentre);

// Реєстрація літаків у посереднику
commandCentre.RegisterAircraft(aircraft1);

// Посадка та зліт літаків
aircraft1.Land();
aircraft1.TakeOff();

Console.WriteLine();

//task 3
Console.WriteLine("task 3");

LightElementNode element = new LightElementNode("h1","Hello");

ClickEventListener clickEventListener = new ClickEventListener();
MouseoverEventListener mouseoverEventListener = new MouseoverEventListener();

element.AddEventListener(clickEventListener);
element.AddEventListener(mouseoverEventListener);

element.TriggerEvent("mouseover");
element.TriggerEvent("click");

Console.WriteLine();

//task 4
Console.WriteLine("task 4");

// Створення зображення зі стратегією завантаження з файлової системи
Image image = new Image(new FilesystemImageLoading());
image.Load("file://path/to/image.jpg");

// Зміна стратегії на завантаження зображення з мережі
image.SetLoadingStrategy(new NetworkImageLoading());
image.Load("http://example.com/image.jpg");

Console.WriteLine();

//task 5
Console.WriteLine("task 5");

// Створення редактора з початним текстом
TextEditor editor = new TextEditor("Початний текст.");

// Збереження початного стану
TextDocumentMemento initialMemento = editor.Save();

// Редагування тексту
editor.Edit("Змінений текст.");

// Збереження зміненого стану
TextDocumentMemento changedMemento = editor.Save();

// Відновлення до початного стану
editor.Undo(initialMemento);

Console.WriteLine("Початний стан документа: " + editor);

// Відновлення до зміненого стану
editor.Undo(changedMemento);

Console.WriteLine("Змінений стан документа: " + editor);