using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;


//ProductTest();
//CategoryTest();
CustomerTest();


void CategoryTest()
{
    var categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll()) // GetAll Test
    {
        Console.WriteLine(category.CategoryName);
    }
    var addEntity = new Category //Add Test
    {
        CategoryName = "Vehicle",
        Description = "Kara Araçları"
    };
    categoryManager.Add(addEntity);
    
    var updateEntity = new Category //Update Test
    {
        CategoryId = 9,
        CategoryName = "Cars",
        Description = "Hava Araçları"
    };
    //categoryManager.Update(updateEntity);
    
    var deleteEntity = new Category //Delete Test
    {
        CategoryId = 9
    };
    //categoryManager.Delete(deleteEntity);
    
}
void CustomerTest()
{
    var customerManager = new CustomerManager(new EfCustomerDal());

    
    var addEntity = new Customer() //Add Test
    {
        
        ContactName = "Emre Demir",
        Address = "Fatih",
        City = "Istanbul",
        Country = "Turkey",
        Fax = "02123216549",
        Phone = "05414414154",
        CompanyName = "IBSoft",
        ContactTitle = "CEO",
        PostalCode = "34000",
        Region = "No Region",
        CustomerId = "93"
    };
    //customerManager.Add(addEntity);
    
    var updateEntity = new Customer() //Update Test
    {
        CustomerId = "92",
        ContactTitle = "CTO",
        CompanyName = "IBSoft"
    };
    customerManager.Update(updateEntity);
    
    var deleteEntity = new Category //Delete Test
    {
        CategoryId = 9
    };
    //customerManager.Delete(deleteEntity);
}
void OrderTest()
{
    var orderManager = new OrderManager(new EfOrderDal());
    foreach (var order in orderManager.GetAll()) // GetAll Test
    {
        Console.WriteLine(order.ShipName);
    }

}
void ProductTest()
{
    var productManager = new ProductManager(new EfProductDal());

    foreach (var product in productManager.GetAll()) // GetAll Test
    {
        //Console.WriteLine(product.ProductName);
    }

    foreach (var product in productManager.GetAllByCategory(2)) // GetAllByCategory Test
    {
        //Console.WriteLine("ID: " + product.CategoryId + "  Ürün Adı: " + product.ProductName);
    }

    foreach (var product in productManager.GetByUnitPrice(40, 100)) // GetByUnitPrice Test
    {
        //Console.WriteLine("ID: " + product.CategoryId + "  Ürün Adı: " + product.ProductName + "  Fiyat: " + product.UnitPrice);
    }
}