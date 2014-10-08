using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_digital_vackarklocka
{
    class Program
    {
        static void Main(string[] args)
            {
                int ammountOfMinutes;
                string HorizontalLine = "Test 1. \nTest av standard konstruktorn.";

                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ╔══════════════════════════════════════╗ ");
                Console.WriteLine(" ║           Väckarklockan              ║ ");
                Console.WriteLine(" ╚══════════════════════════════════════╝ ");
                Console.ResetColor();
                Console.WriteLine();


                AlarmClock time = new AlarmClock();

                Console.WriteLine("__________________________________");
                ViewTestHeader(HorizontalLine);
                Console.WriteLine();
                Console.WriteLine(time);


                AlarmClock time2 = new AlarmClock(9, 42);

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("__________________________________");
                HorizontalLine = "Test 2. \nTest av konstruktorn med två parametrar, <9, 42>.";
                ViewTestHeader(HorizontalLine);
                Console.WriteLine();
                Console.WriteLine(time2);


                AlarmClock time3 = new AlarmClock(13, 24, 7, 35);

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("__________________________________");
                HorizontalLine = "Test 3. \nTest av konstruktorn med fyra parametrar, <13, 24, 7, 35>.";
                ViewTestHeader(HorizontalLine);
                Console.WriteLine();
                Console.WriteLine(time3);



                AlarmClock time4 = new AlarmClock(23, 58, 7, 35);

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("__________________________________");
                HorizontalLine = "Test 4.\nStäller befintligt AlamClock-objekt till 23:58 och låter den gå 13 minuter.";
                ViewTestHeader(HorizontalLine);
                Console.WriteLine();
                ammountOfMinutes = 13;
                Run(time4, ammountOfMinutes);



                AlarmClock time5 = new AlarmClock(6, 12, 6, 15);

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("__________________________________");
                HorizontalLine = "Test 5.\nStäller befintligt AlarmClock-objekt till tiden 6:12 och alarmtiden till 6:15 och låter den gå 6 minuter";
                ViewTestHeader(HorizontalLine);
                Console.WriteLine();
                ammountOfMinutes = 6;
                Run(time5, ammountOfMinutes);




                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("__________________________________");
                HorizontalLine = "Test 6.\nTestar egenskaperna så att undantag kastas så tid och alarmtid tilldelas felaktiga värden.";
                ViewTestHeader(HorizontalLine);
                Console.WriteLine();
                try
                {
                    time.Hour = 88;
                }

                catch (ArgumentException ex)
                {
                    ViewErrorMessage(ex.Message);
                }

                try
                {
                    time.Minute = 88;
                }

                catch (ArgumentException ex)
                {
                    ViewErrorMessage(ex.Message);
                }

                try
                {
                    time.Alarmhour = 88;
                }

                catch (ArgumentException ex)
                {
                    ViewErrorMessage(ex.Message);
                }

                try
                {
                    time.Minute = 88;
                }

                catch (ArgumentException ex)
                {
                    ViewErrorMessage(ex.Message);
                }



                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("__________________________________");
                HorizontalLine = "Test 7.\nTest av konstruktorer så att undantag kastas då tid och alarmtid tilldelas felaktiga värden.";
                ViewTestHeader(HorizontalLine);
                Console.WriteLine();

                try
                {
                    AlarmClock time6 = new AlarmClock(88, 0, 0, 0);
                }

                catch (ArgumentException ex)
                {
                    ViewErrorMessage(ex.Message);

                }

                try
                {
                    AlarmClock time6 = new AlarmClock(0, 0, 545, 0);
                }

                catch (ArgumentException ex)
                {
                    ViewErrorMessage(ex.Message);

                }

                

        }
        private static void Run(AlarmClock ac, int minutes)
        {

            for (int i = 0; i < minutes; i++)
            {

                if (ac.TickTock())
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine(ac + "    RING!! RING!! RING!!");
                }
                else
                {
                    Console.ResetColor();
                    Console.WriteLine(ac);
                }
                    
                
            }

        }

        private static void ViewErrorMessage(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void ViewTestHeader(string header)
        {
            Console.WriteLine(header);
        }
    }
}





                //if (ac.Minute == ac.AlarmMinute && ac.Hour == ac.Alarmhour)
                //{
                //    Console.BackgroundColor = ConsoleColor.Blue;
                //    Console.WriteLine("\r{0}", ac);
                //    Console.ResetColor();
                //}