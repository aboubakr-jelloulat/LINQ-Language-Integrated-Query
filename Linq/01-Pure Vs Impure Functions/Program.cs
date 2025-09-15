
internal class Program
{
    // Global variable
    static List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    static void Main(string[] args)
    {
        Console.WriteLine("Original list:");
        Print(numbers);

        // --- Impure functions ---
        AddInteger1(10);   // Changes global variable
        var x = 5;
        AddInteger2(ref x); // Changes parameter and global variable
        AddInteger3();      // Uses random => interacts with outside world


        Console.WriteLine("\nAfter impure functions:");
        Print(numbers);

        // --- Pure function ---
        var newList = AddInteger4(numbers, 100); // Returns new list without changing old
        Console.WriteLine("\nOld list (unchanged by pure function):");
        Print(numbers);
        Console.WriteLine("New list (result of pure function):");
        Print(newList);

        Console.ReadKey();
    }

    static void Print(List<int> source)
    {
        foreach (var item in source)
        {
            Console.Write($" {item}");
        }
        Console.WriteLine();
    }

    // Impure: modifies global variable
    static void AddInteger1(int num)
    {
        numbers.Add(num);
    }

    // Impure: modifies both parameter (by ref) and global variable
    static void AddInteger2(ref int num)
    {
        num++;
        numbers.Add(num);
    }

    // Impure: interacts with outside world (random)
    static void AddInteger3()
    {
        numbers.Add(new Random().Next());
    }

    // ---------------- Pure Function ----------------

    // Pure: does not modify global state, only returns a new list
    static List<int> AddInteger4(List<int> numbers, int num)
    {
        var result = new List<int>(numbers); // Copy the list
        result.Add(num);
        return result;
    }
}

/*
    ====================== PURE vs IMPURE FUNCTIONS ======================

    1️⃣ Pure Functions:
        - Always produce the same output for the same input.
        - Do NOT modify any external state (no global variables, no file/database changes, etc.).
        - Easy to test and reason about.
        - Example: AddInteger4 in the code above
            * Takes a list and a number
            * Returns a new list with the number added
            * Original list remains unchanged

    2️⃣ Impure Functions:
        - May produce different output for the same input.
        - Can modify external state (global variables, parameters by ref, files, databases, random numbers, etc.).
        - Harder to test and debug.
        - Examples: AddInteger1, AddInteger2, AddInteger3 in the code above
            * They change the global 'numbers' list
            * AddInteger3 also uses Random(), so output is unpredictable

    ====================== SUMMARY ======================
    Pure = predictable, no side effects ✅
    Impure = may change outside world, less predictable ❌
*/
