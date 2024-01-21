using System;

namespace PractiseSession
{
    class Program
    {
        public static void SwapUsingThirdVariable()
        {
            int FirstValue = 32;
            int SecondValue = 2;
            int temp;
            Console.WriteLine($"Before Swapping: First Value = {FirstValue} and Second Value = {SecondValue} ");

            temp = FirstValue;
            FirstValue = SecondValue;
            SecondValue = temp;
            Console.WriteLine($"After Swapping: First Value = {FirstValue} and Second Value = {SecondValue} ");
        }

        public static void SwapWithoutThirdVariable()
        {
            int FirstValue = 32;
            int SecondValue = 2;
            Console.WriteLine($"Before Swapping: First Value = {FirstValue} and Second Value = {SecondValue} ");
            FirstValue = SecondValue + FirstValue;
            SecondValue = FirstValue - SecondValue;
            FirstValue = FirstValue - SecondValue;
            Console.WriteLine($"Afterswapping: First Value = {FirstValue} and Second Value = {SecondValue} ");

        }

        public static void WaleedSalary()
        {
            Console.Write("Enter your salary: ");
            double Salary = Convert.ToDouble(Console.ReadLine());
            double GrossSalary;
            GrossSalary = Salary + 0.4 * Salary + 20 * Salary;
            Console.WriteLine($"Gross Salary is: {GrossSalary}");
        }

        public static void DistanceBetweenCities()
        {
            Console.Write("Enter Distance in km: ");
            double Distance = Convert.ToDouble(Console.ReadLine());
            double Meters;
            double Feet;
            double Inches;
            double Centimeters;

            Meters = Distance * 1000;
            Feet = Distance * 3280.84;
            Inches = Distance * 39370.1;
            Centimeters = Distance * 100000;
            Console.WriteLine($" Distance in Meters = {Meters} \n Distance in Feet = {Feet} \n Distance in Inches = {Inches} \n Distance in Centimeters = {Centimeters}");
        }

        public static void AggregateMarks()
        {
            Console.WriteLine("Enter 1st subject: ");
            double Sub1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 2nd subject: ");
            double Sub2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 3rd subject: ");
            double Sub3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 4th subject: ");
            double Sub4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 5th subject: ");
            double Sub5 = Convert.ToDouble(Console.ReadLine());
            double Percentage;
            double AggregateMarks;

            AggregateMarks = Sub1 / 100 * 100 + Sub2 / 100 * 100 + Sub3 / 100 * 100 + Sub4 / 100 * 100 + Sub5 / 100 * 100;
            Percentage = AggregateMarks / 500 * 100;

            Console.WriteLine($"Your Percentage is {Percentage}");
            Console.WriteLine($"Your Aggregate is {AggregateMarks}");
        }

        public static void FahrenheitIntoCelcius()
        {
            Console.WriteLine(" Enter Temp in Fahrenheit: ");
            Double TempinF = Convert.ToDouble(Console.ReadLine());

            double TempinC;

            TempinC = (TempinF - 32) * 5 / 9;
            Console.WriteLine($"Your Temp in Celcius: {TempinC} ");
        }

        public static void AreaParemeterRectangle()
        {
            Console.Write("Enter Length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter breadth: ");
            double breadth = Convert.ToDouble(Console.ReadLine());
            double RectangleArea;
            double RectangleParameter;
            RectangleArea = length * breadth;
            RectangleParameter = length * 2 + breadth * 2;
            Console.WriteLine($" Rectangle Area is: {RectangleArea}\n Rectangle Parameter is: {RectangleParameter}");
        }

        public static void IlleteracyRate()
        {
            double TotalPopulation = 80000;
            double TotalMen = Convert.ToDouble("52") / Convert.ToDouble(100) * TotalPopulation; //41600;
            double TotalLiteracy = Convert.ToDouble(48) / Convert.ToDouble(100) * TotalPopulation;  //38400
            double TotalLiterateMen = Convert.ToDouble("35") / Convert.ToDouble(100) * TotalPopulation;
            double IlleterateMen;
            double NumberofWomen;
            double IlleterateWomen;


            IlleterateMen = TotalMen - TotalLiterateMen;
            NumberofWomen = TotalPopulation - TotalMen;
            IlleterateWomen = TotalLiteracy - TotalLiterateMen;



            Console.WriteLine($"Total Illiterate Men: {IlleterateMen}");
            Console.WriteLine($"Total Women: {IlleterateWomen}");



        }

        public static void DenominationAmount()
        {
            Console.Write("Enter amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            int hundereds = amount / 100;
            int fifties = amount % 100 / 50;
            int tens = amount % 100 % 50 / 10;

            Console.WriteLine($"Amount in Hundereds: {hundereds}");
            Console.WriteLine($"Amount in Fifties: {fifties}");
            Console.WriteLine($"Amount in Tens: {tens}");
        }

        public static void CostofItem()
        {
            int items = 15;
            Console.WriteLine("Enter Selling Price: ");
            int SellingPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Profit Generated");
            int Profit = Convert.ToInt32(Console.ReadLine());
            int itemsPriceinTotal;
            int SingleItemPrice;

            itemsPriceinTotal = SellingPrice - Profit;
            SingleItemPrice = itemsPriceinTotal / items;

            Console.WriteLine($" Total Price of Items: {itemsPriceinTotal} \n Per Item's Price: {SingleItemPrice}");
        }

        public static void ProfitLoss()
        {
            Console.WriteLine("Enter Cost Price:");
            int CostPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Selling Price:");
            int SellingPrice = Convert.ToInt32(Console.ReadLine());
            int Determination;
            int ProfitMade;
            int LossIncurred;

            Determination = SellingPrice - CostPrice;
            if (Determination > CostPrice)
            {
                Console.WriteLine($"Profit Generated = {Determination} ");
            }

            else if (Determination == 0)
            {
                Console.WriteLine("No Profit Loss made ");
            }

            else
                Console.WriteLine($"Loss Incurred = {Determination} ");
        }

        public static void LeapYearMod()
        {
            int year = Convert.ToInt32(Console.ReadLine());
            //  if (year)
            {

            }
        }

        public static void FindLeapYear()
        {
            int Year;
            Console.Write("Enter The Year");
            Year = Convert.ToInt32(Console.ReadLine());

            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            {
                Console.WriteLine("It's a Leap Year!");
            }
            else
            {
                Console.WriteLine("It's Not a Leap Year!");
            }
        }

        public static void AbsoluteNumber()
        {
            double number, absolute;
            Console.Write("Enter a Number to Find it's Absolute:");
            number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine($"Absoulte of the Number is:{number}");
            }
            else
            {
                number = -(number);
                Console.WriteLine($"Absoulte of the Number is:{number}");
            }
        }

        public static void DriverInsurance()
        {
            Console.Write("Is the Driver Married? (true/false): ");
            bool MaritalStatus = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Enter Gender ' M ' for Male ' F ' for Female: ");
            String Gender = Console.ReadLine();
            Console.WriteLine("Enter Age: ");
            int Age = Convert.ToInt32(Console.ReadLine());

            if (MaritalStatus == true)
            {
                Console.WriteLine("The Driver is Insured! ");
            }
            else if (MaritalStatus == false && Gender == "M" && Age > 30)
            {
                Console.WriteLine("The Driver is Insured! ");
            }
            else if (MaritalStatus == false && Gender == "F" && Age > 25)
            {
                Console.WriteLine("The Driver is Insured! ");
            }
            else
            {
                Console.WriteLine("The Driver is not Insured! ");
            }

        }

        public static void StudentPercentage()
        {
            int Subject1 = Convert.ToInt32(Console.ReadLine());
            int Subject2 = Convert.ToInt32(Console.ReadLine());
            int Subject3 = Convert.ToInt32(Console.ReadLine());
            int Subject4 = Convert.ToInt32(Console.ReadLine());
            int Subject5 = Convert.ToInt32(Console.ReadLine());
            int Sum;
            int TotalPercentage;
            Sum = Subject1 + Subject2 + Subject3 + Subject4 + Subject5;

            TotalPercentage = (Sum * 100) / 500;
            Console.WriteLine($"Total Percentage is: {TotalPercentage}");

            if (TotalPercentage <= 40)
            {
                Console.WriteLine("Fail!");
            }
            else if (TotalPercentage <= 49)
            {
                Console.WriteLine("3rd Division");
            }
            else if (TotalPercentage <= 59)
            {
                Console.WriteLine("2nd Division");
            }
            else
            {
                Console.WriteLine("1st Division");
            }
        }

        public static void PremiumInsurance()
        {
            Console.WriteLine("Enter Health Status: ");
            string Health = Console.ReadLine();
            Console.WriteLine("Enter Age: ");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lives in?: ");
            string Livesin = Console.ReadLine();
            Console.WriteLine("Enter Gender: ");
            string Gender = Console.ReadLine();

            if (Health == "Excellent" && Age >= 25 && Age <= 35 && Livesin == "City" && Gender == "Male")
            {
                Console.WriteLine("The premium is Rs. 40 per thousand and his policy amount can’t exceed Rs. 2 Lakh.");
            }
            else if (Health == "Excellent" && Age >= 25 && Age <= 35 && Livesin == "City" && Gender == "Female")
            {
                Console.WriteLine("The premium is Rs. 30 per thousand and her policy amount can’t exceed Rs. 1 Lakh.");
            }
            else if (Health == "Poor" && Age >= 25 && Age <= 35 && Livesin == "Village" && Gender == "Male")

            {
                Console.WriteLine("The premium is Rs. 60 per thousand and his policy amount can’t exceed Rs. 10,000.");
            }
            else
            {
                Console.WriteLine("The Person is Not Insured!");
            }

        }

        public static void NumberwithLoop()
        {
            int row;
            int column;
            for ( row = 1; row <= 4; row++)
            {
               for ( column = 1; column<=row; column++) 
                {
                    Console.Write(column);
                }
                Console.WriteLine("\n");
            }
        }

        public static void SameNumDiffRow()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine("\n");
            }
        }

        public static void IncreasedNumBy1()
        {
            int count = 0;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    count++;
                    Console.Write(count);
                }
                Console.WriteLine("\n");
            }
        }

        //NOT COMPLETE!
        public static void PrimeNumber()
        {
            Console.WriteLine("Enter a Number: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            if (Number <= 1)
            {
                Console.WriteLine("Number is not Prime");
            }
            else
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(Number); i++)
                {
                    if (Number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    Console.WriteLine("Number is Prime!");
                }
                else
                {
                    Console.WriteLine("Number is Not Prime");
                }
            }



        }

        public static void OvertimePay()
        {
            int EmployeesNumber = 10;
            int RatePerHour = 200;
            int DailyHoursLimit = 40;
            Console.Write("Enter the Number of hours Employees worked: ");
            int TotalHoursWorked = Convert.ToInt32(Console.ReadLine()) ;
            int OvertimeHours;
            int OverTimePay;

            if (TotalHoursWorked > 40)
            {
                OvertimeHours = TotalHoursWorked - 40;
                Console.WriteLine($"Ovetime Hours: {OvertimeHours}");
                OverTimePay = OvertimeHours * 200;
                Console.WriteLine($"Ovetime Pay: {OverTimePay}");

            }
            else
            {
                Console.WriteLine("No Overtime.");
            }
        }

        public static void Factorial()
        {
            Console.WriteLine("Enter a number: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            int Fact=1;
            for (int i = 1; i <= Number; i++)
            {
                Fact = i * Fact ;
            }
            Console.WriteLine($"Factorial is: {Fact}");
        }

        public static void WeekDays()
        {
            Console.Write("Enter Number of the Day: ");
            int Number = Convert.ToInt32(Console.ReadLine());

            switch (Number)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }

        }

        public static void Reverse()
        {
            Console.Write("Enter a 5 digit number: ");
            int number = int.Parse(Console.ReadLine());
            int reverse = 0;
            int rem = 0;

            for ( ; number != 0;)
            {
                rem = number % 10;
                reverse = (reverse * 10) + rem;
                number /= 10;
            }
            Console.WriteLine($"The reverse of number is: {reverse}");
        }

        public static void Vowels()
        {
            Console.Write("Enter an Alphabet: ");
            char Alphabet = Convert.ToChar(Console.ReadLine());

            switch (Alphabet)
            {
                case 'a':
                    Console.WriteLine("Its a Vowel");
                    break;
                case 'e':
                    Console.WriteLine("Its a Vowel");
                    break;
                case 'i':
                    Console.WriteLine("Its a Vowel");
                    break;
                case 'o':
                    Console.WriteLine("Its a Vowel");
                    break;
                case 'u':
                    Console.WriteLine("Its a Vowel");
                    break;
                default:
                    Console.WriteLine("Its Not a Vowel");
                    break;
            }
        }

        public static void NumofDays()
        {
            Console.Write("Enter Month Number: ");
            int Number = Convert.ToInt32(Console.ReadLine());

            switch (Number)
            {
                case 1:
                    Console.WriteLine("31 Days");
                    break;
                case 2:
                    Console.WriteLine("28 OR 29 Days Depending if its a leap Year");
                    break;
                case 3:
                    Console.WriteLine("31 Days");
                    break;
                case 4:
                    Console.WriteLine("30 Days");
                    break;
                case 5:
                    Console.WriteLine("31 Days");
                    break;
                case 6:
                    Console.WriteLine("30 Days");
                    break;
                case 7:
                    Console.WriteLine("31 Days");
                    break;
                case 8:
                    Console.WriteLine("31 Days");
                    break;
                case 9:
                    Console.WriteLine("30 Days");
                    break;
                case 10:
                    Console.WriteLine("31 Days");
                    break;
                case 11:
                    Console.WriteLine("30 Days");
                    break;
                case 12:
                    Console.WriteLine("31 Days");
                    break;

                default:
                    Console.WriteLine("Invalid Month Number");
                    break;
            }

        }

        public static void SimpleCalculator()
        {
            Console.WriteLine("Type an operator from the following: '+' '-' '*' '/'");
            string op = Console.ReadLine();
            Console.WriteLine("Type a Number: ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type a Number: ");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            int result;

            switch (op)
            {
                case "+":
                    result = Num1 + Num2;
                    Console.WriteLine($"The Sum is: {result}");
                    break;
                case "-":
                    result = Num1 - Num2;
                    Console.WriteLine($"The Sub is: {result}");
                    break;
                case "*":
                    result = Num1 * Num2;
                    Console.WriteLine($"The Sub is: {result}");
                    break;
                case "/":
                    result = Num1 / Num2;
                    Console.WriteLine($"The Sub is: {result}");
                    break;

            }

        }

        public static void Array1DReverse( int[] MyArray)
        {
            
            Array.Sort(MyArray);
            Array.Reverse(MyArray);
            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.WriteLine(MyArray[i]);
            }
        }

        public static bool Array2DIdentityMatrix(int[,] Matrix)
        {
            int rows = Matrix.GetLength(0);
            int columns = Matrix.GetLength(1);
            if (rows != columns)
            {
                return false;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (i == j && Matrix[i,j] != 1)
                    {
                        return false;
                    }

                    if (i != j && Matrix[i, j] != 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        //NOT COMPLETE
        public static void Sum2DArray()
        {

        }

        public static void ArrayElementFinder()
        {
            int[] Array = { 64, 78, 98, 46 };
            Console.WriteLine("Enter the Number you want to search for: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] == Number)
                {
                    Console.WriteLine($"Element {Number} found at index {i}");
                    return;
                }
            }
            Console.WriteLine($"Element {Number} not found in the array");
        }

        //NOT COMPLETE
        public static void NoStringLibraries()
        {

        }

        public static void VowelsConsonent()
        {
            int Vowels = 0;
            int Consonent = 0;

            Console.WriteLine("Enter a Sentence: ");
            string sentence = Console.ReadLine();
            
            for(int i=1; i< sentence.Length; i++)

            if (sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] == 'i' || sentence[i] == 'o' || sentence[i] == 'u' )
            {
                Vowels++;
            }

            else
            {
                Consonent++;
            }

            Console.WriteLine($"The Total number of Vowels is: {Vowels}");
            Console.WriteLine($"The Total number of Consonents is: {Consonent}");

        }

        public static void UserLogin()
        {
            string Username = "Hamza";
            string Password = "Hamza123";

            Console.WriteLine("Enter Username: ");
            string Newusername = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            string NewPassword = Console.ReadLine();

            if (Username == Newusername && Password == NewPassword)
            {
                Console.WriteLine("The Login was successfull!");
            }
            else
            {
                Console.WriteLine("The Login Failed!");
            }
        }

        static void Main(string[] args)
        {
            // UserLogin();
             VowelsConsonent();
            // NoStringLibraries();
            // ArrayElementFinder();
            //{
            //    int[,] identityMatrix = { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
            //    bool result = Array2DIdentityMatrix(identityMatrix);
            //    Console.WriteLine("Is Matrix an identity Matrix: " + result);
            //}

            //    {
            //        int[] MyArray = { 99, 40, 600, 39, 55 };
            //        Array1DReverse(MyArray);
            //    }

            // SimpleCalculator();
            // NumofDays();
            // Vowels();
            // Reverse();
            // WeekDays();
            // Factorial();
            // OvertimePay();
            // PrimeNumber();
            // IncreasedNumBy1();
            // SameNumDiffRow();
            // NumberwithLoop();
            // PremiumInsurance();
            // StudentPercentage();
            // DriverInsurance();
            // AbsoluteNumber();
            // FindLeapYear();
            // ProfitLoss();
            // CostofItem();
            // DenominationAmount();
            // IlleteracyRate();  
            // AreaParemeterRectangle();
            // FahrenheitIntoCelcius();
            // AggregateMarks();
            // DistanceBetweenCities();
            // WaleedSalary();
            // SwapWithoutThirdVariable();
            // SwapUsingThirdVariable();



            //Chef NormalChef = new Chef();
            //NormalChef.MakeSalad();
            //SpecialChef Specialchef = new SpecialChef();
            //Specialchef.MakesSpecial();

            Console.ReadLine();
        }
    }
}
