using ClassLibrary.Iterator;
using ClassLibrary.LightHTML;


LightElementNode body = new LightElementNode("body", "normal", "closing", new List<string>());
LightElementNode div = new LightElementNode("div", "normal", "closing", new List<string>());
LightElementNode p1 = new LightElementNode("p", "normal", "closing", new List<string>());
LightTextNode textNode = new LightTextNode("Hello, World!");

body.AddChild(div);
div.AddChild(p1);
p1.AddChild(textNode);

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


