using System;

namespace HW_WK4_Problem01
{
    class Program
    {
        //Joe Buehring, Hayden Jones, Vince Cabahug
        /// <summary>
        /// This displays on a single line asterisks in number equal to argument passed.
        /// </summary>
        /// <param name="num"></param>
        public static void DisplayAsterisks(double num)
        {
            for (int i = 1; i <= num; i++)            //This prints out proper number of asterisks depending on input, rounding down
                Console.Write("*");
            Console.Write("\n");                    //This starts new line.
        }
        /// <summary>
        /// This receives input for store revenue, checks to ensure proper value.
        /// </summary>
        /// <param name="storeNumber"></param>
        /// <param name="sales"></param>
        public static void EnterSales(int storeNumber, out double sales)
        {
            Console.Write($"Enter today's sales for store {storeNumber}: ");                //Formatting console write
            bool test = Double.TryParse(Console.ReadLine(), out sales);                     //creates testing variable, attempts to convert to double
            while (!test)                                                                   //while failed to convert to double
            {
                Console.WriteLine("Invalid response, try again.");                          //prompts for new response
                test = Double.TryParse(Console.ReadLine(), out sales);                      //attempts to convert and updates loop condition variable
            }
        }
        /// <summary>
        /// Dispays pertinent information in requisite format
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="e"></param>
        public static void DisplayAggregateData(double a, double b, double c, double d, double e)
        {
            Console.WriteLine("SALES BAR CHART\n(Each * = $100)");          //Writes to console information after calling method for printing asterisks.
            Console.Write("Store 1: ");
            DisplayAsterisks(a / 100.0);
            Console.Write("Store 2: ");
            DisplayAsterisks(b / 100.0);
            Console.Write("Store 3: ");
            DisplayAsterisks(c / 100.0);
            Console.Write("Store 4: ");
            DisplayAsterisks(d / 100.0);
            Console.Write("Store 5: ");
            DisplayAsterisks(e / 100.0);
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue; //formats the lettering to blue
            Console.WriteLine("This Bar Chart Will Demonstrate the Sales of Five Stores."); //Titles the program
            Console.WriteLine("========================================================="); 
            Console.WriteLine(@"      ,,,,                            ,///               ///,              
           ,,,,          ****              ,///               ///*,,,    ((((   
  /,#  ////,,,,////      ////    ////      ,///,,,,           ///*,,,////((((   
       ////,,,,////((((  ////,,,,////      ,///,,,,////       ///*,,,////((((   
  .,.  ////,,,,////((((  ////,,,,////((((  ,///,,,,////       ///*,,,////((((   
       ////,,,,////((((  ////,,,,////((((  ,///,,,,////****   ///*,,,////((((   
       ////,,,,////((((  ////,,,,////((((  ,///,,,,////((((   ///*,,,////((((   
       ////,,,,////((((  ////,,,,////((((  ,///,,,,////((((   ///*,,,////((((   
       ////,,,,////((((  ////,,,,////((((  ,///,,,,////((((   ///*,,,////((((   
       ////,,,,////((((  ////,,,,////((((  ,///,,,,////((((   ///*,,,////((((   
       ////,,,,////((((  ////,,,,////((((  ,///,,,,////((((   ///*,,,////((((   
    *  ////,,,,////((((  ////,,,,////((((  ,///,,,,////((((   ///*,,,////((((   
                                                                       .        
 ");   //This is purely for cosmetic purposes 
           
            Console.Title = "This title exists only to remind those that I am great.";
            double storeA = 1000, storeB = 800, storeC = 500, storeD = 1200, storeE = 300;  //creates some pre-made revenue values for grading purposes only
            EnterSales(1, out storeA);                                                      //Calls EnterSales function to receive revenue for stores x5
            EnterSales(2, out storeB);
            EnterSales(3, out storeC);
            EnterSales(4, out storeD);
            EnterSales(5, out storeE);

            DisplayAggregateData(storeA, storeB, storeC, storeD, storeE);                   //Calls method to display data collected

        }

    }
}