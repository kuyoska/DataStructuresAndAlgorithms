using System.Linq;
using System.Text;

namespace ZTMCodeInterview
{
    public class ArraysProblems
    {
        /// <summary>
        /// This return true if two arrays contains any comming item, this is O(a + b)
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns></returns>
        public bool ArraysContainCommonItem(int[] array1, int[] array2)
        {
            HashSet<int> uniqueItems = new HashSet<int>();

            for(int i  = 0; i < array1.Length; i++)
            {
                uniqueItems.Add(array1[i]);
            }

            for (int i = 0; i < array2.Length; i++)
            {
                if(uniqueItems.Contains(array2[i]))
                    return true;
            }

            return false;
        }

        /// <summary>
        /// This is my approach for reverse a string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string ReverseString(string str)
        {
            char[] chars = new char[str.Length];

            for(int i = str.Length - 1; i >= 0; i--)
            {
                chars[(str.Length - 1) - i] = str[i];
            }

            return new string(chars);
        }

        /// <summary>
        /// This is a copilot implementation using manual swap 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string ReverseStringUsingManualSwap(string str)
        {
            char[] chars = str.ToCharArray();
            int left = 0, right = chars.Length - 1;
            while (left < right)
            {
                var temp = chars[left];
                chars[left++] = chars[right];
                chars[right--] = temp;
            }
            return new string(chars);
        }

        /// <summary>
        /// Merge two sorted arrays into a new one, this is my implementation
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns></returns>
        public int[] MergeSortedArrays(int[] array1, int[] array2)
        {
            int[] mergedArray = new int[array1.Length + array2.Length];

            int array1Index= 0, array2Index=0;

            for(int i = 0; i < mergedArray.Length; i++)
            {
                int? itemArray1 = array1Index < array1.Length ? array1[array1Index] : null;
                int? itemArray2 = array2Index < array2.Length ? array2[array2Index] : null;

                if(!itemArray2.HasValue || (itemArray1.HasValue && itemArray1.Value < itemArray2.Value))
                {
                    mergedArray[i] = array1[array1Index];
                    array1Index++;
                }
                else
                {
                    mergedArray[i] = array2[array2Index];
                    array2Index++;
                }
            }

            return mergedArray;
        }

        /// <summary>
        /// This is the copilot implementation
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns></returns>
        public int[] MergeSortedArraysCopilot(int[] array1, int[] array2)
        {
            int[] result = new int[array1.Length + array2.Length];
            int i = 0, j = 0, k = 0;

            while (i < array1.Length && j < array2.Length)
            {
                if (array1[i] < array2[j])
                {
                    result[k++] = array1[i++];
                }
                else
                {
                    result[k++] = array2[j++];
                }
            }

            // Append any remaining elements from array1
            while (i < array1.Length)
            {
                result[k++] = array1[i++];
            }

            // Append any remaining elements from array2
            while (j < array2.Length)
            {
                result[k++] = array2[j++];
            }

            return result;
        }

        /// <summary>
        /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> seen = new Dictionary<int, int>();
            int[] indexes = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                if (seen.ContainsKey(nums[i]))
                {
                    indexes[0] = seen[nums[i]];
                    indexes[1] = i;
                    return indexes;
                }                    
                else
                {
                    seen.TryAdd(target - nums[i], i);
                }                   
            }

            return indexes;
        }

        /// <summary>
        /// This is the brute force for two sum problem
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSumBruteForce(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0;j < nums.Length; j++)
                {
                    if (j != i && nums[i] + nums[j] == target)
                        return [i, j];                        
                }
            }

            return new int[2];
        }

        /// <summary>
        /// Given an integer array nums, find the subarray with the largest sum, and return its sum.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MaxSubArray(int[] nums)
        {
            int sum = 0;
            int max = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sum > max)
                    max = sum;
                if (sum < 0)
                    sum = 0;
            }
            return max;
        }

        /// <summary>
        /// Brute force for above problem
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MaxSubArrayBruteForce(int[] nums)
        {
            int maxSum = int.MinValue;

            for (int start = 0; start < nums.Length; start++)
            {
                int currentSum = 0;

                for (int end = start; end < nums.Length; end++)
                {
                    currentSum += nums[end];
                    if (currentSum > maxSum)
                        maxSum = currentSum;
                }
            }

            return maxSum;
        }

        /// <summary>
        /// Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
        /// This uses extra array to do the trick
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] MoveZeroes(int[] nums)
        {
            int[] newArray = new int[nums.Length];

            int zeroIndex = newArray.Length - 1;
            int notZeroIndex = 0;

            for (int i = 0; i < nums.Length; ++i)
            {
                if (nums[i] == 0)
                {
                    newArray[zeroIndex] = 0;
                    zeroIndex--;
                }
                else
                {
                    newArray[notZeroIndex] = nums[i];
                    notZeroIndex++;
                }
            }

            return newArray;
        }

        /// <summary>
        /// Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
        /// This is using the two pointer approach
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] MoveZeroesNoAdditionalSpace(int[] nums)
        {
            int zeroIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    if(zeroIndex != i)
                    {
                        int temp = nums[zeroIndex];
                        nums[zeroIndex] = nums[i];
                        nums[i] = temp;
                    }
                    zeroIndex++;
                }
            }

            return nums;
        }

        /// <summary>
        /// Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
        /// this was my first approach
        /// </summary>
        /// <param name="nums"></param>
        public int[] MoveZeroesNotSoEfficient(int[] nums)
        {
            int zeros = 0;
            int cont = 0;

            for (int i = 0; i < nums.Length; ++i)
            {
                int number = nums[i];

                if (number == 0)
                {
                    zeros++;
                }
                else
                {
                    nums[cont] = number;
                    cont++;
                }
            }

            for (int i = 0; i < zeros; ++i)
            {
                nums[(nums.Length - 1) - i] = 0;
            }

            return nums;
        }

        /// <summary>
        /// Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
        /// this is my implemantation
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> uniqueInts = new HashSet<int>();

            for(int i = 0; i < nums.Length; i++)
            {
                if (uniqueInts.Contains(nums[i])) return true;
                else
                    uniqueInts.Add(nums[i]);
            }

            return false;
        }

        /// <summary>
        /// Have the function LongestWord(sen) take the sen parameter being passed and return the longest word in the string. 
        /// If there are two or more words that are the same length, return the first word from the string with that length. 
        /// Ignore punctuation and assume sen will not be empty. Words may also contain numbers, for example "Hello world123 567"
        /// </summary>
        /// <param name="sen"></param>
        /// <returns></returns>
        public string LongestWord(string sen)
        {
            HashSet<char> allowedChars = [.. "abcdefghijklmnopqrstuvwxyz0123456789"];

            string longestWord = string.Empty;
            StringBuilder currentWord = new StringBuilder();

            for(int i = 0; i < sen.Length; i++)
            {
                if (allowedChars.Contains(char.ToLower(sen[i])))
                {
                    currentWord.Append(sen[i]);
                }
                else
                {
                    longestWord = currentWord.Length > longestWord.Length ? currentWord.ToString() : longestWord;
                    currentWord.Clear();
                }
            }

            return currentWord.Length > longestWord.Length ? currentWord.ToString() : longestWord;

        }

        /// <summary>
        /// Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public int[] Rotate(int[] nums, int k)
        {
            for (int i = 0; i < k; i++)
            {
                int lastNumber = nums[nums.Length - 1];

                for (int j = nums.Length - 1; j > 0; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[0] = lastNumber;
            }

            return nums;
        }

        /// <summary>
        /// This is above implementation with reversing technique, suggested by copilot
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int[] RotateWithReversing(int[] nums, int k)
        {
            int n = nums.Length;
            k = k % n; // In case k > n

            Reverse(nums, 0, n - 1);         // Step 1: Reverse the whole array
            Reverse(nums, 0, k - 1);         // Step 2: Reverse first k elements
            Reverse(nums, k, n - 1);         // Step 3: Reverse the remaining elements

            return nums;
        }

        private void Reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }

        public int[] RotateWithExtraSpace(int[] nums, int k)
        {
            int[] tempArray = new int[nums.Length];
            int maxSize = nums.Length;

            for (int i = 0; i < nums.Length; i++)
            {
                int newIndex = i + k;
                newIndex = newIndex > maxSize - 1 ? newIndex - maxSize : newIndex; //we check the array boundaries 
                //we can replace above line with this
                // newIndex = (i + k) % maxSize;
                tempArray[newIndex] = nums[i];
            }           

            return tempArray;
        }
    }
}
