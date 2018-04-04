# FunWithFSharp
File full of F# functions made for a class assignment.

Functions created off of these specs:

Define a function called cube that resolves to the cube of the input parameter.
Example: (cube 5) resolves to 125.



Define a function called thrd that accepts a list and resolves to the 3rd element of the list. You can assume the list has at least 3 elements.
Example: (thrd '(3 1 5 2 7)) resolves to 5.



Define a function called min3 that accepts 3 values and resolves to the smallest value.
Example: (min3 5 1 6) resolves to 1.



Define a function called del2nd that accepts a list and resolves to a list without the second element.
Example: (del2nd '(5 4 6 7)) resolves to (5 6 7).



Define a function called cycle1 that accepts a list and resolves to a new list with the first element moved to the end.
Example: (cycle1 '(5 4 6 7)) resolves to (4 6 7 5).



Define a function called rotate that accepts a value n and a list and resolves to a new list that has been “rotated” n times.
Example: (rotate 3 '(1 2 3 4 5 6 7)) resolves to (4 5 6 7 1 2 3).



Define a function called isMember (without using any of the "built in" member/memq functions) that accepts a value and a list and resolves to true (#t) if the element is in the list, or false (#f) otherwise.
Example: (isMember 4 '(5 4 6 7)) resolves to #t.



Define a function called countMatches that accepts a function and a list and resolves to the number of elements matching the criteria indicated by the function.
Example: (countMatches (lambda (x) (< x 5)) '(1 9 3 8 7 4 5 6)) resolves to 3.



Define a function called removeMatches that accepts a function and a list and resolves to a new list without the values specified by the function.
Example: (removeMatches (lambda (x) (< x 5)) '(1 9 3 8 7 4 5 6)) resolves to (9 8 7 5 6).



Define a function called reverseList that accepts a list and resolves to the list in reverse order.
Example: (reverseList '(1 9 3 8 7 4 5 6)) resolves to (6 5 4 7 8 3 9 1).




Extra Challange!!!
Define a function called removeDups that accepts a function and a list (which you can assume is already sorted) and resolves to a new list with the duplicates removed.
Example: (removeDups '(1 1 2 3 4 4 5 8 8 8 )) resolves to (1 2 3 4 5 8).
