namespace ZTMCodeInterview.HashTable
{
    public class HashTableProblems
    {
        public int FirstRecurringCharacter(int[] numbers)
        {
            var alreadySeen = new HashSet<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if(alreadySeen.Contains(numbers[i]))
                    return numbers[i];
                else
                    alreadySeen.Add(numbers[i]);
            }

            throw new Exception("No repited characters");
        }
    }
}
