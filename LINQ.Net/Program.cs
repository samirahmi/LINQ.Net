using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;

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
//class Program
//{
//    static void Main()
//    {
//        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//        int total = 0;
//        for (int i =0; i < nums.Length; i++)
//        {
//            total = total + nums[i]; // SUM menggunakan loop
//        }
//        Console.WriteLine($"LOOP = {total}");

//        int sum = nums.Sum(); // Sum Menggunakan LINQ
//        Console.WriteLine($"LINQ = {sum}");

//        double result = total / nums.Length; // AVERAGE menggunkan loop
//        Console.WriteLine($"AVG LOOP = {result}");

//        double avg = nums.Average(); // AVERAGE MENGGUNAKAN LINQ
//        Console.WriteLine($"AVG LINQ = {avg}");

//        int min = nums.Min();
//        Console.WriteLine($"Min = {min}");
//        int max = nums.Max();
//        Console.WriteLine($"Max = {max}");
//        int count = nums.Count();
//        Console.WriteLine($"Count = {count}");
//    }
//}

// PEINTAH SORTING PADA LINQ || SORTING, BUBBLE SORT, INSERTIONSORT, QUICKSORT, MERGESORT
// =======================================================================================
// CONTOH 1

//class Program
//{
//    static void Main()
//    {
//        int[] nums = { 8, 6, 4, 9, 3, 11, 3, 5 };
//        //var sortNumbers = nums.OrderBy(x => x); // Order ASC
//        var sortNumbers = nums.OrderByDescending(x => x); // ORDER DESC
//        foreach(var sortnumber in sortNumbers)
//        {
//            Console.WriteLine(sortnumber);
//        }

//        List<Student> students = new List<Student>()
//        {
//            new Student() { Name = "Sami", Gender = "Female", Subject = new List<string> { "C# Fundamental", "Calculus" } },
//            new Student() { Name = "Garaa", Gender = "Male", Subject = new List<string> { "C# Fundamental", "Calculus" } },
//            new Student() { Name = "Ryu", Gender = "Male", Subject = new List<string> { "C# Fundamental", "Calculus" } }
//        };

//        Console.WriteLine("\nBefore Order Sort");
//        foreach (var student in students)
//        {
//            Console.WriteLine(student.Name);
//        }

//        //var studentOrder = students.OrderBy(x => x.Name); // Order ASC
//        var studentOrder = students.OrderByDescending(x => x.Name); // Order DESC
//        Console.WriteLine("\nAfter Order Sort");
//        foreach (var student in studentOrder)
//        {
//            Console.WriteLine(student.Name);
//        }
//    }
//}

//class Student
//{
//    public string Name { get; set; }

//    public string Gender { get; set; }

//    public List<string> Subject { get; set; }
//}

// CONTOH 2 SORTING
//class Program
//{
//    static void Main()
//    {
//        List<Student> students = new List<Student>()
//        {
//            new Student(){ StudentId = 1, Name = "Sami", Gender = "Female", 
//                Subject = new List<string>{ "Web Design", "Fisika Dasar"} },
//            new Student(){ StudentId = 1, Name = "Garaa", Gender = "Male", 
//                Subject = new List<string>{ "Web Design", "Fisika Dasar"} },
//            new Student(){ StudentId = 3, Name = "Kabuto", Gender = "Male",
//                Subject = new List<string>{ "Web Design", "Fisika Dasar"} },
//            new Student(){ StudentId = 2, Name = "Raya", Gender = "Female",
//                Subject = new List<string>{ "Web Design", "Fisika Dasar"} },
//            new Student(){ StudentId = 2, Name = "Didit", Gender = "Female",
//                Subject = new List<string>{ "Web Design", "Fisika Dasar"} },
//            new Student(){ StudentId = 5, Name = "Lili", Gender = "Female",
//                Subject = new List<string>{ "Web Design", "Fisika Dasar"} },
//        };

//        // Sorting berdasarkan studentId, dilanjut oleh ThenBy yang diurutkan ASC / ThenByDescending diurutkan DESC
//        // SELECT * FROM Student Order by StudentId AND Name
//        var studentSorted = students.OrderBy(x => x.StudentId).ThenBy(x => x.Name);
//        //var studentSorted = students.OrderByDescending(x => x.StudentId).ThenByDescending(x => x.Name);
//        foreach (var student in studentSorted)
//        {
//            Console.WriteLine($"{student.StudentId} - {student.Name} - {student.Subject[0]} - {student.Subject[1]}");
//        }
//    }
//}

//class Student
//{
//    public int StudentId { get; set; } 
//    public string Name { get; set; }
//    public string Gender { get; set; }
//    public List<string> Subject { get; set; }
//}


// PARTITION QUERY, SKO, TAKE, dan TAKEWHILE
// =======================================================================================
// CONTOH 1
//class Program
//{
//    static void Main()
//    {
//        string[] countries = { "India", "USA", "Indonesia", "Turki", "Polandia" };

//        // SELECT * FROM Countries LIMIT 3
//        //IEnumerable<string> result = countries.Take(3); //cara 1
//        IEnumerable<string> result = (from x in countries select x).Take(4); // cara 2 x didalam cuntries
//        foreach(var country in result)
//        {
//            Console.WriteLine(country);
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        string[] countries = { "USA", "UK", "France", "NKRI", "Australia", "Argentina" };

//        // SELECT * FROM Countries LIMIT 3
//        // TAKEWHILE STARTSWITH akan mengambil value string dgn kriteria tapi jika dia false langsung exit takewhile
//        IEnumerable<string> result = countries.TakeWhile(x => x.StartsWith("U"));
//        //IEnumerable<string> result = countries.TakeWhile((country, index) => country.Length >= index);
//        foreach (var country in result)
//        {
//            Console.WriteLine(country);
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        string[] countries = { "India", "USA", "Indonesia", "Turki", "Polandia" };

//        // SELECT * FROM (
//        // SELECT ROW_NUMBER() OVER(ORDER BY Country) as RowNum FROM Countries)
//        // AS Tbl WHERE Country < RowNum
//        IEnumerable<string> result = countries.Skip(3);
//        foreach (var country in result)
//        {
//            Console.WriteLine(country);
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        string[] fruits = { "apple", "passionfruit", "banana", "mango",
//                      "orange", "blueberry", "grape", "strawberry" };

//        IEnumerable<string> query =
//            fruits.TakeWhile((fruit, index) => fruit.Length >= index);

//        foreach (string fruit in query)
//        {
//            Console.WriteLine(fruit);
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        string[] countries = { "USA", "UK", "France", "NKRI", "Australia", "Argentina",
//        "England", "Qatar", "Poland", "Korea Utara"};

//        // SELECT 8 FROM Countries
//        // ORDER BY [Field]
//        // OFFSET 3 ROWS --------> SKIP
//        // FETCH NEXT 5 ROWS ONLY ---------------> TAKE
//        IEnumerable<string> result = (from x in countries select x).Skip(3).Take(5).OrderBy(x => x);

//        foreach(var country in result)
//        {
//            Console.WriteLine(country);
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        string[] countries = { "USA", "UK", "France", "NKRI", "Australia", "Korea Selatan",
//            "Poland", "Qatar", "Japan" };

//        // SELECT 8 FROM Countries
//        // WHERE Fields Like '%a%' ----------> WHERE.CONTAINS
//        // ORDER BY [Field] DESC ----------> ORDERBYDESCENDING
//        // OFFSET 3 ROWS --------> SKIP
//        // FETCH NEXT 5 ROWS ONLY ---------------> TAKE

//        IEnumerable<string> result = (from x in countries select x)
//            .Skip(3)
//            .Take(5)
//            .Where(x => x.Contains("a"))
//            .OrderByDescending(x => x);
//        foreach(var country in result)
//        {
//            Console.WriteLine(country);
//        }
//    }
//}