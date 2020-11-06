using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListProject;
using System.Net.Sockets;

namespace LinkedListTest
{
    [TestClass]
    public class LinkedListTest
    {   
        ///TC 7.1
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
        ///TC 7.2
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
        ///TC 8.1
        /// <summary>
        /// Givens the element to insert element in linked list and check if element is inserted should return true.
        /// </summary>
        [TestMethod]
        public void Given_ElementToInsertElementInLinkedList_AndCheckIfElementIsInsertedShould_Return_True()
        {
            //Arrange
            LinkedList list = new LinkedList();
            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.Insert(3, 40);
            //Act
            bool result = list.Search(40);
            //Assert
            Assert.IsTrue(result);
        }
        ///TC 8.2
        /// <summary>
        /// Givens the element to insert element in linked list and check if element is inserted should return true.
        /// </summary>
        [TestMethod]
        public void Given_ElementToInsertElementInLinkedList_AndCheckIfElementIsInserted_Should_Return_True()
        {
            //Arrange
            LinkedList list = new LinkedList();
            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.Insert(3, 80);
            //Act
            bool result = list.Search(80);
            //Assert
            Assert.IsTrue(result);
        }
        ///TC 9.1
        /// <summary>
        /// Givens the element to delete should give new size after deletion true case
        /// </summary>
        [TestMethod]
        public void Given_ElementToDelete_ShouldGiveNewSizeAfterDeletion()
        {
            //Arrange
            int expected = 3;
            LinkedList list = new LinkedList();
            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.Add(40);
            //Act
            list.Delete(40);
            int result = list.Size();
            //Assert
            Assert.AreEqual(expected, result);
        }
        ///TC 9.2
        /// <summary>
        /// Givens the element to delete should give new size after deletion false case.
        /// </summary>
        [TestMethod]
        public void Given_ElementToDelete_ShouldGiveNewSizeAfterDeletion_FalseCase()
        {
            //Arrange
            int expected = 4;
            LinkedList list = new LinkedList();
            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.Add(40);
            //Act
            list.Delete(40);
            int result = list.Size();
            //Assert
            Assert.AreNotEqual(expected, result);
        }
    }
}
