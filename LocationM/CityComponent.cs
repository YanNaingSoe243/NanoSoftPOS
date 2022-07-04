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
using NanoSoftGreenMark.LocationM;

namespace NanoSoftGreenMark.LocationM
{
    public partial class CityComponent:ComponentBase
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
        private IEnumerable<City> _getResult { get; set; }
        protected IEnumerable<City> getResult
        {
            get { return _getResult; }

            set
            {
                if (!object.Equals(_getResult, value))
                {
                    _getResult = value;

                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        protected DeleteConfirm DeleteConfirmation { get; set; }
        protected AddCity addComponent { get; set; }
        protected int ID;

        protected async System.Threading.Tasks.Task Load()
        {




            var HRDResult1 = await Service.Citys.GetAsync(PageIndex, PageSize);
            getResult = HRDResult1;
            PageCount = await Service.Citys.TotalPage(PageSize);

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
        public async System.Threading.Tasks.Task AddData(City data)
        {
            try
            {
                if (data != null)
                {
                    await Service.Citys.UpInsertAsync(data);
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
                var Result = await Service.Citys.DeleteAsync(ID);
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
                PageCount = await Service.Citys.TotalPage(PageSize);
              
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
            var HRDResult = await Service.Citys.GetAsync(searchTerm);
            getResult = HRDResult;
            int Rowcount = getResult.Count();
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


                exportService.ToExcel(getResult.AsQueryable(), "aaa");




            }

        }


        public async Task ExportToCSV()
        {
            if (await JSRuntime.InvokeAsync<bool>("confirm", $"Do you want to Export?"))
            {

                exportService.ToCSV(getResult.AsQueryable(), "aa");
            }
        }

    }
}

