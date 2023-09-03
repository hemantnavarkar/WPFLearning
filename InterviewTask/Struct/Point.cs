namespace InterviewTask.Struct
{
    public class Point
    {
        /// <summary>
        /// Const
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Represemt X
        /// </summary>
        private int x;

        /// <summary>
        /// Represemnt Y
        /// </summary>
        private int y;

        public int X 
        {
            get { return x; }

            set { x = value; }
        
        }

        public int Y
        {
            get { return y; }

            set { y = value; }

        }
    }
}
