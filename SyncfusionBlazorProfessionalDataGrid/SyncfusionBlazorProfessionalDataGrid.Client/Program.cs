using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;
using SyncfusionBlazorProfessionalDataGrid.Client.Pages;
using SyncfusionBlazorProfessionalDataGrid.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Syncfusion lisansý (Community license için boþ býrakabilirsiniz)
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1JEaF5cXmRCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdmWXhccHVURWhdWUBwWENWYEk=");

// Syncfusion servisleri
builder.Services.AddSyncfusionBlazor();

// Data Service
builder.Services.AddTransient<DataService>();

// Localization için
builder.Services.AddSingleton(typeof(Syncfusion.Blazor.ISyncfusionStringLocalizer), typeof(SyncfusionLocalizer));

var host = builder.Build();
host.Services.GetService<Syncfusion.Blazor.ISyncfusionStringLocalizer>()?.GetText("tr");

await host.RunAsync();

// Türkçe Localization
public class SyncfusionLocalizer : Syncfusion.Blazor.ISyncfusionStringLocalizer
{
    public string GetText(string key)
    {
        return key switch
        {
            "Grid_Add" => "Ekle",
            "Grid_Edit" => "Düzenle",
            "Grid_Delete" => "Sil",
            "Grid_Update" => "Güncelle",
            "Grid_Cancel" => "Ýptal",
            "Grid_Search" => "Ara",
            "Grid_Print" => "Yazdýr",
            "Grid_ExcelExport" => "Excel'e Aktar",
            "Grid_PdfExport" => "PDF'e Aktar",
            "Grid_CsvExport" => "CSV'ye Aktar",
            "Grid_ColumnChooser" => "Sütun Seçici",
            "Grid_FilterbarTitle" => "Filtrele",
            "Grid_EmptyRecord" => "Gösterilecek kayýt bulunamadý",
            "Grid_GroupDropArea" => "Gruplamak için sütun baþlýðýný buraya sürükleyin",
            "Grid_Item" => "öðe",
            "Grid_Items" => "öðe",
            "Pager_FirstPage" => "Ýlk Sayfa",
            "Pager_LastPage" => "Son Sayfa",
            "Pager_PreviousPage" => "Önceki Sayfa",
            "Pager_NextPage" => "Sonraki Sayfa",
            "Pager_of" => "/",
            "Pager_Pages" => "Sayfa",
            "Pager_PageSize" => "Sayfa Boyutu",
            "Grid_SortAscending" => "Artan Sýrala",
            "Grid_SortDescending" => "Azalan Sýrala",
            "Grid_FilterMenu" => "Filtre",
            "Grid_SelectAll" => "Tümünü Seç",
            "Grid_Blanks" => "Boþ Olanlar",
            "Grid_FilterTrue" => "Doðru",
            "Grid_FilterFalse" => "Yanlýþ",
            "Grid_Clear" => "Temizle",
            "Grid_NumberFilter" => "Sayý Filtreleri",
            "Grid_TextFilter" => "Metin Filtreleri",
            "Grid_DateFilter" => "Tarih Filtreleri",
            "Grid_MatchCase" => "Büyük/Küçük Harf Duyarlý",
            "Grid_Equal" => "Eþit",
            "Grid_NotEqual" => "Eþit Deðil",
            "Grid_GreaterThan" => "Büyük",
            "Grid_GreaterThanOrEqual" => "Büyük Eþit",
            "Grid_LessThan" => "Küçük",
            "Grid_LessThanOrEqual" => "Küçük Eþit",
            "Grid_Between" => "Arasýnda",
            "Grid_Contains" => "Ýçerir",
            "Grid_StartsWith" => "Ýle Baþlar",
            "Grid_EndsWith" => "Ýle Biter",
            "Grid_NotContains" => "Ýçermez",
            "Grid_AND" => "VE",
            "Grid_OR" => "VEYA",
            "Grid_ShowRowsWhere" => "Göster",
            _ => key
        };
    }

    public System.Resources.ResourceManager? ResourceManager { get; set; }
}