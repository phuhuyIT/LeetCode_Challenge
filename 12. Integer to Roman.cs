using system;
using system.Collections.Generic;
public class Solution {
    // init dictionary with key is number and value is the roman
    Dictionary<int, string> dict = new Dictionary<int, string>()
    {
        {1, "I"},
        {4, "IV"},
        {5, "V"},
        {9, "IX"},
        {10, "X"},
        {40, "XL"},
        {50, "L"},
        {90, "XC"},
        {100, "C"},
        {400, "CD"},
        {500, "D"},
        {900, "CM"},    
        {1000, "M"}
    };
    public string IntToRoman(int num) {
        string result = "";
        int pow = 1;
        while(num >0 ){
            int temp = num%10;
            if (temp > 0)
            {
                if (temp == 4 || temp == 9)
                {
                    result = dict[temp * pow] + result;
                }
                else if (temp >= 5)
                {
                    result = dict[5 * pow] + new string(dict[pow][0], temp - 5) + result;
                }
                else
                {
                    result = new string(dict[pow][0], temp) + result;
                }

            }
            num /= 10;
            pow *= 10;
        }
        return result;
    }
}