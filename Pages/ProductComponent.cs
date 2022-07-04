using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using NanoSoftGreenMark.Data;
using NanoSoftGreenMark.DepandencyInjection;

namespace NanoSoftGreenMark.Pages
{
    public partial class ProductComponent:ComponentBase
    {
        [Inject]
        protected IJSRuntime JSRuntime { get; set; }
        [Inject]
        protected NavigationManager UriHelper { get; set; }
        [Inject]
        protected InterFaceModel Service { get; set; }
        [Inject]
        protected NavigationManager navigationManager { get; set; }
        [Inject]
        protected ExportService exportService { get; set; }

        //[Inject]
        //protected NotificationService NotificationService { get; set; }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            //if (!Security.IsAuthenticated())
            //{
            //    UriHelper.NavigateTo("Login", true);
            //}
            //else
            //{
            //    await Load();
            //}

            await Load();

            Count = 1;


        }
        protected int PageSize { get; set; } = 10;
        protected int PageIndex { get; set; } = 1;
        protected int Count { get; set; } = 1;
        protected int PageCount { get; set; } = 0;
        private IEnumerable<Product> _geProduct { get; set; }
       protected  IEnumerable<Category> getCategory { get; set; }
        protected IEnumerable<Product> getProduct
        {
            get { return _geProduct; }

            set
            {
                if (!object.Equals(_geProduct, value))
                {
                    _geProduct = value;

                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }
        protected Confirmbase DeleteConfirmation { get; set; }
        protected AddProduct addCategory { get; set; }
        protected int ID;

        protected async System.Threading.Tasks.Task Load()
        {



            var HRDResult = await Service.Products.GetAsync(PageIndex, PageSize);
            getProduct = HRDResult;
            PageCount = await Service.Products.TotalPage(PageSize);
            var CategoryResult= await Service.Categorys.GetAsync(-1, PageSize);
            getCategory = CategoryResult;

            //await Task.Run(LoadIndicator);
        }
        private void LoadIndicator()
        {
            System.Threading.Thread.Sleep(1000);
        }


        protected void Delete(int Id)
        {
            DeleteConfirmation.Show();
            ID = Id;
            //var Result = await Service.Categorys.DeleteAsync(Id);
            //await Load();

        }
        protected void AddCategory()
        {
            addCategory.Show();

        }
        protected void EditCategory(int Id)
        {
            addCategory.Edit(Id);

        }
        protected ElementReference Paging;
        public async System.Threading.Tasks.Task AddData(Product data)
        {
            try
            {
                if (data != null)
                {
                    await Service.Products.UpInsertAsync(data);
                }


            }
            catch (Exception Ex)
            {
                //NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new Branch!");
            }
            await Load();
        }
        protected async Task ConfirmDelete_Click(bool deleteConfirmed)
        {
            if (deleteConfirmed)
            {
                var Result = await Service.Products.DeleteAsync(ID);
                await Load();
                ID = 0;

            }

        }

        protected async Task Previous()
        {
            if (PageIndex <= 1)
            {
                PageIndex = 1;
            }
            else
            {
                PageIndex--;
            }
            await Load();
        }
        protected async Task Next()
        {
            if (PageIndex < PageCount)
            {
                PageIndex++;
            }
            else
            {
                PageIndex = PageCount;
            }
            await Load();
        }
        protected async Task PageEvent(int value)
        {
            PageIndex = value;
            await Load();
        }
        protected override async Task OnAfterRenderAsync(bool a)
        {
            if (a)
            {
                PageCount = await Service.Products.TotalPage(PageSize);
           

            }
        }
       protected  async void  CheckActive(bool e)
        {
            if (e == false)
            {
                var HRDResult = await Service.Products.GetAsync(Status.Inactive);
                getProduct = HRDResult;
            }
            else
            {
                var HRDResult = await Service.Products.GetAsync(Status.Active);
                getProduct = HRDResult;
            }


        }
        protected  void GetCategory(int e)
        {
            
                var HRDResult = getCategory.FirstOrDefault(obj=>obj.ID==Convert.ToInt32(e)).Products;
                getProduct = HRDResult;
           
        }
        protected async Task ChangePageSize(ChangeEventArgs e)
        {
            PageSize = Convert.ToInt32(e.Value);
            await Load();
        }
        private string searchTerm;
        protected string SearchTerm
        {
            get { return searchTerm; }
            set { searchTerm = value; Search(); }
        }
        protected async void Search()
        {
            var HRDResult = await Service.Products.GetAsync(searchTerm);
            getProduct = HRDResult;
            int Rowcount = getProduct.Count();
            PageCount = Rowcount / PageSize;
            if (Rowcount % PageSize != 0)
            {
                PageCount += 1;
            }
            StateHasChanged();

        }

        public async Task ExportToExcel()
        {
            if (await JSRuntime.InvokeAsync<bool>("confirm", $"Do you want to Export?"))
            {

                 exportService.ToExcel(getProduct.AsQueryable(), "aaa");

            }

        }


        public async Task ExportToCSV()
        {

            exportService.ToCSV(getProduct.AsQueryable(), "aa");
        }

    }
}

