using System;

namespace Tournament
{
    class Program
    {
        static void Main(string[] args)
        {




            double numValuesToRead = double.Parse(Console.ReadLine());
            double previousSum = 0;
            double sum = 0;
            
            double maxDiff = 0;
            bool sameSum = true;

            for (int z = 1; z <= numValuesToRead; z++)
            {

                
                    double N1 = double.Parse(Console.ReadLine());
                    double N2 = double.Parse(Console.ReadLine());

                    

                     sum = N1 + N2;


                    if (z == 1)
                    {
                        previousSum = sum;

                       

                    }




                    if (sum != previousSum)
                    {



                    sameSum = false;
                        double diff = Math.Abs(sum -previousSum);

                        if (diff>maxDiff)
                        {
                            maxDiff = diff;
                        }



                    previousSum = sum;

                    

                }
                    

                }





            





            if (sameSum)
            {
                Console.WriteLine($"Yes, value={sum}");
            }

            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
           








        }
    }
}
