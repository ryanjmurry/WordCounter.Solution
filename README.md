# Word Counter

#### Epicodus C# Code Review 1, 06.29.2018

#### By Ryan Murry

## Description

A program that checks how frequently a word appears in a given string.

## Specs

| Behavior | Input | Output | Reasoning |
|----------|-------|--------|-----------|
| Sets the target word | "can" | target word = "can" | include word with all lower case letters with no special characters |
| Checks to make sure the target word does not contain punctuation | "c@n" | target word = invalid | include word with all lower case letters and one punctuation character included |
| Converts the target word to lowercase to make program case-insensitive | "CAN" | target word = "can" |include word with uppercase letters and no special characters |
| Sets a search phrase | "i can open the can of tuna" | search phrase = "i can open a can of tuna" | include a phrase consisting of all lower case letters |
| Converts the search phrase to lower case to make program case-insensitive | "I CAN OPEN THE CAN OF TUNA." | search phrase is "i can open the can of tuna." | include a phrase consisting of uppercase letters
| Stores each word in the search phrase in a search list | "I can open the can of tuna." | search list = { "i", "can", "open", "the", "can", "of", "tuna." } | stores a list of lowercase strings into a list with no matching words containing beginning of ending punctuation
| takes each search element in the list and turns it into an array of individual characters | "can" | array = { 'c', 'a', 'n' } | necessary to check if each character is a punctuation mark |
| Combs through array of characters generated from the search list and creates a clean string with no proceeding or trailing punctuation marks | { ' ' ', 'c', 'a', 'n', ' ' ' } | clean string = "can" | will allow for matches even if the word is in quotes, at the end of a sentence, etc.
| Adds the clean string to a new clean list | clean string = "can" | clean list = { "can" } | will allow the word to be matched against the target word |
| Compares the test word to each word in the clean list | "I can open the can of tuna" | 1. "can" vs. "i" = false </br> 2. "can" vs. "can" = true </br> 3. "can" vs. "open" = false </br> 4. "can" vs. "the" = false </br> 5. "can" vs. "can" = true </br> 6. "can" vs. "of" = false </br> 7. "can" vs. "tuna" = false </br> | If it is true, it will signify that there is a match in the clean list |
| Determines the number of times the target word appears in the clean list| 1. "I can open the can of tuna." </br> 2. "I 'can' open the can of tuna." | 1. matches = 2 </br> 2. matches = 1 | Allows program to return the number of matches in a given phrase to a target word |


## Setup on OSX

* Download and install .Net Core 1.1.4
* Download and install Mono
* Clone the repo
* Run `dotnet restore` from within the project directory

## Contribution Requirements

1. Clone the repo
1. Make a new branch
1. Commit and push your changes
1. Create a PR

## Technologies Used

* .Net Core 1.1.4

## Links

* [Link to Repository](https://github.com/ryanjmurry/WordCounter.Solution)

## License

This software is licensed under the MIT license.

Copyright (c) 2018 **Ryan Murry**
