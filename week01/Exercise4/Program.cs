using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        /*number_list = []*/
        List<int> numberList = new List<int>();
        /*new_number = ''*/
        int newNumber = -1;
        /*sum_number = 0*/
        int sumNumber = 0;
        /*print('')*/
        Console.WriteLine();




        do
        {
            /*new_number = int(input('Enter a number: '))*/
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();   //not needed to declare again the data type later
            newNumber = int.Parse(userInput);
            /*if new_number != 0:*/
            if (newNumber != 0)
            {
                /*number_list.append(new_number)*/
                numberList.Add(newNumber);
            }
        } while (newNumber != 0);


            /*sum_avg = len(number_list)*/
            int sumAvg = numberList.Count;
            /*sum_number = sum(number_list)*/
            sumNumber = numberList.Sum();
            /*average = sum_number / sum_avg*/
            double average = (double)sumNumber / sumAvg;
            /*max_number = max(number_list)*/
            int maxNumber = numberList.Max();
            /*high_number = 1000000000*/
            int highNumber = 1000000000;

            foreach (int number in numberList)
            {
                if (number > 0 && number < highNumber)
                {
                    highNumber = number;
                }
            }




            /*print(f'The sum is: {sum_number}')*/
            Console.WriteLine($"The sum is: {sumNumber}");
            /*print(f'The average is: {average}')*/
            Console.WriteLine($"The average is: {average}");
            /*print(f'The largest number is: {max_number}')*/
            Console.WriteLine($"The largest number is: {maxNumber}");

            List<int> sortedNumbers = new List<int>(numberList);
            /*sorted_numbers = sorted(number_list)*/
            sortedNumbers.Sort();


            /*for sorted_item in sorted_numbers:*/
            foreach (int sorted_item in sortedNumbers)
            {
                /*print(sorted_item)*/
                Console.WriteLine(sorted_item);
            }

    } 


}
