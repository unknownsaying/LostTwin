square15 =
[[1,0,1,0,1],
 [2,0,2,0,2],
 [3,0,3,0,3],
 [4,0,4,0,4],
 [5,0,5,0,5]]

square51 =
[[0,1,0,1,0],
 [0,2,0,2,2],
 [0,3,0,3,0],
 [0,4,0,4,4],
 [0,5,0,5,0]]

square14 = 
[[6,0,6,0],
 [7,0,7,0],
 [8,0,8,0],
 [9,0,9,0]]

square41 = 
[[0,6,0,6],
 [0,7,0,7],
 [0,8,0,8],
 [0,9,0,9]]

square13 =
[[+,-,+],
 [-,+,-],
 [+,-,+]]

square31 =
[[-,+,-],
 [+,-,+],
 [-,+,-]]

square33 = square13 + square31
square44 = square14 + square41
square55 = square15 + square51

square33 ^ 2 + square44 ^ 2 == square55 ^ 2