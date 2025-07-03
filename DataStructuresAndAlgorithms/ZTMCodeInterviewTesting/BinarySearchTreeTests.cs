using ZTMCodeInterview.Tree;

namespace ZTMCodeInterviewTesting
{
    public class BinarySearchTreeTests
    {
        [Fact]
        public void InsertShouldWork()
        {
            //arrange
            var bs = new BinarySearchTree();

            //act
            bs.Insert(9);

            //assert
            Assert.Equal(1, bs.Count);
        }

        [Fact]
        public void InsertShouldWork2()
        {
            //arrange
            var bs = new BinarySearchTree();

            //act
            bs.Insert(9);
            bs.Insert(4);

            //assert
            Assert.Equal(2, bs.Count);
        }

        [Fact]
        public void InsertShouldWork3()
        {
            //arrange
            var bs = new BinarySearchTree();

            //act
            bs.Insert(9);
            bs.Insert(4);
            bs.Insert(6);
            bs.Insert(20);
            bs.Insert(170);
            bs.Insert(15);
            bs.Insert(1);

            //assert
            Assert.Equal(7, bs.Count);
        }

        [Fact]
        public void ToArrayShouldWork()
        {
            //arrange
            var bs = new BinarySearchTree();

            //act
            bs.Insert(9);
            var list = bs.ToList();

            //assert
            Assert.Equal(1, bs.Count);
            Assert.Equal([9], list);
        }

        [Fact]
        public void ToArrayShouldWork2()
        {
            //arrange
            var bs = new BinarySearchTree();

            //act
            bs.Insert(9);
            bs.Insert(4);
            var list = bs.ToList();

            //assert
            Assert.Equal(2, bs.Count);
            Assert.Equal([9, 4], list);
        }

        [Fact]
        public void ToArrayShouldWork3()
        {
            //arrange
            var bs = new BinarySearchTree();

            //act
            bs.Insert(9);
            bs.Insert(4);
            bs.Insert(6);
            bs.Insert(20);
            bs.Insert(170);
            bs.Insert(15);
            bs.Insert(1);
            var list = bs.ToList();

            //assert
            Assert.Equal(7, bs.Count);
            Assert.Equal([9, 4 , 1, 6, 20, 15, 170], list);
        }

        [Fact]
        public void LookUpShouldWork()
        {
            //arrange
            var bs = new BinarySearchTree();

            //act
            bs.Insert(9);
            bs.Insert(4);
            var found = bs.LookUp(4);

            //assert
            Assert.Equal(2, bs.Count);
            Assert.True(found);
        }

        [Fact]
        public void LookUpShouldWorkNotFound()
        {
            //arrange
            var bs = new BinarySearchTree();

            //act
            bs.Insert(9);
            bs.Insert(4);
            var found = bs.LookUp(7);

            //assert
            Assert.Equal(2, bs.Count);
            Assert.False(found);
        }

        [Fact]
        public void LookUpShouldWork2()
        {
            //arrange
            var bs = new BinarySearchTree();

            //act
            bs.Insert(9);
            bs.Insert(4);
            bs.Insert(6);
            bs.Insert(20);
            bs.Insert(170);
            bs.Insert(15);
            bs.Insert(1);
            var found = bs.LookUp(15);

            //assert
            Assert.Equal(7, bs.Count);
            Assert.True(found);
        }

        [Fact]
        public void LookUpShouldWorkNotFound2()
        {
            //arrange
            var bs = new BinarySearchTree();

            //act
            bs.Insert(9);
            bs.Insert(4);
            bs.Insert(6);
            bs.Insert(20);
            bs.Insert(170);
            bs.Insert(15);
            bs.Insert(1);
            var found = bs.LookUp(100);

            //assert
            Assert.Equal(7, bs.Count);
            Assert.False(found);
        }

        [Fact]
        public void LookUpWithParentShouldWork()
        {
            //arrange
            var bs = new BinarySearchTree();

            //act
            bs.Insert(9);
            bs.Insert(4);
            bs.Insert(6);
            bs.Insert(20);
            bs.Insert(170);
            bs.Insert(15);
            bs.Insert(1);
            var (found,parent) = bs.LookUpWithParent(15);

            //assert
            Assert.Equal(7, bs.Count);
            Assert.True(found != null);
            Assert.Equal(15, found.Value);
            Assert.Equal(20, parent.Value);
        }

        [Fact]
        public void RemoveShouldWorkWhenIsLeaf()
        {
            //arrange
            var bs = new BinarySearchTree();

            //act
            bs.Insert(9);
            bs.Insert(4);
            bs.Insert(6);
            bs.Insert(20);
            bs.Insert(170);
            bs.Insert(15);
            bs.Insert(1);
            bs.Remove(15);
            var list = bs.ToList();

            //assert
            Assert.Equal(6, bs.Count);
            Assert.Equal([9, 4, 1, 6, 20, 170], list);
        }

        [Fact]
        public void RemoveShouldWorkWhenCase1()
        {
            //arrange
            var bs = new BinarySearchTree();

            //act
            bs.Insert(9);
            bs.Insert(4);
            bs.Insert(6);
            bs.Insert(20);
            bs.Insert(170);
            bs.Insert(15);
            bs.Insert(1);
            bs.Insert(150);
            bs.Remove(170);
            var list = bs.ToList();

            //assert
            Assert.Equal(7, bs.Count);
            Assert.Equal([9, 4, 1, 6, 20, 15, 150], list);
        }

        [Fact]
        public void RemoveShouldWorkWhenCase2()
        {
            //arrange
            var bs = new BinarySearchTree();

            //act
            bs.Insert(9);
            bs.Insert(4);
            bs.Insert(6);
            bs.Insert(20);
            bs.Insert(170);
            bs.Insert(15);
            bs.Insert(1);
            bs.Remove(20);
            var list = bs.ToList();

            //assert
            Assert.Equal(6, bs.Count);
            Assert.Equal([9, 4, 1, 6, 170, 15], list);
        }

        [Fact]
        public void RemoveShouldWorkWhenCase3()
        {
            //arrange
            var bs = new BinarySearchTree();

            //act
            bs.Insert(9);
            bs.Insert(4);
            bs.Insert(6);
            bs.Insert(20);
            bs.Insert(170);
            bs.Insert(15);
            bs.Insert(1);
            bs.Insert(150);
            bs.Remove(20);
            var list = bs.ToList();

            //assert
            Assert.Equal(7, bs.Count);
            Assert.Equal([9, 4, 1, 6, 150 , 15, 170], list);
        }
    }
}
