using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeTaskC_3
{
    internal class HomeTaskC_RefOut
    {
        static void Main(string[] args)
        {
            #region Task 1
            //ReverseString("Ali Sadat Nicat Mirqubad");
            #endregion

            #region Task 2
            // head:
            //    Console.WriteLine("Reqem daxil edin:");
            //    bool input = int.TryParse(Console.ReadLine(), out int num);
            //    if (input == false)
            //        goto head;
            //    ChangeNumber(num);
            #endregion

            #region Task 3
            //Console.WriteLine("Cumle daxil edin :");
            //string sentence = Console.ReadLine();
            //LetterCount(sentence);

            #endregion

            #region Task 4
            //Console.WriteLine("Soz daxil edin :");
            //string input = Console.ReadLine();
            //bool check=GetPolindrom(input);
            //if (check) Console.WriteLine("Uygun");
            //else Console.WriteLine("Uygun deyil");
            

            #endregion
        }

        #region Task 1
        //static void ReverseString(string str)
        //{
        //    string[] revStr = str.Split(" ");
        //    string str2 = "";
        //    for (int i = 0; i < revStr.Length; i++)
        //    {
        //        for (int j = revStr[i].Length - 1; j >= 0; j--)
        //        {
        //            str2 += revStr[i][j];
        //        }
        //        if (i != revStr.Length - 1)
        //        {
        //            str2 += " ";
        //        }
        //    }
        //    Console.WriteLine(str2);
        //}
        #endregion

        #region Task 2
        //static void ChangeNumber(int num)
        //{
        //    int endNum;
        //    int number=0;
        //    while (num > 0)
        //    {

        //        endNum = num % 10;
        //        num=num / 10;
        //        number = number*10+endNum;
        //    }
        //    Console.WriteLine(number);
        //}
        #endregion

        #region Task 3
        //static void LetterCount(string sentence)
        //{
        //    string endLetter = "";
        //    foreach (var item in sentence.ToLower())
        //    {
        //        int count = 0;
        //        int counter = 0;
        //        foreach (var item1 in sentence.ToLower())
        //        {
        //            if (item == item1)
        //            {
        //                count++;
        //            }
        //        }
        //        endLetter += item;
        //        foreach (var item2 in endLetter)
        //        {
        //            if (item == item2)
        //                counter++;
        //        }
        //        if (item != ' ' && counter == 1)
        //            Console.WriteLine($"{item} " + "-" + $" {count} ededdir");
        //    }
        //}
        #endregion

        #region Task 4
        //static bool GetPolindrom(string sentence)
        //{
        //    int count = 0;
        //    bool check=false;
        //    for (int i = sentence.Length-1; i >=0; i--,count++)
        //    {
        //        check = false;
        //        if (sentence[count] == sentence[i])
        //        {
        //            check = true;
        //        };
        //        if (check == false)
        //        {
        //            break;
        //        }
        //    }
        //    return check;
        //}
        #endregion

    }
}
