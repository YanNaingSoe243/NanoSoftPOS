using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NanoSoftGreenMark.Data
{
    public class Category : IEquatable<Category>
    {
       
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "The Name field is required")]
        public string CategoryName { get; set; }
        public string Icon { get; set; }
        public string Remark { get; set; }
        public ICollection<Product> Products { get; set; }
        public bool Equals(Category other) => other.CategoryName == CategoryName;

    }
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string ProductName { get; set; }
        public string Barcode { get; set; }
        public int UnitPrice { get; set; }
        public int SellPrice { get; set; }
        public int ManufacturerPrice { get; set; }
        public Status Status { get; set; } = Status.Active;
        [ForeignKey("Category")]
        public int? CategoryID { get; set; }
        public Category Category { get; set; }
        [ForeignKey("Property")]
        public int? PropertyID { get; set; }
        public ProductProperty Property { get; set; }
        public string Photo { get; set; }
        public string Note { get; set; }
        public int AlertQty { get; set; } = 10;
        [ForeignKey("Brand")]
        public int? BrandID { get; set; }
        public Brand Brand { get; set; }
       // public IList<PropertyList> PropertyList { get; set; }
    }
    public class PropertyList
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Property")]
        public int? PropertyID { get; set; }
        public ProductProperty Property { get; set; }
        [ForeignKey("Products")]
        public int? ProductFK { get; set; }
        public Product Products { get; set; }

    }
    public class Brand
    {
        [Key]
        public int ID { get; set; }
        public string BrandName { get; set; }
        public  IList<Product> Products { get; set; }

    }
    public class ProductProperty
    {
        [Key]
        public int ID { get; set; }
        public string Properties { get; set; }
        public IList<Product> Products { get; set; }
        //public IList<PropertyList> PropertyList { get; set; }
    }
    public enum Status
    {
        Active,
        Inactive
    }
    public enum PaymentStatus
    {
        Paid,
        Unpaid
    }
    public enum PaymentMethod
    {
        Cash,
        Card,
        BankAccount
    }
    public enum OrderStatus
    {
        Order,
        Confirm,       
        Completed,
        Cancel,
        Favourite,
    }
    //buy
    public class Purchase
    {
        [Key]
        public int ID { get; set; }
        public DateTime? PurchaseDate { get; set; } = DateTime.Now;
        public string InvoiceNumber { get; set; }
        [ForeignKey("Supplier")]
        public int? SupplierID { get; set; }
        public Supplier Supplier { get; set; }
        public PaymentStatus PaymentStatus { get; set; } = PaymentStatus.Unpaid;
        public PaymentMethod PaymentMethod { get; set; } = PaymentMethod.Cash;
        public decimal? SubTotal => PurchaseProdcuts.Sum(item => item.UnitPrice * item.Quantity);
        public decimal? Tax { get; set; } = 0;
        public decimal? GrandTotal =>SubTotal+Tax*SubTotal;
        public decimal? TotalDiscount => PurchaseProdcuts.Where(item=>item?.Discount?.DiscountType?.DiscountTypeName!="FOC").Sum(item=>item?.Discount?.Percentage/100*item?.TotalPrice);
        public decimal? NetTotal =>GrandTotal-TotalDiscount;
        public string Remark { get; set; }
        public IList<PurchaseItem> PurchaseProdcuts { get; set; } = new List<PurchaseItem>();


    }
    public class PurchaseItem
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Products")]
        public int? ProductFK { get; set; }
        public Product Products { get; set; } = new Product();
        public int Quantity { get; set; } = 0;
        public int UnitPrice { get; set; }
        public decimal TotalPrice => Quantity * UnitPrice;
        [DisplayFormat(DataFormatString = "{dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? ExpiryDate { get; set; }
        public int? Stock { get; set; } = 0;
        public string BatchNo { get; set; }
        public string Remark { get; set; }
        [ForeignKey("Purchase")]
        public int? PurchaseFK { get; set; }
        public Purchase Purchase { get; set; }
        public PaymentStatus PaymentStatus { get; set; } = PaymentStatus.Unpaid;
        public OrderStatus OrderStatus { get; set; } = OrderStatus.Order;
        [ForeignKey("Discount")]
        public int? DiscountID { get; set; }
        public Discount Discount { get; set; }
        public string Note { get; set; }
        

    }
    //Sell
    public class Invoice
    {
        [Key]
        public int ID { get; set; }
        public string InvoiceNo { get; set; }
        [ForeignKey("Customer")]
        public int? CustomerFK { get; set; }
        public Customer Customer { get; set; }
        [DisplayFormat(DataFormatString = "{dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? SellDate { get; set; } = DateTime.Now;
        public IList<InvoiceItem> purchaseItems { get; set; }= new List<InvoiceItem>();
        public decimal SubTotal => purchaseItems.Sum(item => item.UnitPrice * item.Quantity);
        public decimal Tax { get; set; }
        public decimal GrandTotal { get; set; } = 0;
        public decimal TotalDiscount { get; set; } = 0;       
        public decimal NetTotal { get; set; } = 0;
        public decimal PaidAmount { get; set; } = 0;
        public decimal DueAmount { get; set; } = 0;//လက်ကျန်ငွေ
        public PaymentStatus PaymentStatus { get; set; } = PaymentStatus.Unpaid;
        public PaymentMethod PaymentMethod { get; set; } = PaymentMethod.Cash;
        public string Note { get; set; }
        public DateTime? ShippedDate{get;set;}
        public string ShipName{ get;set; }
        public string ShipAddress {get;set;}
        public string ShipPhone{get;set; }
        [ForeignKey("City")]
        public int? CityID { get; set; }
        public City City { get; set; }
        public OrderStatus OrderStatus { get; set; } = OrderStatus.Order;
        [ForeignKey("Delivery")]
        public int? DeliveryID { get; set; }
        public Delivery Delivery { get; set; }
        public IList<BankList> BankList { get; set; }
        public IList<DeliveryLog> DeliveryLogs { get; set; }
    }
    public class DeliveryLog
    {
        [Key]
        public int ID { get; set; }
        public string PositioName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("Invoices")]
        public int? InvoiceID { get; set; }
        public Invoice Invoices { get; set; }
        [ForeignKey("Employees")]
        public int? EmployeeID { get; set; }
        public Employee Employees { get; set; }
    }
     public class BankList
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Invoice")]
        public int? InvoiceID { get; set; }
        public Invoice   Invoice {get;set;}
        public int? BankID { get; set; }
        public Bank Banks { get; set; }
        public string BankStatus { get; set; }
        [DisplayFormat(DataFormatString = "{dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Date { get; set; }
    }

    //sell Item
    public class InvoiceItem
    {
        [Key]
        public int ID { get; set; }
        public string BatchNo { get; set; }
        [ForeignKey("Products")]
        public int? ProductFK { get; set; }
        public Product Products { get; set; }
        public int Quantity { get; set; } = 1;
        public int UnitPrice { get; set; }
        public decimal TotalPrice => Quantity * UnitPrice;
        [DisplayFormat(DataFormatString = "{dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? ExpiryDate { get; set; }       
        [ForeignKey("Invoice")]
        public int InvoiceID { get; set; }
        public Invoice Invoice { get; set; }
        [ForeignKey("Discount")]
        public int? DiscountID { get; set; }
        public Discount Discount { get; set; }
        public OrderStatus OrderStatus { get; set; } = OrderStatus.Order;


    }
    public class Delivery
    {
        public int ID { get; set; }
        [ForeignKey("City")]
        public int? CityID { get; set; }
        public City City { get; set; }
        public int Price { get; set; }
        public IList<Invoice> Invoices { get; set; }
       

    }
    public class Discount
    {
        [Key]
        public int ID { get; set; }
        public string DiscountName { get; set; }
        public decimal Percentage { get; set; }
        public IList<InvoiceItem> Invoices { get; set; }
        public IList<DiscountProduct> DiscountProducts { get; set; }
        [ForeignKey("DiscountType")]
        public int? DiscountTypeID { get; set; }
        public DiscountType DiscountType { get; set; }
              

    }
    public class DiscountType
    {
        [Key]
        public int ID { get; set; }
        public string DiscountTypeName { get; set; }
        public IList<Discount> Discounts { get; set; }

    }
    public class GiftCard
    {  
        [Key]
        public int ID { get; set; }
        public string GiftCardName { get; set; }
        public decimal Percentage { get; set; }
        [DisplayFormat(DataFormatString = "{dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? ExpiryDate { get; set; }
        public IList<Invoice> Invoices { get; set; }
    }
    public class GiftCardList
    {
        [Key]
        public int ID { get; set; }
        [DisplayFormat(DataFormatString = "{dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Date { get; set; }
        [ForeignKey("Customers")]
        public int? CustomerID { get; set; }
        public Customer Customers { get; set; }
        [ForeignKey("GiftCards")]
        public int? GiftCardID { get; set; }
        public GiftCard GiftCards { get; set; }
    }

    public class DiscountProduct
    {
            [Key]
            public int ID { get; set; }
            [ForeignKey("Products")]
            public int? ProductID { get; set; }
            public Product Products { get; set; }
            [ForeignKey("Discount")]
            public int? DiscountID { get; set; }
            public Discount Discount { get; set; }
            [DisplayFormat(DataFormatString = "{dd-MM-yyyy}", ApplyFormatInEditMode = true)]
            public DateTime? ExpiryDate { get; set; }

    }


        public class Supplier : IEquatable<Supplier>
        {
            [Key]
            public int ID { get; set; }
            public string SupplierName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public string Contact { get; set; }
            [ForeignKey("City")]
            public int? CityID { get; set; }
            public City City { get; set; }
            public string Detail { get; set; }
            public decimal Balance { get; set; }
            public IList<Purchase> Purchases { get; set; }
            public Status Status { get; set; } = Status.Active;
            public bool Equals(Supplier other) => SupplierName == other.SupplierName && Email == other.Email;
        }
        public class City : IEquatable<City>
        {
            [Key]
            public int ID { get; set; }
            public string CityName { get; set; }
            public string ShortCode { get; set; }
            [Required]
            [ForeignKey("Region")]
            public int? RegionID { get; set; }
            public Region Region { get; set; }
            public IList<Supplier> Suppliers { get; set; }
            public bool Equals(City other) => CityName == other.CityName;
            public IList<Person> Employees { get; set; }
            public IList<Invoice> Invoices { get; set; }
        }
        public class Region : IEquatable<Region>
        {
            [Key]
            public int ID { get; set; }
            public string RegionName { get; set; }
            public string ShortCode { get; set; }
            [ForeignKey("Country")]
            public int? CountryFK { get; set; } = 1;
            public Country Country { get; set; }
            public IList<City> City { get; set; }
            public bool Equals(Region other) => RegionName == other.RegionName;

        }
        public class Country : IEquatable<Country>
        {
            [Key]
            public int ID { get; set; }
            public string CountryName { get; set; }
            public IList<Region> Divisions { get; set; }
            public bool Equals(Country other) => other.CountryName == CountryName;

        }

    public class Customer 
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Person")]
        public int? PersonID { get; set; }
        public Person Person { get; set; }
        public IList<Invoice> Invoices { get; set; }
        public decimal Balance { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public Status Status { get; set; } = Status.Active;

    }
    public enum Gender
    {
        Male,
        Female
    }

    public class Person : IEquatable<Person>
    {
        [Key]
        public int ID { get; set; }
       
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
     
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
       
        [Required]
        [EmailAddress(ErrorMessage = "Invalid email.")]
        public string EmailAddress { get; set; }       
        
       
        [Display(Name = "NRC Number")]
        public string NRC { get; set; }
       
        public string  ContactAddress { get; set; }
       
        public string  HomeAddress { get; set; }
       
        [Display(Name = "Phone No")]
        public string PhoneNo { get; set; }
       

        [Display(Name = "Mobile No")]
        public string ContactNo { get; set; }
      

        public string Specialization { get; set; }

        [Required]
        public Gender Gender { get; set; } = Gender.Male;
       

        [Display(Name = "Blood Group")]
        public string BloodGroup { get; set; }
       
        //[Display(Name = "Date of Birth")]
        //[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateOfBirth { get; set; }
       
        [Display(Name = "Education/Degree")]
        public string Education { get; set; }
        public Status Status { get; set; } = Status.Active;       
        public string FullName => $"{this.FirstName + " " + this.LastName}";       
        public string Photo { get; set; }
        public bool Equals(Person other) =>
         EmailAddress == other.EmailAddress &&
             FullName == other.FullName;

        public DateTime RegisteredDate { get; set; } = DateTime.Today;
       
        public string ShortBiography { get; set; }
        [ForeignKey("City")]
        public int? CityID { get; set; }
        public City City { get; set; }
        public IList<Employee> Employees { get; set; }
        public IList<Customer> Customers { get; set; }
    }
   

    
    public class Register
    { 
        [Key]
        public int ID { get; set; }
        [ForeignKey("Person")]
        public int? PersonID { get; set; }
        public Person Person { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordHash { get; set; }
        public string ConfirmPassword { get; set; }
        [ForeignKey("Role")]
        public int? RoleID { get; set; }
        public Role Role { get; set; }
        public Status Status { get; set; } = Status.Active;
    }
    public class Role
    {
        [Key]
        public int ID { get; set; }
        public string RoleName { get; set; }
        public IList<Register> Registers { get; set; }
     }
     public class Employee 
     {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Person")]
        public int? PersonID { get; set; }
        public Person Person { get; set; } = new Person();
        [ForeignKey("Location")]
        public int? LocationID { get; set; }
        public Location Location { get; set; } 
        public int BasicSalary { get; set; }
        [ForeignKey("EmployeeType")]
        public int? EmployeeTypeID { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public IList< DeliveryLog> DeliveryLogs { get; set; }
        public Status Status { get; set; } = Status.Active;

    }
    public class EmployeeType
    {
        [Key]
        public int ID { get; set; }
        public string EmployeeTypeName { get; set; }
        public IList<Employee> Employees { get; set; }


    }
    public class Location
    {
        [Key]
        public int ID { get; set; }
        public string ShopeName { get; set; }     
        public double  Latitude { get; set; }
        public double Longitude { get; set; }
        [ForeignKey("City")]
        public int? CityID { get; set; }
        public City City { get; set; }
        public string Phone { get; set; }
        public String Contact { get; set; }
        public string  ImagePath { get; set; }
        public IList<Employee> Employees { get; set; }

    }
    public class Messages
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Customer")]
        public int? CustomerID { get; set; }
        public Customer Customer { get; set; }
        [ForeignKey("Employee")]
        public int? EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public string Message { get; set; }
        public DateTime? Date { get; set; }
        public MailStatus MailStatus { get; set; } = MailStatus.UnSeen;
    }

    
    public enum MailStatus
    {
        Seen,
        UnSeen,

    }
    public class Bank
    {
        [Key]
        public int ID { get; set; }
        public string BankName { get; set; }
        public string AccountID { get; set; }
        public string Password { get; set; }
        public IList<BankList> BankList { get; set; }
    }


    //internal class CounterState
    //{
    //    public int CurrentCount { get; private set; }

    //    public void IncrementCount()
    //    {
    //        CurrentCount++;
    //        StateChanged?.Invoke();
    //    }
    //    public void DecrementCount()
    //    {
    //        if (CurrentCount > 0)
    //        {


    //            CurrentCount--;
    //        }
    //        else
    //        {
    //            CurrentCount = 1;
    //        }
    //        StateChanged?.Invoke();
    //    }

    //    public event Action StateChanged;
    //}

}
