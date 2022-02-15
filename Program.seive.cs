// See https://aka.ms/new-console-template for more information

using System;
// I didnt saw how you showed it in class so i used loops to do it in easy way
    namespace loops
    {
     class program
       {
          static void Main(string[] args )
        {
          Console.WriteLine("Enter a number  for setting the range");
          Console.Title = "SEIVE OF ERATOSTHENES";
          int nums;
            nums = Convert.ToInt32(Console.ReadLine());
            
            for (int i  = 1; i <= nums ; i++) //set the range of number which will be excuted in the for loop
                 {
                      
               bool primenumbers = true; // set a boolean flag for denoting if the number is prime or not
               for (int j = 2; j < i; j++) // loop that divides number from the above condition with every possible value as the theory
               {
                 if (i % j == 0) // no remainder means its not a prime number
                 {
                   primenumbers = false;
                   break;
                 }
               }
               if (primenumbers)
               {
               Console.WriteLine(i);
               }
                 }
                  Console.ReadKey();
        }
       }
    }


