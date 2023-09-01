namespace InterviewTask.Implemetation
{
    public class CustomStack<TElement> : IStack<TElement>
    {
        private TElement[] stackedArray;
        int top = -1;
        private readonly int STACK_LENGTH;
        private object pushpoplockerInstance = new object();

        public CustomStack(int maxLength = 1000) 
        {
            STACK_LENGTH = maxLength;
            // fixed size array
            stackedArray = new TElement[STACK_LENGTH];
        }

        public TElement Pop()
        {
            if (top == -1)
            {
                throw new ArgumentOutOfRangeException("Nothing to poped out");
            }

            // LIFO 
            lock (pushpoplockerInstance)
            {
                return stackedArray[top--];
            }   
        }

        public void Push(TElement item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("no null item can be added");
            }

            // very first element

            if (top == STACK_LENGTH -1)
            {
                throw new Exception("Reached Limit, cant add further items");
            }

            lock (pushpoplockerInstance)
            {
                stackedArray[++top] = item;
            }
        }
    }
}
