using System.Xml.Serialization;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char? choice=default;
            List<int> myList = new List<int>();
            do 
            {

                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("C - Clear List");
                Console.WriteLine("F - Find number and print index");
                Console.WriteLine("Q - Quit");
                Console.WriteLine("Enter your choice:");
                choice = Convert.ToChar(Console.ReadLine().ToUpper());

                if (choice == 'P')
                {
                    if (myList.Count == 0)
                    {
                        Console.WriteLine("[] - the list is empty");
                    }
                    else
                    {
                        Console.Write("[ ");
                        for (int i = 0; i < myList.Count; i++)
                        {
                            Console.Write(myList[i]);
                            if (i < myList.Count - 1)
                                Console.Write(" , ");

                        }
                        Console.WriteLine(" ]");
                    }
                }
                else if (choice == 'A')
                {
                    //دا الكود في حالة تكرار المدخلات للست
                    //string[] list = Console.ReadLine().Split(" ");
                    //for (int i = 0; i < list.Length; i++)
                    //{
                    //    myList.Add(Convert.ToInt32(list[i]));
                    //}
                    int n;
                    Console.WriteLine("Enter number of element need to insert to list :");
                    n = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"enter element {i}:");
                        int number = Convert.ToInt32(Console.ReadLine());
                        if (i == 0)
                        {
                            myList.Add(number);
                        }
                        if (i >= 1)
                        {
                            bool find = false;
                            for (int j = 0; j < myList.Count; j++)
                            {
                                if (number == myList[j])
                                {
                                    Console.WriteLine("this element find in list no duplicat:");
                                    find = true;
                                    break;
                                }

                            }
                            if (!find)
                            {
                                myList.Add(number);
                            }
                        }
                    }
                }
                else if (choice == 'M')
                {
                    if (myList.Count == 0)
                        Console.WriteLine("Unable to calculate the mean - no data");
                    else
                    {
                        double sum = 0;
                        double averge;
                        for (int i = 0; i < myList.Count; i++)
                        {
                            sum += myList[i];
                        }
                        averge = sum / myList.Count;
                        Console.WriteLine($"the averge of the elements in the list = {averge}");
                    }
                }
                else if (choice == 'S')
                {
                    if (myList.Count == 0)
                        Console.WriteLine("Unable to determine the smallest number - list is empty");
                    else
                    {
                        int smallest = myList[0];
                        for (int i = 0; i < myList.Count; i++)
                        {
                            if (smallest > myList[i])
                                smallest = myList[i];
                        }
                        Console.WriteLine($"The smallest number is {smallest}");
                    }
                }
                else if (choice == 'L')
                {
                    if (myList.Count == 0)
                        Console.WriteLine("Unable to determine the largest number - list is empty");
                    else
                    {
                        int largest = myList[0];
                        for (int i = 0; i < myList.Count; i++)
                        {
                            if (largest < myList[i])
                                largest = myList[i];
                        }
                        Console.WriteLine($"The largest number is {largest}");
                    }
                }
                else if (choice == 'C')
                {
                    myList.Clear();
                    Console.WriteLine("the list is clear Done:");
                }
                else if (choice == 'F')
                {
                    bool found = false;
                    do
                    {
                        Console.WriteLine("Enter number to search : ");
                        int num = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < myList.Count; i++)
                        {
                            if (num == myList[i])
                            {
                                Console.WriteLine($"the Index of {num} in list equal {i}");
                                found = true;
                                break;
                            }

                        }
                        if (!found)
                        {
                            Console.WriteLine($"{num} is not found in list  try again :");
                        }
                    } while (!found);
                }
                else if (choice == 'Q')
                {
                    Console.WriteLine("Goodbye");
                    break;
                }
                else
                {
                    Console.WriteLine("Unknown selection, please try again");
                }




            } while ( true);
        }
    }
}
