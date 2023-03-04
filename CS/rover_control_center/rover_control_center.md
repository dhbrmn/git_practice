
### Rover Control Center

- [x] There are two Moon rovers and one Mars rover defined in **Program.cs**. (We can ignore the satellite object for now.) To manage them all at once, we’ll need to put them in an `array`.

Store the three rovers in an `array` of type `Rover[]`, their shared base class.

- [x] You’ll regularly need to direct the rovers to send info, explore their surroundings, and collect samples.

Below `Main()`, write a `static` method `DirectAll()` that takes one argument of type `Rover[]`. The method should call the below three methods for each element and print out the returned strings.

    GetInfo()
    Explore()
    Collect()

- [x] Back in `Main()`, call the `DirectAll()` method using the array as the argument.

Make sure that the right text is printed to the screen!

- [x] The leaders of SPACE have promoted you to Director of Probes! You are now in charge of all space probes, not just rovers.

To manage all space probes, which includes the three rovers and one satellite, put them in an array.

At the moment, the only inherited class they share is `Object`.

- [x] To test that we built the `Object[]` array correctly, print the results of `GetType()` for each object in the array.

For clarity, use string interpolation to print something like "Tracking a [TYPE]…" for each one.

- [x] As the SPACE Director of Probes, the `Object` array isn’t very useful because you can’t direct the probes to keep collecting and exploring!

We’ll need to create another shared class or interface. We have two options:

* Create a superclass `Probe` that `Rover` and `Satellite` inherit from
 *   Create an interface `IDirectable` that `Rover` and `Satellite` implement

The first option would involve a lot of changes to `Rover` and `Satellite`, like moving methods out of `Rover` and `Satellite` and into `Probe` or making those methods override.

It will be easier to just create a shared interface, which doesn’t require writing or changing any methods.

In **IDirectable.cs**, define an interface `IDirectable` with three methods:

    string GetInfo()
    string Explore()
    string Collect()

- [x] Edit **Rover.cs** and **Satellite.cs** so that they explicitly implement `IDirectable`.

- [x] With a shared interface, we can manage `Rover` and `Satellite` types in the same array.

Back in **Program.cs**, create an `array` of type `IDirectable[]` containing all the probes (three rovers and one satellite).

- [x] Update the `DirectAll()` method so that it now accepts one argument of type `IDirectable[]`.

Try calling it with the newly created `array`!

- [x] Well done! If you’d like to keep practicing, try these extensions:

* In Task 6, we decided to create a shared interface over a shared superclass. To prove that making a shared superclass really is more work, try it yourself: Remove the interface and create a shared `Probe` superclass. Instead of an `array` of type `IDirectable[]`, make an `array` of type `Probe[]`.
* Try to answer this question on your own: in task 3, you called the `Explore()` and `Collect()` methods on each rover. Even though you used `Rover` references, the specific rover type (`MoonRover` or `MarsRover`) was printed. How is that possible?

>The answer is: The objects were defined with the <code>MoonRover</code> and <code>MarsRover</code> class. Even if we put them in an array that is defined by the <code>Rover</code> superclass the <code>Explore()</code> and <code>Collect()</code> methods will output the override definitions from each respective subclass.

***Cheers!***

