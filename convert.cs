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
        Console.WriteLine("exception, red");
        throw;
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

        }
    }
}
