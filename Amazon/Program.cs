//Department-CRUDs
#region Department
//using Amazon.DTOs.Department;
//using Amazon.Services.Implements;
//using Amazon.Services.Interfaces;

//IGenericService<DepartmentCreateDto> departmentService = new DepartmentService();

////CRUD - Create
//var electronics = new DepartmentCreateDto { Id = 1, Name = "Electronics" };
//var clothes = new DepartmentCreateDto { Id = 2, Name = "Clothes" };
//departmentService.Create(electronics);
//departmentService.Create(clothes);

////CRUD - Delete
//departmentService.Delete(2);

////CRUD - Read (All)
//departmentService.GetAll();


////CRUD - Read (Single)
//departmentService.GetById(3);
#endregion


//Category-CRUDs
#region Category
//using Amazon.DTOs.Category;
//using Amazon.Services.Implements;
//using Amazon.Services.Interfaces;

//IGenericService<CategoryCreateDto> categoryService = new CategoryService(); //non-static
//var bluz = new CategoryCreateDto { Id = 1, Name = "Bluz", DepartmentId = 5 };
//var tShirt = new CategoryCreateDto { Id = 2, Name = "T-Shirt", DepartmentId = 4 };
//categoryService.Create(bluz);
//categoryService.Create(tShirt);

////categoryService.Delete(1);
////categoryService.GetAll();
//categoryService.GetById(2);
//categoryService.GetById(3);
#endregion


//Product-CRUDs
#region Product
//IProductService _productService = new ProductService();
//var dto1 = new ProductCreateDto()
//{
//    Id = 1,
//    Name = "Book 1",
//    Description = "Dedective",
//    CategoryId = 2,
//    ImageUrl = "https://www.some.com/od3d3.png",
//    Price = 40,
//    DiscountPersentage = 24
//};
//var dto4 = new ProductCreateDto()
//{
//    Id = 2,
//    Name = "Book 2",
//    Description = "Dedective",
//    CategoryId = 2,
//    ImageUrl = "https://www.some.com/od3d3.png",
//    Price = 100,
//    DiscountPersentage = 10
//};
//var dto2 = new ProductCreateDto()
//{
//    Id = 3,
//    Name = "Book 3",
//    Description = "Dedective",
//    CategoryId = 2,
//    ImageUrl = "https://www.some.com/od3d3.png",
//    Price = 60,
//    DiscountPersentage = 0
//};
//var dto3 = new ProductCreateDto()
//{
//    Id = 4,
//    Name = "Book 4",
//    Description = "Dedective",
//    CategoryId = 2,
//    ImageUrl = "https://www.some.com/od3d3.png",
//    Price = 45,
//    DiscountPersentage = 70
//};

//_productService.Create(dto1);
//_productService.Create(dto2);
//_productService.Create(dto3);
//_productService.Create(dto4);
//Console.WriteLine("\nBefore delete:\n");
//_productService.GetAll();
//_productService.Delete(3);
//Console.WriteLine("\nAfter delete:\n");
//_productService.GetAll();
#endregion


//Customer-CRUDs
#region Customer
//using Amazon.DTOs.Customer;
//using Amazon.Services.Implements;
//using Amazon.Services.Interfaces;

//IGenericService<CustomerCreateDto> customerService = new CustomerService();
//var dto1 = new CustomerCreateDto()
//{
//    Id = 1,
//    Email = "sabina@gmail.com",
//    Firstname = "Sabina",
//    Lastname = "Hashimova",
//    PhoneNumber = "1234567890",
//    Password = "sabina123"
//};

//var dto2 = new CustomerCreateDto()
//{
//    Id = 2,
//    Email = "lale@gmail.com",
//    Firstname = "Lale",
//    Lastname = "Hashimova",
//    PhoneNumber = "1234567890",
//    Password = "lale123"
//};

//var dto3 = new CustomerCreateDto()
//{
//    Id = 3,
//    Email = "rauf@gmail.com",
//    Firstname = "Rauf",
//    Lastname = "Hashimov",
//    PhoneNumber = "1234567890",
//    Password = "rauf123"
//};

//var dto4 = new CustomerCreateDto()
//{
//    Id = 4,
//    Email = "kenan@gmail.com",
//    Firstname = "Kenan",
//    Lastname = "Hashimov",
//    PhoneNumber = "1234567890",
//    Password = "kenan123"
//};
//customerService.Create(dto1);
//customerService.Create(dto2);
//customerService.Create(dto3);
//customerService.Create(dto4);

////customerService.GetAll();

//customerService.Delete(4);
////customerService.GetAll();
//customerService.GetById(2);
#endregion

using System.Reflection;

List<int> numbers = new List<int>();
numbers.Add(1);
numbers.Add(1);
numbers.Add(1);
numbers.Add(1);
numbers.Add(2);

List<string> names = new List<string>();
names.Add("Najiba");
names.Add("Leyla");
foreach(int number in numbers)
{
    //Console.WriteLine(number);
}

HashSet<int> set = new HashSet<int>(); //unique value
set.Add(1);
set.Add(1);
set.Add(1);
set.Add(1);
set.Add(1);
set.Add(2);
set.Add(2);
set.Add(2);
set.Add(2);
set.Add(2);
set.Add(2);
//foreach (int number in set)
//{
//    Console.WriteLine(number);
//}

//list ile hashset ferqi: 
//list deyere fikir vermir, eyni deyeri istenilen qeder tekrar saxlaya bilersen, hamisini qebul edir.
//hashset her deyeri yalniz 1 defe saxlayir. Eyni deyerden isteilen qeder Add elesen de, onu 1 defe gorur.

//acar-deyer collection
var students = new SortedDictionary<string, int>();
students.Add("7yre34e", 600);
students.Add("43rr45w", 550);
students.Add("12wq32e", 558);
students.Add("432ee34", 400);
students.Add("12we34r", 670);

//students.TryGetValue("7yre74e", out int value);
//Console.WriteLine(value);

SortedSet<int> list = new SortedSet<int>();
list.Add(1);
list.Add(20);
list.Add(16);
list.Add(8);
foreach(var item in list)
{
    //Console.WriteLine(item);    
}

SortedDictionary<int, string> people = new SortedDictionary<int, string>();
people.Add(3, "Kemale");
people.Add(2, "Najiba");
people.Add(14, "Yehya");
people.Add(8, "Kamal");
foreach(var item in people.Keys)
{
    Console.WriteLine(item); 
}
