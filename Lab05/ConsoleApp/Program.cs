using ClassLibrary.Iterator;
using ClassLibrary.Command;
using ClassLibrary.LightHTML;
using ClassLibrary.State;
using ClassLibrary.Visitor;

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

// Створення HTML документу з використанням ітератора в глибину
HTMLDocument documentDepthFirst = new HTMLDocument(body);

foreach (var node in documentDepthFirst)
{
    Console.WriteLine(node.OuterHTML);
}

// Створення HTML документу з використанням ітератора в ширину
HTMLDocument documentBreadthFirst = new HTMLDocument(body, true);

foreach (var node in documentBreadthFirst)
{
    Console.WriteLine(node.OuterHTML);
}


// Створення контексту
ViewModeContext viewModeContext = new ViewModeContext();

// Встановлення режиму відображення дерева DOM
viewModeContext.SetState(new TreeViewModeState());
viewModeContext.Render(document);

// Встановлення режиму відображення коду HTML
viewModeContext.SetState(new CodeViewModeState());
viewModeContext.Render(document);

// Тестування шаблонного методу
body.ExecuteLifecycle();
div.ExecuteLifecycle();
textNode.ExecuteLifecycle();

// тестування Visitor 
ElementPresenceVisitor visitor = new ElementPresenceVisitor("div");
body.Accept(visitor);

if (visitor.IsElementPresent())
{
    Console.WriteLine("Div element is present in the DOM tree.");
}
else
{
    Console.WriteLine("Div element is not present in the DOM tree.");
}