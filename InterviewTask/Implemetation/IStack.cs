namespace InterviewTask.Implemetation
{
    public interface IStack<TElement>
    {
        /// <summary>
        /// Pops the item from stack.
        /// </summary>
        /// <returns></returns>
        TElement Pop();
      
        /// <summary>
        /// Push the item to stack
        /// </summary>
        /// <param name="item"></param>
        void Push(TElement item);
    }
}