# Wahoo Game
## Purpose
### This is a project assigned from Professor Toler at Richaland, and applies the hardest methods from a game of Yahtzee
## In this game, the player rolls 5 dice up to 3 times per round.  They roll all 5 the first time, and then may choose to reroll one or more dice two more times.  The goal is to create the following sets to score points:

### 1.	If all 5 dice are the same, it’s a Wahoo! (score: 50)
### 2.	If 4 dice are the same, it’s a 4 of a kind (score: sum of the matching dice values)
### 3.	If only 3 dice are the same, it’s a 3 of a kind (score: sum of the matching dice values)
### 4.	If 5 dice are sequential then it’s a large straight (score: 40)
### 5.	If 4 dice are sequential then it’s a large straight (score: 30)
### 6.	If there are 2 dice of one number and three of another, it’s a full house (score: 25)
### 7.	If none of the other scores were earned, then it will be Chance and the score is the sum of all 5 dice. 

## GUI Capabilities
### •	Shows the dice when they are rolled
### •	Gives the user the ability to select which dice to reroll
### •	Allows the user to roll up to 3 times
### •	Lets the user choose which of the above sets to use the dice for.  If nothing is left that fits, the user chooses one of the above sets, and a 0 is entered for its score. 
### •	Keeps a running total score and only allows the user to use each of the above sets once. (Once a set’s checkbox has been checked, it should be disabled, so it cannot be used again.)
### •	Shows which roll has just been completed for the turn (1, 2, or 3).
