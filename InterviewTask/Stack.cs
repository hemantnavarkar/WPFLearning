using System.Collections;

namespace InterviewTask
{
    public class LocalStack : IStack
    {
        public ArrayList dataHoldingList;
        public LocalStack()
        {
            dataHoldingList = new ArrayList();
        }
        public TElement Pop<TElement>()
        {
            var lastEntryAvailble = dataHoldingList.ToArray()[dataHoldingList.Count -1];
            if (lastEntryAvailble == null)
            {
                throw new Exception();
            }

            dataHoldingList.RemoveAt(dataHoldingList.Count -1);
            return (TElement)lastEntryAvailble;
        }

        public void Push<TElement>(TElement item)
        {
            if (item == null)
            {
                throw new Exception();
            }

            dataHoldingList.Add(item);
        }
    }
}
