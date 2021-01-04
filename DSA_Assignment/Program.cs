using System;
using System.Collections;
using System.Collections.Generic;


using System.Text;


namespace DSA_Assignment
{
    public class Program
    {
        public static void DisplayList(LinkedList<Student> list) //– display all elements of the array
        {
            int compteur = 1;
            int p = 0;
            foreach (Student item in list)
            {
                Console.WriteLine("\n          Student n°" + compteur);
                Console.WriteLine("------------------------------------------------------------");

                Console.WriteLine(" " + item.FirstName + " " + item.LastName + ",  Student Number : " + item.StudentNumber + ",  Average Score : " + item.AverageScore);
                compteur++;
            }
        }

        public static float Score()
        {
            float AverageScore = 0;

            //Creates an array with a given number of scores, adds this score to the array. When all the scores have been entered, calculates and returns the average 

            Console.WriteLine("\n How many scores did this student get ? ");
            int length = int.Parse(Console.ReadLine());
            int[] scores = new int[length];
            int compteur = 1;
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine("\n Score n°" + compteur + " : ");
                int nbr = int.Parse(Console.ReadLine());

                scores[i] = nbr;
                compteur++;
            }

            // goes through the array to calculate the average based on the numbers entered

            float total = 0;
            foreach (var item in scores)
            {
                total += item;
            }
            AverageScore = total / scores.Length;
            return AverageScore;
        }

        public static void Addd(Student student1, LinkedList<Student> CustomDataList) // called Addd to override the function .Add
        {
            CustomDataList.AddFirst(student1);
        }

        public static void PopulateWithSampleData(LinkedList<Student> list)  //Asks and gets all the informations about a student. The student is the added to the custom data list. You can add as many students in the list as you'd like, as long as you don't close and quit the user interface.
        {
            float score1 = 0;
            Console.WriteLine("\nStudent 1 : ");
            Console.WriteLine("\nFirst name");
            string fst = Console.ReadLine();
            Console.WriteLine("\nLast name ?");
            string lst = Console.ReadLine();
            Console.WriteLine("\nStudent number ?");
            string stnbr = Console.ReadLine();

            score1 = Score(); //the average score is directly calculated using the Score() method, and added to the Student as its average score.

            Student student1 = new Student(fst, lst, stnbr, score1);

            Addd(student1, list);
        }

        public static LinkedList<Student> RemoveByIndex(int index, LinkedList<Student> list)
        {
            // transfers all the data from the list to a tab, to be able to go through it and stop at a given index
            Student[]tab = new Student[list.Count];

            list.CopyTo(tab, 0);

            Student[] temptab = new Student[list.Count - 1]; // we create a new temporary table the length of the tab - 1. We copy all the elements from the tab exept the index we want to remove.

            int j = 0;

            for (int i = 0; i < tab.Length; i++)
            {

                if(i != index )
                {
                    temptab[j] = tab[i];
                    j++;
                }
            }

            LinkedList<Student>  list1 = new LinkedList<Student>(temptab); // then we create a new list, copying all the data from the temporary tab in it
            return list1;
        }
        public static void GetElement(int index, LinkedList<Student> list)
        {
            Student[] tab = new Student[list.Count];

            list.CopyTo(tab, 0); // transfers the list data to a tab, to go through the table and search for an index

            for (int i = 0; i < tab.Length; i++)
            {
                if (i == index)
                {
                    Console.WriteLine($"Element at index {index} :\n{ tab[i].FirstName} { tab[i].LastName},  Student number : {tab[i].StudentNumber},  Average Score :{tab[i].AverageScore}");
                }
            }
        }
        public static void RemoveFirst(LinkedList<Student> list)
        {
            list.RemoveFirst();  //using a function implemented in linked lists
        }
        public static void RemoveLast_(LinkedList<Student> list)
        {
            list.RemoveLast(); //using a function implemented in linked lists
        }
        









        public static void GetMinElement(LinkedList<Student> list) //student with lowest score
        {
            Student[] tab = new Student[list.Count];
            list.CopyTo(tab, 0); // transfers the list data to a tab, to go through the table and search for an index

            float score = tab[0].AverageScore;
            int index = 0;

            for (int i = 0; i < tab.Length; i++)
            {
                if(tab[i].AverageScore < score)
                {
                    score = tab[i].AverageScore;
                    index = i;
                }
            }

            Console.WriteLine(" Student with the lowest score : " + tab[index].FirstName + " " + tab[index].LastName + ",  Student Number : " + tab[index].StudentNumber + ",  Average Score : " + tab[index].AverageScore);

        }
        public static void GetMaxElement(LinkedList<Student> list) //student with best score
        {
            Student[] tab = new Student[list.Count];
            list.CopyTo(tab, 0); // transfers the list data to a tab, to go through the table and search for an index

            float score = tab[0].AverageScore;
            int index = 0;

            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i].AverageScore > score)
                {
                    score = tab[i].AverageScore;
                    index = i;
                }
            }
             
            Console.WriteLine(" Student with the highest score : \n" + tab[index].FirstName + " " + tab[index].LastName + ",  Student Number : " + tab[index].StudentNumber + ",  Average Score : " + tab[index].AverageScore);

        }
        public static void Sort_Ascending_First_Name(LinkedList<Student> list)
        {
            Student[] tab = new Student[list.Count];
            string[] stringtab = new string[list.Count];

            list.CopyTo(tab, 0); // transfers the list data to a tab, to go through the table and search for an index

            for (int i = 0; i < tab.Length; i++)
            {
                stringtab[i] = tab[i].FirstName;
            }

            Array.Sort(stringtab);

            Student[] sortedtab = new Student[list.Count];
            for (int i = 0; i < stringtab.Length; i++)
            {
                for (int j = 0; j < sortedtab.Length; j++)
                {
                    if (stringtab[i] == tab[j].FirstName)
                    {
                        sortedtab[i] = tab[j];
                    }
                }
            }

            foreach (Student item in sortedtab)
            {
                Console.WriteLine("Students sorted by first names\n------------------------------------------------------------");

                Console.WriteLine(" " + item.FirstName + " " + item.LastName + ",  Student Number : " + item.StudentNumber + ",  Average Score : " + item.AverageScore);
            }
        }
        public static void Sort_Ascending_Last_Name(LinkedList<Student> list)
        {
            Student[] tab = new Student[list.Count];
            string[] stringtab = new string[list.Count];

            list.CopyTo(tab, 0); // transfers the list data to a tab, to go through the table and search for an index

            for (int i = 0; i < tab.Length; i++)
            {
                stringtab[i] = tab[i].LastName;
            }

            Array.Sort(stringtab);

            Student[] sortedtab = new Student[list.Count];
            for (int i = 0; i < stringtab.Length; i++)
            {
                for (int j = 0; j < sortedtab.Length; j++)
                {
                    if (stringtab[i] == tab[j].LastName)
                    {
                        sortedtab[i] = tab[j];
                    }
                }
            }

            foreach (Student item in sortedtab)
            {
                Console.WriteLine("Students sorted by last names\n------------------------------------------------------------");

                Console.WriteLine(" " + item.FirstName + " " + item.LastName + ",  Student Number : " + item.StudentNumber + ",  Average Score : " + item.AverageScore);
            }
        }
        public static void Sort_Ascending_Student_Number(LinkedList<Student> list)
        {
            Student[] tab = new Student[list.Count];
            float[] floattab = new float[list.Count];

            list.CopyTo(tab, 0); // transfers the list data to a tab, to go through the table and search for an index

            for (int i = 0; i < tab.Length; i++)
            {
                floattab[i] = tab[i].AverageScore;
            }

            Array.Sort(floattab);

            Student[] sortedtab = new Student[list.Count];
            for (int i = 0; i < floattab.Length; i++)
            {
                for (int j = 0; j < sortedtab.Length; j++)
                {
                    if (floattab[i] == tab[j].AverageScore)
                    {
                        sortedtab[i] = tab[j];
                    }
                }
            }

            foreach (Student item in sortedtab)
            {
                Console.WriteLine("Students sorted by first names (ascending)\n------------------------------------------------------------");

                Console.WriteLine(" " + item.FirstName + " " + item.LastName + ",  Student Number : " + item.StudentNumber + ",  Average Score : " + item.AverageScore);
            }
        }
        public static void Sort_Descending_First_Name(LinkedList<Student> list)
        {
            Student[] tab = new Student[list.Count];
            string[] stringtab = new string[list.Count];

            list.CopyTo(tab, 0); // transfers the list data to a tab, to go through the table and search for an index

            for (int i = 0; i < tab.Length; i++)
            {
                stringtab[i] = tab[i].FirstName;
            }

            Array.Sort(stringtab);

            Student[] sortedtab = new Student[list.Count];
         
            for (int i = 0; i < stringtab.Length; i++)
            {
                for (int j = 0 ; j< sortedtab.Length; j++)
                {
                    if (stringtab[i] == tab[j].FirstName)
                    {
                        sortedtab[sortedtab.Length-1 - i] = tab[j];
                    }
                }
            }

            foreach (Student item in sortedtab)
            {
                Console.WriteLine("Students sorted by first names (descending)\n------------------------------------------------------------");

                Console.WriteLine(" " + item.FirstName + " " + item.LastName + ",  Student Number : " + item.StudentNumber + ",  Average Score : " + item.AverageScore);
            }
        }
        public static void Sort_Descending_Last_Name(LinkedList<Student> list)
        {

            Student[] tab = new Student[list.Count];
            string[] stringtab = new string[list.Count];

            list.CopyTo(tab, 0); // transfers the list data to a tab, to go through the table and search for an index

            for (int i = 0; i < tab.Length; i++)
            {
                stringtab[i] = tab[i].LastName;
            }

            Array.Sort(stringtab);

            Student[] sortedtab = new Student[list.Count];

            for (int i = 0; i < stringtab.Length; i++)
            {
                for (int j = 0; j < sortedtab.Length; j++)
                {
                    if (stringtab[i] == tab[j].LastName)
                    {
                        sortedtab[sortedtab.Length - 1 - i] = tab[j];
                    }
                }
            }

            foreach (Student item in sortedtab)
            {
                Console.WriteLine("Students sorted by last names (descending)\n------------------------------------------------------------");

                Console.WriteLine(" " + item.FirstName + " " + item.LastName + ",  Student Number : " + item.StudentNumber + ",  Average Score : " + item.AverageScore);
            }
        }
        public static void Sort_Descending_Student_Number(LinkedList<Student> list)
        {
            Student[] tab = new Student[list.Count];
            float[] floattab = new float[list.Count];

            list.CopyTo(tab, 0); // transfers the list data to a tab, to go through the table and search for an index

            for (int i = 0; i < tab.Length; i++)
            {
                floattab[i] = tab[i].AverageScore;
            }

            Array.Sort(floattab);

            Student[] sortedtab = new Student[list.Count];

            for (int i = 0; i < floattab.Length; i++)
            {
                for (int j = 0; j < sortedtab.Length; j++)
                {
                    if (floattab[i] == tab[j].AverageScore)
                    {
                        sortedtab[sortedtab.Length - 1 - i] = tab[j];
                    }
                }
            }

            foreach (Student item in sortedtab)
            {
                Console.WriteLine("Students sorted by their average score (descending)\n------------------------------------------------------------");

                Console.WriteLine(" " + item.FirstName + " " + item.LastName + ",  Student Number : " + item.StudentNumber + ",  Average Score : " + item.AverageScore);
            }
        }





        public static void Main(string[] args)
        {
            LinkedList<Student> CustomDataList = new LinkedList<Student>();

               ConsoleKeyInfo cki;
                do
                {
                    Console.Clear();
                    Console.WriteLine( "\n\n 1 : Populate with sample data (creates and adds a student to the list)"
                                       + "\n 2 : Get element by index"
                                       + "\n 3 : Remove by index"
                                       + "\n 4 : Remove first element"
                                       + "\n 5 : Remove last element"
                                       + "\n 6 : Display list\n\n"


                                                                                             + "\n 7 : Get min element (based on average scores) "
                                                                             + "\n 8 : Get max element (based on average score) "
                               + "\n\n 9 : Ascending : Sort by last names "
                        + "\n 10 : Ascending : Sort by last names "
                                                                              + "\n 11 : Ascending : Sort by average scores "
                                                                                   + "\n\n 12 : Descending : Sort by first names "
                                                                              + "\n 13 : Descending : Sort by last names "
                                                                              + "\n 14 : Descending : Sort by average scores"





                                       + "\n *The custom data list doesn't change until the user quits the interface*"
                                       

                                       + "\n\n Please choose : ");
                    int exo = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (exo)
                    {
                   

                        case 1:

                        PopulateWithSampleData(CustomDataList);
                        break;

                        case 2:

                        Console.WriteLine("index?");
                        int index3 = int.Parse(Console.ReadLine());
                        GetElement(index3, CustomDataList);
                        break;

                        case 3:

                        Console.WriteLine("index?");
                        int index2 = int.Parse(Console.ReadLine());
                        CustomDataList = RemoveByIndex(index2, CustomDataList);
                        break;

                        case 4:

                        RemoveFirst(CustomDataList);
                        break;
                         
                        case 5:

                        RemoveLast_(CustomDataList);

                        break;

                        case 6:

                        // displays all the elements from the list
                        DisplayList(CustomDataList);
                        break;

                        case 7:
                        GetMinElement(CustomDataList);
                        break;

                    case 8:
                        GetMaxElement(CustomDataList);
                        break;

                    case 9:
                        Sort_Ascending_First_Name(CustomDataList);
                            break;

                    case 10:
                        Sort_Ascending_Last_Name(CustomDataList);
                        break;
                    case 11:
                        Sort_Ascending_Student_Number(CustomDataList);
                        break;
                    case 12:
                        Sort_Descending_First_Name(CustomDataList);
                        break;
                    case 13:
                        Sort_Descending_Last_Name(CustomDataList);
                        break;
                    case 14:
                        Sort_Descending_Student_Number(CustomDataList);
                        break;



                    }
                    Console.WriteLine("\nPress enter to go back to the menu and continue ");
                    cki = Console.ReadKey();
                } while (cki.Key != ConsoleKey.Escape);
                Console.ReadKey();
        }


    }
    }
