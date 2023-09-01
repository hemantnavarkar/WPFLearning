namespace InterviewTask.Constructor
{
    internal struct Point
    {

        static Point()
        {

            Console.Write("Static Data");
            // Dummy = 100;
        }

        public Point()
        {
            this.X = 0;
            this.Y = 0;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public static int Dummy { get; set; }
    }
}
