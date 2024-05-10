// Створення HTML документу
using ClassLibrary.Composite;

LightElementNode body = new LightElementNode("body", "normal", "closing", new List<string>());
LightElementNode div = new LightElementNode("div", "normal", "closing", new List<string>());
LightTextNode textNode = new LightTextNode("Hello, World!");

body.AddChild(div);
div.AddChild(textNode);

HTMLDocument document = new HTMLDocument(body);

// Створення одержувача
ModifyHTMLReceiver receiver = new ModifyHTMLReceiver(document);

// Створення команди для додавання елемента
LightElementNode paragraph = new LightElementNode("p", "normal", "closing", new List<string>());
AddElementCommand addCommand = new AddElementCommand(div, paragraph);

// Виклик команди через викликача
CommandInvoker invoker = new CommandInvoker();
invoker.StoreAndExecute(addCommand);

// Вивід зміненого HTML
foreach (var node in document)
{
    Console.WriteLine(node.OuterHTML);
}
