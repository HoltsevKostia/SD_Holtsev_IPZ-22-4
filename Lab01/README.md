## SPR - single principle responsibility
### This principle means: 1 class = 1 task.
In my case, class [ReportingRegister](./ClassLibrary/ReportingRegister.cs) is needed for changing information about warehouse - register incoming/outcoming products. 

It could be a mistake to add method for saving this reports, we'll create another class for it.

## OCP - open-closed principle
### Your entities should be "closed" for changes, but "open" to be extended.
It's bad practice to touch already working code, as you have to test it again to make sure you didn't brake something.

My abstract class [Money](./ClassLibrary/Money.cs) has appropriate [function](./ClassLibrary/Money.cs#L24), that can be overrided in new classes.

So it will be easy to create child classes like [UAH](./ClassLibrary/UAH.cs).

## LSP - Liskov Substitution Principle
### Implemented class should extend, but not replace base class.
My class [ProductLogger](./ClassLibrary/ProductLogger.cs) has same logic as base class [Product](./ClassLibrary/Product.cs), but it also adds logs logic that can be used if needed.

## ISP - interface segregation principle
### Your entities shouldn't be related to interfaces they dont implement.
If interface has 3 funtions that should be implemented ("ultra versetile" interface), but your class don't actually need 1 of this functions - it should be used.

It's better to separate it, and then use each unique interface where it needed.

In my case i created [IGenerateReportConsole](./ClassLibrary/IGenerateReportConsole.cs) and [IGenerateReportText](./ClassLibrary/IGenerateReportText.cs) and then classes like [ReportGeneratorText](./ClassLibrary/ReportGeneratorText.cs) and [ReportGeneratorConsole](./ClassLibrary/ReportGeneratorConsole.cs) implement appropriate interface.

I guess it could be a mistake to crate 1 class ReportGenerator with 1 interface. In the future we may need saving this reports to CSV, database, ect. In this case class would be overwhelmed and would violate the principles of SOLID.

## KISS - Keep It Simple, Stupid.
### Even a simple piece of a code can be written in a complicated way. But our goal to write understandable code for other programmers.
My function [PriceDecreaser](./ClassLibrary/Product.cs#L22-L33) is simple and can be understanded easily.

## DRY - Don't Repeat Yourself
### Yeah, basically, don't repeat yourself.
You should use functions to avoid code duplication, like i did here. [Funtion](./ClassLibrary/ReportGeneratorText.cs#L11-L14) which i [used](./ClassLibrary/ReportGeneratorConsole.cs#L14) in stead of repeating myself.

## YAGNI - You Ain't Gonna Need It 
### Don't write code you wasn't asked to (my favourite rule). 
Your class requires 2 feilds, but your voice inside says "it could be nice to have a few more, class will be more useful!". But if your class need 2 fields to represent all the logic, you do only 2 and go next.

For example, fields of class [Products](./ClassLibrary/Product.cs#L11-L13), i used only most important fields to describe my class, but i could add ton of different descriptions that are not needed to represent knowledge of code principles.

