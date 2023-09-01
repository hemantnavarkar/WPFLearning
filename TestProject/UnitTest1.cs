using InterviewTask;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StackPush_Int_CountShouled1()
        {
            // Arregr
            LocalStack lc = new LocalStack();

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
            LocalStack lc = new LocalStack();
            lc.Push(1);
            lc.Push(2);
            lc.Push(3);

            var result = lc.Pop<int>();
            //Act 


            // Assert
            Assert.AreEqual(result, 3);
        }

        
        [TestMethod]
        public void StackPush_EmptyScenarion_THrowsException()
        {
            // Arregr
            LocalStack lc = new LocalStack();

            //Act 
            lc.Push(1);
            lc.Push(2);
            lc.Push(3);


            bool isExceptionThrowm = false; ;
            try
            {
                var result = lc.Pop<int>();
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