using system;
using system.Collections.Generic;
public class Solution {
    public string KthDistinct(string[] arr, int k) {
        Dictionary<string, int> frequency = new Dictionary<string, int>();
        foreach (string s in arr)
        {
            if (frequency.ContainsKey(s))
            {
                frequency[s]++;
            }
            else
            {
                frequency.Add(s, 1);
            }
        }
        //C1: tối ưu hơn về thời gian chạy
        // List<string> uniqueElements = frequency.Where(pair => pair.Value == 1)
        //                                      .Select(pair => pair.Key)
        //                                      .ToList();

        // // Xuất ra phần tử có tần suất xuất hiện là 1 tại vị trí thứ k
        // if (k <= uniqueElements.Count)
        // {
        //     return uniqueElements[k-1];
        // }
        // else
        // {
        //     return string.Empty;
        // }
        // C2: tối ưu hơn về bộ nhớ
        int count = 0;
        string result = string.Empty; // Ký tự mặc định nếu không tìm thấy

        foreach (string c in arr)
        {
            if (frequency[c] == 1)
            {
                count++;
                if (count == k)
                {
                    result = c;
                    break;
                }
            }
        }
        return result;
    }
}