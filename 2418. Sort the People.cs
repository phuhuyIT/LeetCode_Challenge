using system;
using system.Collections.Generic;
public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
        Dictionary<int, string> dict = new Dictionary<int, string>();
        for (int i = 0; i < names.Length; i++)
        {
            dict.Add(heights[i], names[i]);
        }
        // sort heights array by descending order
        Array.Sort(heights, (a, b) => -1 * a.CompareTo(b));

        string[] result = new string[names.Length];
        for (int i = 0; i < names.Length; i++)
        {
            result[i] = dict[heights[i]];
        }
        return result;
    }
}