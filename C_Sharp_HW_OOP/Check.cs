using System;


namespace C_Sharp_HW_OOP
{
    class Check
    {
        public static int ForNumberWithoutZero(string input)
        {
            int returnNum;
            while (!int.TryParse(input, out returnNum) || returnNum <= 0)
            {
                Console.Write("\n\tInvalid data entered!\n\tThe entered value is not a number, or not an integer, or a negative number, or zero.\n\n");
                Console.Write("Please enter a positive integer greater than zero: ");
                input = Console.ReadLine();
            }
            return returnNum;
        }

        public static int ForNumberWithZero(string input)
        {
            int returnNum;
            while (!int.TryParse(input, out returnNum) || returnNum < 0)
            {
                Console.Write("\n\tInvalid data entered\n\tThe entered value is not a number, or not an integer, or a negative number\n\n");
                Console.Write("Please enter a positive integer or zero: ");
                input = Console.ReadLine();
            }
            return returnNum;
        }

    }
}
