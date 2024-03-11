namespace TMS_Haulage_Planning_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please chose option:");
            Console.WriteLine("1. View plan");
            Console.WriteLine("2. Manage plan");

            string operation = Console.ReadLine();

            Console.WriteLine($"You have chosen option number: {operation}");

            int chosenOperation = 0;

            Int32.TryParse( operation, out chosenOperation );

            if( chosenOperation == 1 )
            {
                Console.WriteLine("Please chose one of the following options:");
                Console.WriteLine("1. View planned jobs.");
                Console.WriteLine("2. View unplanned jobs.");
                Console.WriteLine("3. View completed jobs.");
                Console.WriteLine("4. View all jobs. ");
            }
            else if( chosenOperation == 2 )
            {
                Console.WriteLine("PLease chose one of the following options:");
                Console.WriteLine("1. Add job.");
                Console.WriteLine("2. Edit job.");
                Console.WriteLine("3. Delete job.");
            }
            else
            {
                Console.WriteLine("This option is not availble.");
            }
            
        }
    }
}
