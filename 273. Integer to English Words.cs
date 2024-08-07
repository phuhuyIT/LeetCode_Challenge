using system;
using system.Collections.Generic;
public class Solution {
    public string NumberToWords(int num) {
        string result = "";
        if (num == 0)
        {
            return "Zero";
        }
        // init dictionary with key is number of zeros and value is the word
        string [] dict = new string[] {"", "Thousand", "Million", "Billion"};
        int count = 0;
        while (num > 0)
        {
            if (num % 1000 > 0)
            {
                result = GetWords(num % 1000) + dict[count] + " " + result;
            }
            num /= 1000;
            count++;
        }
        return result.Trim();
    }
    private string GetWords(int number){
        string result = "";
        // using string array
        string [] dict = new string[] {"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
        "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen",
        "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};
        if (number >= 100)
        {
            result += dict[number / 100] + " Hundred ";
            number %= 100;
        }
        if (number >= 20)
        {
            result += dict[number / 10 + 18] + " ";
            number %= 10;
        }
        if (number > 0)
        {
            result += dict[number] + " ";
        }
        
        return result;
    }
}