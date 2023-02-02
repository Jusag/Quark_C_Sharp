using System;

namespace testing
{
    class testingMainClass
    {
        static void Main(string[] args)
        {
            page_52_1 auxC = new page_52_1(); //Change CLASS for the number of the exercise
            auxC.exercise();
        }
    }
    /* Template for exercises
    class page_X_x
    {
        public void exercise()
        {
            
        }
    }
    */
    class firstExample
    {
        public void exercise()
        {
            Console.WriteLine("Hello, World!");
        }
    }

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
            Console.WriteLine("Enter values for the matrix 2x5");
            string auxControlstringEntered;
            for (int y = 0; y < matriz.GetLength(1); y++)
            {
                for (int x = 0; x < matriz.GetLength(0); x++)
                {
                    auxControlstringEntered = Console.ReadLine();
                    matriz[x, y] = int.Parse(auxControlstringEntered);
                }
            }
            Console.WriteLine("The Matrix is...");
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

    /*
    Se desea saber la temperatura media trimestral de cuatro paises. Para ello se tiene como dato las temperaturas medias mensuales de dichos paises.
    Se debe ingresar el nombre del país y seguidamente las tres temperaturas medias mensuales.
    Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en memoria.
    * a - Cargar por teclado los nombres de los paises y las temperaturas medias mensuales.
    * b - Imprimir los nombres de las paises y las temperaturas medias mensuales de las mismas.
    * c - Calcular la temperatura media trimestral de cada país.
    * d - Imprimir los nombres de los paises y las temperaturas medias trimestrales.
    e - Imprimir el nombre del país con la temperatura media trimestral mayor.
    */

    class page_23_1
    {
        private string[] country;
        private float[,] temperature;
        private float[] averageTemperature;

        public page_23_1()
        {
            country = new string[4];
            temperature = new float[4, 3];
            averageTemperature = new float[4];
            for (int i = 0; i < averageTemperature.Length; i++)
            {
                averageTemperature[i] = 0;
            }
        }
        public void exercise()
        {
            string auxControlstringEntered;
            for (int c = 0; c < country.Length; c++)
            {
                Console.WriteLine("Enter Country name:");
                country[c] = Console.ReadLine();
                for (int t = 0; t < temperature.GetLength(1); t++)
                {
                    Console.WriteLine("Enter " + (t + 1) + "° " + "temperature");
                    auxControlstringEntered = Console.ReadLine();
                    temperature[c, t] = int.Parse(auxControlstringEntered);
                    averageTemperature[c] += temperature[c, t];
                }
                averageTemperature[c] = averageTemperature[c] / 3f;
            }
            //all temperatures 
            for (int c = 0; c < country.Length; c++)
            {
                Console.WriteLine("The country " + country[c] + " has this temperatures ");
                for (int t = 0; t < temperature.GetLength(1); t++)
                {
                    Console.Write(temperature[c, t] + " ");
                }
                Console.WriteLine();
            }
            //average temperature
            for (int c = 0; c < country.Length; c++)
            {
                Console.WriteLine("The country " + country[c] + " has " + averageTemperature[c] + " average temperature");
            }
            //the country with the most average temperature
            float tempControl = 0;
            int countryIndex = 0;
            for (int i = 0; i < country.Length; i++)
            {
                for (int j = 0; j < country.Length - i; j++)
                {
                    if (averageTemperature[j] > tempControl)
                    {
                        tempControl = averageTemperature[j];
                        countryIndex = j;
                    }
                }
            }
            Console.WriteLine("The country " + country[countryIndex] + " has the most average temperature and is " + averageTemperature[countryIndex]);
        }
    }

    class page_26_1
    {
        public void exercise()
        {
            club nuevoClub = new club();
            string auxControlStringName, auxControlStringAntiquity;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the name of member " + (i + 1));
                auxControlStringName = Console.ReadLine();
                Console.WriteLine("Enter the antiquity of member " + (i + 1));
                auxControlStringAntiquity = Console.ReadLine();
                club_member auxMember = new club_member(auxControlStringName, int.Parse(auxControlStringAntiquity));
                nuevoClub.addMember(auxMember);
            }
            nuevoClub.printAllMembers();
            Console.WriteLine(); Console.WriteLine();
            nuevoClub.moreAntiquity();
        }
        class club
        {
            private club_member[] members;
            public club()
            {
                members = new club_member[3];
            }
            public void addMember(club_member auxClub_Member)
            {
                bool added = false;
                for (int i = 0; i < members.Length; i++)
                {
                    if (added == false && members[i] == null)
                    {
                        members[i] = auxClub_Member;
                        added = true;
                    }
                }
            }
            public void printAllMembers()
            {
                for (int i = 0; i < members.Length; i++)
                {
                    Console.WriteLine("Member " + (i + 1) + "°" + " the name is " + members[i].memberName() + " and antiquity is " + members[i].memberAntiquity());
                }
            }
            public void moreAntiquity()
            {
                int auxAntiquityControl = 0;
                int auxAntiquityIndex = 0;
                for (int i = 0; i < members.Length; i++)
                {
                    if (auxAntiquityControl < members[i].memberAntiquity())
                    {
                        auxAntiquityIndex = i;
                    }
                }
                Console.WriteLine("The member with more antiquity is " + members[auxAntiquityIndex].memberName() + " with " + members[auxAntiquityIndex].memberAntiquity() + " years");

                //Testing getter setter
                //members[0].Antiquity = 20;
                //Console.WriteLine(members[0].Antiquity);

            }
        }
        class club_member
        {
            private string name;
            private int antiquity;
            public club_member(string name, int antiquity)
            {
                this.name = name;
                this.antiquity = antiquity;
            }
            public string memberName()
            {
                return name;
            }
            public int memberAntiquity()
            {
                return antiquity;
            }
            public int Antiquity
            {
                set
                {
                    antiquity = value;
                }
                get
                {
                    return antiquity;
                }
            }
        }
    }
    class page_29_1 //Herencia - inheritance
    {
        public void exercise()
        {
            C aux = new C();
        }
        class A
        {
            public A()
            {
                Console.WriteLine("We are in A");
            }
        }
        class B : A
        {
            public B()
            {
                Console.WriteLine("We are in B");
            }
        }
        class C : B
        {
            public C()
            {
                Console.WriteLine("We are in C");
            }
        }
    }

    class page_43_1
    {
        public void exercise()
        {
            Stack newStack = new Stack();
            newStack.addNode(8);
            newStack.addNode(3);
            newStack.addNode(9);
            newStack.addNode(1);
            newStack.printStack();
            newStack.extractNode();
            newStack.printStack();
        }

        class Stack
        {
            class Node
            {
                public int value;
                public Node next;
            }

            private Node node;

            public Stack()
            {
                node = null;
            }

            public void addNode(int x)
            {
                Node auxNode = new Node();
                auxNode.value = x;
                if (node == null)
                {
                    auxNode.next = null;
                    node = auxNode;
                }
                else
                {
                    auxNode.next = node;
                    node = auxNode;
                }
            }
            public int extractNode()
            {
                int info;

                if (node != null)
                {
                    info = node.value;
                    node = node.next;
                    return info;
                }
                else
                {
                    return int.MaxValue;
                }
            }
            public void printStack()
            {
                while (node != null)
                {
                    Console.Write(node.value + " ");
                    extractNode();
                }
                Console.WriteLine(" This is all values");
            }
        }
    }

    class page_45_1
    {
        public void exercise()
        {
            Stack newStack = new Stack();
            newStack.addNode(8);
            newStack.addNode(3);
            newStack.addNode(9);
            newStack.addNode(1);
            newStack.printStack();
            newStack.extractNode();
            newStack.printStack();
        }
        class Stack
        {
            class Node
            {
                public int value;
                public Node next;
            }

            private Node rooting, last;

            public Stack()
            {
                rooting = null;
                last = null;
            }

            public void addNode(int x)
            {
                Node newNode = new Node();
                newNode.value = x;
                newNode.next = null;
                if (rooting == null)
                {
                    rooting = newNode;
                    last = newNode;
                }
                else
                {
                    last.next = newNode;
                    last = newNode;
                }
            }

            public int extractNode()
            {
                if (emptyStack())
                {
                    return int.MaxValue;
                }
                else
                {
                    int auxControl = rooting.value;
                    rooting = rooting.next;
                    return auxControl;
                }
            }

            public void printStack()
            {
                Node auxControl = rooting;
                while (auxControl != null)
                {
                    Console.Write(auxControl.value + " ");
                    auxControl = auxControl.next;
                }
                Console.WriteLine();
            }

            public bool emptyStack()
            {
                return rooting == null;
            }
        }
    }

    class page_47_1
    {
        public void exercise()
        {
            Stack newStack = new Stack();
            newStack.addNode(0, 8);
            newStack.addNode(1, 3);
            newStack.addNode(5, 9);
            newStack.addNode(3, 1);
            newStack.printStack();
            newStack.extractNode(2);
            newStack.printStack();
        }

        class Stack
        {
            class Node
            {
                public int value;
                public Node nextNode;
            }

            Node rooting;

            public Stack()
            {
                rooting = null;
            }

            public void addNode(int position, int newValueInNode)
            {
                Node auxNodeNew = new Node();
                auxNodeNew.value = newValueInNode;
                auxNodeNew.nextNode = null;
                if (rooting == null)
                {
                    rooting = auxNodeNew;
                    Console.WriteLine("We add the first one");
                }
                else
                {
                    Node auxNodeIndex = rooting;
                    if (position < stackLenght())
                    {
                        if (position == 0)
                        {
                            auxNodeNew.nextNode = rooting;
                            rooting = auxNodeNew;
                        }
                        else
                        {
                            for (int i = 0; i < position; i++)
                            {
                                if (i == (position - 1))
                                {
                                    auxNodeNew.nextNode = auxNodeIndex.nextNode;
                                    auxNodeIndex.nextNode = auxNodeNew;
                                }
                                if (i != 0)
                                {
                                    auxNodeIndex = auxNodeIndex.nextNode;
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("The position it's our of range...we add to last");
                        Node lastNodeAlive = auxNodeIndex;
                        while (auxNodeIndex != null)
                        {
                            lastNodeAlive = auxNodeIndex;
                            auxNodeIndex = auxNodeIndex.nextNode;
                        }
                        lastNodeAlive.nextNode = auxNodeNew;
                    }
                }
            }

            public int extractNode(int position)
            {
                int aux = int.MinValue;
                Node auxNodeIndex = rooting;
                if (position == 0)
                {
                    int auxInt = rooting.value;
                    rooting = rooting.nextNode;
                    return auxInt;
                }
                else
                {
                    if (position < stackLenght())
                    {
                        for (int i = 0; i < stackLenght(); i++)
                        {
                            if (i == position - 1)
                            {
                                aux = auxNodeIndex.nextNode.value;
                                auxNodeIndex.nextNode = auxNodeIndex.nextNode.nextNode;
                                break;
                            }

                            if (i != 1)
                            {
                                auxNodeIndex = auxNodeIndex.nextNode;
                            }
                        }
                    }
                }
                return aux;
            }

            public void printStack()
            {
                Node auxControl = rooting;
                while (auxControl != null)
                {
                    Console.Write(auxControl.value + " ");
                    auxControl = auxControl.nextNode;
                }
                Console.WriteLine();
            }

            public int stackLenght()
            {
                int totalLenght = 0;
                Node aux = rooting;
                while (aux != null)
                {
                    totalLenght++;
                    aux = aux.nextNode;
                }
                return totalLenght;
            }

            public bool empty()
            {
                return rooting == null;
            }
        }
    }


    class page_49_1
    {
        public void exercise()
        {
            Stack newStack = new Stack();
            newStack.addNode(9, 8);
            newStack.addNode(9, 3);
            newStack.addNode(9, 9);
            newStack.addNode(9, 1);
            newStack.printStack();
            newStack.extractNode(2);
            newStack.swapNodes(0, 1);
            newStack.printStack();
        }

        public class Stack
        {
            public class Node
            {
                public int value;
                public Node back, next;
                public Node()
                {
                    back = null;
                    next = null;
                    //value it's unassigned
                }
            }

            private Node rooting;

            public Stack()
            {
                rooting = null;
            }

            public void addNode(int position, int value)
            {
                Node auxNewNode = new Node();
                auxNewNode.value = value;

                Node auxIndexNode = rooting;

                if (emptyStack())
                {
                    rooting = auxNewNode;
                }
                else
                {
                    if (position == 0)
                    {
                        auxNewNode.next = rooting;
                        rooting = auxNewNode;
                        auxNewNode.next.back = auxNewNode;
                    }
                    else
                    {
                        if (position > stackLenght())   //if position it's wrong
                        {
                            Console.WriteLine("It's over the actual lenght, we add to last...");

                            while (auxIndexNode.next != null)
                            {
                                auxIndexNode = auxIndexNode.next;
                            }
                            auxNewNode.back = auxIndexNode;
                            auxIndexNode.next = auxNewNode;
                            //In case it's the last Node.next = rooting and in the case doble rooting.back = Node.next 
                        }
                        else
                        {
                            for (int i = 0; i < stackLenght(); i++)
                            {
                                if (i == position)
                                {
                                    auxNewNode.next = auxIndexNode;
                                    auxNewNode.back = auxIndexNode.back;
                                    auxIndexNode.back = auxNewNode;
                                    auxNewNode.back.next = auxNewNode;
                                }
                                else
                                {
                                    auxIndexNode = auxIndexNode.next;
                                }
                            }
                        }
                    }
                }
            }

            public int extractNode(int position)
            {
                int value = int.MinValue;
                Node auxNodeIndex = rooting;
                if (!emptyStack() && position < stackLenght())
                {
                    for (int i = 0; i < stackLenght(); i++)
                    {
                        if (i == position)
                        {
                            value = auxNodeIndex.value;
                            Node auxNodeBack = auxNodeIndex.back;
                            auxNodeBack.next = auxNodeIndex.next;
                        }
                        else
                        {
                            auxNodeIndex = auxNodeIndex.next;
                        }
                    }
                }
                return value;
            }

            public void deleteNode(int position)
            {
                Node auxNodeIndex = rooting;
                if (!emptyStack() && position < stackLenght())
                {
                    for (int i = 0; i < stackLenght(); i++)
                    {
                        if (i == position)
                        {
                            auxNodeIndex.back.next = auxNodeIndex.next;
                            auxNodeIndex.next.back = auxNodeIndex.back;
                        }
                        else
                        {
                            auxNodeIndex = auxNodeIndex.next;
                        }
                    }
                }
            }

            public void swapNodes(int positionOne, int positionTwo)
            {
                if (positionOne < stackLenght() && positionTwo < stackLenght())
                {
                    Node auxPositionOne = null;
                    Node auxPositionTwo = null;
                    Node auxNodeIndex;
                    auxNodeIndex = rooting;

                    for (int i = 0; i < stackLenght(); i++)
                    {
                        if (i == positionOne)
                        {
                            auxPositionOne = auxNodeIndex;
                            Console.WriteLine(auxPositionOne.value);
                        }
                        else
                        {
                            if (i == positionTwo)
                            {
                                auxPositionTwo = auxNodeIndex;
                                Console.WriteLine(auxPositionTwo.value);
                            }
                        }
                        auxNodeIndex = auxNodeIndex.next;
                    }
                    Node auxNodeNewC = new Node();
                    if (positionOne == 0)
                    {
                        auxNodeNewC.next = auxPositionOne.next;
                        auxNodeNewC.next.back = auxNodeNewC; //new Rooting

                        auxPositionOne.next = auxPositionTwo.next;
                        auxPositionOne.back = auxPositionTwo.back;
                        auxPositionOne.next.back = auxPositionOne;
                        auxPositionOne.back.next = auxPositionOne;

                        auxPositionTwo.next = auxNodeNewC.next;
                        auxPositionTwo.next.back = auxPositionTwo;
                        rooting = auxPositionTwo;
                    }
                    else
                    {
                        auxNodeNewC.next = auxPositionOne.next;
                        auxNodeNewC.back = auxPositionOne.back;
                        auxNodeNewC.next.back = auxNodeNewC;
                        auxNodeNewC.back.next = auxNodeNewC;

                        auxPositionOne.next = auxPositionTwo.next;
                        auxPositionOne.back = auxPositionTwo.back;
                        auxPositionOne.next.back = auxPositionOne;
                        auxPositionOne.back.next = auxPositionOne;

                        auxPositionTwo.next = auxNodeNewC.next;
                        auxPositionTwo.back = auxNodeNewC.back;
                        auxPositionTwo.next.back = auxPositionTwo;
                        auxPositionTwo.back.next = auxPositionTwo;
                    }
                }
            }

            public int maxValueOnStack()
            {
                int maxValue = int.MinValue;
                Node auxNodeIndex = rooting;
                while (auxNodeIndex != null)
                {
                    if (auxNodeIndex.value > maxValue)
                    {
                        maxValue = auxNodeIndex.value;
                    }
                    else
                    {
                        auxNodeIndex = auxNodeIndex.next;
                    }
                }
                return maxValue;
            }

            public int maxPositionWithMaxValue()
            {
                int maxValue = int.MinValue;
                int position = 0;
                Node auxNodeIndex = rooting;
                for (int i = 0; i < stackLenght(); i++)
                {
                    if (auxNodeIndex.value > maxValue)
                    {
                        maxValue = auxNodeIndex.value;
                        position = i;
                    }
                    else
                    {
                        auxNodeIndex = auxNodeIndex.next;
                    }
                }
                return position;
            }

            public int stackLenght()
            {
                int counter = 0;
                Node auxNodeIndex = rooting;
                while (auxNodeIndex != null)
                {
                    counter++;
                    auxNodeIndex = auxNodeIndex.next;
                }
                return counter;
            }

            public bool existValueInNode(int x)
            {
                bool exist = false;
                Node auxNodeIndex = rooting;
                while (auxNodeIndex != null && exist == false)
                {
                    if (auxNodeIndex.value == x)
                    {
                        exist = true;
                    }
                    else
                    {
                        auxNodeIndex = auxNodeIndex.next;
                    }
                }
                return exist;
            }

            public bool emptyStack()
            {
                return rooting == null;
            }

            public void printStack()
            {
                Node auxNodeIndex = rooting;
                while (auxNodeIndex != null)
                {
                    Console.Write(auxNodeIndex.value + " ");
                    auxNodeIndex = auxNodeIndex.next;
                }
                Console.WriteLine();
            }
        }
    }

    class page_51_1
    {
        public void exercise()
        {
            recursion auxRecursion = new recursion();
            Console.WriteLine("Factor of 10 is : " + auxRecursion.factorial(10));
        }

        class recursion
        {
            public int factorial(int value)
            {
                int aux = 1;
                if (value > 0)
                {
                    aux *= value;
                    aux = aux * factorial(value - 1);
                }
                return aux;
            }
        }
    }

    class page_52_1
    {
        public void exercise()
        {
            Stack newStack = new Stack();
            newStack.addNode(8);
            newStack.addNode(3);
            newStack.addNode(9);
            newStack.addNode(1);
            newStack.addNode(55);
            newStack.addNode(100);
            newStack.addNode(7);
            newStack.addNode(84);
            Node auxNode = newStack.localNodeReturn();
            newStack.printStack();
            newStack.recurReversePrint(auxNode);
        }

        class Node
        {
            public int value;
            public Node next;
        }

        class Stack
        {
            private Node node;

            public Stack()
            {
                node = null;
            }

            public void addNode(int x)
            {
                Node auxNode = new Node();
                auxNode.value = x;
                if (node == null)
                {
                    auxNode.next = null;
                    node = auxNode;
                }
                else
                {
                    auxNode.next = node;
                    node = auxNode;
                }
            }

            public int extractNode()
            {
                int info;

                if (node != null)
                {
                    info = node.value;
                    node = node.next;
                    return info;
                }
                else
                {
                    return int.MaxValue;
                }
            }

            public void recurReversePrint(Node reco)
            {
                if (reco.next != null)
                {
                    recurReversePrint(reco.next);
                }
                Console.Write(reco.value + " ");
            }

            public Node localNodeReturn()
            {
                return node;
            }

            public void printStack()
            {
                while (node != null)
                {
                    Console.Write(node.value + " ");
                    extractNode();
                }
                Console.WriteLine(" This is all values");
            }
        }
    }



}