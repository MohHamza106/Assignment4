using System.Data.SqlTypes;
using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assigment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            //Console.Write("this is x ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("this is y ");
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{x}+{y}={x + y}");
            //Console.WriteLine($"{x}*{y}={x * y}");
            //Console.WriteLine($"{x}-{y}={x - y}");
            #endregion
            #region 1
            //  Console.Write("enter number=   ");
            //int number= Convert.ToInt32(Console.ReadLine());+
            //  if (number %3==0 &&number%4==0)   
            //  {
            //      Console.WriteLine("yes");
            //  }
            //  else
            //  {
            //      Console.WriteLine("No");
            //  }
            #endregion
            #region 2
            //Console.Write("enter number =   ");

            //int number= Convert.ToInt32(Console.ReadLine());
            //if (number < 0)
            //{
            //    Console.WriteLine("negative");
            //}
            //else {
            //    Console.WriteLine("positive");

            //}


            #endregion
            #region 3
            //Console.Write("this is x ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("this is y ");
            //int y = int.Parse(Console.ReadLine());
            //Console.Write("this is z ");
            //int z = int.Parse(Console.ReadLine());
            //int max=Math.Max(x,Math.Max(y,z));
            //int min = Math.Min(x, Math.Min(y, z));
            //Console.WriteLine($"  max element = {max}");
            //Console.WriteLine($"  min element = {min}");

            //in other way--------------------
            //Console.Write("this is x=  ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("this is y=  ");
            //int y = int.Parse(Console.ReadLine());
            //Console.Write("this is z=  ");
            //int z = int.Parse(Console.ReadLine());
            //if (x > y && x > z)
            //{
            //    Console.WriteLine("max is x");
            //    if (y > z)
            //    {
            //        Console.WriteLine("min is z");
            //    }
            //    else
            //        Console.WriteLine("min is y");
            //}
            //else if (y > z && y > x)
            //{
            //    Console.WriteLine("max is y");
            //    if (z > x)
            //    {
            //        Console.WriteLine("min is x");
            //    }
            //    else
            //        Console.WriteLine("min is z");
            //}
            //else
            //{
            //    if (z > y && z > x)
            //    {
            //        Console.WriteLine("max is z");
            //        if (y > x)
            //        {
            //            Console.WriteLine("min is x");
            //        }
            //        else
            //        {
            //            Console.WriteLine("min is z");
            //        }
            //    }
            //}

            #endregion
            #region 4
            //Console.Write("this is x =  ");
            //int x = int.Parse(Console.ReadLine());

            //if (x % 2 == 0)
            //{
            //    Console.WriteLine(" number is  even");
            //}
            //else if ( x==0)
            //{
            //    Console.WriteLine(" the number not even or odd ");
            //}
            //else
            //{
            //    Console.WriteLine(" number is  odd");
            //}

            #endregion
            #region 5
            // Console.Write("this is character: ");
            //char x= Convert.ToChar (Console.ReadLine());
            // // or   char x = char.Parse(Console.ReadLine());
            // List<char> list = new List<char> { 'a', 'e', 'I', 'o', 'u' };
            //     if (x ==list[0] || x == list[1] || x == list[2] || x == list[3] || x == list[4])
            // {
            //     Console.WriteLine(" vowel");
            // }
            // else 
            // {
            //     Console.WriteLine(" Consonant");
            // }
            #endregion
            #region 7
            //Console.Write("enter the number:   ");
            //int x =int.Parse (Console.ReadLine());
            //for (int i = 1; i <= 12; i++) 
            //{
            //    Console.WriteLine($"{x}*{i}={x*i}");
            //}
            #endregion
            #region 9
            //Console.Write("this is x=  ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("this is y=  ");
            //int y = int.Parse(Console.ReadLine());
            //double power = Math.Pow(x,y);
            //Console.WriteLine($"{ power}");

            #endregion
            #region 10
            //Console.Write("this is subject1=  ");
            //int subject1 = int.Parse(Console.ReadLine());
            //Console.Write("this is subject2=  ");
            //int subject2 = int.Parse(Console.ReadLine());
            //Console.Write("this is subject3=  ");
            //int subject3 = int.Parse(Console.ReadLine());
            //Console.Write("this is subject4=  ");
            //int subject4 = int.Parse(Console.ReadLine());
            //Console.Write("this is subject5 =  ");
            //int subject5 = int.Parse(Console.ReadLine());


            //double total = subject1 + subject2 + subject3 + subject4 + subject5;
            //double aver = total / 5;
            //double perstenage = total / 500 * 100;
            //Console.WriteLine(@$" Total marks:  {total}
            // Average Marks : {aver}
            // Percentage: {perstenage} ");


            //-----------------------------------------------------
            //    double[] arr = new double[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("enter degree:");
            //    arr[i] = Convert.ToDouble(Console.ReadLine());
            //}
            //Array.Sort(arr);
            //double sum = arr.Sum();
            //double ave = arr.Average();
            //double per = sum / 500 * 100;
            //Console.WriteLine(sum);
            //Console.WriteLine(ave);
            //Console.WriteLine(per);

            #endregion
            #region 11
            //Console.Write("enter  number mothn : ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number >= 1 && number < 12)
            //{
            //    if (number == 1 || number == 3 || number == 5 || number == 7 || number == 8 || number == 10 || number == 12)

            //    {
            //        Console.WriteLine(" Days in Month: 31");
            //    }
            //    else if (number == 4 || number == 6 || number == 9 || number == 11)
            //    {
            //        Console.WriteLine(" Days in Month: 30");
            //    }
            //    else if (number == 2)
            //    {
            //        Console.Write("enter year:  ");  
            //        int year=int.Parse(Console.ReadLine());
            //        if ( year%4==0) 
            //        {
            //            Console.WriteLine(" Days in Month: 29");
            //        }
            //        else
            //        Console.WriteLine(" Days in Month: 28");
            //    }
            //}
            //else
            //    Console.WriteLine("this is not month");



            #endregion
            #region 17
            //Console.Write("enter  point1 x1  : ");
            //int x1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("enter  point1 y1  : ");
            //int y1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("enter  point1 x2  : ");
            //int x2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("enter  point1 y2  : ");
            //int y2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("enter  point1 x3  : ");
            //int x3 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("enter  point1 y3  : ");
            //int y3 = Convert.ToInt32(Console.ReadLine());
            //int dx1=x2 - x1;
            //int dy1=y2 - y1;
            //int dictant = dx1 / dy1;
            //int dx2 = x3 - x2;
            //int dy2 = y3 - y2;
            //int dictant2 = dx2 / dy2 ;
            //int dx3 = x1 - x3;
            //int dy3 = y1 - y3;
            //int dictant3 = (dx3 / dy3 );
            //Point point1 = new Point( x1,y1);
            //Point point2 = new Point( x2,y2);
            //Point point3 = new Point(x3,y3);
            //if (dictant3 == dictant2|| dictant2==dictant ||dictant==dictant3)
            //{
            //    Console.WriteLine("   points lie on a single straight line.");
            //}
            //else
            //    Console.WriteLine("not   points lie on a single straight line");
            #endregion
            #region 18
            //Console.Write("enter time worker using:   ");
            //float time = float .Parse(Console.ReadLine());
            //if (time >= 2 && time <= 3)
            //{
            //    Console.WriteLine("worker highly efficient. ");
            //}
            //else if (time >= 3 && time <= 4)
            //{
            //    Console.WriteLine("instructed to increase their speed. ");
            //}
            //else if (time >= 4 && time <= 5)
            //{
            //    Console.WriteLine("they are provided with training to enhance their speed. \r\n ");
            //}
            //else 
            //{
            //    Console.WriteLine("hey are required to leave the company.  ");
            //}

            #endregion
            #region 21
            //int x = 5;
            //int y = 8;
            //Console.WriteLine( $" thisis old x:  {x}");
            //Console.WriteLine($" thisis old y:  {y}");
            //x = y;
            //x = x + 2;
            ////x increaseby2          x=7
            ////y change values of x   y=7
            //Console.WriteLine($" thisis new x:  {x}");
            //Console.WriteLine($" thisis new x:  {x}");
            #endregion
            #region 22
            //Console.Write("this is name1 ");
            //string name1 = Console.ReadLine();
            //Console.Write("this is name2 ");
            //string name2 = Console.ReadLine();
            //name2 = name1;
            //Console.WriteLine($" this is name1: {name1}   ");
            //Console.WriteLine($"this is name2:{name2}");
            #endregion
            #region 23
            ////b
            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            //(!(false))= true (1)

            #endregion
            #region 24
            //d
            //Console.WriteLine(13 / 2 + " " + 13 % 2);
            //13/2=6.5 but =6 because datatype int  and 13%2=1 because12%2=0 remind 1
            #endregion
            #region 25
            //-- d
            //int num = 1, z = 5;


            //if (!(num <= 0))     //(!(false))= true


            //Console.WriteLine(++num + z++ + " " + ++z);  //num=2 +z=5 =print  7 z=6 ""+ z=6+1 print z=7

            //else
            //    Console.WriteLine(--num + z-- + " " + --z);



            #endregion
            #region sheet 2
            #region 1
            //Console.Write("enter number:  ");
            //bool flag;
            //    flag=int.TryParse(Console.ReadLine(), out var number);
            //if (flag && number > 0)
            //{
            //    for (int i = 1; i <= number; i++)
            //    {
            //        Console.WriteLine(i);

            //    }
            //}
            #endregion
            #region 2
            //Console.Write("ENTER NUMBER :  ");
            //int number = int.Parse(Console.ReadLine());
            //int.TryParse(Console.ReadLine(), out int Number);
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($"{number * i}");
            //}

            #endregion
            #region 3
            //Console.Write("ENTER NUMBER :  ");
            //int number = int.Parse(Console.ReadLine());
            //int.TryParse(Console.ReadLine(), out int Number);
            //for (int i = 1; i < number; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region 4


            //Console.Write("ENTER NUMBER1 :  ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("ENTER NUMBER2 :  ");
            //int number2 = int.Parse(Console.ReadLine());
            //double result = Math.Pow(number1, number2);
            //Console.WriteLine($"{result}");

            #endregion
            #region 5 not result 
            //Console.Write("enter string:    ");
            //string str = Console.ReadLine();
            //char[] charArray = str.ToCharArray();

            //for (int i = 0; i < charArray.Length; i++)
            //{

            //    Console.Write(charArray[i]);
            //}
            //Console.WriteLine("\n");
            //Array.Reverse(charArray);
            //Console.WriteLine(charArray);
            #endregion
            #region 6
            //int num = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());

            //bool isprime = true;

            //for(int i  = num; i <= num2; i++)
            //{
            //    if(i==1)continue;
            //    isprime = true;
            //    for (int j = 2; j <= i/2; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //             isprime = false;
            //             break;
            //        }
            //    }
            //    if (isprime) Console.WriteLine(i);
            //}

            #endregion
            #region 7 not result

            //Console.Write("enter number:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int reminder  = 0 ;
            //string binarycode = "";
            //if (n == 0) Console.WriteLine(0);
            //while (n > 0)
            //{
            //    reminder = n % 2;
            //    binarycode =reminder+ binarycode;
            //    n = n / 2;
            //}

            //Console.WriteLine(binarycode);

            #endregion
            #region   8
            //Console.Write("Enter the size of the identity matrix: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine($"The identity matrix of size is:{n}");

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write("1 ");
            //        }
            //        else
            //        {
            //            Console.Write("0 ");
            //        }
            //    }
            //    Console.WriteLine();
            //}


            #endregion
            #region 9
            //Console.Write("enter string name :  ");
            //string name = Console.ReadLine();
            //string substring = name.Substring(7, 5);
            //Console.WriteLine(substring);

            #endregion
            #region 10
            //Console.Write("enter string1 :  ");
            //string name1 = Console.ReadLine();
            //Console.Write("enter string2 :  ");
            //string name2 = Console.ReadLine(); 
            //Console.WriteLine(name1);   
            //Console.WriteLine(name2);

            //Console.Write ("**********************\n");
            //name1 = name2;
            //Console.WriteLine(name1);   
            //Console.WriteLine(name2);
            #endregion
            #region 11
            //Console.Write("Enter the size of the identity matrix: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine($"The identity matrix of size is:{n}");

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write("1 ");
            //        }
            //        else
            //        {
            //            Console.Write("0 ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region 12
            //int[] number = { 1, 2, 9, 3, 5, 6, 8, 7 ,85,36,95,24,39};
            //Array.Sort(number);
            //Console.WriteLine(number.Sum());
            #endregion
            #region 13
            //int[] number1 = { 1, 2, 3 ,6,2,58,3};
            //int[] array2 = { 4, 5, 6,8,2,7,5 };
            //int[] mergedArray = number1.Concat(array2).ToArray();
            //Console.WriteLine(string.Join(", ", mergedArray));
            #endregion
            #region 14
            //int[] arr = { 1, 2, 2, 3, 5, 3, 4, 6, 7, 4 };
            //Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int currentElement = arr[i];
            //    if (frequencyMap.ContainsKey(currentElement))
            //    {
            //        frequencyMap[currentElement]++;
            //    }
            //    else
            //    {
            //        frequencyMap[currentElement] = 1;
            //    }
            //}
            //Console.WriteLine("Element Frequency:");
            //foreach (var item in frequencyMap)
            //{
            //    Console.WriteLine($"{item.Key}: {item.Value}");
            //}


            #endregion
            #region 15
            //int[] number = { 13, 23, 39, 4, 65, 66, 7, 58, 20, 10, 11, 12 };
            //Console.WriteLine(number.Max());
            //Console.WriteLine(number.Min());
            #endregion
            #region 16
            //int[] number = { 13, 23, 39, 4, 65, 66, 7, 58, 20, 10, 11, 12, 76 };
            //Array.Sort(number);
            //Console.WriteLine(number[number.Length - 2]);
            #endregion
            #region 17
            //Console.Write("enter max" );
            //int max=int .Parse( Console.ReadLine() );
            //int[] number=new int[max];
            //int distance = 0;
            //int num = 0;
            //int index1 = 0;
            //int index2 = 0;
            //for (int i = 0; i < max; i++)
            //{
            //    number[i] = int.Parse(Console.ReadLine()); 
            //}
            //for (int i = 0; i < max; i++)
            //{
            //    for (int j = 0; j < max; j++)
            //    {
            //        if (number[j] == number[i])
            //        {
            //            int res = i - (j + 1);
            //            if (res > distance)
            //            {
            //                distance = res;
            //                num = number[i];
            //                index1 = j;
            //                index2 = i;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine($"the longesr distance between" +
            //    $" two identical numbers is {distance} of number " +
            //    $"{num} between index {index1} and index {index2} ");
            #endregion
            #region 18
            //Console.Write("Enter the number of rows: ");
            //int rows = int.Parse(Console.ReadLine());

            //Console.Write("Enter the number of columns: ");
            //int columns = int.Parse(Console.ReadLine());

            //int[,] firstArray = new int[rows, columns];
            //int[,] secondArray = new int[rows, columns];

            //Console.WriteLine("Enter the elements of the first array:");

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write("Element[{0},{1}]: ", i, j);
            //        firstArray[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        secondArray[i, j] = firstArray[i, j];
            //    }
            //}

            //Console.WriteLine("The elements of the second array are:");

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write(secondArray[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region 19
            //int[] array = { 1, 52, 9, 8, 3, 9, 7, 6, 85, 93 };
            //Array.Sort(array);
            //Array.Reverse(array);
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
            #endregion
            #region Demo
            #region Loop Statement
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);

            //for (int i = 1; i <= 10; i++)
            //{
            //Console.WriteLine($"{i} T");
            //}


            #endregion
            #region for-foreach
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //   // Numbers[i] += 10;
            //   if (Numbers[i] == 5)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(Numbers[i] );
            //}

            //class implement interface iemurabel
            //foreach (int number in Numbers)
            //{
            //    number += 10;//invalid
            //    Console.WriteLine(number);
            //}
            #endregion
            #region While - Do while
            //Console.WriteLine("Please enter an even number");
            //int Numbner = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{Numbner} is even number");

            //int Number;
            //bool Flag;
            //do
            //{
            //Console.WriteLine("Please enter an even number");
            ////Number = int.Parse(Console.ReadLine());
            //Flag = int .TryParse(Console.ReadLine(), out Number);

            //}while(Number % 2 == 1 || !(Flag));
            //Console.WriteLine($"{Number} is even number"); 

            // Same exambel using while loop
            //int Number = 3;
            //bool Flag = false;
            //while (Number % 2 == 1 || !(Flag))
            //{
            //    Console.WriteLine("Please enter an even number");
            //    Flag = int.TryParse(Console.ReadLine(),out Number);
            //}
            //Console.WriteLine($"{Number} is even number");

            #endregion
            #region String
            // Class => Rerference type
            //Immutable data type [Value can not be changed]
            //Array of character

            //string Name;
            //Name = new string("Ali");
            //Name = "Ayman"; //Syntax sugar

            //string Name01 = "Ali";
            //string Name02 = "Ali";
            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name01 hashCode : {Name01.GetHashCode()}");
            //Console.WriteLine("********************************************");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name02 HashCode : {Name02.GetHashCode()}");
            //string Name01 = "Ahmed";
            //string Name02 = "Ali";
            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name01 hashCode : {Name01.GetHashCode()}");
            //Console.WriteLine("********************************************");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name02 HashCode : {Name02.GetHashCode()}");
            //Name02 = Name01;
            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name01 hashCode : {Name01.GetHashCode()}");
            //Console.WriteLine("********************************************");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name02 HashCode : {Name02.GetHashCode()}");

            //Name01 = "Mostafa";
            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name01 hashCode : {Name01.GetHashCode()}");
            //Console.WriteLine("********************************************");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name02 HashCode : {Name02.GetHashCode()}");
            //string Message = "Hello"; // unreachabel opject
            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());
            //Console.WriteLine("********************");
            //Message += " root";
            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());
            #endregion
            #region StringBuilder
            //StringBuilder Meassge;
            //Meassge = new StringBuilder("Hello");
            //Console.WriteLine(Meassge);
            //Console.WriteLine(Meassge.GetHashCode());
            ////Meassge += route; invalid
            //Meassge.Append(" root");
            //Console.WriteLine(Meassge);
            //Console.WriteLine(Meassge.GetHashCode());
            #endregion

            #region StringBuilderMethods
            //StringBuilder Message = new StringBuilder("Welcome");
            //Message.Append(" to route");
            //Console.WriteLine(Message);
            //Message.AppendLine(" Ali");
            //Message.Append(" saleh");
            //Console.WriteLine(Message);

            //Message.Remove(0, 7);
            //Console.WriteLine(Message);

            //Message.Insert(0, "Hello");
            //Console.WriteLine(Message);

            //int age = 22;
            //string Name = "Amir";
            //Message.AppendFormat("Name {0}, age {1}",Name, age);
            //Message.AppendJoin("/","21","11","89"); 
            //Console.WriteLine(Message);
            #endregion
            #region Array 1D
            //int[] Numbers = new int[3];
            //int[] Numbers = new int[3] { 1, 2, 3 };
            //int[] Numbers = new int[] { 1, 2, 3 };
            //int[] Numbers =  { 1, 2, 3 };
            //int[] Numbers = new int[3];

            //Numbers[0] = 1;
            //Numbers[1] = 2;
            //Numbers[2] = 3;

            //for(int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine($"please enter a no {i+1} ");
            //    Numbers[i] = int.Parse( Console.ReadLine() );
            //}

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]); 
            //}
            //Console.WriteLine(Numbers.Length);
            //Console.WriteLine(Numbers.Rank);
            #endregion
            #region 2D Array
            //int[,] Marks = new int[3, 5];

            //Console.WriteLine(Marks.Length);
            //Console.WriteLine(Marks.Rank);
            //Console.WriteLine(Marks.GetLength(0));// Number of rows 
            //Console.WriteLine(Marks.GetLength(1));// Number of coulmns

            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    bool Flag;
            //    Console.WriteLine($"Enter grades of student {(i + 1)}");
            //    for (int j = 0; j < Marks.GetLength(1); /*j++*/)
            //    {
            //        Console.WriteLine($"enter grades of subject {(j + 1)}");
            //        //Marks[i,j] = int.Parse(Console.ReadLine());
            //        Flag = int.TryParse(Console.ReadLine(), out Marks[i, j]);//protictive code
            //        if (Flag && Marks[i, j] >= 0)
            //        {
            //            ++j;
            //        }

            //    }
            //}

            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($" grades of student {(i + 1)}");
            //    for (int j = 0; j < Marks.GetLength(1); j++)
            //    {
            //        Console.Write($"enter grades of subject {(j + 1)} :");
            //        Console.WriteLine(Marks[i,j]);
            //    }
            //}

            //for (int i = 0; i < Marks.Length; i++)
            //{
            //    Console.WriteLine(Marks[i/Marks.GetLength(1),i%Marks.GetLength(1)]);

            //}
            #endregion
            #region judge Array
            //int[][] Numbers = new int[3][];
            //Numbers[0]= new int[3]  { 1, 2 , 3};
            //Numbers[1]= new int[2] {4 ,5};
            //Numbers[2]= new int[1] { 6};
            //for (int i =0; i < Numbers.Length; i++)
            //{
            //    for (int j = 0; j < Numbers[i].Length; j++)
            //    {
            //        Console.WriteLine(Numbers[i] [j]);
            //    }
            //}
            #endregion
            #endregion

            #endregion

        }

    }
}
