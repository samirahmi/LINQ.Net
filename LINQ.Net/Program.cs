using System.Diagnostics.Metrics;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Xml.Linq;

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


// COLLECTION pada LINQ
// ===========================================================
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

// CONVERTION LINQ
// =======================================================================================
// CONVERSI ARRAY LIST KE COLLECTION LIST (list marupakan implemntasi IEnumerable)
//class Program
//{
//    static void Main()
//    {
//        // Array String
//        string[] countries = { "USA", "UK", "France", "NKRI", "Australia", "Korea Selatan",
//           "Poland", "Qatar", "Japan" }; 

//        //List<string> result = countries.ToList(); // mengkonversi string array (string) menjadi collection LIST (count)
//        List<string> result = (from x in countries select x).ToList();
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
//        List<string> countries = new List<string>();
//        countries.Add("Japan");
//        countries.Add("USA");
//        countries.Add("NKRI");
//        countries.Add("Argentina");
//        countries.Add("Polandia");
//        countries.Add("Swiss");

//        //  ----------------------------------------------------------> mengubah List collection menjadi ARRAY (string)
//        string[] result = (from x in countries select x).ToArray();
//        foreach(var country in result)
//        {
//            Console.WriteLine(country);
//        }
//    }
//}

//class Employee
//{
//    public string Name { get; set; }
//    public string Department { get; set; }
//    public string Country { get; set; }
//}

// =======================================================================================
// ELEMENT LINQ
// =======================================================================================
//// FISRT | FIRSTORDEFAULT --> mengmabil 1 row pada sequence meskipun return nya lebih dari satu sequence
//class Program
//{
//    static void Main()
//    {
//        int[] objs = { 1, 2, 1, 3, 4, 6, 7, 8 };
//        //int result = (from x in objs select x).First(); // ---> untuk mengambil element pertama pada list, array, atau collection lainnya walupun banyak nilai yang sama
//        int result = (from x in objs select x).FirstOrDefault(w => w == 1); // -----> FirstOfDefault dapat mencari value int ynag ingin di cari/ jika sequence nya NULL akan mengembalikan nilai nol
//        Console.WriteLine(result);
//    }
//}

// SINGLE | SINGLEORDEFAULT ---> mengambil 1 row HANYA pada 1 sequence (tidak ada yang lebih), ketika return ny multi dia akan error
//class Program
//{
//    static void Main()
//    {
//        int[] objs = { 1, 2, 1, 3, 4, 6, 7, 8 };
//        //int result = (from x in objs select x).Single(w => w == 2); // ---> untuk mengambil element pada list, array, atau collection lainnya dan HARUS DIBUAT RETURN/NILAI Yang ingin diambil
//        int result = (from x in objs select x).SingleOrDefault(w => w == 4); // -----> FirstOfDefault dapat mencari value int ynag ingin di cari
//        Console.WriteLine(result);
//    }
//}

// ----------------------------------
// LAST | LASTORDEFAULT
//class Program
//{
//    static void Main()
//    {
//        int[] objs = { 1, 2, 1, 3, 4, 6, 7, 8 };
//        int result = (from x in objs select x).Last(); // ---> mangembalikan last sequence, akan terjadi error jika sequence = NULL/KOSONG {}
//        int resultLoD = (from x in objs select x).LastOrDefault(); // -----> mengembalikan last sequence, akan return default value (0) jika sequence = NULL/KOSONG
//        Console.WriteLine(result);
//    }
//}

// ------------------------------------
// DEFAULTIFEMPTY
//class Program
//{
//    static void Main()
//    {
//        int[] objA = { 1, 2, 3, 4, 5, 6, 7, 8 };
//        int[] objB = { };

//        var resultA = objA.DefaultIfEmpty();
//        var resultB = objB.DefaultIfEmpty();

//        Console.WriteLine("List dengan Nilai");
//        foreach (var x in resultA)
//        {
//            Console.WriteLine($"{x}");
//        }

//        Console.WriteLine("\nList tanpa Nilai");
//        foreach (var y in resultB)

//        {
//            Console.WriteLine($"{y}");
//        }
//    }
//}

// =======================================================================================
// GROUP ELEMENT 
// =======================================================================================
// ---> ToLOOKUP
//class Program
//{
//    static void Main()
//    {
//        List<Employee> employees = new List<Employee>()
//        {
//            new Employee(){ Name = "Anton", Department = "Marketing", Country = "UK" },
//            new Employee(){ Name = "Andik", Department = "HR", Country = "USA" },
//            new Employee(){ Name = "Madara", Department = "IT", Country = "Japan" },
//            new Employee(){ Name = "Naruto", Department = "Marketing", Country = "USA" },
//            new Employee(){ Name = "Shoyo", Department = "IT", Country = "Indonesia" },
//            new Employee(){ Name = "Tanaka", Department = "HR", Country = "UK" },
//            new Employee(){ Name = "Kageyama", Department = "Sales", Country = "USA" },
//            new Employee(){ Name = "Ryu", Department = "Sales", Country = "Polandia" },
//        };

//        var empLookup = employees.OrderBy(x => x.Department).ToLookup(x => x.Department);
//        Console.WriteLine("Group Employee by Department");
//        Console.WriteLine("----------------------------");
//        foreach (var dept in empLookup)
//        {
//            Console.WriteLine($"\n{dept.Key}");
//            foreach (var emp in empLookup[dept.Key])
//            {
//                Console.WriteLine($"{emp.Name} - {emp.Department} - {emp.Country}");
//            }
//        }
//    }
//}

// =======================================================================================
// GROUP ELEMENT LINQ
// =======================================================================================
// 
//class Program
//{
//    static void Main()
//    {
//        List<Student> students = new List<Student>()
//        {
//            new Student(){ Name = "Sami", Gender = "Female", City = "Bukittinggi" },
//            new Student(){ Name = "Hanafi", Gender = "Male", City = "Garut" },
//            new Student(){ Name = "Hinata", Gender = "Female", City = "Konoha" },
//            new Student(){ Name = "Rafif", Gender = "Male", City = "Tangsel" },
//            new Student(){ Name = "Sakura", Gender = "Female", City = "KOnoha" },
//            new Student(){ Name = "Syaiful", Gender = "Male", City = "Tangsel" },
//        };

//        // SELECT * FROM Student GROUP BY Gender
//        var studentGroup = from student in students
//                           group student by student.Gender;

//        foreach(var studentItem in studentGroup)
//        {
//            Console.WriteLine($"\n{studentItem.Key}");
//            foreach(var stud in studentItem)
//            {
//                Console.WriteLine($"{stud.Name} - {stud.Gender} - {stud.City}");
//            }
//        }
//    }
//}

//class Student
//{
//    public string Name { get; set; }
//    public string Gender { get; set; }
//    public string City { get; set; }
//}


// =======================================================================================
// LOAD XML ke LINQ 
// =======================================================================================
//class Program
//{
//    static void Main()
//    {
//        var xml = @"
//                    <ingredients>
//                        <ingredient name='Milk' quantity= '200' price='2500' />
//                        <ingredient name='Sugar' quantity= '200' price='2500' />
//                        <ingredient name='Bread' quantity= '500' price='2500' />
//                        <ingredient name='Salt' quantity= '200' price='2500' />
//                    </ingredients>
//                    ";

//        XElement xElement = XElement.Parse(xml);

//        XElement Food = xElement.Descendants("ingredient")
//            .First(x => x.Attribute("name").Value == "Bread");

//        XAttribute nameAttribute = Food.FirstAttribute;
//        XAttribute priceAttribute = Food.Attribute("price");
//        string priceMilk = priceAttribute.Value;
//        XAttribute qty = Food.Attributes().Skip(1).First();

//        Console.Write(qty);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Ingredient[] ingredients =
//        {
//            new Ingredient{Name = "Sugar", Calories = 500},
//            new Ingredient{Name = "Egg", Calories = 100},
//            new Ingredient{Name = "Milk", Calories = 150},
//            new Ingredient{Name = "Flour", Calories = 50},
//            new Ingredient{Name = "Butter", Calories = 200},
//            new Ingredient{Name = "Milk", Calories = 500},
//        };


//        // SELECT Name FROM Ingredient WHERE Calories >= 150 ORDER BY Name
//        IEnumerable<string> ingredient = ingredients.Where(x => x.Calories >= 150)
//                                            .OrderBy(x => x.Name)
//                                            .Select(x => x.Name); // Hanya mengambil Field Nama

//        foreach(var IngName in ingredient)
//        {
//            Console.WriteLine(IngName);
//        }    
//    }
//}

//class Ingredient
//{
//    public string Name { get; set; }
//    public int Calories { get; set; }
//}


//class Program
//{
//    static void Main()
//    {
//        Ingredient[] ingredients =
//        {
//            new Ingredient{Name = "Sugar", Calories = 500},
//            new Ingredient{Name = "Egg", Calories = 100},
//            new Ingredient{Name = "Milk", Calories = 150},
//            new Ingredient{Name = "Flour", Calories = 50},
//            new Ingredient{Name = "Butter", Calories = 200},
//        };

//        // SELECT OriginalIngredient = 1, IsDairy (CASE WHEN Name = Milk dst), IsHighCalories = Calories >= 150
//        // INTO Temp FROM Ingredient WHERE IsDairy AND IsHighCalories

//        IEnumerable<Ingredient> hiCalorie =
//            from i in ingredients
//            select new
//            {
//                OriginalIngredient = i,
//                //IsDairy = i.Name == "Milk" || i.Name == "Butter",
//                IsHIghCalorie = i.Calories >= 150
//            }
//            into temp
//            where temp.IsHIghCalorie
//            select temp.OriginalIngredient;

//        foreach (var ingredient in hiCalorie)
//        {
//            Console.WriteLine(ingredient.Name);
//        }

//    }
//}

//class Ingredient
//{
//    public string Name { get; set; }
//    public int Calories { get; set; }
//}


// =======================================================================================
// QUERY JOIN atau INNER JOIN pada LINQ
// =======================================================================================

//class Program
//{
//    static void Main()
//    {
//        Recipe[] recipes =
//        {
//            new Recipe {Id = 1, Name = "Mashed Potato"},
//            new Recipe {Id = 2, Name = "Rendang"},
//            new Recipe {Id = 3, Name = "Sayur Anyang"}
//        };

//        Review[] reviews =
//        {
//            new Review {RecipeId = 1, ReviewText = "Tasty!"},
//            new Review {RecipeId = 2, ReviewText = "Bad :("},
//            new Review {RecipeId = 2, ReviewText = "Terlalu Asin"},
//            new Review {RecipeId = 1, ReviewText = "Loved it!"},
//            new Review {RecipeId = 3, ReviewText = "Loved it!"}
//        };

//        // SELECT RecipeName, RecipeReview FROM Recipe
//        // JOIN Review ON Recipe.Id = Review.RecipeId
//        var query = from recipe in recipes
//                    join review in reviews on recipe.Id equals review.RecipeId
//                    select new // SELECT Fields
//                    {
//                        RecipeName = recipe.Name,
//                        RecipeReview = review.ReviewText
//                    };

//        foreach (var item in query)
//        {
//            Console.WriteLine("{0} - '{1}'", item.RecipeName, item.RecipeReview);
//        }
//    }
//}

//class Recipe
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//}

//class Review
//{
//    public int RecipeId { get; set; }
//    public string ReviewText { get; set; }
//}

// =======================================================================================
// LEFT JOIN pada LINQ DAN MENGAMBIL KONDISI EMPTY
// =======================================================================================

//class Program
//{
//    static void Main()
//    {
//        Recipe[] recipes =
//        {
//            new Recipe {Id = 1, Name = "Mashed Potato"},
//            new Recipe {Id = 2, Name = "Rendang"},
//            new Recipe {Id = 3, Name = "Anyang"}
//        };

//        Review[] reviews =
//        {
//            new Review {RecipeId = 1, ReviewText = "Tasty!"},
//            new Review {RecipeId = 2, ReviewText = "Bad :("},
//            new Review {RecipeId = 2, ReviewText = "Terlalu Asin"},
//            new Review {RecipeId = 1, ReviewText = "Loved it!"},
//        };

//        var query = from recipe in recipes
//                    join review in reviews
//                    on recipe.Id equals review.RecipeId into ReviewGroup
//                    from rg in ReviewGroup.DefaultIfEmpty()
//                    select new 
//                    {
//                        RecipeName = recipe.Name,
//                        RecipeReview = rg == null ? "No Review" : rg.ReviewText
//                    };

//        foreach (var item in query)
//        {
//            Console.WriteLine("{0} - '{1}'", item.RecipeName, item.RecipeReview);
//        }
//    }
//}

//class Recipe
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//}

//class Review
//{
//    public int RecipeId { get; set; }
//    public string ReviewText { get; set; }
//}

// =======================================================================================
// CROSS JOIN == menampilkan semua record yang ada
// =======================================================================================
//class Program
//{
//    static void Main()
//    {
//        Recipe[] recipes =
//        {
//            new Recipe {Id = 1, Name = "Tanak Lado"},
//            new Recipe {Id = 2, Name = "Rendang"},
//            new Recipe {Id = 3, Name = "Anyang"}
//        };

//        Review[] reviews =
//        {
//            new Review {RecipeId = 1, ReviewText = "Tasty!"},
//            new Review {RecipeId = 2, ReviewText = "Bad :("},
//            new Review {RecipeId = 2, ReviewText = "Salty!"},
//            new Review {RecipeId = 1, ReviewText = "Loved it!"},
//        };

//        // SELECT RecipeName, ReviewText FROM Recipes CROSS JOIN (Reviews)
//        // SELECT RecipeName, REviewText FROM Recipes, Reviews
//        var query = from recipe in recipes
//                    from review in reviews
//                    select new
//                    {
//                        RecipeName = recipe.Name,
//                        RecipeReview = review.ReviewText
//                    };

//        foreach (var item in query)
//        {
//            Console.WriteLine("{0} - '{1}'", item.RecipeName, item.RecipeReview);
//        }
//    }
//}

//class Recipe
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//}

//class Review
//{
//    public int RecipeId { get; set; }
//    public string ReviewText { get; set; }
//}

// =======================================================================================
// RIGHT JOIN  == tinggal di switch datasetnya dari LEFT JOIN
// =======================================================================================
//class Program
//{
//    static void Main()
//    {
//        Recipe[] recipes =
//        {
//            new Recipe {Id = 1, Name = "Tanak Lado"},
//            new Recipe {Id = 2, Name = "Rendang"},
//            new Recipe {Id = 3, Name = "Anyang"}
//        };

//        Review[] reviews =
//        {
//            new Review {RecipeId = 4, ReviewText = "Tasty!"},
//            new Review {RecipeId = 2, ReviewText = "Bad :("},
//            new Review {RecipeId = 3, ReviewText = "Salty!"},
//            new Review {RecipeId = 1, ReviewText = "Loved it!"},
//        };

//        // SELECT RecipeName, ReviewText FROM Review
//        // RIGHT JOIN Recipe ON Review.RecipeId = Recipe.Id
//        var query = from review in reviews
//                    join recipe in recipes
//                    on review.RecipeId equals recipe.Id into RecipeGroup
//                    from rg in RecipeGroup.DefaultIfEmpty()
//                    select new
//                    {
//                        RecipeName = rg == null ? "No Recipe" : rg.Name,
//                        RecipeReview = review.ReviewText,
//                    };

//        foreach (var item in query)
//        {
//            Console.WriteLine("{0} - '{1}'", item.RecipeName, item.RecipeReview);
//        }
//    }
//}

//class Recipe
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//}

//class Review
//{
//    public int RecipeId { get; set; }
//    public string ReviewText { get; set; }
//}

// =======================================================================================
// UNION ----> Union secara performance itu JELEK, jangan dipakai keculai terpaksa!!
// =======================================================================================
//class Program
//{
//    static void Main()
//    {
//        var people1 = new[]
//        {
//            new {Id = 1112, Name = "Hanafi", City = "Garut"},
//            new {Id = 1113, Name = "Anton", City = "Bekasi"},
//            new {Id = 1114, Name = "Andik", City = "Bukitinggi"},
//            new {Id = 1115, Name = "Jimmy", City = "Cikarang"}
//        };

//        var people2 = new[]
//       {
//            new {Id = 1112, Name = "Hanafi", City = "Garut"},
//            new {Id = 1113, Name = "Anton", City = "Bekasi"},
//            new {Id = 1114, Name = "Andik", City = "Bukitinggi"},
//            new {Id = 1115, Name = "Jimmy", City = "Cikarang"},
//            new {Id = 1116, Name = "Bima", City = "Bukitinggi"},
//            new {Id = 1117, Name = "Setiawan", City = "Padang"},
//        };

//        // SELECT * FROM TABLE_A
//        // UNION
//        // SELECT * FROM TABLE_A

//        var people = people1.Union(people2);

//        foreach (var item in people)
//        {
//            Console.WriteLine($"{item.Name} - {item.City}");
//        }
//    }
//}


// =======================================================================================
// INTERSECT ----> secara performance itu JELEK, jangan dipakai keculai terpaksa!!
// =======================================================================================
class Program
{
    static void Main()
    {
        var people1 = new[]
        {
            new {Id = 1112, Name = "Hanafi", City = "Garut"},
            new {Id = 1113, Name = "Anton", City = "Bekasi"},
            new {Id = 1114, Name = "Andik", City = "Bukitinggi"},
            new {Id = 1115, Name = "Jimmy", City = "Cikarang"}
        };

        var people2 = new[]
       {
            new {Id = 1112, Name = "Hanafi", City = "Garut"},
            new {Id = 1113, Name = "Anton", City = "Bekasi"},
            new {Id = 1114, Name = "Andik", City = "Bukitinggi"},
            new {Id = 1115, Name = "Jimmy", City = "Cikarang"},
            new {Id = 1116, Name = "Bima", City = "Bukitinggi"},
            new {Id = 1117, Name = "Setiawan", City = "Padang"},
        };

        // SELECT * FROM TABLE_A
        // INTERSACET  ---------------> BERIRISAN
        // SELECT * FROM TABLE_A

        var people = people1.Intersect(people2);

        foreach (var item in people)
        {
            Console.WriteLine($"{item.Name} - {item.City}");
        }
    }
}

