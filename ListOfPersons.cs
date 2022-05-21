using System;
using System.Collections.Generic;


namespace TestImageFactory
{
    class ListOfPersons //Class that realize list of working persons
    {
        protected List<Person> listOfPersons;
        public List<Person> ListOfPersonsGS
        {
            get
            {
                return listOfPersons;
            }
            set
            {
                listOfPersons = value;
            }
        }

        internal List<Person> ListCreation()//Creating list method
        {
            uint? numImg;
            uint? time;
            List<Person> listOfPersons = new List<Person>();//initialization of list
            while (true)//Block for creating a list and providing the values ​​of the fields of Person`s objects
            {
                Console.WriteLine("\nAdd new person?\n1)Yes\t2)No");
            AnswerToCreate:
                switch (Console.ReadKey().KeyChar)
                {
                    case '1':

                        Console.WriteLine("\nInput number of images that this person edit");
                        while (true)// Unit for entering user information about the number of images for person
                        {           //that you add
                            try
                            {
                                numImg = uint.Parse(Console.ReadLine());
                                if (numImg is null)
                                {
                                    Console.WriteLine("Please input positive integer number.");
                                    continue;
                                }
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Incorect data! Please input integer number.");
                            }
                        }//End of unit
                        Console.WriteLine("\nInput how much time this person needs to edit such number of images");
                        while (true)// Unit for entering user information about the time person needs to edit
                        {           //his number of images
                            try
                            {
                                time = uint.Parse(Console.ReadLine());
                                if (time is null)
                                {
                                    Console.WriteLine("Please input positive integer number.");
                                    continue;
                                }
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Incorect data! Please input integer number.");
                            }
                        }//End of unit

                        listOfPersons.Add(new Person(numImg, time));//Add new person to your list of workers

                        break;

                    case '2':
                        return listOfPersons;// Returns list of person in main to operate with it


                    default:
                        Console.WriteLine("\nPlease, choose corect answer - input 1 or 2");

                        goto AnswerToCreate;

                }
            }
        }

        internal float? TotalCalculation(uint? totalNumOfImgT)//Counting time that crew needs to edit total number of images
        {
            float? result = 0.0f;

            foreach (Person person in listOfPersons)
            {
                result = result + person.DivisionRes;
            }
            result = 1 / result * totalNumOfImgT;
            Console.WriteLine("\nThis crew needs " + result + " minutes to edit " + totalNumOfImgT + " images ");//Display result
            return result;
        }
    }
}
