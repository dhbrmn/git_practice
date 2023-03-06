## Caesar's Cipher 

Caesar's Cipher is a practice task in the Codecademy's _Learn C#_ course. The main goal of this practice is for the user to get more comfortable with arrays and loops.

Tasks:
- [x] Ask the user for a secret message and store the result in a variable.
- [x] Convert the captured string to an array of characters. Store the result in a new variable called `secretMessage`.
- [x] Create a new, empty array of characters to hold the encrypted message. It should be named `encryptedMessage` and have a length equal to the length of `secretMessage`.
- [x] Create an empty for loop that loops through each character of `secretMessage`,
* The iterator variable should be called `i` and start at 0
* It should continue as long as it is less than `secretMessage.Length`
* Each iteration it should increment by 1 

- [x] Within the loop, access the character at position `i` in the `secretMessage` array and store it in a variable.
- [x] Find the position of the character in the `alphabet` array using the method `Array.IndexOf()`. Store the value in a variable.
- [x] Add `3` to the letter position and store the value in a variable.
- [x] Find the new encrypted character by getting the character in the `alphabet` array with that new position.
- [x] Add the encrypted character to the array `encryptedMessage`. Store the character at the index `i` (the iterator variable).
- [x] Convert the character array to a string using `String.Join()` and print it to the console.
- [x] Run your app and try these messages (not all of them may work yet!):
* `hello` converts to `khoor`
* `citizen` converts to `flwlchq` => returns an `error`


- [x] What went wrong? When the program tried to encrypt the z in `citizen`, it found its index in the `alphabet`, 25. It looked up the letter 3 spaces to the right, which would be `alphabet[28]`. This threw an error because the alphabet is only 26 letters! We can “wrap around” by using the modulo operator: `%`. On the line where you add 3 to the letter position, surround the expression `letterPosition + 3` with parentheses and take the modulo of 26. Now the new letter position will never go past 26.
- [x] Test the code again with `citizen`, which converts to `flwlchq`.
- [x] If you’d like, you can keep building on your app:

* The app doesn’t work with uppercase letters. Fix that by converting any message to lowercase.
* The app doesn’t work with symbols, like `!` or `?`. Skip any symbols in your loop so that they are not encrypted.
* Rewrite the loop as a method `Encrypt()` which takes a character array and key and returns an encrypted character array .
* Write a `Decrypt()` method which takes a character array and key and returns a decrypted character array.

### My experience with this project

I learning about arrays and loops was really exciting and interesting, but it took me some time to wrap my head around how to properly write the conditions syntax for the loops. I had to find and read about some `Array.Methods()` too to make this function as it should.

**Cheers!**
