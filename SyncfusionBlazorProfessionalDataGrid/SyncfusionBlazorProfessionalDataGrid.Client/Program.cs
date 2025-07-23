using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;
using SyncfusionBlazorProfessionalDataGrid.Client.Pages;
using SyncfusionBlazorProfessionalDataGrid.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Syncfusion lisans� (Community license i�in bo� b�rakabilirsiniz)
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1JEaF5cXmRCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdmWXhccHVURWhdWUBwWENWYEk=");

// Syncfusion servisleri
builder.Services.AddSyncfusionBlazor();

// Data Service
builder.Services.AddTransient<DataService>();

// Localization i�in
builder.Services.AddSingleton(typeof(Syncfusion.Blazor.ISyncfusionStringLocalizer), typeof(SyncfusionLocalizer));

var host = builder.Build();
host.Services.GetService<Syncfusion.Blazor.ISyncfusionStringLocalizer>()?.GetText("tr");

await host.RunAsync();

// T�rk�e Localization
public class SyncfusionLocalizer : Syncfusion.Blazor.ISyncfusionStringLocalizer
{
    public string GetText(string key)
    {
        return key switch
        {
            "Grid_Add" => "Ekle",
            "Grid_Edit" => "D�zenle",
            "Grid_Delete" => "Sil",
            "Grid_Update" => "G�ncelle",
            "Grid_Cancel" => "�ptal",
            "Grid_Search" => "Ara",
            "Grid_Print" => "Yazd�r",
            "Grid_ExcelExport" => "Excel'e Aktar",
            "Grid_PdfExport" => "PDF'e Aktar",
            "Grid_CsvExport" => "CSV'ye Aktar",
            "Grid_ColumnChooser" => "S�tun Se�ici",
            "Grid_FilterbarTitle" => "Filtrele",
            "Grid_EmptyRecord" => "G�sterilecek kay�t bulunamad�",
            "Grid_GroupDropArea" => "Gruplamak i�in s�tun ba�l���n� buraya s�r�kleyin",
            "Grid_Item" => "��e",
            "Grid_Items" => "��e",
            "Pager_FirstPage" => "�lk Sayfa",
            "Pager_LastPage" => "Son Sayfa",
            "Pager_PreviousPage" => "�nceki Sayfa",
            "Pager_NextPage" => "Sonraki Sayfa",
            "Pager_of" => "/",
            "Pager_Pages" => "Sayfa",
            "Pager_PageSize" => "Sayfa Boyutu",
            "Grid_SortAscending" => "Artan S�rala",
            "Grid_SortDescending" => "Azalan S�rala",
            "Grid_FilterMenu" => "Filtre",
            "Grid_SelectAll" => "T�m�n� Se�",
            "Grid_Blanks" => "Bo� Olanlar",
            "Grid_FilterTrue" => "Do�ru",
            "Grid_FilterFalse" => "Yanl��",
            "Grid_Clear" => "Temizle",
            "Grid_NumberFilter" => "Say� Filtreleri",
            "Grid_TextFilter" => "Metin Filtreleri",
            "Grid_DateFilter" => "Tarih Filtreleri",
            "Grid_MatchCase" => "B�y�k/K���k Harf Duyarl�",
            "Grid_Equal" => "E�it",
            "Grid_NotEqual" => "E�it De�il",
            "Grid_GreaterThan" => "B�y�k",
            "Grid_GreaterThanOrEqual" => "B�y�k E�it",
            "Grid_LessThan" => "K���k",
            "Grid_LessThanOrEqual" => "K���k E�it",
            "Grid_Between" => "Aras�nda",
            "Grid_Contains" => "��erir",
            "Grid_StartsWith" => "�le Ba�lar",
            "Grid_EndsWith" => "�le Biter",
            "Grid_NotContains" => "��ermez",
            "Grid_AND" => "VE",
            "Grid_OR" => "VEYA",
            "Grid_ShowRowsWhere" => "G�ster",
            _ => key
        };
    }

    public System.Resources.ResourceManager? ResourceManager { get; set; }
}