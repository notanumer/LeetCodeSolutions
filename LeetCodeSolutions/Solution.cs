namespace RomanToInt
{
    public class Solution
    {
        public static int RomanToInt(string s)
        {
            var values = new Dictionary<char, int>
            {
                ['I'] = 1,
                ['V'] = 5,
                ['X'] = 10,
                ['L'] = 50,
                ['C'] = 100,
                ['D'] = 500,
                ['M'] = 1000
            };

            if (s.Length == 1)
                return values[s[0]];

            if (s.Length == 2 && values[s[0]] < values[s[1]])
                return values[s[1]] - values[s[0]];

            var convertedNum = 0;
            for (var i = 0; i < s.Length; i++)
            {
                var temp = 0;
                if (i != s.Length - 1 && values[s[i]] < values[s[i + 1]])
                    temp = values[s[i + 1]] - values[s[i]];
                if (temp == 0)
                    convertedNum += values[s[i]];
                else
                {
                    convertedNum += temp;
                    i++;
                }
            }

            return convertedNum;
        }

        public static void Main()
        {
            Console.WriteLine(RomanToInt("XX"));
        }
    }
}
