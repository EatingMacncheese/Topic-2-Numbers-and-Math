namespace Topic_2_Numbers_and_Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I will now count my chickens:");
            Console.WriteLine("Hens " + (10 + 5 *2));
            Console.WriteLine("Roosters " + (25 + 30 / 6));

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("six" + 6);
            Console.WriteLine("6 + 6");
            Console.WriteLine("6" + 6);
            Console.WriteLine(6 + 6);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Now I will count the eggs");
            Console.WriteLine(11 / 2);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Is it true that 3 + 2 < 5 - 7?");
            Console.WriteLine(3 + 2 < 5 - 7);

            Console.WriteLine("What is 3 + 2? " + (3 + 2));
            Console.WriteLine("What is 5 - 7 ? " + (3 + 2 < -5 - 7));


            Console.WriteLine("12 eggs costs $6. That means 1 egg is worth");
            Console.WriteLine((6.00 / 12.00).ToString("C"));

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("If sales tax is 13%, and we applied it to an item that costs $79.99");
            Console.WriteLine("It would then cost " + (79.99 * 1.13).ToString("C"));

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("There are 12 inches  in 1 foot, and 2.54cm in 1 inch. That means there are");
            Console.Write(2.54 * 12);  Console.Write("cm in 5'6''");

            Console.ReadLine();
        }
    }
}
