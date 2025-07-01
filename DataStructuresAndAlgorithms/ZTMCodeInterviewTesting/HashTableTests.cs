using ZTMCodeInterview.HashTable;

namespace ZTMCodeInterviewTesting
{
    public class HashTableTests
    {
        [Fact]
        public void HashTableShouldAdd()
        {
            //arrange
            var hastTable = new HashTable(50);

            //act
            hastTable.Set("grapes", 10000);

            //assert
            Assert.Equal(1, hastTable.Count);
        }

        [Fact]
        public void HashTableShouldRetriveAddedValue()
        {
            //arrange
            var hastTable = new HashTable(50);

            //act
            hastTable.Set("grapes", 10000);
            var result = hastTable.Get("grapes");

            //assert
            Assert.Equal(10000, result);
        }

        [Fact]
        public void HashTableShouldRetriveAllKeys()
        {
            //arrange
            var hastTable = new HashTable(50);

            //act
            hastTable.Set("grapes", 10000);
            hastTable.Set("apples", 54);
            var result = hastTable.GetKeys().ToArray();

            //assert
            Assert.Equal(["grapes", "apples"], result);
        }

        [Fact]
        public void FirstRecurringCharacterShouldWork()
        {
            //arrange
            var hastTable = new HashTableProblems();

            //act
            var result = hastTable.FirstRecurringCharacter([2, 5, 1, 2, 3, 5, 1, 2, 4]);
            
            //assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void FirstRecurringCharacterShouldWork2()
        {
            //arrange
            var hastTable = new HashTableProblems();

            //act
            var result = hastTable.FirstRecurringCharacter([2, 1, 1, 2, 3, 5, 1, 2, 4]);

            //assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void FirstRecurringCharacterShouldThrowExceptionIfNotRecurring()
        {
            //arrange
            var hastTable = new HashTableProblems();

            //assert
            Assert.Throws<Exception>(() =>
            {
                var result = hastTable.FirstRecurringCharacter([1, 2, 3, 4]);
            });
        }
    }
}
