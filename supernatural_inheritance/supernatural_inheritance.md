### Supernatural Inheritance

- [x] We�ll start by defining the  `Storm`  class.

In  **Storm.cs**, create an empty class named  `Storm`.

- [x] Define three automatic properties. Each one should have a public getter and private setter:

-   `string Essence`  - the type of storm, like wind or rain
-   `bool IsStrong`- true if the storm is strong
-   `string Caster`  - the title of the magician casting the storm

- [x] Define a constructor that takes three arguments, one for each property.

In the body of the constructor, use those arguments to set the property values.

- [x] We�ll need some way to print a  `Storm`  object to the console.

Define a public  `Announce()`  method that returns a string. The string should use all three properties. For example, if a weak wind storm was cast by Zul�rajas, the string would be:

		Zul'rajas cast a weak wind storm!

- [x] Test your class! In  **Program.cs**  in  `Main()`, construct a new  `Storm`. It should:

-   have  `"wind"`  essence
-   NOT be strong
-   be cast by  `"Zul'rajas"`

After constructing the new object, call  `Announce()`  and print the result to the console.

- [x] Next, we�ll define the  `Pupil`  class.

In  **Pupil.cs**, define a class named  `Pupil`  with these two members:

-   a string  `Title`, with public getter and private setter. This represents the name of the pupil
-   a constructor with one argument, that sets the  `Title`  property

- [x] Give the Pupil its single spell: a  `CastWindStorm()`  method. It should be public with return type  `Storm`. In the body of the method, construct a new  `Storm`  object and return it.

Remember that this is a weak wind storm cast by the pupil.

- [x] Test your class! In  **Program.cs**, construct a new  `Pupil`  named Mezil-kree.

After constructing a new object, call  `CastWindStorm()`  and store the result in a variable. Use  `Announce()`  to check that it is a weak wind storm.

- [x] The next rank, Mage, also has a  `Title`  property and  `CastWindStorm()`  method. It also has a new  `CastRainStorm()`  method. Instead of writing the first two members again, we can inherit them from  `Pupil`.

In  **Mage.cs**, define an empty  `Mage`  class that inherits from  `Pupil`.

- [x] Add a  `Mage`  constructor with one  `string`  argument. It should call the  `base`  constructor with that same argument.

- [x] Give the Mage a new spell:  `CastRainStorm()`. It should be public with return type  `Storm`. In the body of the method, construct a new  `Storm`  object and return it.

Remember that this is a weak rain storm cast by the mage.

- [x] Test your class! In  **Program.cs**, construct a new  `Mage`  named Gul�dan.

After constructing a new object, call  `CastRainStorm()`  and store the result in a variable. Use  `Announce()`  to check that it is a weak rain storm.

- [x] The next rank, Archmage, also has a  `Title`  property and  `CastWindStorm()`  method. On top of that, it overrides  `CastRainStorm()`  and has a new  `CastLightningStorm()`  method. Instead of writing the first two members again, we can inherit them from  `Mage`.

In  **Archmage.cs**, define an empty  `Archmage`  class that inherits from  `Mage`.

- [x] Add an  `Archmage`  constructor with one  `string`  argument. It should call the  `base`  constructor with that same argument.

- [x] Override the  `CastRainStorm()`  spell. Just like the one in  `Mage`, it should be public with return type  `Storm`. In the body of the method, construct a new  `Storm`  object and return it.

This time it is a strong rain storm cast by the archmage.

You may see an error here: we�ll fix it in the next step.

- [x] Since the  `CastRainStorm()`  method is overridden, it must be marked  `virtual`  in  `Mage`. Do that now.

- [x] Add one more spell in  **Archmage.cs**:  `CastLightningStorm()`. It should be public with return type  `Storm`. In the body of the method, construct a new  `Storm`  object and return it.

This time it is a strong lightning storm cast by the archmage.

- [x] Test your class! In  **Program.cs**, construct a new  `Archmage`  named Nielas Aran.

After constructing a new object, call  `CastRainStorm()`  and  `CastLightningStorm()`  and store the results in variables. Use  `Announce()`  to make sure they are correct!

- [ ] Well done! You�ve created four new classes. Three of them are in an inheritance hierarchy:  `Archmage`  inherits from  `Mage`, which inherits from  `Pupil`. Each class has at least one method that uses the fourth class,  `Storm`.

If you�d like more practice, try these optional challenges:

-  In  **Program.cs**, store the  `Storm`  objects in an array instead of separate variables.
-  Add a  `string Origin`  property and a new constructor to the  `Pupil`  class. The constructor should have two parameters, one for  `Title`  and one for  `Origin`. Add a similar constructor to  `Mage`  and  `Archmage`. In other words, you should be able to run this code in  **Program.cs**:

		Pupil  p = new  Pupil("Mezil-kree", "Icecrown");  
		Mage  m = new  Mage("Gul'dan", "Draenor");  
		Archmage  a = new  Archmage("Nielas Aran", "Stormwind");

- Define an  `abstract`  class  `Spell`  with  `Essence`,  `IsStrong`, and  `Caster`  properties and an abstract  `Announce()`  method. Make  `Storm`  inherit from  `Spell`. A  **Spell.cs**  file is included in the workspace � find it by clicking the folder icon at the top of the text editor.

***Cheers!***
