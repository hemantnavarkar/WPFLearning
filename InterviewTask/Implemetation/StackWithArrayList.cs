using System.Collections;

namespace InterviewTask.Implemetation
{
    public class StackWithArrayList<TElement> : IStack<TElement>
    {
        public ArrayList dataHoldingList;

        public StackWithArrayList()
        {
            dataHoldingList = new ArrayList();
        }
        public TElement Pop()
        {
            var lastEntryAvailble = dataHoldingList.ToArray()[dataHoldingList.Count - 1];
            if (lastEntryAvailble == null)
            {
                throw new Exception();
            }

            dataHoldingList.RemoveAt(dataHoldingList.Count - 1);
            return (TElement)lastEntryAvailble;
        }

        public void Push(TElement item)
        {
            if (item == null)
            {
                throw new Exception();
            }

            dataHoldingList.Add(item);
        }
    }
}
