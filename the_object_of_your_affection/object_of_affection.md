### True or False

The Object of Your Affection is a practice task in the Codecademy's _Learn C#_ course. The main goal of this practice is for the user to get more comfortable with navigating custom classes.

Tasks:

- [x] Tab over to ***Profile.cs*** and set up the skeleton of the `Profile` class.
- [x] Add the following fields to `Profile`:

* a `string` `name`
* an `int` `age`
* a `string` `city`
* a `string` `country`
* a `string` `pronouns`
* a `string[]` `hobbies`

- [x] Tab over to ***Program.cs***. In `Main()`:

* Instantiate a new `Profile` object called `sam`. (Your friend Sam is looking for love.)
* Try to give `sam` a `name`: "Sam Drakkila".
* Then try to run the code using `dotnet run`.

- [x] Make the access level explicit: Add `private` to all the fields you created in `Profile`.
- [x] Below the fields, declare a constructor for `Profile` that allows you to set:

* `name`
* `age`
* `city`
* `country`
* `pronouns` (give this a default value of "they/them" just in case it’s ever left blank)

Define the constructor in ***Profile.cs*** and set the fields to the values passed in. Make sure to also set `hobbies` to an empty array of strings.

- [x] If you assigned `sam` a `name` in ***Program.cs*** before, remove that line. Where `sam` is constructed, pass in the following information:

* a `name` of `"Sam Drakkila"`
* an `age` of `30`
* `city` and `country` of `"New York"` and `"USA"`
* `pronouns` of `"he/him"`

Then run your code.

- [x] In ***Profile.cs*** define a `ViewProfile()` method under the constructor. It should have:

* public access
* a return type of `string`
* no parameters

It should return a string containing all of the profile’s information.

- [x] In `Main()`, test out the new method on `sam` and print out the result.
- [x] In ***Profile.cs***, declare a new method `SetHobbies()` with:

* public access
* no return value
* a `string[]` parameter named `hobbies`

In the method body, set the field `this.hobbies` equal to the `hobbies` argument.

- [x] Go back into `ViewProfile()` and modify the method so that you display a profile’s hobbies.
- [x] Above where you print `sam`‘s profile information out, add some hobbies to `sam`:

* “listening to audiobooks and podcasts”
* “playing rec sports like bowling and kickball”
* “writing a speculative fiction novel”
* “reading advice columns”

- [x] Here are a few suggestions to make the `Profile` class even better:

* If you call `ViewProfile()` before calling `SetHobbies()`, you’ll get an error because the `hobbies` field isn’t set to any value. Fix the class so that you can call `ViewProfile()` without adding hobbies.
* Convert the fields into private properties and add validation. For example, users must be at least 18 years of age.
* Some users may create a profile with just a name and age. Use optional parameters or create a constructor overload to handle those issues.

***Cheers!***

