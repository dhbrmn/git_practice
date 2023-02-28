### App Interfaces

- [x] Get comfortable with the two classes `TodoList` and `PasswordManager`. You can see in **Program.cs** an instance of each class constructed.

* In **TodoList.cs**, read the definition of the constructor and Add() method
* In **PasswordManager.cs**, read the definition of the constructor


- [x] Every app must have a display feature. In **IDisplayable.cs**, define an empty `IDisplayable` interface.


- [x] Within `IDisplayable` declare one method that:

* is named `Display()`
* returns nothing

- [x] In **TodoList.cs**, declare that the class implements the `IDisplayable` interface.

- [x] The class must actually implement the interface by defining a `Display()` method.

Define a method that:

* satisfies the interface requirements
* uses `Console.WriteLine()` to write each to-do item to the console

- [x] Repeat the process for `PasswordManager`.

Declare that it implements `IDisplayable`.

- [x] Define a `Display()` method that:

* satisfies the interface requirements
* uses `Console.WriteLine()` to print the actual password if `Hidden` is `false`. If `Hidden` is `true`, print asterisks `*`

* Make sure that both classes are printable.

In **Program.cs**, call `Display()` on `tdl` and `pm`. Run the program with:

> dotnet run

You should see both objects printed to the console.

- [x] Every app must have a reset feature. In **IResetable.cs**, define an `IResetable` interface with one method:

* name it `Reset()`
* it should return nothing

- [x] In **TodoList.cs**, implement the interface:

* Declare that it implements `IResetable`
* Define a `Reset()` method to satisfy the interface. It should set the `Todos` property to an empty array of length 5 and set `nextOpenIndex` to `0`.

- [x] In **PasswordManager**, implement the interface:

* Declare that it implements `IResetable`
* Define a `Reset()` method to satisfy the interface. It should set `Password` to an empty string and set `Hidden` to `false`.

- [x] In **Program.cs**, call `Reset()` and `Display()` with `tdl` and `pm`. In other words, both objects should display, then reset, then display again.

Run the program with:

> dotnet run

- [x] Well done! The Computron is a better computer thanks to your work. If you’d like extra practice, try these optional challenges:

Add a get-only property to `IDisplayable` called `HeaderSymbol`. This should be used in `Display()` as a header. For example, if the header symbol is -, then the apps should be displayed as:

> Todos
> \--------
> Eat
> Sleep
> Code
> 
> Password
> \-----------
> \***

If you add more than five to-dos to the `TodoList`, it throws an error! Extend the `Add()` method so that it doesn’t add any more than five items to the `Todos` array.

Currently a blank line is printed for each empty index in `Todos`. Change `Display()` in `TodoList` so that it prints `[]` instead of a blank line. You’ll need to use the static method `String.IsNullOrEmpty()`.

Add a method `ChangePassword()` to `PasswordManager`. It should:

* have two `string` parameters
* if the first argument matches the existing `Password`, reset the `Password` to the second argument
* return `true` if the password change was a success (the first argument matched the old password), and `false` otherwise

Extend the `Password` property in `PasswordManager`:

* Change the `set` method so that it requires the password to be at least eight characters in length

***Cheers!***
