using System;

namespace testing
{
    class testingMainClass
    {
        static void Main(string[] args)
        {
            page_7_4 auxC = new page_7_4(); //Change CLASS for the number of the exercise
            auxC.exercise();
        }
    }
    class firstExample
    {
        public void exercise()
        {
            Console.WriteLine("Hello, World!");
        }
    }
    /*
    class page_6_3
    {
        public void exercise()
        {
            
        }
    }
    */

    class page_5_1
    {
        public void exercise()
        {
            Console.WriteLine("Please, enter an int value not null");
            string aux = Console.ReadLine();
            int int_aux = 0;
            if (aux != null)
            {
                int_aux = int.Parse(aux);
            }
            Console.WriteLine("The primeter of the cube is: " + int_aux * 4);
        }
    }

    class page_5_2
    {
        public void exercise()
        {
            Console.WriteLine("Enter 4 int values not nulls separated with the ENTER key");
            int int_aux_1 = 0;
            int int_aux_2 = 0;
            int int_aux_3 = 0;
            int int_aux_4 = 0;
            string auxControl = Console.ReadLine();
            if (auxControl != null)
            {
                int_aux_1 = int.Parse(auxControl);
            }
            auxControl = Console.ReadLine();
            if (auxControl != null)
            {
                int_aux_2 = int.Parse(auxControl);
            }
            auxControl = Console.ReadLine();
            if (auxControl != null)
            {
                int_aux_3 = int.Parse(auxControl);
            }
            auxControl = Console.ReadLine();
            if (auxControl != null)
            {
                int_aux_4 = int.Parse(auxControl);
            }
            Console.WriteLine("The sum of first and second values is: " + (int_aux_1 + int_aux_2) + " the multiplication of the third and fourth values is: " + (int_aux_3 * int_aux_4));
        }
    }

    class page_6_3
    {
        public void exercise()
        {
            Console.WriteLine("Enter an int number between 1..99");
            string auxControl = Console.ReadLine();
            int aux = int.Parse(auxControl);
            if (aux / 10 > 0)
            {
                Console.WriteLine("Your number has 2 digits");
            }
            else
            {
                Console.WriteLine("Your number has 1 digits");
            }
        }
    }

    class page_7_4
    {
        public void exercise()
        {
            Console.WriteLine("Insert number of total questions and number answered correct by candidate separated by ENTER key");
            string auxControl = Console.ReadLine();
            int totalQuestions = int.Parse(auxControl);
            auxControl = Console.ReadLine();
            int answeredCorrect = int.Parse(auxControl);
            float percent = answeredCorrect * 100f / totalQuestions;
            if (percent >= 90)
            {
                Console.WriteLine("Your level is Maximum");
            }
            else
            {
                if (percent >= 75 && percent < 90)
                {
                    Console.WriteLine("Your level is Middle");
                }
                else
                {
                    if (percent >= 50 && percent < 75)
                    {
                        Console.WriteLine("Your level is Regular");
                    }
                    else
                    {
                        if (percent < 50)
                        {
                            Console.WriteLine("Your level is Under Required");
                        }
                    }
                }
            }
        }
    }




}