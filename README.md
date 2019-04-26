# Word-Counter ![alt text](https://github.com/adam-p/markdown-here/raw/master/src/common/images/icon48.png "Logo Title Text 1")
#### A program that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence. , 04.26.2019

#### By _**Mariia Stashuk**_

## Description

A program that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence. It should check for full word matches only. (For instance, if provided the word "cat" and sentence "I'm walking to the cathedral." the first three letters of the word cathedral would not be counted.)

*
*
*


## Setup/Installation Requirements

_To run this project,install it locally:_

* Clone this repository https://github.com/Marrri4ka/Word-Counter.git


## Beep Boop Specifications

 List of specs from the simplest possible behavior to the most complex behavior:

| Behavior       | Input          | Output  |
| ------------- |:-------------:| -----:|
|User enter two same words      | "cat" "cat cat"   | 2|
|User enter sentence of two different words | "cat" "cat dog"    |  1 |
| User enter sentence of three words, where tow words are the same   | "cat" "cat dog cat"   |   2 |
|User enter sentence with word 'meercat' | "cat" "I am a meercat" | 0 |
|User | "cat" "They will not pay for our relocation" | 0 |
|User can use different punctuation| This is cat;not dog | 1 |
|User can use lower or upper case| "cat" This is Cat;not dog | 1 |



## Known Bugs

No bugs.

## Support and contact details

If you have any questions or problems, please contact Mariia (mariiapopovych@gmail.com)

## Technologies Used

* C#


### License

*License under MIT*

Copyright (c) 2019 **_Mariia Stashuk_**
