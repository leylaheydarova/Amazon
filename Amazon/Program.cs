using Amazon.Services.Implements;
using Amazon.Services.Interfaces;

//Department-CRUDs
#region Department
//IDepartmentService departmentService = new DepartmentService();

////CRUD - Create
//departmentService.Create(1, "Electronics");
//departmentService.Create(2, "Clothes");
//departmentService.Create(3, "Enginees");
//departmentService.Create(4, "Kids");
//departmentService.Create(5, "Woman");
//departmentService.Create(6, "Man");
//departmentService.Create(7, "Fashion");

////CRUD - Delete
//departmentService.Delete(2);

////CRUD - Read (All)
//departmentService.GetAll();


////CRUD - Read (Single)
//departmentService.GetById(3);
#endregion


//Category-CRUDs
#region Category
ICategoryService categoryService = new CategoryService();
categoryService.Create(1, "Bluz", 5);
categoryService.Create(2, "T-Shirt", 4);

//categoryService.Delete(1);
//categoryService.GetAll();
categoryService.GetById(2);
categoryService.GetById(3);
#endregion


//Product-CRUDs
#region Product

#endregion
