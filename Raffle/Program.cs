using System;


namespace Raffle
{
    class Program
    {
        static void Main(string[] args)
        {
           //Giving the user the options to type up to 30 names
            Console.WriteLine("Please type up to 30 names: ");
            Console.ReadLine();


            //Declaring the variable and arrays
            var names = new string[] {
                "Terriek", "Timiera", "Temeka", "Raymere", "Nestle", "Terrance", "Tyger" ,
                "Terry", "Tayler", "Cierra", "Wynter", "Charlie", "Dannie", "Raquel", "Nicole" ,
                "Bj", "Malik", "Nichelle", "Ryan", "Raymere", "Ralene", "Naya", "Doug", "Larry" ,
                "Charmaine", "Susan", "Candice", "Tim", "Morris", "Quiana", "Terriyon"
            };

            //Declaring the variable for randomizing
            var r = new Random();

            //promting the complier to randomly search the array list 
            var index = r.Next(names.Length);
            Console.WriteLine($" The winner is: {names [index]} "); 
            
            //Telling system to group the list of 'losers'
            Console.WriteLine("Better luck next time! " + string.Join(", ", names));

            Console.ReadLine();

        }
    }
}
