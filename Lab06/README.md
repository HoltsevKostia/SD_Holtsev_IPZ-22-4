# Console Blackjack Game

This is a simple console-based Blackjack game developed in C#. The project demonstrates the use of various programming principles, design patterns, and refactoring techniques to create a clean, maintainable, and extendable codebase.

## Table of Contents

- [Getting Started](#getting-started)
- [Features](#features)
- [Usage](#usage)
- [Programming Principles](#programming-principles)
- [Design Patterns](#design-patterns)
- [Refactoring Techniques](#refactoring-techniques)

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
- [`Deck`]() handles card operations.
- `Hand` manages the player's or dealer's hands.
- `PlayerManager` deals with database operations.

### Open/Closed Principle (OCP)

The design allows for easy extension of the game's functionality without modifying existing code. For instance, new game states can be added by implementing the `IGameState` interface.

### Liskov Substitution Principle (LSP)

All derived classes can be used interchangeably with their base classes. For example, different game states like `MenuState` and `GameState` can be used interchangeably via the `IGameState` interface.

### Interface Segregation Principle (ISP)

Interfaces are designed to be small and specific to avoid forcing classes to implement methods they do not use. For example, `IObserver` and `IObservable` interfaces are focused on the observer pattern functionality.

### Dependency Inversion Principle (DIP)

High-level modules do not depend on low-level modules but on abstractions. The `GameContext` depends on the `IGameState` interface rather than concrete implementations of game states.

## Design Patterns

### Singleton

The `PlayerManager` class is implemented as a singleton to ensure a single instance handles database operations, providing a global point of access.

```csharp
// PlayerManager.cs
