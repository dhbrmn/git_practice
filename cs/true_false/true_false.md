### True or False

True or false is a practice task in the Codecademy's _Learn C#_ course. The main goal of this practice is for the user to get more comfortable with arrays and loops.

Tasks:

- [x] Declare and initialize a `questions` array of type `string[]`. The array should contain your own true or false questions.
- [x] Declare and initialize an `answers` array of type `bool[]`. It should contain the correct answers for each question, in the same order.
- [x] Declare `responses` array of type `bool[]`. It should be an empty array with the same length as the `questions` array.
- [x] To avoid any errors later on, write yourself an `if` statement that checks if the length of the `questions` array IS NOT equal to the length of the `answers` array. If they are not equal, write a warning to the console.
- [x] Create a variable `askingIndex` to keep track of the currently asked question. Set it to `0`.
- [x] Build an empty `foreach` loop that iterates through each question in `questions`.
- [x] Declare these variables in the loop:

* `input` — the text the user enters
* `isBool` — true if the user input can be converted to a boolean, otherwise false
* `inputBool` — the boolean version of the user’s entry

- [x] Ask the question once. In the loop:

* Print the current question to the console
* Print `True or false?` to the console
* Capture the user’s input in `input`

- [x] Let’s check if the user’s input can be converted to a boolean.
- [x] Run a sample code to make sure that everything is working fine.
- [x] We may have to ask the current question multiple times if the user responds in the wrong format. Create an empty `while` loop within the `foreach` loop. It should continue looping while `isBool` is false.
- [x] If the user does not respond with “true” or “false”, then we’ll need to ask for a proper response again. Within the `while` loop:

* Print `Please respond with 'true' or 'false'`. to the console
* Capture the user’s input in `input`
* Try to convert `input` to a boolean using `Boolean.TryParse()`

- [x] Outside of the `while` loop but inside the `foreach` loop, store the user’s boolean answer in `responses` and increment `askingIndex` by 1.
- [x] Test your code to make sure the responses are being recorded correctly.
- [x] Define a few variables:

* `scoringIndex` — to loop through the responses. Set to `0`
* `score` — to count the number of correct responses. Set to `0`

- [x] Create an empty `foreach` loop that iterates through each answer in `answers`.
- [x] First, capture the response matching the answer. Within the loop, use `scoringIndex` to access an element in `responses` and store the value in a variable.
- [x] Second, write out the user response and correct answer for each answer in `answers`.
- [x] Still within the loop, use an `if` statement that increments `score` if the response equals the answer.
- [x] Outside of the `if` statement but within the `foreach` loop, increment `scoringIndex` by `1`.
- [x] Outside of this loop, announce the user’s score.
- [x] Refactor your code into a method `RunQuiz()`. It should take two arguments: a `string[]` array of questions and `bool[]` array of answers. It should have the same behavior as your current app.

**Cheers!**