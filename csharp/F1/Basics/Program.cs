internal class Program
{
    public static void Main(string[] args)
    {
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("\n--- The Main Menu ---");
            Console.WriteLine("1 - Variables and Types");
            Console.WriteLine("2 - Shipping Price");
            Console.WriteLine("3 - Multiplication Table");
            Console.WriteLine("4 - Sum Numbers");
            Console.WriteLine("5 - Saudi Mobile Validator");
            Console.WriteLine("6 - Delivery Cities");
            Console.WriteLine("7 - Classics (Algorithms)");
            Console.WriteLine("0 - Exit");
            Console.Write("Choose an option: ");

            if (int.TryParse(Console.ReadLine(), out var value))
            {
                switch (value)
                {
                    case 1:
                        VariablesDemo();
                        break;
                    case 2:
                        ShippingPriceDemo();
                        break;
                    case 3:
                        MultiplicationDemo();
                        break;
                    case 4:
                        SumNumbersDemo();
                        break;
                    case 5:
                        SaudiMobileNumber();
                        break;
                    case 6:
                        DeliveryCities();
                        break;
                    case 7:
                        ClassicsDemo();
                        break;
                    case 0:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please enter numbers only.");
            }
        }
    }

    static void VariablesDemo()
    {
        int numberOfItems;
        Console.WriteLine("Number of Items:");
        int.TryParse(Console.ReadLine(), out numberOfItems);

        string customer;
        Console.WriteLine("Enter customer name:");
        customer = Console.ReadLine() ?? "";

        double enterWeight;
        Console.WriteLine("Enter the weight:");
        double.TryParse(Console.ReadLine(), out enterWeight);

        decimal price;
        Console.WriteLine("Enter the price of the shipment:");
        decimal.TryParse(Console.ReadLine(), out price);

        bool shipmentDelivered;
        Console.WriteLine("Is the shipment delivered (True/False):");
        bool.TryParse(Console.ReadLine(), out shipmentDelivered);

        DateTime orderTime = DateTime.Now;
        var city = "Amman";

        Console.WriteLine($"Number of items: {numberOfItems}, Customer: {customer}, Weight: {enterWeight}, Price: {price}, Delivered: {shipmentDelivered}, Order time: {orderTime}, Location: {city}");
    }

    static void ShippingPriceDemo()
    {
        Console.Write("Enter weight (kg): ");
        decimal.TryParse(Console.ReadLine(), out decimal weight);
        decimal price = CalculatePrice(weight);
        Console.WriteLine($"Shipping price for {weight} kg is: {price}");
    }

    static void MultiplicationDemo()
    {
        Console.WriteLine("Enter a number for multiplication table:");
        int.TryParse(Console.ReadLine(), out int number);
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} * {i} = {number * i}");
        }
    }

    static void SumNumbersDemo()
    {
        int sum = 0;
        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter a number to add (0 to stop): ");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                sum += number;
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a number.");
                number = -1;
            }
        }
        Console.WriteLine($"Total sum is {sum}");
    }

    static void SaudiMobileNumber()
    {
        Console.WriteLine("Please enter a Saudi mobile number:");
        string saudiNumber = Console.ReadLine() ?? "";
        if (IsValidSaudiMobile(saudiNumber))
        {
            Console.WriteLine("Valid Saudi mobile number.");
        }
        else
        {
            Console.WriteLine("Invalid Saudi mobile number.");
        }
    }

    static void DeliveryCities()
    {
        List<string> cities = new List<string> { "Amman", "Riyadh", "Dammam" };
        foreach (string city in cities)
        {
            Console.WriteLine(city);
        }
    }

    static void ClassicsDemo()
    {
        Console.WriteLine("--- 1. FizzBuzz ---");
        for (int i = 1; i <= 20; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(i);
        }

        Console.WriteLine("--- 2. Reverse a String ---");
        Console.WriteLine("Enter a word to reverse:");
        string text = Console.ReadLine() ?? "";
        string reverse = "";
        for (int t = text.Length - 1; t >= 0; t--)
        {
            reverse += text[t];
        }
        Console.WriteLine($"Reversed: {reverse}");

        Console.WriteLine("--- 3. Count Vowels ---");
        Console.WriteLine("Enter text to count vowels:");
        string vowelText = Console.ReadLine() ?? "";
        int vowelCount = 0;
        string vowelLetters = "aeiou";
        foreach (char h in vowelText)
        {
            if (vowelLetters.Contains(char.ToLower(h)))
            {
                vowelCount++;
            }
        }
        Console.WriteLine($"Vowel count: {vowelCount}");

        Console.WriteLine("--- 4. Largest Number in an Array ---");
        int[] numbers = { 10, 22, 45, 74, 96, 58, 334 };
        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"Largest number is {largest}");
    }

    static decimal CalculatePrice(decimal weightKg)
    {
        if (weightKg <= 1)
        {
            return 10m;
        }
        else if (weightKg <= 5)
        {
            return 15m;
        }
        else if (weightKg <= 20)
        {
            return 25m;
        }
        else
        {
            return 40m;
        }
    }

    static bool IsValidSaudiMobile(string mobile)
    {
        return mobile.Length == 10 && mobile.StartsWith("05") && long.TryParse(mobile, out _);
    }
}