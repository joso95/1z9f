
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution
{
    public class Solution

    {
        //TODO: (TASK 1) Give discount to largest price 
        public static double BiggestDiscount(int [] shoppingList, int discount)
        {

            if (discount > 0)
            {
                double totalWithoutMax = shoppingList.Sum() - shoppingList.Max();
                double changeToPercentDiscount = discount / 100.00;
                double totalDiscount = shoppingList.Max() * changeToPercentDiscount;
                double reducedMax = shoppingList.Max() - totalDiscount;
                
                return totalWithoutMax + reducedMax;
            }
            else
            {
                return shoppingList.Sum();
            }

        }


        //TODO: (TASK 2) Count occurance of words, return dict 
        public static IDictionary<string, int> CountWords (string[] wordCollection)
        {
            IDictionary<string, int> wordCount = new Dictionary<string, int>();
            foreach (string word in wordCollection)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]+= 1;
                }
                else
                {
                    wordCount.Add(word, 1);
                }
            }
            return wordCount;

        }

        //TODO: (TASK 3) Remove duplicates in a list
        public static int[] RemoveDuplicates(int[] sentence)
        {
            return sentence.Distinct().ToArray();
        }


        //TODO: (TASK 4) No more than two different numbers in the int. e.g. 2020 = good, 3333 = good, -1 = good , 123 = bad
        //Note: Not working according to requirements.

        public static string DuoDigit(int number)
        {
            if (number < 99 && number > -99)
            {
                return "y";
            }
            else if (number % 2 == 0 || number % 3 == 0)
            {
                return "y";
            }
            else
            {
                return "n";
            }

        }

        //TODO: (TASK 5) Find streak of profitable months and total profit before loss
        public static int[] ProfitableMonths(int[] months)
        {
            int totalMonthsProfitable = 0;
            int totalMonthsProfit = 0;
            int currentProfit = 0;
            

            for (int i = 0; i < months.Length; i++)
            {
                currentProfit += months[i];

                if (currentProfit > 0)
                {
                    totalMonthsProfitable += 1;
                    totalMonthsProfit += months[i];
                }

            }

            int[] res = { totalMonthsProfit, totalMonthsProfitable };
       
            return res;
        }



        public static void Main()
        {
            // Used for TASK 1
            int[] shoppingList1 = { 100, 200, 300, 400 };
            int[] shoppingList2 = { 100, 200 };
            int discountYes = 20;
            int discountNo = 0;

            double resultWithDiscount = BiggestDiscount(shoppingList1, discountYes);
            double resultWithoutDiscount = BiggestDiscount(shoppingList2, discountNo);

            //Uncomment under for results:
            //Console.WriteLine(resultWithDiscount);
            //Console.WriteLine(resultWithoutDiscount);


            //Used for TASK 2
            string[] collectionOfWords = { "dog", "person", "human", "dog", "dog", "human"};
            var wordOccurance = CountWords(collectionOfWords);

            //Uncomment under for result:
            /*
            foreach (var word in wordOccurance)
            Console.WriteLine("Key: {0}, Value: {1}", word.Key, word.Value);
            */


            //Used for TASK 3
            int[] collectionOfNumbers = { 1, 2, 3, 4, 1, 1, 3, 4, 5, 6, 7, 8, 9, 9, 9 };
            int[] resultOfRemoveDuplicates = RemoveDuplicates(collectionOfNumbers);

            //Uncomment under for result:
            /*for (int i = 0; i < resultOfRemoveDuplicates.Length; i++)
            {
            Console.WriteLine(resultOfRemoveDuplicates[i]);
            }
            */


            //Used for TASK 4
            int numb1 = 1;
            int numb2 = 22;
            int numb3 = 123;
            int numb4 = -333;
            int numb5 = 567;
            int numb6 = 2021;

            //Uncomment under for result:
            /*
            Console.WriteLine(duoDigit(numb1));
            Console.WriteLine(duoDigit(numb2));
            Console.WriteLine(duoDigit(numb3));
            Console.WriteLine(duoDigit(numb4));
            Console.WriteLine(duoDigit(numb5));
            Console.WriteLine(duoDigit(numb6));
            */


            //Used for TASK 5
            int[] monthsProfit = { -1, 0, 1, 8, 3, -3, 1, - 24 }; 
            var profit = ProfitableMonths(monthsProfit);

            //Uncomment under for result:
            /*
            for (int i = 0; i < profit.Length; i++)
            {
                Console.WriteLine(profit[i]);
            }
            */
        }

    }
}