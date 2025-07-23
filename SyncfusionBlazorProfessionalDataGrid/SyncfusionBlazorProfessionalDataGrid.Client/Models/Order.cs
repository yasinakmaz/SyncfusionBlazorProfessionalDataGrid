using System.ComponentModel.DataAnnotations;
namespace SyncfusionBlazorProfessionalDataGrid.Client.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [Required(ErrorMessage = "Müşteri seçimi zorunludur")]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Çalışan seçimi zorunludur")]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "Sipariş tarihi zorunludur")]
        public DateTime OrderDate { get; set; }

        public DateTime? RequiredDate { get; set; }

        public DateTime? ShippedDate { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Kargo ücreti 0'dan büyük olmalıdır")]
        public decimal Freight { get; set; }

        [Required(ErrorMessage = "Kargo firması zorunludur")]
        [StringLength(40, ErrorMessage = "Kargo firması adı en fazla 40 karakter olabilir")]
        public string ShipName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Adres zorunludur")]
        [StringLength(60, ErrorMessage = "Adres en fazla 60 karakter olabilir")]
        public string ShipAddress { get; set; } = string.Empty;

        [Required(ErrorMessage = "Şehir zorunludur")]
        [StringLength(15, ErrorMessage = "Şehir adı en fazla 15 karakter olabilir")]
        public string ShipCity { get; set; } = string.Empty;

        [StringLength(15, ErrorMessage = "Bölge en fazla 15 karakter olabilir")]
        public string? ShipRegion { get; set; }

        [StringLength(10, ErrorMessage = "Posta kodu en fazla 10 karakter olabilir")]
        public string? ShipPostalCode { get; set; }

        [Required(ErrorMessage = "Ülke zorunludur")]
        public string ShipCountry { get; set; } = string.Empty;

        public string OrderStatus { get; set; } = "Beklemede";

        [Range(0, double.MaxValue, ErrorMessage = "Toplam tutar 0'dan büyük olmalıdır")]
        public decimal TotalAmount { get; set; }

        public int ProductCount { get; set; }

        public string? PaymentMethod { get; set; }

        public bool IsActive { get; set; } = true;

        public string? Notes { get; set; }
    }
}
