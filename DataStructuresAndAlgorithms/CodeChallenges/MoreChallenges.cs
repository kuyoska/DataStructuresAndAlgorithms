using System.Text;

namespace CodeChallenges
{
    public class MoreChallenges
    {
        public int Compress(char[] chars)
        {

            var stringBuilder = new StringBuilder();
            int cont = 1;
            char charBefore = chars[0];

            if (chars.Length == 1) return chars.Length;

            for (int i = 1; i < chars.Length; i++)
            {
                if (charBefore != chars[i])
                {
                    if (cont == 1)
                        stringBuilder.Append(charBefore);
                    else
                        stringBuilder.Append($"{charBefore}{cont}");

                    cont = 1;
                    charBefore = chars[i];
                }
                else
                    cont++;
            }

            if (cont == 1)
                stringBuilder.Append(charBefore);
            else
                stringBuilder.Append($"{charBefore}{cont}");

            return stringBuilder.ToString().Length;
        }

        /// <summary>
        /// Generates a sequence of strings representing the FizzBuzz game for numbers from 1 to the specified upper
        /// limit.
        /// </summary>
        /// <param name="n">The upper limit of the sequence. Must be greater than or equal to 1.</param>
        /// <returns>A list of strings where each element corresponds to a number in the sequence: - "FizzBuzz" for numbers
        /// divisible by both 3 and 5. - "Fizz" for numbers divisible by 3. - "Buzz" for numbers divisible by 5. - The
        /// number itself as a string for all other cases.</returns>
        public IList<string> FizzBuzz(int n)
        {
            var result = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                var isDivisibleBy3 = i % 3 == 0;
                var isDivisibleBy5 = i % 5 == 0;

                result.Add(isDivisibleBy3 && isDivisibleBy5 ? "FizzBuzz" : isDivisibleBy3 ? "Fizz" : isDivisibleBy5 ? "Buzz" : i.ToString());
            }

            return result;
        }

        /// <summary>
        /// Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
        /// You must implement a solution with a linear runtime complexity and use only constant extra space.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumber(int[] nums)
        {
            int single = 0;
            foreach (var num in nums)
            {
                single ^= num; // XOR operation
            }
            return single;
        }

        /// <summary>
        /// Finds the single number in an array where every other number appears twice.
        /// </summary>
        /// <remarks>This method uses a dictionary to track the frequency of each number in the array. It
        /// is suitable for scenarios where additional space usage is acceptable.</remarks>
        /// <param name="nums">An array of integers where every element except one appears twice.</param>
        /// <returns>The integer that appears only once in the array.</returns>
        public int SingleNumberWithExtraSpace(int[] nums)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                    dict[nums[i]]++;
                else
                    dict[nums[i]] = 1;
            }

            return dict.Single(n => n.Value == 1).Key;
        }

        public int MaxDepth(TreeNode root)
        {
            return MaxDepthInternal(root, 0);
        }

        private int MaxDepthInternal(TreeNode currentNode, int currentDepth)
        {
            if (currentNode == null)
            {
                return currentDepth;
            }

            currentDepth++;
            var maxLeft = MaxDepthInternal(currentNode.Left, currentDepth);
            var maxRight = MaxDepthInternal(currentNode.Right, currentDepth);
            return Math.Max(maxLeft, maxRight);
        }

        public int Rob(int[] nums)
        {
            int p2Amount = 0; //the max money robbed up to two houses ago
            int p1Amount = 0; //the max money robbed up to the previous house

            foreach (var money in nums)
            {
                var currentAmount = Math.Max(p2Amount + money, p1Amount);
                p2Amount = p1Amount;
                p1Amount = currentAmount;
            }

            return p1Amount;
        }

        /// <summary>
        /// Finds the first character in the specified string that does not repeat.
        /// </summary>
        /// <remarks>This method scans the input string to identify the first character that appears only
        /// once. If no non-repeating character is found, the method returns <see langword="'$'"/>.</remarks>
        /// <param name="s">The input string to search for the first non-repeating character.</param>
        /// <returns>The first non-repeating character in the string. Returns <see langword="'$'"/> if no such character exists.</returns>
        public char FirstNotRepeatingCharacter(string s)
        {
            var dict = new Dictionary<char, (int cont,int index)>();
            var result = '$';

            for(int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    dict[s[i]] = (dict[s[i]].cont + 1, dict[s[i]].index);
                }
                else
                {
                    dict[s[i]] = (1, i);
                }
            }

            int minIndex = s.Length + 1;
            foreach (var item in dict)
            {
                if (item.Value.cont == 1 && item.Value.index < minIndex)
                {
                    result = item.Key;
                    minIndex = item.Value.index;
                }
            }

            return result;
        }
    }

    public class TreeNode
    {
        public int Val;
        public TreeNode Left;
        public TreeNode Right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.Val = val;
            this.Right = left;
            this.Right = right;
            
        }
    }
}
