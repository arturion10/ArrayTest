using ArrayTest;
using Xunit;

namespace TestArrayTest
{
    public class ArrayLogicTest
    {
        private ArrayLogic logic;
        public ArrayLogicTest()
        {
            logic = new ArrayLogic();
        }
        [Fact]
        public void SortedStringArray_Sorted()
        {
            //Arrange
            int [,] array = new int[,] {{ 3, 2, 1 }, { 1, 2, 3 }, { 3, 2, 1 }};
            int[,] array2 = new int[,] {{ 3, 2, 1 }, { 1, 2, 3 }, { 3, 2, 1 }};
            //Act
            array2 = logic.SortedStringArray(array);
            //Assert
            Assert.Equal(string.Join(',', array), (string.Join(',', array2)));
        }
        [Fact]
        public void SortedStringArray_UnSorted()
        {
            //Arrange
            int[,] array = new int[,] { { 1, 2, 3 }, { 2, 1, 3 }, { 3, 1, 2 } };
            int[,] array2 = new int[,] { { 3, 2, 1 }, { 1, 2, 3 }, { 3, 2, 1 } };
            //Act
            array2 = logic.SortedStringArray(array);
            //Assert
            Assert.Equal(string.Join(',', array), (string.Join(',', array2)));
        }
    }
}