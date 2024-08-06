using system;
using system.Collections.Generic;
public class Solution {
    public int RangeSum(int[] nums, int n, int left, int right) {
        List<long> sums = new List<long>();
        for (int i = 0; i < n; i++)
        {
            long sum = 0;
            for (int j = i; j < n; j++)
            {
                sum += nums[j];
                sums.Add(sum);
            }
        }
        sums.Sort();
        long result = 0;
        for (int i = left - 1; i < right; i++)
        {
            result += sums[i];
        }
        return (int)(result % 1000000007);
    }
}