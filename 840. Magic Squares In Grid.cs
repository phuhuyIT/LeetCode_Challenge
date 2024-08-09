public class Solution {
    public int NumMagicSquaresInside(int[][] grid) {
        if(grid.Length < 3 || grid[0].Length < 3) return 0;
        // init count of magic square
        int count = 0;
        // loop through the grid
        for(int i = 0; i < grid.Length - 2; i++){
            for(int j = 0; j < grid[0].Length - 2; j++){
                // check if the current 3x3 grid is a magic square
                if(IsMagicSquare(grid, i, j)){
                    count++;
                }
            }
        }
        return count;
    }
    public bool IsMagicSquare(int[][]grid, int i, int j){
        // init list of unique element
        List<int> unique = new List<int>();
        // check if center is equal to 5
        if(grid[i + 1][j + 1] != 5) return false;
        // loop through the 3x3 grid 
        for(int x = i; x < i + 3; x++){
            int sum =0;
            for(int y = j; y < j + 3; y++){
                // check if the element is between 1 and 9
                if(grid[x][y] > 9) return false;
                // check if the element is unique
                if(unique.Contains(grid[x][y])) return false;
                unique.Add(grid[x][y]);
                sum += grid[x][y];
            }
            // check if the sum of the row is equal to 15
            if(sum != 15) return false;
        }
        // check if the sum of first col is equal to 15
        if(grid[i][j] + grid[i + 1][j] + grid[i + 2][j] != 15) return false;
        // check if the sum of the second col without center is even
        if(grid[i][j + 1] + grid[i + 2][j + 1] != 10) return false;
        // check if the sum of first diagonal without center is even
        if(grid[i][j] + grid[i + 2][j + 2] != 10) return false;
        return true;
    }
}