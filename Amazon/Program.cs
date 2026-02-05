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


