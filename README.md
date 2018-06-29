# Word Counter

#### Epicodus C# Code Review 1, 06.29.2018

#### By Ryan Murry

## Description

A program that checks how frequently a word appears in a given string.

## Specs

| Behavior | Input | Output |
|----------|-------|--------|
| Sets the target word | "can" | target word = "can" |
| Checks to make sure the target word does not contain punctuation | "c@n" | target word = invalid |
| Converts the target word to lowercase to make program case-insensitive | "CAN" | target word = "can" |
| Sets a search phrase | "I can open the can of tuna" | search phrase = "I can open a can of tuna" |
| Converts the search phrase to lower case to make program case-insensitive | "I CAN OPEN THE CAN OF TUNA." | search phrase is "i can open the can of tuna." |
| Stores each word in the search phrase in a search list | "I can open the can of tuna." | search list = { "i", "can", "open", "the", "can", "of", "tuna." } |
| Compares the test word to each word in the search list | "I can open the can of tuna" | 1. "can" vs. "i" = false </br> 2. "can" vs. "can" = true </br> 3. "can" vs. "open" = false </br> 4. "can" vs. "the" = false </br> 5. "can" vs. "can" = true </br> 6. "can" vs. "of" = false </br> 7. "can" vs. "tuna" = false </br> |
| Determines the number of **exact** times the target word appears in the search list| 1. "I can open the can of tuna." </br> 2. "I 'can' open the can of tuna." | 1. matches = 2 </br> 2. matches = 1 |
| Removes punctuation at the beginning and end of each word in the search list in order to get every match | "I 'can' open a can of tuna." | matches = 2


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
