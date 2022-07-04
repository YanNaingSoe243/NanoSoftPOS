using NanoSoftGreenMark.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NanoSoftGreenMark.DepandencyInjection
{
    public interface InterFaceModel
    {
        ICategory Categorys { get;}
        ICity Citys { get; }
        ICountry Countries { get; }
        IRegion Regions { get; }
        ILocation Locations { get; }
        IEmployee Employees { get; }
        IPerson Persons { get; }
        IEmployeeType EmployeeTypes { get; }
        IRole Roles { get; }
        ISupplier Suppliers { get;  }
        IBrand Brands { get; }
        IProductProperty ProductPropertys { get; }
        IProduct Products { get; }
        IPurchase Purchases { get; }
        Iinvoice Invoices { get; }
        IPurchaseItem PurchaseItems { get; }
        IInvoiceItem InvoiceItems { get; }
        IDiscountType DiscountTypes { get; }
        IDiscount Discounts { get; }
       IDiscountProduct DiscountProducts { get; }
        IGiftCard GiftCards { get; }
    }
    public interface ICategory
    {
       
        Task<IEnumerable<Category>> GetAsync(int pageindex, int pagesize);
        Task<IEnumerable<Category>> GetAsync(string searh);
        Task<Category> GetAsync(int Id);
        Task<Category> UpInsertAsync(Category item);
        Task<Category> DeleteAsync(int Id);
        Task<int> TotalPage(int Pagesize);
    }
    public interface ICity
    {

        Task<IEnumerable<City>> GetAsync(int pageindex, int pagesize);
        Task<IEnumerable<City>> GetAsync(string searh);
        Task<City> GetAsync(int Id);
        Task<City> UpInsertAsync(City item);
        Task<City> DeleteAsync(int Id);
        Task<int> TotalPage(int Pagesize);
    }
    public interface ICountry
    {

        Task<IEnumerable<Country>> GetAsync(int pageindex, int pagesize);
        Task<IEnumerable<Country>> GetAsync(string searh);
        Task<Country> GetAsync(int Id);
        Task<Country> UpInsertAsync(Country item);
        Task<Country> DeleteAsync(int Id);
        Task<int> TotalPage(int Pagesize);
    }
    public interface IRegion
    {

        Task<IEnumerable<Region>> GetAsync(int pageindex, int pagesize);
        Task<IEnumerable<Region>> GetAsync(string searh);
        Task<Region> GetAsync(int Id);
        Task<Region> UpInsertAsync(Region item);
        Task<Region> DeleteAsync(int Id);
        Task<int> TotalPage(int Pagesize);
    }
    public interface ILocation
    {

        Task<IEnumerable<Location>> GetAsync(int pageindex, int pagesize);
        Task<IEnumerable<Location>> GetAsync(string searh);
        Task<Location> GetAsync(int Id);
        Task<Location> UpInsertAsync(Location item);
        Task<Location> DeleteAsync(int Id);
        Task<int> TotalPage(int Pagesize);
    }
    public interface IEmployee
    {

        Task<IEnumerable<Employee>> GetAsync(int pageindex, int pagesize);
        Task<IEnumerable<Employee>> GetAsync(string searh);
        Task<IEnumerable<Employee>> GetAsync(Status searh);
        Task<Employee> GetAsync(int Id);
        Task<Employee> UpInsertAsync(Employee item);
        Task<Employee> DeleteAsync(int Id);
        Task<int> TotalPage(int Pagesize);
    }
    public interface IPerson
    {

        Task<IEnumerable<Person>> GetAsync(int pageindex, int pagesize);
        Task<IEnumerable<Person>> GetAsync(string searh);
        Task<Person> GetAsync(int Id);
        Task<Person> UpInsertAsync(Person item);
        Task<Person> DeleteAsync(int Id);
        Task<int> TotalPage(int Pagesize);
    }
    public interface IEmployeeType
    {

        Task<IEnumerable<EmployeeType>> GetAsync(int pageindex, int pagesize);
        Task<IEnumerable<EmployeeType>> GetAsync(string searh);       
        Task<EmployeeType> GetAsync(int Id);
        Task<EmployeeType> UpInsertAsync(EmployeeType item);
        Task<EmployeeType> DeleteAsync(int Id);
        Task<int> TotalPage(int Pagesize);
    }
    public interface IRole
    {

        Task<IEnumerable<Role>> GetAsync(int pageindex, int pagesize);
        Task<IEnumerable<Role>> GetAsync(string searh);
        Task<Role> GetAsync(int Id);
        Task<Role> UpInsertAsync(Role item);
        Task<Role> DeleteAsync(int Id);
        Task<int> TotalPage(int Pagesize);
    }
    public interface ISupplier
    {

        Task<IEnumerable<Supplier>> GetAsync(int pageindex, int pagesize);
        Task<IEnumerable<Supplier>> GetAsync(string searh);
        Task<Supplier> GetAsync(int Id);
        Task<Supplier> UpInsertAsync(Supplier item);
        Task<Supplier> DeleteAsync(int Id);
        Task<int> TotalPage(int Pagesize);
    }
    public interface IBrand
    {

        Task<IEnumerable<Brand>> GetAsync(int pageindex, int pagesize);
        Task<IEnumerable<Brand>> GetAsync(string searh);
        Task<Brand> GetAsync(int Id);
        Task<Brand> UpInsertAsync(Brand item);
        Task<Brand> DeleteAsync(int Id);
        Task<int> TotalPage(int Pagesize);
    }
    public interface IProductProperty
    {

        Task<IEnumerable<ProductProperty>> GetAsync(int pageindex, int pagesize);
        Task<IEnumerable<ProductProperty>> GetAsync(string searh);
        Task<ProductProperty> GetAsync(int Id);
        Task<ProductProperty> UpInsertAsync(ProductProperty item);
        Task<ProductProperty> DeleteAsync(int Id);
        Task<int> TotalPage(int Pagesize);
    }
    public interface IProduct
    {

        Task<IEnumerable<Product>> GetAsync(int pageindex, int pagesize);
        Task<IEnumerable<Product>> GetAsync(string searh);
        Task<IEnumerable<Product>> GetAsync(Status searh);
        Task<Product> GetAsync(int Id);
        Task<Product> BarcodeExit(string  barcode);
        Task<Product> UpInsertAsync(Product item);
        Task<Product> DeleteAsync(int Id);
        Task<int> TotalPage(int Pagesize);
    }
    public interface IPurchase
    {

        Task<IEnumerable<Purchase>> GetAsync(int pageindex, int pagesize);
        Task<IEnumerable<Purchase>> GetAsync(string searh);
        Task<IEnumerable<Purchase>> GetAsync(PaymentStatus searh);
        Task<Purchase> GetAsync(int Id);       
        Task<Purchase> UpInsertAsync(Purchase item);
        Task<Purchase> DeleteAsync(int Id);
        Task<int> TotalPage(int Pagesize);
    }
    public interface IPurchaseItem
    {

        Task<IEnumerable<PurchaseItem>> GetAsync(int pageindex, int pagesize);
        Task<IEnumerable<PurchaseItem>> GetAsync(string searh);
        Task<IEnumerable<PurchaseItem>> GetAsync(PaymentStatus searh);
        Task<PurchaseItem> GetAsync(int Id);
        Task<PurchaseItem> UpInsertAsync(PurchaseItem item);
        Task<PurchaseItem> DeleteAsync(int Id);
        Task<int> TotalPage(int Pagesize);
    }
    public interface IInvoiceItem
    {

        Task<IEnumerable<InvoiceItem>> GetAsync(int pageindex, int pagesize);
        Task<IEnumerable<InvoiceItem>> GetAsync(string searh);
        Task<IEnumerable<InvoiceItem>> GetAsync(OrderStatus searh);
        Task<InvoiceItem> GetAsync(int Id);
        Task<InvoiceItem> UpInsertAsync(InvoiceItem item);
        Task<InvoiceItem> DeleteAsync(int Id);
        Task<int> TotalPage(int Pagesize);
    }

    public interface Iinvoice
    {

        Task<IEnumerable<Invoice>> GetAsync(int pageindex, int pagesize);
        Task<IEnumerable<Invoice>> GetAsync(string searh);
        Task<IEnumerable<Invoice>> GetAsync(PaymentStatus searh);
        Task<Invoice> GetAsync(int Id);
        Task<Invoice> UpInsertAsync(Invoice item);
        Task<Invoice> DeleteAsync(int Id);
        Task<int> TotalPage(int Pagesize);
    }
    public interface IDiscountType    {

        Task<IEnumerable<DiscountType>> GetAsync(int pageindex, int pagesize);
        Task<IEnumerable<DiscountType>> GetAsync(string searh);
        Task<DiscountType> GetAsync(int Id);
        Task<DiscountType> UpInsertAsync(DiscountType item);
        Task<DiscountType> DeleteAsync(int Id);
        Task<int> TotalPage(int Pagesize);
    }
    public interface IDiscountProduct
    {

        Task<IEnumerable<DiscountProduct>> GetAsync(int pageindex, int pagesize);
        Task<IEnumerable<DiscountProduct>> GetAsync(string searh);
        Task<DiscountProduct> GetAsync(int Id);
        Task<DiscountProduct> UpInsertAsync(DiscountProduct item);
        Task<DiscountProduct> DeleteAsync(int Id);
        Task<int> TotalPage(int Pagesize);
    }
    public interface IDiscount
    {

        Task<IEnumerable<Discount>> GetAsync(int pageindex, int pagesize);
        Task<IEnumerable<Discount>> GetAsync(string searh);
        Task<Discount> GetAsync(int Id);
        Task<Discount> UpInsertAsync(Discount item);
        Task<Discount> DeleteAsync(int Id);
        Task<int> TotalPage(int Pagesize);
    }
    public interface IGiftCard
    {

        Task<IEnumerable<GiftCard>> GetAsync(int pageindex, int pagesize);
        Task<IEnumerable<GiftCard>> GetAsync(string searh);
        Task<GiftCard> GetAsync(int Id);
        Task<GiftCard> UpInsertAsync(GiftCard item);
        Task<GiftCard> DeleteAsync(int Id);
        Task<int> TotalPage(int Pagesize);
    }
}
