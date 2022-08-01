namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, sum, diff, mux, div;
            Console.WriteLine("First number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            sum = number1 + number2;
            diff = number1 - number2;
            mux = number1 * number2;
            div = number1 / number2;
            Console.WriteLine("The sum of these two numbers: " + sum);
            Console.WriteLine("The difference of these two numbers: " + diff);
            Console.WriteLine("The multiplication of these two numbers: " + mux);
            Console.WriteLine("The division of these two numbers: " + div);
            Console.ReadLine();
        }

    }

}