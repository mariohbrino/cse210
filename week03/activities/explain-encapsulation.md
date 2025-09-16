# W03 Assignment: Explain Encapsulation

## Overview

Encapsulation is a principal that describe how the abstraction handles visibility
within properties and methods on the class. With this principal it allows to
define the behavior of the object and how the properties and methods can be
accessible by internally and externally. That means properties and methods can be
visible and allow to be modified by other entities when appropriated for the use
case that the application programming interface (API) was designed for.

Encapsulation is beneficial to define how the appliation must interact internally
and externally, with a proper abstraction definition it can reduce the need of
changes on the class and on other entities that use it's properties or methods.

An example of encapsulation is when you need the object to handle data processing
to ensure consistence on the state of the object, that means the object is
responsible to manage it's own state and it must define methods that controls how
the data must be modified or retrieved during it's lifecycle. With that in mind
the class would have private properties that are only modified and retrieved within
the class, this require to define getters and setters methods to manipulate the data
accoring with the expected behavior as you may see the abstraction class below.

A game application would protect how the information of the players is stored and
retrieved to ensure consistence and how other entities can interact with each other,
as you may see the player class has properties that can be consider sensitive and its
responsable manage the first name and last name as well how to display the players name.

class Player
{
    private string _firstName;
    private string _lastName;

    public Player(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    public string GetPlayerName()
    {
        return $"{_lastName}, {_firstName}";
    }
}

class Game
{
    private Player _playerOne;
    private Player _playerTwo;

    public Game(Player playerOne, Player playerTwo)
    {
        _playerOne = playerOne;
        _playerTwo = playerTwo;
    }

    public void Play()
    {
        Console.WriteLine($"{_playerOne.GetPlayerName()} x {_playerTwo.GetPlayerName()}");
    }
}
