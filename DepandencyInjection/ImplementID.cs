using Microsoft.EntityFrameworkCore;
using NanoSoftGreenMark.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NanoSoftGreenMark.DepandencyInjection
{
    public class CategoryImp : ICategory
    {
        private readonly NanoContext _db;
        public CategoryImp(NanoContext db)
        {
            _db = db;
        }
        public async Task<Category> DeleteAsync(int Id)
        {
            var current = await _db.Categories.FirstOrDefaultAsync(_obj => _obj.ID == Id);
            if (current != null)
            {
                _db.Categories.Remove(current);
                await _db.SaveChangesAsync();
            }
            return current;
        }

        public async Task<IEnumerable<Category>> GetAsync(int pageindex, int pagesize)
        {
            int offset = (pageindex - 1) * pagesize;
            if (pageindex == -1)
            {
                return await _db.Categories.Include(obj=>obj.Products).ThenInclude(obj=>obj.Brand).Include(obj=>obj.Products).ThenInclude(obj=>obj.Property).ToListAsync();
            }
            else
            {
                return await _db.Categories.Include(obj => obj.Products).ThenInclude(obj => obj.Brand).Include(obj => obj.Products).ThenInclude(obj => obj.Property).AsNoTracking().Skip(offset).Take(pagesize).ToListAsync();
            }

        }

        public async Task<IEnumerable<Category>> GetAsync(string searh)
        {
           
            return await _db.Categories.Include(obj => obj.Products).ThenInclude(obj => obj.Brand).Include(obj => obj.Products).ThenInclude(obj => obj.Property)
                .Where(obj => obj.CategoryName.StartsWith(searh)).AsNoTracking()
                .ToListAsync();
        }

        public async Task<Category> GetAsync(int Id)
        {
            return await _db.Categories.Include(obj => obj.Products).ThenInclude(obj => obj.Brand).Include(obj => obj.Products).ThenInclude(obj => obj.Property).AsNoTracking().FirstOrDefaultAsync(obj => obj.ID == Id);
        }

        public async Task<int> TotalPage(int Pagesize)
        {
            int Totalp = 0;
            int Rowcount = await _db.Categories.CountAsync();
            Totalp = Rowcount / Pagesize;
            if (Rowcount % Pagesize != 0)
            {
                Totalp += 1;
            }

            return Totalp;
        }

        public async Task<Category> UpInsertAsync(Category item)
        {
            var current = await _db.Categories.FirstOrDefaultAsync(_obj => _obj.ID == item.ID);
            if (current == null)
            {
                _db.Categories.Add(item);
            }
            else
            {
                _db.Entry(current).CurrentValues.SetValues(item);

            }
            await _db.SaveChangesAsync();
            return item;
        }
    }

    public class CityImp : ICity
    {
        private readonly NanoContext _db;
        public CityImp(NanoContext db)
        {
            _db = db;
        }
        public async Task<City> DeleteAsync(int Id)
        {
            var current = await _db.Cities.FirstOrDefaultAsync(_obj => _obj.ID == Id);
            if (current != null)
            {
                _db.Cities.Remove(current);
                await _db.SaveChangesAsync();
            }
            return current;
        }

        public async Task<IEnumerable<City>> GetAsync(int pageindex, int pagesize)
        {
            int offset = (pageindex - 1) * pagesize;
            if(pageindex==-1)
            {
                return await _db.Cities.Include(obj => obj.Region).ThenInclude(obj => obj.Country).AsNoTracking().ToListAsync();
            }
            else
            {          
            return await _db.Cities.Include(obj=>obj.Region).ThenInclude(obj=>obj.Country).AsNoTracking().Skip(offset).Take(pagesize).ToListAsync();
            }
        }

        public async Task<IEnumerable<City>> GetAsync(string searh)
        {

            return await _db.Cities
                .Where(obj => obj.CityName.StartsWith(searh)).AsNoTracking()
                .ToListAsync();
        }

        public async Task<City> GetAsync(int Id)
        {
            return await _db.Cities.AsNoTracking().FirstOrDefaultAsync(obj => obj.ID == Id);
        }

        public async Task<int> TotalPage(int Pagesize)
        {
            int Totalp = 0;
            int Rowcount = await _db.Cities.CountAsync();
            Totalp = Rowcount / Pagesize;
            if (Rowcount % Pagesize != 0)
            {
                Totalp += 1;
            }

            return Totalp;
        }

        public async Task<City> UpInsertAsync(City item)
        {
            var current = await _db.Cities.FirstOrDefaultAsync(_obj => _obj.ID == item.ID);
            if (current == null)
            {
                _db.Cities.Add(item);
            }
            else
            {
                _db.Entry(current).CurrentValues.SetValues(item);

            }
            await _db.SaveChangesAsync();
            return item;
        }
    }

    public class CountryImp : ICountry
    {
        private readonly NanoContext _db;
        public CountryImp(NanoContext db)
        {
            _db = db;
        }
        public async Task<Country> DeleteAsync(int Id)
        {
            var current = await _db.Countries.FirstOrDefaultAsync(_obj => _obj.ID == Id);
            if (current != null)
            {
                _db.Countries.Remove(current);
                await _db.SaveChangesAsync();
            }
            return current;
        }

        public async Task<IEnumerable<Country>> GetAsync(int pageindex, int pagesize)
        {
            int offset = (pageindex - 1) * pagesize;
            if(pageindex==-1)
            {
                return await _db.Countries.Include(obj=>obj.Divisions).ThenInclude(obj=>obj.City).AsNoTracking().ToListAsync();
            }
            else
            {
                return await _db.Countries.Include(obj => obj.Divisions).ThenInclude(obj => obj.City).AsNoTracking().Skip(offset).Take(pagesize).ToListAsync();
            }
          

        }

        public async Task<IEnumerable<Country>> GetAsync(string searh)
        {

            return await _db.Countries
                .Where(obj => obj.CountryName.StartsWith(searh)).AsNoTracking()
                .ToListAsync();
        }

        public async Task<Country> GetAsync(int Id)
        {
            return await _db.Countries.AsNoTracking().FirstOrDefaultAsync(obj => obj.ID == Id);
        }

        public async Task<int> TotalPage(int Pagesize)
        {
            int Totalp = 0;
            int Rowcount = await _db.Countries.CountAsync();
            Totalp = Rowcount / Pagesize;
            if (Rowcount % Pagesize != 0)
            {
                Totalp += 1;
            }

            return Totalp;
        }

        public async Task<Country> UpInsertAsync(Country item)
        {
            var current = await _db.Countries.FirstOrDefaultAsync(_obj => _obj.ID == item.ID);
            if (current == null)
            {
                _db.Countries.Add(item);
            }
            else
            {
                _db.Entry(current).CurrentValues.SetValues(item);

            }
            await _db.SaveChangesAsync();
            return item;
        }
    }
    public class RegionImp : IRegion
    {
        private readonly NanoContext _db;
        public RegionImp(NanoContext db)
        {
            _db = db;
        }
        public async Task<Region> DeleteAsync(int Id)
        {
            var current = await _db.Regions.FirstOrDefaultAsync(_obj => _obj.ID == Id);
            if (current != null)
            {
                _db.Regions.Remove(current);
                await _db.SaveChangesAsync();
            }
            return current;
        }

        public async Task<IEnumerable<Region>> GetAsync(int pageindex, int pagesize)
        {
            int offset = (pageindex - 1) * pagesize;
            if (pageindex == -1)
            {
                return await _db.Regions.Include(obj => obj.Country).ToListAsync();
            }
            else
            {
                return await _db.Regions.Include(obj => obj.Country).AsNoTracking().Skip(offset).Take(pagesize).ToListAsync();
            }

        }

        public async Task<IEnumerable<Region>> GetAsync(string searh)
        {

            return await _db.Regions.Include(obj=>obj.Country)
                .Where(obj => obj.RegionName.StartsWith(searh)).AsNoTracking()
                .ToListAsync();
        }

        public async Task<Region> GetAsync(int Id)
        {
            return await _db.Regions.Include(obj=>obj.Country).AsNoTracking().FirstOrDefaultAsync(obj => obj.ID == Id);
        }

        public async Task<int> TotalPage(int Pagesize)
        {
            int Totalp = 0;
            int Rowcount = await _db.Regions.CountAsync();
            Totalp = Rowcount / Pagesize;
            if (Rowcount % Pagesize != 0)
            {
                Totalp += 1;
            }

            return Totalp;
        }

        public async Task<Region> UpInsertAsync(Region item)
        {
            var current = await _db.Regions.FirstOrDefaultAsync(_obj => _obj.ID == item.ID);
            if (current == null)
            {
                _db.Regions.Add(item);
            }
            else
            {
                _db.Entry(current).CurrentValues.SetValues(item);

            }
            await _db.SaveChangesAsync();
            return item;
        }
    }

    public class LocationImp : ILocation
    {
        private readonly NanoContext _db;
        public LocationImp(NanoContext db)
        {
            _db = db;
        }
        public async Task<Location> DeleteAsync(int Id)
        {
            var current = await _db.Locations.FirstOrDefaultAsync(_obj => _obj.ID == Id);
            if (current != null)
            {
                _db.Locations.Remove(current);
                await _db.SaveChangesAsync();
            }
            return current;
        }

        public async Task<IEnumerable<Location>> GetAsync(int pageindex, int pagesize)
        {
            int offset = (pageindex - 1) * pagesize;
            if (pageindex == -1)
            {
                return await _db.Locations.Include(obj=>obj.City).ThenInclude(obj=>obj.Region).ThenInclude(obj=>obj.Country).Include(obj => obj.Employees).ToListAsync();
            }
            else
            {
                return await _db.Locations.Include(obj => obj.City).ThenInclude(obj => obj.Region).ThenInclude(obj => obj.Country).Include(obj=>obj.Employees).AsNoTracking().Skip(offset).Take(pagesize).ToListAsync();
            }

        }

        public async Task<IEnumerable<Location>> GetAsync(string searh)
        {

            return await _db.Locations.Include(obj => obj.Employees).Include(obj => obj.City).ThenInclude(obj => obj.Region).ThenInclude(obj => obj.Country).Where(obj => obj.ShopeName.StartsWith(searh) || obj.Longitude.ToString()==searh || obj.Latitude.ToString()==searh).AsNoTracking()
                .ToListAsync();
        }

        public async Task<Location> GetAsync(int Id)
        {
            return await _db.Locations.Include(obj => obj.City).ThenInclude(obj => obj.Region).ThenInclude(obj => obj.Country).Include(obj => obj.Employees).AsNoTracking().FirstOrDefaultAsync(obj => obj.ID == Id);
        }

        public async Task<int> TotalPage(int Pagesize)
        {
            int Totalp = 0;
            int Rowcount = await _db.Locations.CountAsync();
            Totalp = Rowcount / Pagesize;
            if (Rowcount % Pagesize != 0)
            {
                Totalp += 1;
            }

            return Totalp;
        }

        public async Task<Location> UpInsertAsync(Location item)
        {
            var current = await _db.Locations.FirstOrDefaultAsync(_obj => _obj.ID == item.ID);
            if (current == null)
            {
                _db.Locations.Add(item);
            }
            else
            {
                _db.Entry(current).CurrentValues.SetValues(item);

            }
            await _db.SaveChangesAsync();
            return item;
        }
    }

    public class EmployeeImp : IEmployee
    {
        private readonly NanoContext _db;
        public EmployeeImp(NanoContext db)
        {
            _db = db;
        }
        public async Task<Employee> DeleteAsync(int Id)
        {
            var current = await _db.Employees.Include(obj=>obj.Person).FirstOrDefaultAsync(_obj => _obj.ID == Id);
            if (current != null)
            {
                _db.Employees.Remove(current);
                var current1 = await _db.Persons.FirstOrDefaultAsync(_obj => _obj.ID == current.PersonID);
                if (current1 == null)
                {

                }
                else
                {
                    _db.Persons.Remove(current1);

                }
                await _db.SaveChangesAsync();
            }
            return current;
        }

        public async Task<IEnumerable<Employee>> GetAsync(int pageindex, int pagesize)
        {
            int offset = (pageindex - 1) * pagesize;
            if (pageindex == -1)
            {
                return await _db.Employees.Include(obj => obj.Person).ThenInclude(obj=>obj.City).ThenInclude(obj => obj.Region).ThenInclude(obj => obj.Country).Include(obj=>obj.DeliveryLogs).Include(obj => obj.EmployeeType).ToListAsync();
            }
            else
            {
                return await _db.Employees.Include(obj => obj.Person).ThenInclude(obj => obj.City).ThenInclude(obj => obj.Region).ThenInclude(obj => obj.Country).Include(obj => obj.DeliveryLogs).Include(obj => obj.EmployeeType).AsNoTracking().Skip(offset).Take(pagesize).ToListAsync();
            }

        }

        public async Task<IEnumerable<Employee>> GetAsync(string searh)
        {

            return await _db.Employees.Include(obj => obj.Person).ThenInclude(obj => obj.City).ThenInclude(obj => obj.Region).ThenInclude(obj => obj.Country).Include(obj => obj.DeliveryLogs).Include(obj => obj.EmployeeType).Where(obj => obj.Person.FullName.StartsWith(searh) || obj.Person.NRC == searh || obj.Person.EmailAddress.ToString() == searh).AsNoTracking().ToListAsync();
        }
        public async Task<IEnumerable<Employee>> GetAsync(Status searh)
        {

            return await _db.Employees.Include(obj => obj.Person).ThenInclude(obj => obj.City).ThenInclude(obj => obj.Region).ThenInclude(obj => obj.Country).Include(obj => obj.DeliveryLogs).Include(obj => obj.EmployeeType).Where(obj =>obj.Status  == searh).AsNoTracking().ToListAsync();
        }

        public async Task<Employee> GetAsync(int Id)
        {
            return await _db.Employees.Include(obj => obj.Person).ThenInclude(obj => obj.City).ThenInclude(obj => obj.Region).ThenInclude(obj => obj.Country).Include(obj => obj.DeliveryLogs).Include(obj => obj.EmployeeType).AsNoTracking().FirstOrDefaultAsync(obj => obj.ID == Id);
        }

        public async Task<int> TotalPage(int Pagesize)
        {
            int Totalp = 0;
            int Rowcount = await _db.Employees.CountAsync();
            Totalp = Rowcount / Pagesize;
            if (Rowcount % Pagesize != 0)
            {
                Totalp += 1;
            }

            return Totalp;
        }

        public async Task<Employee> UpInsertAsync(Employee item)
        {
            var current = await _db.Employees.FirstOrDefaultAsync(_obj => _obj.ID == item.ID);
            if (current == null)
            {
                _db.Employees.Add(item);
                _db.Persons.Add(item.Person);
            }
            else
            {
                _db.Entry(current).CurrentValues.SetValues(item);
               
                var current1 = await _db.Persons.FirstOrDefaultAsync(_obj => _obj.ID == item.Person.ID);
                if (current1 == null)
                {
                   
                }
                else
                {
                    _db.Entry(current1).CurrentValues.SetValues(item.Person);

                }
               // await _db.SaveChangesAsync();
            }
            await _db.SaveChangesAsync();
            return item;
        }
    }
    public class PersonImp : IPerson
    {
        private readonly NanoContext _db;
        public PersonImp(NanoContext db)
        {
            _db = db;
        }
        public async Task<Person> DeleteAsync(int Id)
        {
            var current = await _db.Persons.FirstOrDefaultAsync(_obj => _obj.ID == Id);
            if (current != null)
            {
                _db.Persons.Remove(current);
                await _db.SaveChangesAsync();
            }
            return current;
        }

        public async Task<IEnumerable<Person>> GetAsync(int pageindex, int pagesize)
        {
            int offset = (pageindex - 1) * pagesize;
            if (pageindex == -1)
            {
                return await _db.Persons.Include(obj => obj.Employees).Include(obj => obj.City).ThenInclude(obj => obj.Region).ThenInclude(obj => obj.Country).Include(obj => obj.Customers).ToListAsync();
            }
            else
            {
                return await _db.Persons.Include(obj => obj.Employees).Include(obj => obj.City).ThenInclude(obj => obj.Region).ThenInclude(obj => obj.Country).Include(obj => obj.Customers).AsNoTracking().Skip(offset).Take(pagesize).ToListAsync();
            }

        }

        public async Task<IEnumerable<Person>> GetAsync(string searh)
        {

            return await _db.Persons.Include(obj => obj.Employees).Include(obj => obj.City).ThenInclude(obj => obj.Region).ThenInclude(obj => obj.Country).Include(obj => obj.Customers).Where(obj => obj.FullName.StartsWith(searh) || obj.NRC == searh || obj.EmailAddress.ToString() == searh).AsNoTracking()
                .ToListAsync();
        }

        public async Task<Person> GetAsync(int Id)
        {
            return await _db.Persons.Include(obj => obj.Employees).Include(obj => obj.City).ThenInclude(obj => obj.Region).ThenInclude(obj => obj.Country).Include(obj => obj.Customers).AsNoTracking().FirstOrDefaultAsync(obj => obj.ID == Id);
        }

        public async Task<int> TotalPage(int Pagesize)
        {
            int Totalp = 0;
            int Rowcount = await _db.Persons.CountAsync();
            Totalp = Rowcount / Pagesize;
            if (Rowcount % Pagesize != 0)
            {
                Totalp += 1;
            }

            return Totalp;
        }

        public async Task<Person> UpInsertAsync(Person item)
        {
            var current = await _db.Persons.FirstOrDefaultAsync(_obj => _obj.ID == item.ID);
            if (current == null)
            {
                _db.Persons.Add(item);
            }
            else
            {
                _db.Entry(current).CurrentValues.SetValues(item);

            }
            await _db.SaveChangesAsync();
            return item;
        }
    }
    public class EmployeeTypeImp : IEmployeeType
    {
        private readonly NanoContext _db;
        public EmployeeTypeImp(NanoContext db)
        {
            _db = db;
        }
        public async Task<EmployeeType> DeleteAsync(int Id)
        {
            var current = await _db.EmployeeTypes.FirstOrDefaultAsync(_obj => _obj.ID == Id);
            if (current != null)
            {
                _db.EmployeeTypes.Remove(current);
                await _db.SaveChangesAsync();
            }
            return current;
        }

        public async Task<IEnumerable<EmployeeType>> GetAsync(int pageindex, int pagesize)
        {
            int offset = (pageindex - 1) * pagesize;
            if (pageindex == -1)
            {
                return await _db.EmployeeTypes.Include(obj => obj.Employees).ThenInclude(obj=>obj.Person).ThenInclude(obj => obj.City).ThenInclude(obj => obj.Region).ThenInclude(obj => obj.Country).ToListAsync();
            }
            else
            {
                return await _db.EmployeeTypes.Include(obj => obj.Employees).ThenInclude(obj => obj.Person).ThenInclude(obj => obj.City).ThenInclude(obj => obj.Region).ThenInclude(obj => obj.Country).AsNoTracking().Skip(offset).Take(pagesize).ToListAsync();
            }

        }

        public async Task<IEnumerable<EmployeeType>> GetAsync(string searh)
        {

            return await _db.EmployeeTypes.Include(obj => obj.Employees).ThenInclude(obj => obj.Person).ThenInclude(obj => obj.City).ThenInclude(obj => obj.Region).ThenInclude(obj => obj.Country).Where(obj => obj.EmployeeTypeName.StartsWith(searh)).AsNoTracking()
                .ToListAsync();
        }

        public async Task<EmployeeType> GetAsync(int Id)
        {
            return await _db.EmployeeTypes.Include(obj => obj.Employees).ThenInclude(obj => obj.Person).ThenInclude(obj => obj.City).ThenInclude(obj => obj.Region).ThenInclude(obj => obj.Country).AsNoTracking().FirstOrDefaultAsync(obj => obj.ID == Id);
        }

        public async Task<int> TotalPage(int Pagesize)
        {
            int Totalp = 0;
            int Rowcount = await _db.EmployeeTypes.CountAsync();
            Totalp = Rowcount / Pagesize;
            if (Rowcount % Pagesize != 0)
            {
                Totalp += 1;
            }

            return Totalp;
        }

        public async Task<EmployeeType> UpInsertAsync(EmployeeType item)
        {
            var current = await _db.EmployeeTypes.FirstOrDefaultAsync(_obj => _obj.ID == item.ID);
            if (current == null)
            {
                _db.EmployeeTypes.Add(item);
            }
            else
            {
                _db.Entry(current).CurrentValues.SetValues(item);

            }
            await _db.SaveChangesAsync();
            return item;
        }
    }

    public class RoleImp : IRole
    {
        private readonly NanoContext _db;
        public RoleImp(NanoContext db)
        {
            _db = db;
        }
        public async Task<Role> DeleteAsync(int Id)
        {
            var current = await _db.Roles.FirstOrDefaultAsync(_obj => _obj.ID == Id);
            if (current != null)
            {
                _db.Roles.Remove(current);
                await _db.SaveChangesAsync();
            }
            return current;
        }

        public async Task<IEnumerable<Role>> GetAsync(int pageindex, int pagesize)
        {
            int offset = (pageindex - 1) * pagesize;
            if (pageindex == -1)
            {
                return await _db.Roles.Include(obj => obj.Registers).ThenInclude(obj => obj.Person).ThenInclude(obj => obj.City).ThenInclude(obj => obj.Region).ThenInclude(obj => obj.Country).ToListAsync();
            }
            else
            {
                return await _db.Roles.Include(obj => obj.Registers).ThenInclude(obj => obj.Person).ThenInclude(obj => obj.City).ThenInclude(obj => obj.Region).ThenInclude(obj => obj.Country).AsNoTracking().Skip(offset).Take(pagesize).ToListAsync();
            }

        }

        public async Task<IEnumerable<Role>> GetAsync(string searh)
        {

            return await _db.Roles.Include(obj => obj.Registers).ThenInclude(obj => obj.Person).ThenInclude(obj => obj.City).ThenInclude(obj => obj.Region).ThenInclude(obj => obj.Country).Where(obj => obj.RoleName.StartsWith(searh)).AsNoTracking()
                .ToListAsync();
        }

        public async Task<Role> GetAsync(int Id)
        {
            return await _db.Roles.Include(obj => obj.Registers).ThenInclude(obj => obj.Person).ThenInclude(obj => obj.City).ThenInclude(obj => obj.Region).ThenInclude(obj => obj.Country).AsNoTracking().FirstOrDefaultAsync(obj => obj.ID == Id);
        }

        public async Task<int> TotalPage(int Pagesize)
        {
            int Totalp = 0;
            int Rowcount = await _db.Roles.CountAsync();
            Totalp = Rowcount / Pagesize;
            if (Rowcount % Pagesize != 0)
            {
                Totalp += 1;
            }

            return Totalp;
        }

        public async Task<Role> UpInsertAsync(Role item)
        {
            var current = await _db.Roles.FirstOrDefaultAsync(_obj => _obj.ID == item.ID);
            if (current == null)
            {
                _db.Roles.Add(item);
            }
            else
            {
                _db.Entry(current).CurrentValues.SetValues(item);

            }
            await _db.SaveChangesAsync();
            return item;
        }
    }

    public class SupplierImp : ISupplier
    {
        private readonly NanoContext _db;
        public SupplierImp(NanoContext db)
        {
            _db = db;
        }
        public async Task<Supplier> DeleteAsync(int Id)
        {
            var current = await _db.Suppliers.FirstOrDefaultAsync(_obj => _obj.ID == Id);
            if (current != null)
            {
                _db.Suppliers.Remove(current);
                await _db.SaveChangesAsync();
            }
            return current;
        }

        public async Task<IEnumerable<Supplier>> GetAsync(int pageindex, int pagesize)
        {
            int offset = (pageindex - 1) * pagesize;
            if (pageindex == -1)
            {
                return await _db.Suppliers.Include(obj => obj.City).ThenInclude(obj => obj.Region).ThenInclude(obj => obj.Country).ToListAsync();
            }
            else
            {
                return await _db.Suppliers.Include(obj => obj.City).ThenInclude(obj => obj.Region).ThenInclude(obj => obj.Country).AsNoTracking().Skip(offset).Take(pagesize).ToListAsync();
            }

        }

        public async Task<IEnumerable<Supplier>> GetAsync(string searh)
        {

            return await _db.Suppliers.Include(obj => obj.City).ThenInclude(obj => obj.Region).ThenInclude(obj => obj.Country).Where(obj => obj.SupplierName.StartsWith(searh)|| obj.Email.StartsWith(searh)).AsNoTracking()
                .ToListAsync();
        }

        public async Task<Supplier> GetAsync(int Id)
        {
            return await _db.Suppliers.Include(obj => obj.City).ThenInclude(obj => obj.Region).ThenInclude(obj => obj.Country).AsNoTracking().FirstOrDefaultAsync(obj => obj.ID == Id);
        }

        public async Task<int> TotalPage(int Pagesize)
        {
            int Totalp = 0;
            int Rowcount = await _db.Suppliers.CountAsync();
            Totalp = Rowcount / Pagesize;
            if (Rowcount % Pagesize != 0)
            {
                Totalp += 1;
            }

            return Totalp;
        }

        public async Task<Supplier> UpInsertAsync(Supplier item)
        {
            var current = await _db.Suppliers.FirstOrDefaultAsync(_obj => _obj.ID == item.ID);
            if (current == null)
            {
                _db.Suppliers.Add(item);
            }
            else
            {
                _db.Entry(current).CurrentValues.SetValues(item);

            }
            await _db.SaveChangesAsync();
            return item;
        }
    }

    public class BrandImp : IBrand
    {
        private readonly NanoContext _db;
        public BrandImp(NanoContext db)
        {
            _db = db;
        }
        public async Task<Brand> DeleteAsync(int Id)
        {
            var current = await _db.Brands.FirstOrDefaultAsync(_obj => _obj.ID == Id);
            if (current != null)
            {
                _db.Brands.Remove(current);
                await _db.SaveChangesAsync();
            }
            return current;
        }

        public async Task<IEnumerable<Brand>> GetAsync(int pageindex, int pagesize)
        {
            int offset = (pageindex - 1) * pagesize;
            if (pageindex == -1)
            {
                return await _db.Brands.Include(obj => obj.Products).ThenInclude(obj=>obj.Category).ToListAsync();
            }
            else
            {
                return await _db.Brands.Include(obj => obj.Products).ThenInclude(obj => obj.Category).AsNoTracking().Skip(offset).Take(pagesize).ToListAsync();
            }

        }

        public async Task<IEnumerable<Brand>> GetAsync(string searh)
        {

            return await _db.Brands.Include(obj => obj.Products).ThenInclude(obj => obj.Category).Where(obj => obj.BrandName.StartsWith(searh)).AsNoTracking()
                .ToListAsync();
        }

        public async Task<Brand> GetAsync(int Id)
        {
            return await _db.Brands.Include(obj => obj.Products).ThenInclude(obj => obj.Category).AsNoTracking().FirstOrDefaultAsync(obj => obj.ID == Id);
        }

        public async Task<int> TotalPage(int Pagesize)
        {
            int Totalp = 0;
            int Rowcount = await _db.Brands.CountAsync();
            Totalp = Rowcount / Pagesize;
            if (Rowcount % Pagesize != 0)
            {
                Totalp += 1;
            }

            return Totalp;
        }

        public async Task<Brand> UpInsertAsync(Brand item)
        {
            var current = await _db.Brands.FirstOrDefaultAsync(_obj => _obj.ID == item.ID);
            if (current == null)
            {
                _db.Brands.Add(item);
            }
            else
            {
                _db.Entry(current).CurrentValues.SetValues(item);

            }
            await _db.SaveChangesAsync();
            return item;
        }
    }
    public class ProductPropertyImp : IProductProperty
    {
        private readonly NanoContext _db;
        public ProductPropertyImp(NanoContext db)
        {
            _db = db;
        }
        public async Task<ProductProperty> DeleteAsync(int Id)
        {
            var current = await _db.productProperties.FirstOrDefaultAsync(_obj => _obj.ID == Id);
            if (current != null)
            {
                _db.productProperties.Remove(current);
                await _db.SaveChangesAsync();
            }
            return current;
        }

        public async Task<IEnumerable<ProductProperty>> GetAsync(int pageindex, int pagesize)
        {
            int offset = (pageindex - 1) * pagesize;
            if (pageindex == -1)
            {
                return await _db.productProperties.Include(obj => obj.Products).ThenInclude(obj => obj.Category).ToListAsync();
            }
            else
            {
                return await _db.productProperties.Include(obj => obj.Products).ThenInclude(obj => obj.Category).AsNoTracking().Skip(offset).Take(pagesize).ToListAsync();
            }

        }

        public async Task<IEnumerable<ProductProperty>> GetAsync(string searh)
        {

            return await _db.productProperties.Include(obj => obj.Products).ThenInclude(obj => obj.Category).Where(obj => obj.Properties.StartsWith(searh)).AsNoTracking()
                .ToListAsync();
        }

        public async Task<ProductProperty> GetAsync(int Id)
        {
            return await _db.productProperties.Include(obj => obj.Products).ThenInclude(obj => obj.Category).AsNoTracking().FirstOrDefaultAsync(obj => obj.ID == Id);
        }

        public async Task<int> TotalPage(int Pagesize)
        {
            int Totalp = 0;
            int Rowcount = await _db.productProperties.CountAsync();
            Totalp = Rowcount / Pagesize;
            if (Rowcount % Pagesize != 0)
            {
                Totalp += 1;
            }

            return Totalp;
        }

        public async Task<ProductProperty> UpInsertAsync(ProductProperty item)
        {
            var current = await _db.productProperties.FirstOrDefaultAsync(_obj => _obj.ID == item.ID);
            if (current == null)
            {
                _db.productProperties.Add(item);
            }
            else
            {
                _db.Entry(current).CurrentValues.SetValues(item);

            }
            await _db.SaveChangesAsync();
            return item;
        }
    }
  
    public class ProductImp : IProduct
    {
        private readonly NanoContext _db;
        public ProductImp(NanoContext db)
        {
            _db = db;
        }
        public async Task<Product> DeleteAsync(int Id)
        {
            var current = await _db.Products.FirstOrDefaultAsync(_obj => _obj.ID == Id);
            if (current != null)
            {
                _db.Products.Remove(current);
                await _db.SaveChangesAsync();
            }
            return current;
        }

        public async Task<IEnumerable<Product>> GetAsync(int pageindex, int pagesize)
        {
            int offset = (pageindex - 1) * pagesize;
            if (pageindex == -1)
            {
                return await _db.Products.Include(obj => obj.Property).Include(obj => obj.Category).Include(obj => obj.Brand).ToListAsync();
            }
            else
            {
                return await _db.Products.Include(obj => obj.Property).Include(obj => obj.Category).Include(obj => obj.Brand).AsNoTracking().Skip(offset).Take(pagesize).ToListAsync();
            }

        }

        public async Task<IEnumerable<Product>> GetAsync(string searh)
        {

            return await _db.Products.Include(obj => obj.Property).Include(obj => obj.Category).Include(obj => obj.Brand).Where(obj => obj.ProductName.StartsWith(searh) || obj.Barcode.StartsWith(searh)).AsNoTracking()
                .ToListAsync();
        }
        public async Task<IEnumerable<Product>> GetAsync(Status searh)
        {

            return await _db.Products.Include(obj => obj.Property).Include(obj => obj.Category).Include(obj => obj.Brand).Where(obj => obj.Status == searh).AsNoTracking()
                .ToListAsync();
        }

        public async Task<Product> GetAsync(int Id)
        {
            return await _db.Products.Include(obj => obj.Property).Include(obj => obj.Category).Include(obj => obj.Brand).AsNoTracking().FirstOrDefaultAsync(obj => obj.ID == Id);
        }

        public async Task<Product> BarcodeExit(string Id)
        {
            return await _db.Products.Include(obj => obj.Property).Include(obj => obj.Category).Include(obj => obj.Brand).AsNoTracking().FirstOrDefaultAsync(obj => obj.Barcode == Id);
        }
        public async Task<int> TotalPage(int Pagesize)
        {
            int Totalp = 0;
            int Rowcount = await _db.Products.CountAsync();
            Totalp = Rowcount / Pagesize;
            if (Rowcount % Pagesize != 0)
            {
                Totalp += 1;
            }

            return Totalp;
        }

        public async Task<Product> UpInsertAsync(Product item)
        {
            var current = await _db.Products.FirstOrDefaultAsync(_obj => _obj.ID == item.ID);
            if (current == null)
            {
                _db.Products.Add(item);
            }
            else
            {
                _db.Entry(current).CurrentValues.SetValues(item);

            }
            await _db.SaveChangesAsync();
            return item;
        }
    }
    public class PurchaseImp : IPurchase
    {
        private readonly NanoContext _db;
        public PurchaseImp(NanoContext db)
        {
            _db = db;
        }
        public async Task<Purchase> DeleteAsync(int Id)
        {
            var current = await _db.Purchases.FirstOrDefaultAsync(_obj => _obj.ID == Id);
            if (current != null)
            {
                _db.Purchases.Remove(current);
                await _db.SaveChangesAsync();
            }
            return current;
        }

        public async Task<IEnumerable<Purchase>> GetAsync(int pageindex, int pagesize)
        {
            int offset = (pageindex - 1) * pagesize;
            if (pageindex == -1)
            {
                return await _db.Purchases.Include(obj => obj.PurchaseProdcuts).ThenInclude(obj => obj.Discount).Include(obj => obj.PurchaseProdcuts).ThenInclude(obj => obj.Products).Include(obj => obj.Supplier).ToListAsync();
            }
            else
            {
                return await _db.Purchases.Include(obj => obj.PurchaseProdcuts).ThenInclude(obj => obj.Discount).Include(obj => obj.PurchaseProdcuts).ThenInclude(obj => obj.Products).Include(obj => obj.Supplier).AsNoTracking().Skip(offset).Take(pagesize).ToListAsync();
            }

        }

        public async Task<IEnumerable<Purchase>> GetAsync(string searh)
        {

            return await _db.Purchases.Include(obj => obj.PurchaseProdcuts).ThenInclude(obj => obj.Discount).Include(obj => obj.PurchaseProdcuts).ThenInclude(obj => obj.Products).Include(obj => obj.Supplier).Where(obj => obj.InvoiceNumber.StartsWith(searh)).AsNoTracking()
                .ToListAsync();
        }
        public async Task<IEnumerable<Purchase>> GetAsync(PaymentStatus searh)
        {

            return await _db.Purchases.Include(obj => obj.PurchaseProdcuts).ThenInclude(obj => obj.Discount).Include(obj => obj.PurchaseProdcuts).ThenInclude(obj=>obj.Products).Include(obj => obj.PurchaseProdcuts).ThenInclude(obj => obj.Products).Include(obj => obj.Supplier).Where(obj => obj.PaymentStatus == searh).AsNoTracking()
                .ToListAsync();
        }

        public async Task<Purchase> GetAsync(int Id)
        {
            return await _db.Purchases.Include(obj => obj.PurchaseProdcuts).ThenInclude(obj => obj.Discount).Include(obj => obj.PurchaseProdcuts).ThenInclude(obj=>obj.Products).ThenInclude(obj=>obj.Category).Include(obj => obj.Supplier).AsNoTracking().FirstOrDefaultAsync(obj => obj.ID == Id);
        }


        public async Task<int> TotalPage(int Pagesize)
        {
            int Totalp = 0;
            int Rowcount = await _db.Purchases.CountAsync();
            Totalp = Rowcount / Pagesize;
            if (Rowcount % Pagesize != 0)
            {
                Totalp += 1;
            }

            return Totalp;
        }

        public async Task<Purchase> UpInsertAsync(Purchase item)
        {
            var current = await _db.Purchases.FirstOrDefaultAsync(_obj => _obj.ID == item.ID);
            if (current == null)
            {

                //foreach (PurchaseItem item1 in item.PurchaseProdcuts)
                //{
                //    item1.Products = new Product();
                //    item1.Discount = new Discount();
                //}

                _db.Purchases.Add(item);
            }
            else
            {
                _db.Entry(current).CurrentValues.SetValues(item);
                foreach (PurchaseItem pitem in item.PurchaseProdcuts)
                {
                    var pcurrent = await _db.PurchaseItems.FirstOrDefaultAsync(_obj => _obj.ID == pitem.ID);
                    if (pcurrent == null)
                    {
                        _db.PurchaseItems.Add(pitem);
                    }
                    else
                    {
                        _db.Entry(pcurrent).CurrentValues.SetValues(pitem);


                    }
                }
            }
            await _db.SaveChangesAsync();
            return item;
        }
    }
    public class PurchaseItemImp : IPurchaseItem
    {
        private readonly NanoContext _db;
        public PurchaseItemImp(NanoContext db)
        {
            _db = db;
        }
        public async Task<PurchaseItem> DeleteAsync(int Id)
        {
            var current = await _db.PurchaseItems.FirstOrDefaultAsync(_obj => _obj.ID == Id);
            if (current != null)
            {
                _db.PurchaseItems.Remove(current);
                await _db.SaveChangesAsync();
            }
            return current;
        }

        public async Task<IEnumerable<PurchaseItem>> GetAsync(int pageindex, int pagesize)
        {
            int offset = (pageindex - 1) * pagesize;
            if (pageindex == -1)
            {
                return await _db.PurchaseItems.Include(obj => obj.Products).ThenInclude(obj => obj.Category).Include(obj=>obj.Products).ThenInclude(obj=>obj.Brand).Include(obj=>obj.Products).ThenInclude(obj=>obj.Property).Include(obj => obj.Discount).ToListAsync();
            }
            else
            {
                
                return await _db.PurchaseItems.Include(obj => obj.Products).ThenInclude(obj => obj.Category).Include(obj => obj.Products).ThenInclude(obj => obj.Brand).Include(obj => obj.Products).ThenInclude(obj => obj.Property).Include(obj => obj.Discount).AsNoTracking().Skip(offset).Take(pagesize).ToListAsync();
            }

        }

        public async Task<IEnumerable<PurchaseItem>> GetAsync(string searh)
        {

            return await _db.PurchaseItems.Include(obj => obj.Products).ThenInclude(obj => obj.Category).Include(obj => obj.Products).ThenInclude(obj => obj.Brand).Include(obj => obj.Products).ThenInclude(obj => obj.Property).Include(obj => obj.Discount).Where(obj => obj.Products.ProductName.StartsWith(searh) || obj.Products.Barcode.StartsWith(searh)).AsNoTracking()
                .ToListAsync();
        }
        public async Task<IEnumerable<PurchaseItem>> GetAsync(PaymentStatus searh)
        {

            return await _db.PurchaseItems.Include(obj => obj.Products).ThenInclude(obj => obj.Category).Include(obj => obj.Products).ThenInclude(obj => obj.Brand).Include(obj => obj.Products).ThenInclude(obj => obj.Property).Include(obj => obj.Discount).Where(obj => obj.PaymentStatus == searh).AsNoTracking()
                .ToListAsync();
        }

        public async Task<PurchaseItem> GetAsync(int Id)
        {
            return await _db.PurchaseItems.Include(obj => obj.Products).ThenInclude(obj => obj.Category).Include(obj => obj.Products).ThenInclude(obj => obj.Brand).Include(obj => obj.Products).ThenInclude(obj => obj.Property).Include(obj=>obj.Discount).AsNoTracking().FirstOrDefaultAsync(obj => obj.ID == Id);
        }


        public async Task<int> TotalPage(int Pagesize)
        {
            int Totalp = 0;
            int Rowcount = await _db.PurchaseItems.CountAsync();
            Totalp = Rowcount / Pagesize;
            if (Rowcount % Pagesize != 0)
            {
                Totalp += 1;
            }

            return Totalp;
        }

        public async Task<PurchaseItem> UpInsertAsync(PurchaseItem item)
        {
            var current = await _db.PurchaseItems.FirstOrDefaultAsync(_obj => _obj.ID == item.ID);
            if (current == null)
            {
                _db.PurchaseItems.Add(item);
            }
            else
            {
                
                _db.Entry(current).CurrentValues.SetValues(item);
                
            }
            await _db.SaveChangesAsync();
            return item;
        }
    }


    public class InvoiceImp : Iinvoice
    {
        private readonly NanoContext _db;
        public InvoiceImp(NanoContext db)
        {
            _db = db;
        }
        public async Task<Invoice> DeleteAsync(int Id)
        {
            var current = await _db.Invoices.FirstOrDefaultAsync(_obj => _obj.ID == Id);
            if (current != null)
            {
                _db.Invoices.Remove(current);
                await _db.SaveChangesAsync();
            }
            return current;
        }

        public async Task<IEnumerable<Invoice>> GetAsync(int pageindex, int pagesize)
        {
            int offset = (pageindex - 1) * pagesize;
            if (pageindex == -1)
            {
                return await _db.Invoices.Include(obj => obj.purchaseItems).ThenInclude(obj => obj.Discount).Include(obj => obj.purchaseItems).ThenInclude(obj => obj.Products).Include(obj => obj.Customer).ToListAsync();
            }
            else
            {
                return await _db.Invoices.Include(obj => obj.purchaseItems).ThenInclude(obj => obj.Discount).Include(obj => obj.purchaseItems).ThenInclude(obj => obj.Products).Include(obj => obj.Customer).AsNoTracking().Skip(offset).Take(pagesize).ToListAsync();
            }

        }

        public async Task<IEnumerable<Invoice>> GetAsync(string searh)
        {

            return await _db.Invoices.Include(obj => obj.purchaseItems).ThenInclude(obj => obj.Discount).Include(obj => obj.purchaseItems).ThenInclude(obj => obj.Products).Include(obj => obj.Customer).Where(obj => obj.InvoiceNo.StartsWith(searh)).AsNoTracking()
                .ToListAsync();
        }
        public async Task<IEnumerable<Invoice>> GetAsync(PaymentStatus searh)
        {

            return await _db.Invoices.Include(obj => obj.purchaseItems).ThenInclude(obj => obj.Discount).Include(obj => obj.purchaseItems).ThenInclude(obj => obj.Products).Include(obj => obj.Customer).Where(obj => obj.PaymentStatus == searh).AsNoTracking()
                .ToListAsync();
        }

        public async Task<Invoice> GetAsync(int Id)
        {
            return await _db.Invoices.Include(obj => obj.purchaseItems).ThenInclude(obj => obj.Discount).Include(obj => obj.purchaseItems).ThenInclude(obj => obj.Products).Include(obj => obj.Customer).AsNoTracking().FirstOrDefaultAsync(obj => obj.ID == Id);
        }


        public async Task<int> TotalPage(int Pagesize)
        {
            int Totalp = 0;
            int Rowcount = await _db.Invoices.CountAsync();
            Totalp = Rowcount / Pagesize;
            if (Rowcount % Pagesize != 0)
            {
                Totalp += 1;
            }

            return Totalp;
        }

        public async Task<Invoice> UpInsertAsync(Invoice item)
        {
            var current = await _db.Invoices.FirstOrDefaultAsync(_obj => _obj.ID == item.ID);
            if (current == null)
            {

                //foreach (PurchaseItem item1 in item.PurchaseProdcuts)
                //{
                //    item1.Products = new Product();
                //    item1.Discount = new Discount();
                //}

                _db.Invoices.Add(item);
            }
            else
            {
                _db.Entry(current).CurrentValues.SetValues(item);
                foreach (InvoiceItem pitem in item.purchaseItems)
                {
                    var pcurrent = await _db.InvoiceItems.FirstOrDefaultAsync(_obj => _obj.ID == pitem.ID);
                    if (pcurrent == null)
                    {
                        _db.InvoiceItems.Add(pitem);
                    }
                    else
                    {
                        _db.Entry(pcurrent).CurrentValues.SetValues(pitem);


                    }
                }
            }
            await _db.SaveChangesAsync();
            return item;
        }
    }

    public class InvoceItemImp : IInvoiceItem
    {
        private readonly NanoContext _db;
        public InvoceItemImp(NanoContext db)
        {
            _db = db;
        }
        public async Task<InvoiceItem> DeleteAsync(int Id)
        {
            var current = await _db.InvoiceItems.FirstOrDefaultAsync(_obj => _obj.ID == Id);
            if (current != null)
            {
                _db.InvoiceItems.Remove(current);
                await _db.SaveChangesAsync();
            }
            return current;
        }

        public async Task<IEnumerable<InvoiceItem>> GetAsync(int pageindex, int pagesize)
        {
            int offset = (pageindex - 1) * pagesize;
            if (pageindex == -1)
            {
                return await _db.InvoiceItems.Include(obj => obj.Products).ThenInclude(obj => obj.Category).Include(obj => obj.Products).ThenInclude(obj => obj.Brand).Include(obj => obj.Products).ThenInclude(obj => obj.Property).Include(obj => obj.Discount).ToListAsync();
            }
            else
            {

                return await _db.InvoiceItems.Include(obj => obj.Products).ThenInclude(obj => obj.Category).Include(obj => obj.Products).ThenInclude(obj => obj.Brand).Include(obj => obj.Products).ThenInclude(obj => obj.Property).Include(obj => obj.Discount).AsNoTracking().Skip(offset).Take(pagesize).ToListAsync();
            }

        }

        public async Task<IEnumerable<InvoiceItem>> GetAsync(string searh)
        {

            return await _db.InvoiceItems.Include(obj => obj.Products).ThenInclude(obj => obj.Category).Include(obj => obj.Products).ThenInclude(obj => obj.Brand).Include(obj => obj.Products).ThenInclude(obj => obj.Property).Include(obj => obj.Discount).Where(obj => obj.Products.ProductName.StartsWith(searh) || obj.Products.Barcode.StartsWith(searh)).AsNoTracking()
                .ToListAsync();
        }
        public async Task<IEnumerable<InvoiceItem>> GetAsync(OrderStatus searh)
        {

            return await _db.InvoiceItems.Include(obj => obj.Products).ThenInclude(obj => obj.Category).Include(obj => obj.Products).ThenInclude(obj => obj.Brand).Include(obj => obj.Products).ThenInclude(obj => obj.Property).Include(obj => obj.Discount).Where(obj => obj.OrderStatus == searh).AsNoTracking()
                .ToListAsync();
        }

        public async Task<InvoiceItem> GetAsync(int Id)
        {
            return await _db.InvoiceItems.Include(obj => obj.Products).ThenInclude(obj => obj.Category).Include(obj => obj.Products).ThenInclude(obj => obj.Brand).Include(obj => obj.Products).ThenInclude(obj => obj.Property).Include(obj => obj.Discount).AsNoTracking().FirstOrDefaultAsync(obj => obj.ID == Id);
        }


        public async Task<int> TotalPage(int Pagesize)
        {
            int Totalp = 0;
            int Rowcount = await _db.InvoiceItems.CountAsync();
            Totalp = Rowcount / Pagesize;
            if (Rowcount % Pagesize != 0)
            {
                Totalp += 1;
            }

            return Totalp;
        }

        public async Task<InvoiceItem> UpInsertAsync(InvoiceItem item)
        {
            var current = await _db.InvoiceItems.FirstOrDefaultAsync(_obj => _obj.ID == item.ID);
            if (current == null)
            {
                _db.InvoiceItems.Add(item);
            }
            else
            {

                _db.Entry(current).CurrentValues.SetValues(item);

            }
            await _db.SaveChangesAsync();
            return item;
        }
    }

    public class DiscountTypeImp : IDiscountType
    {
        private readonly NanoContext _db;
        public DiscountTypeImp(NanoContext db)
        {
            _db = db;
        }
        public async Task<DiscountType> DeleteAsync(int Id)
        {
            var current = await _db.DiscountTypes.FirstOrDefaultAsync(_obj => _obj.ID == Id);
            if (current != null)
            {
                _db.DiscountTypes.Remove(current);
                await _db.SaveChangesAsync();
            }
            return current;
        }

        public async Task<IEnumerable<DiscountType>> GetAsync(int pageindex, int pagesize)
        {
            int offset = (pageindex - 1) * pagesize;
            if (pageindex == -1)
            {
                return await _db.DiscountTypes.Include(obj => obj.Discounts).ThenInclude(obj => obj.DiscountProducts).ThenInclude(obj => obj.Products).ToListAsync();
            }
            else
            {
                return await _db.DiscountTypes.Include(obj => obj.Discounts).ThenInclude(obj => obj.DiscountProducts).ThenInclude(obj => obj.Products).AsNoTracking().Skip(offset).Take(pagesize).ToListAsync();
            }

        }

        public async Task<IEnumerable<DiscountType>> GetAsync(string searh)
        {

            return await _db.DiscountTypes.Include(obj => obj.Discounts).ThenInclude(obj => obj.DiscountProducts).ThenInclude(obj => obj.Products)
                .Where(obj => obj.DiscountTypeName.StartsWith(searh)).AsNoTracking()
                .ToListAsync();
        }

        public async Task<DiscountType> GetAsync(int Id)
        {
            return await _db.DiscountTypes.Include(obj => obj.Discounts).ThenInclude(obj => obj.DiscountProducts).ThenInclude(obj => obj.Products).AsNoTracking().FirstOrDefaultAsync(obj => obj.ID == Id);
        }

        public async Task<int> TotalPage(int Pagesize)
        {
            int Totalp = 0;
            int Rowcount = await _db.DiscountTypes.CountAsync();
            Totalp = Rowcount / Pagesize;
            if (Rowcount % Pagesize != 0)
            {
                Totalp += 1;
            }

            return Totalp;
        }

        public async Task<DiscountType> UpInsertAsync(DiscountType item)
        {
            var current = await _db.DiscountTypes.FirstOrDefaultAsync(_obj => _obj.ID == item.ID);
            if (current == null)
            {
                _db.DiscountTypes.Add(item);
            }
            else
            {
                _db.Entry(current).CurrentValues.SetValues(item);

            }
            await _db.SaveChangesAsync();
            return item;
        }
    }
    public class DiscountImp : IDiscount
    {
        private readonly NanoContext _db;
        public DiscountImp(NanoContext db)
        {
            _db = db;
        }
        public async Task<Discount> DeleteAsync(int Id)
        {
            var current = await _db.Discounts.FirstOrDefaultAsync(_obj => _obj.ID == Id);
            if (current != null)
            {
                _db.Discounts.Remove(current);
                await _db.SaveChangesAsync();
            }
            return current;
        }

        public async Task<IEnumerable<Discount>> GetAsync(int pageindex, int pagesize)
        {
            int offset = (pageindex - 1) * pagesize;
            if (pageindex == -1)
            {
                return await _db.Discounts.Include(obj => obj.DiscountType).Include(obj => obj.DiscountProducts).ThenInclude(obj => obj.Products).Include(obj=>obj.Invoices).ToListAsync();
            }
            else
            {
                return await _db.Discounts.Include(obj => obj.DiscountType).Include(obj => obj.DiscountProducts).ThenInclude(obj => obj.Products).Include(obj => obj.Invoices).AsNoTracking().Skip(offset).Take(pagesize).ToListAsync();
            }

        }

        public async Task<IEnumerable<Discount>> GetAsync(string searh)
        {

            return await _db.Discounts.Include(obj => obj.DiscountType).Include(obj => obj.DiscountProducts).ThenInclude(obj => obj.Products).Include(obj => obj.Invoices)
                .Where(obj => obj.DiscountName.StartsWith(searh)|| obj.Percentage.ToString().StartsWith(searh)).AsNoTracking()
                .ToListAsync();
        }

        public async Task<Discount> GetAsync(int Id)
        {
            return await _db.Discounts.Include(obj => obj.DiscountType).Include(obj => obj.DiscountProducts).ThenInclude(obj => obj.Products).Include(obj => obj.Invoices).AsNoTracking().FirstOrDefaultAsync(obj => obj.ID == Id);
        }

        public async Task<int> TotalPage(int Pagesize)
        {
            int Totalp = 0;
            int Rowcount = await _db.Discounts.CountAsync();
            Totalp = Rowcount / Pagesize;
            if (Rowcount % Pagesize != 0)
            {
                Totalp += 1;
            }

            return Totalp;
        }

        public async Task<Discount> UpInsertAsync(Discount item)
        {
            var current = await _db.Discounts.FirstOrDefaultAsync(_obj => _obj.ID == item.ID);
            if (current == null)
            {
                _db.Discounts.Add(item);
            }
            else
            {
                _db.Entry(current).CurrentValues.SetValues(item);

            }
            await _db.SaveChangesAsync();
            return item;
        }
    }
    public class GiftCardImp : IGiftCard
    {
        private readonly NanoContext _db;
        public GiftCardImp(NanoContext db)
        {
            _db = db;
        }
        public async Task<GiftCard> DeleteAsync(int Id)
        {
            var current = await _db.GiftCards.FirstOrDefaultAsync(_obj => _obj.ID == Id);
            if (current != null)
            {
                _db.GiftCards.Remove(current);
                await _db.SaveChangesAsync();
            }
            return current;
        }

        public async Task<IEnumerable<GiftCard>> GetAsync(int pageindex, int pagesize)
        {
            int offset = (pageindex - 1) * pagesize;
            if (pageindex == -1)
            {
                return await _db.GiftCards.Include(obj => obj.Invoices).ThenInclude(obj => obj.purchaseItems).ThenInclude(obj => obj.Products).ToListAsync();
            }
            else
            {
                return await _db.GiftCards.Include(obj => obj.Invoices).ThenInclude(obj => obj.purchaseItems).ThenInclude(obj => obj.Products).AsNoTracking().Skip(offset).Take(pagesize).ToListAsync();
            }

        }

        public async Task<IEnumerable<GiftCard>> GetAsync(string searh)
        {

            return await _db.GiftCards.Include(obj => obj.Invoices).ThenInclude(obj => obj.purchaseItems).ThenInclude(obj => obj.Products)
                .Where(obj => obj.GiftCardName.StartsWith(searh) || obj.Percentage.ToString().StartsWith(searh)).AsNoTracking()
                .ToListAsync();
        }

        public async Task<GiftCard> GetAsync(int Id)
        {
            return await _db.GiftCards.Include(obj => obj.Invoices).ThenInclude(obj => obj.purchaseItems).ThenInclude(obj => obj.Products).AsNoTracking().FirstOrDefaultAsync(obj => obj.ID == Id);
        }

        public async Task<int> TotalPage(int Pagesize)
        {
            int Totalp = 0;
            int Rowcount = await _db.GiftCards.CountAsync();
            Totalp = Rowcount / Pagesize;
            if (Rowcount % Pagesize != 0)
            {
                Totalp += 1;
            }

            return Totalp;
        }

        public async Task<GiftCard> UpInsertAsync(GiftCard item)
        {
            var current = await _db.GiftCards.FirstOrDefaultAsync(_obj => _obj.ID == item.ID);
            if (current == null)
            {
                _db.GiftCards.Add(item);
            }
            else
            {
                _db.Entry(current).CurrentValues.SetValues(item);

            }
            await _db.SaveChangesAsync();
            return item;
        }
    }
    public class DiscountProductImp : IDiscountProduct
    {
        private readonly NanoContext _db;
        public DiscountProductImp(NanoContext db)
        {
            _db = db;
        }
        public async Task<DiscountProduct> DeleteAsync(int Id)
        {
            var current = await _db.DiscountProducts.FirstOrDefaultAsync(_obj => _obj.ID == Id);
            if (current != null)
            {
                _db.DiscountProducts.Remove(current);
                await _db.SaveChangesAsync();
            }
            return current;
        }

        public async Task<IEnumerable<DiscountProduct>> GetAsync(int pageindex, int pagesize)
        {
            int offset = (pageindex - 1) * pagesize;
            if (pageindex == -1)
            {
                return await _db.DiscountProducts.Include(obj => obj.Products).Include(obj => obj.Discount).ToListAsync();
            }
            else
            {
                return await _db.DiscountProducts.Include(obj => obj.Products).Include(obj => obj.Discount).AsNoTracking().Skip(offset).Take(pagesize).ToListAsync();
            }

        }

        public async Task<IEnumerable<DiscountProduct>> GetAsync(string searh)
        {

            return await _db.DiscountProducts.Include(obj => obj.Products).Include(obj => obj.Discount)
                .Where(obj => obj.Discount.DiscountName.StartsWith(searh) || obj.ExpiryDate.ToString().StartsWith(searh)).AsNoTracking()
                .ToListAsync();
        }

        public async Task<DiscountProduct> GetAsync(int Id)
        {
            return await _db.DiscountProducts.Include(obj => obj.Products).Include(obj => obj.Discount).AsNoTracking().FirstOrDefaultAsync(obj => obj.ID == Id);
        }

        public async Task<int> TotalPage(int Pagesize)
        {
            int Totalp = 0;
            int Rowcount = await _db.DiscountProducts.CountAsync();
            Totalp = Rowcount / Pagesize;
            if (Rowcount % Pagesize != 0)
            {
                Totalp += 1;
            }

            return Totalp;
        }

        public async Task<DiscountProduct> UpInsertAsync(DiscountProduct item)
        {
            var current = await _db.DiscountProducts.FirstOrDefaultAsync(_obj => _obj.ID == item.ID);
            if (current == null)
            {
                _db.DiscountProducts.Add(item);
            }
            else
            {
                _db.Entry(current).CurrentValues.SetValues(item);

            }
            await _db.SaveChangesAsync();
            return item;
        }
    }
    public class ImplementModel : InterFaceModel
    {
        private readonly DbContextOptions<NanoContext> _dbOptions;
        public ImplementModel(DbContextOptionsBuilder<NanoContext> dbOptionsBuilder)
        {
            _dbOptions = dbOptionsBuilder.Options;
            using (var db = new NanoContext(_dbOptions))
            {
               // db.Database.EnsureCreated();
            }
        }

        public ICategory Categorys => new CategoryImp(new NanoContext(_dbOptions));
        public ICity Citys => new CityImp(new NanoContext(_dbOptions));
        public ICountry Countries => new CountryImp(new NanoContext(_dbOptions));
        public IRegion Regions => new RegionImp(new NanoContext(_dbOptions));
        public ILocation Locations => new LocationImp(new NanoContext(_dbOptions));
        public IEmployee Employees => new EmployeeImp(new NanoContext(_dbOptions));
        public IPerson Persons => new PersonImp(new NanoContext(_dbOptions));
        public IEmployeeType EmployeeTypes => new EmployeeTypeImp(new NanoContext(_dbOptions));
        public IRole Roles => new RoleImp(new NanoContext(_dbOptions));
        public ISupplier Suppliers => new SupplierImp(new NanoContext(_dbOptions));
        public IBrand Brands => new BrandImp(new NanoContext(_dbOptions));
        public IProductProperty ProductPropertys => new ProductPropertyImp(new NanoContext(_dbOptions));
        public IProduct Products => new ProductImp(new NanoContext(_dbOptions));
        public IPurchase Purchases => new PurchaseImp(new NanoContext(_dbOptions));
        public Iinvoice Invoices => new InvoiceImp(new NanoContext(_dbOptions));
        public IPurchaseItem PurchaseItems => new PurchaseItemImp(new NanoContext(_dbOptions));
        public IInvoiceItem InvoiceItems => new InvoceItemImp(new NanoContext(_dbOptions));
        public IDiscountType DiscountTypes => new DiscountTypeImp(new NanoContext(_dbOptions));
        public IDiscount Discounts => new DiscountImp(new NanoContext(_dbOptions));
        public IGiftCard GiftCards => new GiftCardImp(new NanoContext(_dbOptions));
        public IDiscountProduct DiscountProducts => new DiscountProductImp(new NanoContext(_dbOptions));

    }
}
