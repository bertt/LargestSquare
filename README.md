# LargestSquare

NuGet: https://www.nuget.org/packages/LargestSquareCalculator/

Find largest squares in array of points

For example:

```
[1,1,0]
[1,1,0]
[0,0,0] 

Result: 1 square, size 2
```
 
Input: List of points list(int, int)

Output: List of squares 

Algorithm: Loop through all points in list of points, for each point determine the maximum square to the right and bottom. Return
maximum of those squares.
