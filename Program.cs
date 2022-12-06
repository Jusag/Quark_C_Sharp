using System;

namespace testing
{
    class testingMainClass
    {
        static void Main(string[] args)
        {
            page_21_1 auxC = new page_21_1(); //Change CLASS for the number of the exercise
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

    class page_13_1
    {
        private string name = "";
        private int age, salary;
        public void exercise()
        {
            Console.WriteLine("Please enter the name of the new employee");
            name = Console.ReadLine();
            Console.WriteLine("Please enter the age of the " + name);
            string auxLocal = Console.ReadLine();
            age = int.Parse(auxLocal);
            Console.WriteLine("Finally enter the salary of " + name);
            auxLocal = Console.ReadLine();
            salary = int.Parse(auxLocal);
            if (salary > 3000)
            {
                Console.WriteLine("The new employee " + name + " with age " + age + " must pay taxes because the salary is above 3000");
            }
            else
            {
                Console.WriteLine("The new employee " + name + " with age " + age + " don't pay taxes because the salary is under or equal to 3000");
            }
        }
    }

    class page_15_1
    {
        public void exercise()
        {
            Console.WriteLine("Enter 8 int number for the vector separated with ENTER key");
            int[] vectorLocal = new int[8];
            string auxControlstringEntered;
            for (int i = 0; i < vectorLocal.Length; i++)
            {
                auxControlstringEntered = Console.ReadLine();
                vectorLocal[i] = int.Parse(auxControlstringEntered);
            }
            Console.WriteLine();
            Console.Write("The values of de vector are ");
            for (int i = 0; i < vectorLocal.Length; i++)
            {
                if (i != 7)
                {
                    Console.Write(vectorLocal[i] + " ");
                }
                else
                {
                    Console.WriteLine(vectorLocal[i]);
                }
            }
            Console.WriteLine();
            int totalSum = 0;
            for (int i = 0; i < vectorLocal.Length; i++)
            {
                totalSum += vectorLocal[i];
                if (i == vectorLocal.Length - 1)
                {
                    Console.WriteLine("The sum of all values is " + totalSum);
                }
            }
            Console.WriteLine();
            totalSum = 0;
            for (int i = 0; i < vectorLocal.Length; i++)
            {
                if (vectorLocal[i] > 36)
                {
                    totalSum += vectorLocal[i];
                }
                if (i == vectorLocal.Length - 1)
                {
                    Console.WriteLine("The sum of all values above 36 is " + totalSum);
                }
            }
            Console.WriteLine();
            totalSum = 0;
            for (int i = 0; i < vectorLocal.Length; i++)
            {
                if (vectorLocal[i] > 50)
                {
                    totalSum++;
                }
                if (i == vectorLocal.Length - 1)
                {
                    Console.WriteLine("In the vector there are " + totalSum + " values above 50");
                }
            }
        }
    }


    class page_16_1
    {
        public void exercise()
        {
            Console.WriteLine("Enter the number of total values for the vector");
            string auxStringRead = Console.ReadLine();
            int[] vector = new int[int.Parse(auxStringRead)];
            int totalSum = 0;
            Console.WriteLine("Enter the values for the vector separated with ENTER key");
            for (int i = 0; i < vector.Length; i++)
            {
                auxStringRead = Console.ReadLine();
                vector[i] = int.Parse(auxStringRead);
                totalSum += vector[i];
                if (i == vector.Length - 1)
                {
                    Console.WriteLine("The sum of all values is " + totalSum);
                }
            }
        }
    }

    class page_20_1
    {
        string[] countrys;
        int[] population;
        public page_20_1() //constructor
        {
            countrys = new string[5];
            population = new int[5];
        }
        public void exercise()
        {
            string auxControlString;
            for (int i = 0; i < countrys.Length; i++)
            {
                Console.Write("Enter the country name: ");
                countrys[i] = Console.ReadLine();
                Console.Write("Enter the population of: " + countrys[i] + ": ");
                auxControlString = Console.ReadLine();
                population[i] = int.Parse(auxControlString);
            }
            //Name Control
            for (int i = 0; i < countrys.Length; i++)
            {
                for (int j = 0; j < countrys.Length - i; j++)
                {
                    if (j < countrys.Length - 1)
                    {
                        if (string.Compare(countrys[j], countrys[j + 1]) == 1)
                        {
                            string auxCountry = countrys[j];
                            int auxPopulation = population[j];
                            countrys[j] = countrys[j + 1];
                            population[j] = population[j + 1];
                            countrys[j + 1] = auxCountry;
                            population[j + 1] = auxPopulation;
                        }
                    }
                }
            }
            Console.WriteLine("Alphabetical order ");
            for (int i = 0; i < countrys.Length; i++)
            {
                Console.Write(countrys[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < countrys.Length; i++)
            {
                for (int j = 0; j < countrys.Length - i; j++)
                {
                    if (j < countrys.Length - 1)
                    {
                        if (population[j] > population[j + 1])
                        {
                            string auxCountry = countrys[j];
                            int auxPopulation = population[j];
                            countrys[j] = countrys[j + 1];
                            population[j] = population[j + 1];
                            countrys[j + 1] = auxCountry;
                            population[j + 1] = auxPopulation;
                        }
                    }
                }
            }
            Console.WriteLine("Population order");
            for (int i = 0; i < countrys.Length; i++)
            {
                Console.Write(countrys[i] + " ");

            }
        }
    }

    class page_21_1
    {
        private int[,] matriz;
        public page_21_1()
        {
            matriz = new int[2, 5];
        }
        public void exercise()
        {
            //Console.WriteLine(matriz.GetLength(0));
            //Console.WriteLine(matriz.GetLength(1));
            Console.WriteLine("Enter values for the matriz 2x5");
            string auxControlstringEntered;
            for (int y = 0; y < matriz.GetLength(1); y++)
            {
                for (int x = 0; x < matriz.GetLength(0); x++)
                {
                    auxControlstringEntered = Console.ReadLine();
                    matriz[x, y] = int.Parse(auxControlstringEntered);
                }
            }
            Console.WriteLine("The Matriz is...");
            for (int x = 0; x < matriz.GetLength(0); x++)
            {
                for (int y = 0; y < matriz.GetLength(1); y++)
                {
                    Console.Write(matriz[x, y] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}