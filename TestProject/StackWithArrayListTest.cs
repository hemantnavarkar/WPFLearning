using InterviewTask.Implemetation;

namespace TestProject
{
    [TestClass]
    public class StackWithArrayListTest
    {
        [TestMethod]
        public void StackPush_Int_CountShouled1()
        {
            // Arregr
            StackWithArrayList<int> lc = new StackWithArrayList<int>();

            //Act 
            lc.Push(1);
            lc.Push(2);
            lc.Push(3);

            // Assert       
            Assert.AreEqual(lc.dataHoldingList.Count, 3);
        }

        [TestMethod]
        public void StackPush_Int_LastItem()
        {
            // Arregr
            StackWithArrayList<int> lc = new StackWithArrayList<int>();
            lc.Push(1);
            lc.Push(2);
            lc.Push(3);

            var result = lc.Pop();
            //Act 


            // Assert
            Assert.AreEqual(result, 3);
        }

        
        [TestMethod]
        public void StackPush_EmptyScenarion_THrowsException()
        {
            // Arregr
            StackWithArrayList<int> lc = new StackWithArrayList<int>();

            //Act 
            lc.Push(1);
            lc.Push(2);
            lc.Push(3);


            bool isExceptionThrowm = false; ;
            try
            {
                var result = lc.Pop();
            }
            catch (Exception)
            {
                isExceptionThrowm = true;
            }


            // Assert
            Assert.AreEqual(isExceptionThrowm, true);
        }
    }
}