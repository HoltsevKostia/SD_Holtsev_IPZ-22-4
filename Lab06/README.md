# Console Blackjack Game

This is a simple console-based Blackjack game developed in C#. The project demonstrates the use of various programming principles, design patterns, and refactoring techniques to create a clean, maintainable, and extendable codebase.

## Getting Started

To launch the project, install the MongoDB.Driver package in the Nuget manager for ClassLibrary.

## Features

- **Play Blackjack against a dealer**
- **Player can choose to hit or stand**
- **Win, lose, or draw based on standard Blackjack rules**
- **Optional login system to keep track of player scores**
- **High score table stored in a MongoDB database**

## Usage

When the game starts, you have the option to either play with a login system or as a guest. If you choose to log in, you can either create a new account or use an existing one. Your scores will be tracked and stored in the database. If you choose to play as a guest, your scores will not be tracked.

## Programming Principles

### Single Responsibility Principle (SRP)

Each class in the project has a single responsibility. For example:
- [`Deck`](/Lab06/ClassLibrary/CardDeck/Deck.cs) handles card operations.
- [`Hand`](/Lab06/ClassLibrary/PlayerHand/Hand.cs) manages the player's or dealer's hands.
- [`PlayerManager`](/Lab06/ClassLibrary/Players/PlayerManager.cs) deals with database operations.

### Open/Closed Principle (OCP)

The design allows for easy extension of the game's functionality without modifying existing code. For instance, new game states can be added by implementing the [`IGameState`](/Lab06/ClassLibrary/GameStates/IGameState.cs) interface.

### Liskov Substitution Principle (LSP)

All derived classes can be used interchangeably with their base classes. For example, different game states like [`MainMenuState`](/Lab06/ClassLibrary/GameStates/MainMenuState.cs) and [`PlayGameState`](/Lab06/ClassLibrary/GameStates/PlayGameState.cs) can be used interchangeably via the [`IGameState`](/Lab06/ClassLibrary/GameStates/IGameState.cs) interface.

### Interface Segregation Principle (ISP)

Interfaces are designed to be small and specific to avoid forcing classes to implement methods they do not use. For example, [`IObserver`](/Lab06/ClassLibrary/Observer/IObserver.cs) and [`IObservable`](/Lab06/ClassLibrary/Observer/IObservable.cs) interfaces are focused on the observer pattern functionality.

### Dependency Inversion Principle (DIP)

High-level modules do not depend on low-level modules but on abstractions. The [`GameContext`](/Lab06/ClassLibrary/GameStates/GameContext.cs) depends on the [`IGameState`](/Lab06/ClassLibrary/GameStates/IGameState.cs) interface rather than concrete implementations of game states.

## Design Patterns

### Singleton

The [`MongoConnection`](/Lab06/ClassLibrary/MongoConnection.cs) class is implemented as a singleton to ensure a single instance handles database operations, providing a global point of access.

### Template Method

The [`BlackjackGame`](/Lab06/ClassLibrary/GameTemplate/BlackjackGame.cs) class defines the skeleton of the game process using the template method pattern. Subclasses like [`ConsoleBlackjackGame`](/Lab06/ClassLibrary/GameTemplate/ConsoleBlackjackGame.cs) override specific steps without changing the overall algorithm.

### State

The state pattern is used to manage different states of the game (e.g., menu, gameplay, high score display). The [`GameContext`](/Lab06/ClassLibrary/GameStates/GameContext.cs) class changes its behavior based on the current state.

### Observer

The observer pattern is used to monitor the game state, such as checking for a blackjack or a bust. The [`Hand`](/Lab06/ClassLibrary/PlayerHand/Hand.cs) class notifies observers about changes in the hand's state. Other connected classes to observer implementation - [Observer](/Lab06/ClassLibrary/Observer)

## Refactoring Techniques

### Extract Method

Complex methods were broken down into smaller, more manageable methods. For example, the [`DetermineWinner`](/Lab06/ClassLibrary/GameTemplate/ConsoleBlackjackGame.cs#L80-L116) method was refactored to separate the logic for updating the player score.

### Encapsulate Collection

The [`Hand`](/Lab06/ClassLibrary/PlayerHand/Hand.cs) class encapsulates the collection of cards, providing methods to add cards and calculate the score, ensuring the internal state is not exposed directly.

### Other usefull techniques that was/can be used :)

- Extract variable
- Inline Temp
- Remove Assignments to Parameters
- Substitution algorithm
- Extract Class
- Pull Up Constructor Body
- Remove Parameter
- Hide Method
- Decompose Conditional
- Consolidate Duplicate Conditional Fragments
