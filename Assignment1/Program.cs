namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            Console.WriteLine(input);
            #endregion
            #region Q2
            Console.Write("Convert from string To Number");
            string inp = Console.ReadLine();
            try
            {
                int output = Convert.ToInt32(inp);
                Console.WriteLine($"the number that you converted is : {output}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: The input contains non-numeric characters and cannot be converted to number.");
            }

            // there is an error when string contain non-numeric because it isn't converted to number
            #endregion
            #region Q3
            try
            {
                Console.Write("Enter first numbers for multiplication: ");
                float num1 = float.Parse(Console.ReadLine());
                Console.Write("Enter second numbers for multiplication: ");
                float num2 = float.Parse(Console.ReadLine());

                float result = num1 * num2;
                Console.WriteLine($"The result is : {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR: plaese enter a number no a cahracter and special character");
            }
            #endregion
            #region Q4

            Console.Write("Please enter aSentence:");
            string inpu = Console.ReadLine();
            Console.Write("Please inter the index to start From :");
            int StartIndex = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please Enter The Length of Sentence");
            int Length = Convert.ToInt32(Console.ReadLine());
            try
            {
                string substring = inpu.Substring(StartIndex, Length);
                Console.WriteLine($"The Sentence you want is : {substring}");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Error : The Index Or Length is out of range");
            }


            #endregion
            #region Q5
            int x = 4;
            int y = 9;
            Console.WriteLine($"x = {x}, y = {y}");
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            y = x;
            Console.WriteLine($"x = {x}, y = {y}");
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            x++;
            Console.WriteLine($"x = {x}, y = {y}");
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("it is mean that when you assigne one value type to another it gets a copy of value from the variable in the right side and the other variable dosn'r affected because independent copies of the same value");


            #endregion

            #region Q6
            point point1 = new() { x = 10, y = 10 };
            point point2 = new() { x = 20, y = 20 };
            Console.WriteLine($"Pخint 1 = ({point1.x},{point1.y})");
            Console.WriteLine($"Point 2 = ({point2.x},{point2.y})");
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            point2 = point1;
            Console.WriteLine($"Pخint 1 = ({point1.x},{point1.y})");
            Console.WriteLine($"Point 2 = ({point2.x},{point2.y})");
            Console.WriteLine();
            Console.WriteLine("-------------------------------");

            point1.x = 100;
            point1.y = 100;
            Console.WriteLine($"Pخint 1 = ({point1.x},{point1.y})");
            Console.WriteLine($"Point 2 = ({point2.x},{point2.y})");
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("the reference type is more diffrent than value type because the value of reference type is stored in Heap and th evariable work as a pointer store address of the value that is in the heap on Stack so when we make the two variable equals the two variable on  stack store the same address so the old values in the heap dosnt have address stored in the stack and the new value have two variable take the same address refer om it so any modification in one variable affect on another variable ");
            #endregion
            #region Q7
            Console.Write("Please enter the First String: ");
            string string1 = Console.ReadLine();
            Console.Write("Please enter the Secound String: ");
            string string2 = Console.ReadLine();

            string Addtion = string1 + " " + string2;
            Console.WriteLine(Addtion);
            #endregion
            #region Q8
            //A value 1 will be assigned to d.
            #endregion
            #region Q9
            //6 1
            #endregion
            #region Q10
            //7 7
            #endregion
        }
    }
}
