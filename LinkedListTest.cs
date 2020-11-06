using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListProject;
namespace LinkedListTest
{
    [TestClass]
    public class LinkedListTest
    {
        /// <summary>
        /// Givens the element to search in linked list should return true.
        /// </summary>
        [TestMethod]
        public void Given_ElementToSearchInLinkedList_Should_Return_True()
        {
            //Arrange
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            //Act
            bool result = list.Search(30);
            //Assert
            Assert.AreEqual(true, result);
        }
        /// <summary>
        /// Givens the element to search in linked list should return false.
        /// </summary>
        [TestMethod]
        public void Given_ElementToSearchInLinkedList_Should_Return_False()
        {
            //Arrange
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            //Act
            bool result = list.Search(1200000000);
            //Assert
            Assert.AreEqual(false, result);
        }
    }
}
