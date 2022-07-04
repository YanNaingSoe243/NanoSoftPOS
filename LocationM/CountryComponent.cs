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


namespace NanoSoftGreenMark.LocationM
{
    public partial class CountryComponent:ComponentBase
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
        private IEnumerable<Country> _getCountry { get; set; }
        protected IEnumerable<Country> getCountry
        {
            get { return _getCountry; }

            set
            {
                if (!object.Equals(_getCountry, value))
                {
                    _getCountry = value;

                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }
        protected DeleteConfirm DeleteConfirmation { get; set; }
        protected AddCountry addComponent { get; set; }
        protected int ID;

        protected async System.Threading.Tasks.Task Load()
        {



            var HRDResult = await Service.Countries.GetAsync(PageIndex, PageSize);
            getCountry = HRDResult;
            PageCount = await Service.Countries.TotalPage(PageSize);

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
            addComponent.Show();

        }
        protected void EditCategory(int Id)
        {
            addComponent.Edit(Id);

        }
        protected ElementReference Paging;
        public async System.Threading.Tasks.Task AddData(Country data)
        {
            try
            {
                if (data != null)
                {
                    await Service.Countries.UpInsertAsync(data);
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
                var Result = await Service.Countries.DeleteAsync(ID);
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
                PageCount = await Service.Countries.TotalPage(PageSize);
                //await JSRuntime.InvokeAsync<bool>("Paging", Paging, PageCount + 2);



            }
            StateHasChanged();
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
            var HRDResult = await Service.Countries.GetAsync(searchTerm);
            getCountry = HRDResult;
            int Rowcount = getCountry.Count();
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


                exportService.ToExcel(getCountry.AsQueryable(), "aaa");




            }

        }


        public async Task ExportToCSV()
        {

            exportService.ToCSV(getCountry.AsQueryable(), "aa");
        }

    }
}
