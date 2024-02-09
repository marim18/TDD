// See https://aka.ms/new-console-template for more information
using System;

namespace converte
{

class program{
    static int Main(string[] args)
    {
       convertfunctions bs = new convertfunctions();
      try
      {
        double number = double.Parse(args[0]);
        string unit = args[1];
        if (unit == bs.t){
            bs.testcases();
        }
        else{
        bs.InchesToXConverter(number,unit);
        }
        
      }
      catch (System.Exception)
      {
        string unit = args[0];
        if(unit == bs.t){
            Console.WriteLine("yellow");
             bs.testcases();
        }
        else{
        Console.WriteLine("exception, red");
        throw;}
      }
     
      return 0;

    }}

    public class convertfunctions
    {
        #region variables
        public string cm = "-cm";
        public string mm = "-mm";
        public string m = "-m";
        public string t = "-t";
        public double constant = 2.54;
        public double output = 0;
        #endregion
       public void InchesToXConverter(double number, String arg)
        {



            if (arg == cm)
            {

                output = number * constant;

            }
            if (arg == mm)
            {
                output = number * (constant * 10);

            }
            if (arg == m)
            {
                output = number * (constant / 10);
            }
            else if(arg == t){
                Console.WriteLine("missing argument of metric, red");
            }
           Console.WriteLine( output);

        }
        public void testcases(){
              //testcases provided by chatgpt
            double input1 = 3;
            double expected1 = 3 * 2.54;
            RunTest(input1, "-cm", expected1);

            double input2 = 3;
            double expected2 = 3 * (2.54 * 10);
            RunTest(input2, "-mm", expected2);

            double input3 = 3;
            double expected3 = 3 * (2.54 / 100);
            RunTest(input3, "-m", expected3);

           
            double input4 = 3;
            RunTest(input4, "-t", -1);
        }
        public void RunTest(double input, string arg, double expected){
             try
            {
                InchesToXConverter(input, arg);

                // Check if the output matches the expected value
                if (output == expected)
                {
                    Console.WriteLine("Test passed: green");
                }
                else
                {
                    Console.WriteLine("Test failed: red");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test failed: {ex.Message}, red");
            }
        }
    }
}
