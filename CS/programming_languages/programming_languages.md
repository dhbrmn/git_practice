### Programming Languages

- [x] Let’s start by printing all of the languages: print each item in  `languages`  by calling its  `Prettify()`  method.

- [x] Write a query that returns a string for each language. It should include the year, name, and chief developer of each language.

Print each one to the console.

- [x] When was C# first released?

Find the language(s) with the name  `"C#"`. Use the  `Prettify()`  method to print the results to the console.

- [x] Microsoft invented a bunch of languages, not just C#!

Find all of the languages which have  `"Microsoft"`  included in their  `ChiefDeveloper`  property.

- [x] A few early languages laid the foundation for many of the advanced languages we use now. One of those languages is Lisp, which looks like this:

```
;;; Here's a comment  
(print "Hello world")  
(+ 3 4)  
(let x 29)
```

Find all of the languages that descend from Lisp.

- [x] Programmers really like to call their languages “scripts”.

Find all of the language names that contain the word  `"Script"`  (capital S). Make sure the query only selects the name of each language.

- [x] How many languages are included in the  `languages`  list?

- [x] How many languages were launched between 1995 and 2005?

- [x] Print a string for each of those near-millennium languages.

In your query add a  `Select`  operation that returns a string of this format for each element:

```
NAME was invented in YEAR
```

- [x] You might have used  `foreach`  loops to print every  `Language`  in this project. Write a method  `PrettyPrintAll()`  that handles that for us. It should:

-   return nothing
-   accept an argument of type  `IEnumerable<Language>`
-   pretty print every language in the argument

- [x] You might have also used  `foreach`  loops to print every query result in this project. Write a method  `PrintAll()`  that handles that for us. It should:

-   return nothing
-   accept an argument of type  `IEnumerable<Object>`
-   prints every object in the argument

- [x] Well done! You’ve completed the main project. If you’d like to dive deeper into LINQ, try these optional challenges:

* Take a look at the first query in  **Program.cs**. It uses the  `File`  class and the  `ReadAllLines()`  method, then it uses three LINQ methods:  `Skip()`,  `Select()`,  `ToList()`. Try to explain what each method call does, in simple terms. Use the  [.NET API Browser](https://docs.microsoft.com/en-us/dotnet/api/?view=netcore-3.1)  to learn more about any unfamiliar methods.

>Skip() skips a specified of elements and returns the rest.
>Select() changes the form of an element in a sequence
>ToList() creates a new List\<T> from a source

* Your queries are currently sorted by year since the  `languages`  list was sorted by year. Try sorting a query alphabetically (on the name of each language) using  [the  `OrderBy()`  method](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.orderby).

* Find the oldest language in the list using  [the  `Min()`  method](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.min).