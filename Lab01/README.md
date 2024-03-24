## SPR - single principle responsibility
### This principle means: 1 class = 1 task.
In my case, class [ReportingRegister](Lab01/ClassLibrary/ReportingRegister.cs) is needed for changing information about warehouse - register incoming/outcoming products. 

It could be a mistake to add method for saving this reports, we'll create another class for it.

## OCP - open-closed principle
### Your entities should be "closed" for changes, but "open" to be extended.
It's bad practice to touch already working code, as you have to test it again to make sure you didn't brake something.

My abstract class [Money](Lab01/ClassLibrary/Money.cs) has appropriate [function](Lab01/ClassLibrary/Money.cs#L24), that can be overrided in new classes.

So it will be easy to create child classes like [UAH](Lab01/ClassLibrary/UAH.cs).

## LSP - Liskov Substitution Principle
### Implemented class should extend, but not replace base class.
My class [ProductLogger](Lab01/ClassLibrary/ProductLogger.cs) has same logic as base class [Product](Lab01/ClassLibrary/Product.cs), but it also adds logs logic that can be used if needed.

## ISP - interface segregation principle
### Your entities shouldn't be related to interfaces they dont implement.
If interface has 3 funtions that should be implemented ("ultra versetile" interface), but your class don't actually need 1 of this functions - it should be used.

It's better to separate it, and then use each unique interface where it needed.
