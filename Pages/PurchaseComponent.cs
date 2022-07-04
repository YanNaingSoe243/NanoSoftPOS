using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.JSInterop;
using NanoSoftGreenMark.Data;
using NanoSoftGreenMark.DepandencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NanoSoftGreenMark.Pages
{
    public class PurchaseComponent:ComponentBase
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
            itemCount = 1;

        }
        protected int PageSize { get; set; } = 10;
        protected int PageIndex { get; set; } = 1;
        protected int Count { get; set; } = 1;
        protected int itemCount { get; set; } = 1;
        protected int PageCount { get; set; } = 0;
        private IEnumerable<Purchase> _geCategory { get; set; }
        protected IEnumerable<Purchase> Categories
        {
            get { return _geCategory; }

            set
            {
                if (!object.Equals(_geCategory, value))
                {
                    _geCategory = value;

                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }
        protected Confirmbase DeleteConfirmation { get; set; }
        protected AddPurchase addCategory { get; set; }
        protected int ID;

        protected async System.Threading.Tasks.Task Load()
        {



            var HRDResult = await Service.Purchases.GetAsync(PageIndex, PageSize);
            
            Categories = HRDResult;
            PageCount = await Service.Purchases.TotalPage(PageSize);

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
        public async System.Threading.Tasks.Task AddData(Purchase data)
        {
            try
            {
                if (data != null)
                {
                    foreach(PurchaseItem obj in data.PurchaseProdcuts)
                    {
                        obj.Products = null;
                        obj.Discount = null;
                    }
                    await Service.Purchases.UpInsertAsync(data);
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
                try
                {
                                  
                    var Result = await Service.Purchases.DeleteAsync(ID);
                    await Load();
                    ID = 0;
                 }
                catch(Exception e)
                {

                }

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
                PageCount = await Service.Purchases.TotalPage(PageSize);
                //  await JSRuntime.InvokeAsync<bool>("Paging", Paging,PageCount+2);

            }
            StateHasChanged();
        }
        protected async Task ChangePageSize(ChangeEventArgs e)
        {
            PageSize = Convert.ToInt32(e.Value);
            await Load();

            PageCount = await Service.Purchases.TotalPage(PageSize);
            await JSRuntime.InvokeAsync<bool>("Paging", Paging, PageCount + 2);

        }
        private string searchTerm;
        protected string SearchTerm
        {
            get { return searchTerm; }
            set { searchTerm = value; Search(); }
        }
        protected async void Search()
        {
            var HRDResult = await Service.Purchases.GetAsync(searchTerm);
            Categories = HRDResult;
            int Rowcount = Categories.Count();
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


                exportService.ToExcel(Categories.AsQueryable(), "aaa");




            }

        }


        public async Task ExportToCSV()
        {

            exportService.ToCSV(Categories.AsQueryable(), "aa");
        }
    }
}
