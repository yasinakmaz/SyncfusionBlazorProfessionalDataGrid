using SyncfusionBlazorProfessionalDataGrid.Client.Models;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SyncfusionBlazorProfessionalDataGrid.Client.Services
{
    public class DataService
    {
        private static readonly Random random = new Random();

        private readonly string[] firstNames = { "Ali", "Ayşe", "Mehmet", "Fatma", "Ahmet", "Zeynep", "Mustafa", "Elif", "Ömer", "Merve" };
        private readonly string[] lastNames = { "Yılmaz", "Kaya", "Demir", "Çelik", "Aydın", "Özkan", "Arslan", "Doğan", "Kılıç", "Aslan" };
        private readonly string[] titles = { "Satış Müdürü", "Satış Temsilcisi", "Müşteri Temsilcisi", "Operasyon Uzmanı", "Kıdemli Satış Uzmanı" };
        private readonly string[] departments = { "Satış", "Operasyon", "Müşteri Hizmetleri", "Pazarlama" };

        private readonly string[] companyNames = {
            "Teknoloji A.Ş.", "İnovasyon Ltd.", "Dijital Çözümler", "Akıllı Sistemler",
            "Yazılım Dünyası", "E-Ticaret Merkezi", "Bulut Teknolojileri", "Veri Analitiği A.Ş.",
            "Mobil Uygulamalar Ltd.", "Güvenlik Sistemleri", "Otomasyon Çözümleri", "AI Teknolojileri"
        };

        private readonly string[] contactTitles = { "Satın Alma Müdürü", "IT Müdürü", "Genel Müdür", "Operasyon Müdürü", "Proje Yöneticisi" };

        private readonly string[] cities = { "İstanbul", "Ankara", "İzmir", "Bursa", "Antalya", "Konya", "Adana", "Gaziantep", "Kayseri", "Eskişehir" };
        private readonly string[] countries = { "Türkiye", "Almanya", "Fransa", "İngiltere", "İtalya", "İspanya", "Hollanda", "Belçika" };

        private readonly string[] shipNames = { "Hızlı Kargo", "Express Lojistik", "Güvenli Taşımacılık", "24 Saat Kargo", "Ulusal Kargo" };
        private readonly string[] paymentMethods = { "Kredi Kartı", "Havale/EFT", "Kapıda Ödeme", "Sanal POS", "Mobil Ödeme" };
        private readonly string[] orderStatuses = { "Beklemede", "Onaylandı", "Hazırlanıyor", "Kargoda", "Teslim Edildi", "İptal Edildi", "İade" };

        public List<Employee> GetEmployees()
        {
            var employees = new List<Employee>();
            for (int i = 1; i <= 20; i++)
            {
                employees.Add(new Employee
                {
                    EmployeeID = i,
                    FirstName = firstNames[random.Next(firstNames.Length)],
                    LastName = lastNames[random.Next(lastNames.Length)],
                    Title = titles[random.Next(titles.Length)],
                    Department = departments[random.Next(departments.Length)]
                });
            }
            return employees;
        }

        public List<Customer> GetCustomers()
        {
            var customers = new List<Customer>();
            for (int i = 1; i <= 50; i++)
            {
                customers.Add(new Customer
                {
                    CustomerID = i,
                    CompanyName = companyNames[random.Next(companyNames.Length)] + " " + i,
                    ContactName = firstNames[random.Next(firstNames.Length)] + " " + lastNames[random.Next(lastNames.Length)],
                    ContactTitle = contactTitles[random.Next(contactTitles.Length)],
                    Country = countries[random.Next(countries.Length)],
                    City = cities[random.Next(cities.Length)],
                    Phone = $"+90 {random.Next(500, 599)} {random.Next(100, 999)} {random.Next(10, 99)} {random.Next(10, 99)}"
                });
            }
            return customers;
        }

        public List<Order> GetOrders()
        {
            var orders = new List<Order>();
            var startDate = DateTime.Now.AddYears(-2);

            for (int i = 1; i <= 500; i++)
            {
                var orderDate = startDate.AddDays(random.Next(0, 730));
                var requiredDate = orderDate.AddDays(random.Next(7, 30));
                var shippedDate = orderDate.AddDays(random.Next(1, 5));

                if (random.Next(100) < 10) shippedDate = DateTime.Now; // %10 henüz gönderilmemiş

                var status = orderStatuses[random.Next(orderStatuses.Length)];
                if (shippedDate == null) status = "Hazırlanıyor";

                orders.Add(new Order
                {
                    OrderID = 10000 + i,
                    CustomerID = random.Next(1, 51),
                    EmployeeID = random.Next(1, 21),
                    OrderDate = orderDate,
                    RequiredDate = requiredDate,
                    ShippedDate = shippedDate,
                    Freight = Math.Round((decimal)(random.NextDouble() * 500 + 10), 2),
                    ShipName = shipNames[random.Next(shipNames.Length)],
                    ShipAddress = $"Atatürk Cad. No: {random.Next(1, 200)}",
                    ShipCity = cities[random.Next(cities.Length)],
                    ShipRegion = random.Next(100) < 50 ? "Marmara" : random.Next(100) < 70 ? "İç Anadolu" : "Ege",
                    ShipPostalCode = random.Next(10000, 99999).ToString(),
                    ShipCountry = "Türkiye",
                    OrderStatus = status,
                    TotalAmount = Math.Round((decimal)(random.NextDouble() * 10000 + 100), 2),
                    ProductCount = random.Next(1, 20),
                    PaymentMethod = paymentMethods[random.Next(paymentMethods.Length)],
                    IsActive = random.Next(100) > 5,
                    Notes = random.Next(100) < 20 ? "Özel paketleme isteniyor" : null
                });
            }

            return orders.OrderByDescending(o => o.OrderDate).ToList();
        }

        public List<OrderStatus> GetOrderStatuses()
        {
            return new List<OrderStatus>
            {
                new OrderStatus { Status = "Beklemede", StatusText = "Beklemede" },
                new OrderStatus { Status = "Onaylandı", StatusText = "Onaylandı" },
                new OrderStatus { Status = "Hazırlanıyor", StatusText = "Hazırlanıyor" },
                new OrderStatus { Status = "Kargoda", StatusText = "Kargoda" },
                new OrderStatus { Status = "Teslim Edildi", StatusText = "Teslim Edildi" },
                new OrderStatus { Status = "İptal Edildi", StatusText = "İptal Edildi" },
                new OrderStatus { Status = "İade", StatusText = "İade" }
            };
        }

        public List<Country> GetCountries()
        {
            return new List<Country>
            {
                new Country { CountryCode = "TR", CountryName = "Türkiye" },
                new Country { CountryCode = "DE", CountryName = "Almanya" },
                new Country { CountryCode = "FR", CountryName = "Fransa" },
                new Country { CountryCode = "GB", CountryName = "İngiltere" },
                new Country { CountryCode = "IT", CountryName = "İtalya" },
                new Country { CountryCode = "ES", CountryName = "İspanya" },
                new Country { CountryCode = "NL", CountryName = "Hollanda" },
                new Country { CountryCode = "BE", CountryName = "Belçika" }
            };
        }
    }
}
