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
    }
}
