namespace ConsoleApp25
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Task1

            //int[] nums = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            //var  num =from a in nums where (a % 2) == 0 select a;

            //   foreach (int a in num)
            //   {
            //       Console.Write( nums);
            //   }



            ////Task2

            //int[] nums = {0, 1, 2 ,3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };


            //var num =from a in nums where a > 0 where a < 12 select a;

            //foreach (var item in num)
            //{
            //    Console.Write(item);
            //}

            ////Task3

            //var nums = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9};


            //var sqrno = from int Number in nums let SqrNo = Number * Number where SqrNo > 20 select new { Number, SqrNo };

            //foreach (var item in sqrno) 
            //{
            //    Console.WriteLine(item);
            //}

            ////Task4

            //int[] nums = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };


            //var n = from x in nums group x by x into y select y;

            //foreach (var item in n)
            //{
            //    Console.WriteLine("Number " + item.Key + " appears " + item.Count() + " times");
            //}

            //Task5

            // string word;

            //word = Console.ReadLine();

            //var FreQ = from x in word group x by x into y select y;

            // foreach (var item in FreQ)
            // {
            //     Console.WriteLine("Character " + item.Key + ": " + item.Count() + " times");
            // }

            ////Task6

            //string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            //var days = from WeekDay in dayWeek select WeekDay;

            //foreach (var item in days)
            //{
            //    Console.WriteLine(item);
            //}

            ////Task7

            //int[] nums = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

            //var a = from x in nums group x by x into y select y;

            //foreach (var item in a)
            //{
            //    Console.WriteLine(item.Key + " " + item.Sum() + " " + item.Count());
            //}




            ////Task9

            //int i = 0;
            //List<int>list = new List<int>();
            //list.Add(55);
            //list.Add(200);
            //list.Add(740);
            //list.Add(76);
            //list.Add(230);
            //list.Add(482);
            //list.Add(95);

            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}
            //List<int> FilterList = list.FindAll(x => x > 80 ? true : false);

            //foreach (var item in FilterList)
            //{
            //    Console.WriteLine(item);
            //}


            ////Task10

            //int i = 0;
            //int list, num1, num2;
            //List<int> templist = new List<int>();

            //num1 = Convert.ToInt32(Console.ReadLine());

            //for (i = 0; i < num1; i++)
            //{
            //    Console.Write(i);
            //    list = Convert.ToInt32(Console.ReadLine());
            //    templist.Add(list);
            //}

            //num2= Convert.ToInt32(Console.ReadLine());

            //List<int> FilterList = templist.FindAll(x => x > num2 ? true : false);
            //Console.WriteLine(num2);
            //foreach (var item in FilterList)
            //{
            //    Console.WriteLine(item);
            //}


            // //Task11

            // List<int> list = new List<int>();
            // list.Add(5);
            // list.Add(7);
            // list.Add(13);
            // list.Add(24);
            // list.Add(6);
            // list.Add(9);
            // list.Add(8);
            // list.Add(7);

            // foreach (var item in list)
            // {
            //     Console.WriteLine(item + " ");
            // }

            //int num = Convert.ToInt32(Console.ReadLine());

            // list.Sort();
            // list.Reverse();

            // foreach (int item in list.Take(num))
            // {
            //     Console.WriteLine(item);
            // }


            ////Task12

            //string word;

            //Console.WriteLine("Input the string : ");
            //word = Console.ReadLine();

            //var Word = (word);

            //foreach (var item in word)
            //{
            //    Console.WriteLine(item);
            //}


            ////Task13

            //string[] word;
            //int num1, num2;

            //num1 = Convert.ToInt32(Console.ReadLine());

            //word = new string[num1];

            //for (num2 = 0; num2 < num1; num2++)
            //{
            //    Console.Write("Element[{0}] : ", num2);
            //    word[num2] = Console.ReadLine();
            //}
            //string newword= String.Join(", ", word.Select(s => s.ToString()).ToArray());

            //Console.WriteLine(newword);

            ////Task15

            //string[] arr = { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };

            //var fGrp = arr.Select(file => Path.GetExtension(file).TrimStart('.').ToLower()).GroupBy(z => z, (fExt, extCtr) => new{Extension = fExt,Count = extCtr.Count() });

            //foreach (var item in fGrp)
            //{
            //    Console.WriteLine("{0} File(s) with {1} Extension ", item.Count, item.Extension);

            //}


            ////Task16

            //string[] file = Directory.GetFiles("/home/w3r/abcd/");
            //// there are three files in the directory abcd are :
            //// abcd.txt, simple_file.txt and xyz.txt

            //var size = file.Select(file => new FileInfo(file).Length).Average();
            //size = Math.Round(size / 10, 1);
            //Console.WriteLine(size);

            ////Task17


            //List<string> list = new List<string>();
            //list.Add("m");
            //list.Add("n");
            //list.Add("o");
            //list.Add("p");
            //list.Add("q");

            //var a = from y in list select y;

            //foreach (var item in a)
            //{
            //    Console.WriteLine(item);
            //}

            //string newstring = list.FirstOrDefault(en => en == "o");
            //list.Remove(newstring);


            //var result = from z in list select z;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            ////Task18

            //List<string> list = new List<string>();
            //list.Add("m");
            //list.Add("n");
            //list.Add("o");
            //list.Add("p");
            //list.Add("q");

            //var a = from y in list select y;

            //foreach (var item in a)
            //{
            //    Console.WriteLine(item);
            //}

            //list.Remove(list.FirstOrDefault(en => en == "p"));


            //var _result = from z in list select z;

            //foreach (var item in a)
            //{
            //    Console.WriteLine(item);
            //}


            ////Task19

            //List<string> list = new List<string>();
            //list.Add("m");
            //list.Add("n");
            //list.Add("o");
            //list.Add("p");
            //list.Add("q");


            //var result = from a in list select a;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //list.RemoveAll(en => en == "q");

            //var result2 = from b in list select b;

            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}


            ////Task20

            //List<string> list = new List<string>();
            //list.Add("m");
            //list.Add("n");
            //list.Add("o");
            //list.Add("p");
            //list.Add("q");

            // var result = from a in list select a;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //list.RemoveAt(3);

            //var result2 = from b in list select b;

            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}

            ////Task21

            //List<string> list = new List<string>();
            //list.Add("m");
            //list.Add("n");
            //list.Add("o");
            //list.Add("p");
            //list.Add("q");

            //var result = from a in list select a;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //list.RemoveRange(1, 3);

            //var result2 = from b in list select b;

            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}


            ////Task22

            //string[] word;
            //int num1, num2, ctr;

            //num1 = Convert.ToInt32(Console.ReadLine());
            //word = new string[num1];
            //Console.Write(num1);
            //for (num2 = 0; num2 < num1; num2++)
            //{
            //    Console.Write("Element[{0}] : ", num2);
            //    word[num2] = Console.ReadLine();
            //}


            //ctr = Convert.ToInt32(Console.ReadLine());

            //IEnumerable<string> objNew = from a in word where a.Length >= ctr orderby a select a;
            //Console.Write(ctr);
            //foreach (string item in objNew)
            //    Console.WriteLine("Item: {0}", item);

            ////Task23

            //char[] chars = { 'X', 'Y', 'Z' };
            //int[] nums = { 1, 2, 3, 4 };


            //var a= from letterList in chars from numberList in nums select new { letterList, numberList };


            //foreach (var item in a)
            //{
            //    Console.WriteLine(item);
            //}

            ////Task24

            //char[] chars = { 'X', 'Y', 'Z' };
            //int[] nums = { 1, 2, 3 };
            //string[] colors = { "Green", "Orange" };



            //var a = from letter in chars from number in nums from colour in colors select new { letter, number, colour };


            //foreach (var item in a)
            //{
            //    Console.WriteLine(item);
            //}


            //Task28

            //string[] cities ={ "Rome","London","Nairobi","California","Zurich","New Delhi","Amsterdam","Abu Dabi", "Paris"};


            //IEnumerable<string> cityOrder =cities.OrderBy(str => str.Length).ThenBy(str => str);
            //foreach (string city in cityOrder)
            //{
            //    Console.WriteLine(city);
            //}


            

         

           



        }
       


    }
}