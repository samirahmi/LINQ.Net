using System.Linq;
using System.Linq.Expressions;

//class Program
//{
//    static void Main()
//    {
//        var nums = new int[] { 3, 1, 2, 3, 4, 2 };
//        var result = FindDuplicate.findDuplicate(nums);
//        Console.WriteLine($"Result : {result}");

//        var resultLINQ = FindDuplicate.findDuplicateLINQ(nums);
//        Console.WriteLine($"ResultLINQ : {resultLINQ}");
//    }
//}

//class FindDuplicate
//{
//    public static int findDuplicate(int[] nums)
//    {
//        var nilai_1 = nums[0];
//        var nilai_2 = nums[0];

//        while(true)
//        {
//            nilai_1 = nums[nilai_1];
//            nilai_1 = nums[nums[nilai_2]];

//            if (nilai_1 == nilai_2)
//                break;
//        }

//        var ptr1 = nums[0];
//        var ptr2 = nilai_1;

//        while(ptr1 != ptr2)
//        {
//            ptr1 = nums[ptr1];
//            ptr2 = nums[ptr2];
//        }

//        return ptr1;
//    }

//    //MENCARI DUPLIKAT DENGAN LINQ
//    public static int findDuplicateLINQ(int[] nums)
//    {
//        var qryDuplicate = nums.GroupBy(x => x)
//            .Where(w => w.Count() > 1)
//            .Select(s => s)
//            .ToList();

//        var result = qryDuplicate.FirstOrDefault();
//        return result.ElementAt(0);
//    }
//}

//SELECT DISTINCT
//==========================================================================================
//class Program
//{
//    static void Main()
//    {
//        int[] fibb = { 0, 1, 1, 2, 2, 3, 5 };
//        int fibbCount = fibb.Count();
//        Console.WriteLine($"Fibb Count : {fibbCount}");

//        IEnumerable<int> distinctFibb = fibb.Distinct(); //SELECT DISTINCT Fields....
//        foreach(var dis in distinctFibb)
//        {
//            Console.WriteLine($"{dis}");
//        }
//    }
//}


//PENGGUNAAN WHERE di LINQ
//==========================================================================================
//class Program
//{
//    static void Main()
//    {
//        int[] fibb = { 0, 1, 1, 2, 3, 5 };
//        //buat query nya tapi belum di execute oleh compiler
//        IEnumerable<int> nums = fibb.Where(w => w > 2);
//        fibb[0] = 99; // Assign value

//        foreach(var num in nums) // query LINQ di execute {99, 1, 1, 2, 3, 5}
//        {
//            Console.WriteLine($"{num}");
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        int[] fibb = { 0, 1, 1, 2, 3, 5 };
//        //buat query ny telah di execute oleh compiler
//        IEnumerable<int> nums = fibb.Where(x => x > 2).ToArray();
//        fibb[0] = 99;

//        foreach (var num in nums) // query LINQ ynag sudah di execute { 3, 5 }
//        {
//            Console.WriteLine($"{num}");
//        }
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        //COLLECTION string Countries
//        List<string> countries = new List<string>();
//        countries.Add("India"); //assign value
//        countries.Add("USA");
//        countries.Add("Australia");
//        countries.Add("Russia");

//        //Select from collection sstring countries
//        // == != > >= < <= logical operator bisa ditaruh di clausa WHERE
//        IEnumerable<string> result = countries.Select(x => x).Where(w => w.Contains("R"));
//        foreach (var country in result) // loop
//        {
//            Console.WriteLine($"{country}"); //Display
//        }
//    }
//}

// AGGREGATE pada LINQ Sum, Max, Count, Min, Avg
// ===========================================================
class Program
{
    static void Main()
    {
        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int total = 0;
        for (int i =0; i < nums.Length; i++)
        {
            total = total + nums[i]; // SUM menggunakan loop
        }
        Console.WriteLine($"LOOP = {total}");

        int sum = nums.Sum(); // Sum Menggunakan LINQ
        Console.WriteLine($"LINQ = {sum}");

        double result = total / nums.Length; // AVERAGE menggunkan loop
        Console.WriteLine($"AVG LOOP = {result}");

        double avg = nums.Average(); // AVERAGE MENGGUNAKAN LINQ
        Console.WriteLine($"AVG LINQ = {avg}");

        int min = nums.Min();
        Console.WriteLine($"Min = {min}");
        int max = nums.Max();
        Console.WriteLine($"Max = {max}");
        int count = nums.Count();
        Console.WriteLine($"Count = {count}");
    }
}