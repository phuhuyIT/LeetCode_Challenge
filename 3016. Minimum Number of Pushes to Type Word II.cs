using system;
using system.Collections.Generic;
public class Solution {
    public int MinimumPushes(string word) {
        Dictionary<char, int> freq = new Dictionary<char, int>();
        for (int i = 0; i < word.Length; i++)
        {
            if (!freq.ContainsKey(word[i]))
            {
                freq.Add(word[i], 1);
            }
            else
            {
                freq[word[i]]++;
            }
        }
        var sortedFreq = freq.OrderByDescending(x => x.Value);
        int result = 0;
        int index =0;
        foreach(var item in sortedFreq)
        {
            result += item.Value * (index/8 +1);
            index ++;
        }
        return result;
    }
    
}