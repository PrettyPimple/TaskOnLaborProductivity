using System;

namespace TestImageFactory
{
    class Program
    {
        static void Main(string[] args)//Start of program
        {
            uint? totalNumOfImages;// Total number of images that we need to edit
            Console.Write("Input total number of needed images: ");
            while (true)// Unit for entering user information about the total number of images
            {
                try
                {
                    totalNumOfImages = uint.Parse(Console.ReadLine());
                    if(totalNumOfImages is null)
                    {
                        Console.WriteLine("Please input positive integer number.");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Incorect data! Please input positive integer number.");
                    
                }
            }//End of unit

            ListOfPersons list = new ListOfPersons();//List announcement
            list.ListOfPersonsGS = list.ListCreation();//Adding persons who editing images
            float? result = list.TotalCalculation(totalNumOfImages);//Counting time persons need to edit images
            for (int i = 0; i<list.ListOfPersonsGS.Count; i++)//Cycle for counting total number of edited images  
            {                                                 //for any person
                Console.WriteLine("\nPerson "+(i+1)+": edited "                             //Display the result
                    + list.ListOfPersonsGS[i].SeparateCalc(result)                          //of each person's
                    + " ("+list.ListOfPersonsGS[i].AccuracySeparateCalc(result)+") images");//work
            }
            Console.ReadKey();
        }    
    }


    

    
}
    
