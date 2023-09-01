using InterviewTask.Implemetation;

namespace TestProject
{
    [TestClass]
    public class StackWithArrayTest
    {
        [TestMethod]
        public void Push_FirstValue_NoException()
        {
            //Arrenge
            CustomStack<int> stackOfInt = new CustomStack<int>();

            //Assert
            stackOfInt.Push(10);
        }

        [TestMethod]
        public void Push_WrontDataType_NoException()
        {
            //Arrenge
            CustomStack<int> stackOfInt = new CustomStack<int>();

            //Assert
            stackOfInt.Push(10);
            stackOfInt.Push(11);
            stackOfInt.Push(2);

            var item = stackOfInt.Pop();
            Assert.AreEqual(item, 2);
            item = stackOfInt.Pop();
            Assert.AreEqual(item, 11);
            item = stackOfInt.Pop();
            Assert.AreEqual(item, 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Nothing to poped out")]
        public void Pop_NoElementsToPop_ShouldThrowException()
        {
            //Arrenge
            CustomStack<int> stackOfInt = new CustomStack<int>();

            //Assert
            stackOfInt.Push(10);
            stackOfInt.Push(11);
            stackOfInt.Push(2);

            var item = stackOfInt.Pop();
            Assert.AreEqual(item, 2);
            item = stackOfInt.Pop();
            Assert.AreEqual(item, 11);
            item = stackOfInt.Pop();
            Assert.AreEqual(item, 10);
            item = stackOfInt.Pop();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Reached Limit, cant add further item")]
        public void Push_MaxLimitReached_ThrowException()
        {
            //Arrenge
            CustomStack<int> stackOfInt = new CustomStack<int>(2);

            //Assert
            stackOfInt.Push(10);
            stackOfInt.Push(11);
            stackOfInt.Push(2);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Reached Limit, cant add further item")]
        public void Push_NullTypeData_ThrowException()
        {
            //Arrenge
            CustomStack<object> stackOfInt = new CustomStack<object>(2);

            //Assert
            stackOfInt.Push(10);
            stackOfInt.Push(11);
            stackOfInt.Push(null);
        }
    }
}
