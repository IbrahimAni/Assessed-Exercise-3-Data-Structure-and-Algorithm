namespace Assessment_3_Task_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input n");
            int n = Convert.ToInt32(Console.ReadLine());

            int r = 20;
            int dummy = 0;
            Console.WriteLine("Creating a nested loop");

            for (int i = 0; i < n; i++) // Executed n times
            {
                Console.WriteLine("Inside the first loop");
                dummy++;

                for (int j = 0; j < n; j++) // Executed n times for each iteration of the outer loop
                {
                    r = r + dummy;
                    Console.WriteLine("Inside the second loop " + r);
                }
            }
            //Segment 1:
            //for (int i = 0; i < n; i++): This loop iterates n times, where n is the input value.
            //for (int j = 0; j < n; j++): This inner loop also iterates n times.
            //The inner loop is nested within the outer loop, so the total number of iterations will be n* n. The time complexity of this segment is O(n ^ 2).


            Console.WriteLine("Please enetr m ");
            int m = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j <= m; j++)
            {
                Console.WriteLine("for loop");
            }
            while (m > 0)
            {
                m--;
                Console.WriteLine("while loop");
            }
            //Segment 2:
            //for (int j = 1; j <= m; j++): This loop iterates m times, where m is the input value.The time complexity of this loop is O(m).
            //while (m > 0): This loop also iterates m times, decrementing m with each iteration. The time complexity of this loop is O(m).
        }
    }
}