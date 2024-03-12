###Sudoku

##Rules for generating a valid Sudoku puzzle

1. Generate a random filled 9x9 Sudoku grid.				
2. Remove numbers, so at least 17 numbers are still filled in.

Idea: start with an empty array of 9 elements, indicating the occurence of the said number in the whole board.
As there should be at least 17 numbers, we can randomly add 1 to any index in the array, making sure that maximum 1 number will be completely removed from the board.
We can add all 17 occurances randomly, but then the biggest number of occurance should be removed, adding that 1 occurance to the lowest number of occurance. This way we can make sure that the board will be valid.
Also make sure, no occurance is greater than 3, as it would make the board boring, or invalid.
This is the hardest difficulty, we can leave more numbers in after all of the above is done, if easier difficulty is needed.