
namespace TaxiRidesLocalization.Models
{
    public class TaxiRide
    {
        public string medallion { get; set; } = string.Empty; // Број на лиценцата
        public string hashLicense { get; set; } = string.Empty; // Хеш од лицето + лиценцата
        public DateTime pickupTime { get; set; } // Време на подигнување
        public DateTime dropOffTime { get; set; } // Време на симнување
        public int duration { get; set; } // Времетраење во секунди
        public double distance { get; set; } // Растојание во милји
        public double pLongitude { get; set; } // Географска должина на појдовната точка
        public double pLatitude { get; set; } // Географска ширина на појдовната точка
        public double dLongitude { get; set; } // Географска должина на дојдовната точка
        public double dLatitude { get; set; } // Географска ширина на дојдовната точка
        public string paymentType { get; set; } = string.Empty; // Тип на плаќање (кеш, картичка, не познато)
        public double fareAmount { get; set; } // Основа цена во USD
        public double surcharge { get; set; } // Доплата во USD
        public double tax { get; set; } // Данок во USD
        public double tipAmount { get; set; } // Бакшиш во USD
        public double tollsAmount { get; set; } // Такси за патишта во USD
        public double totalAmount { get; set; } // Вкупен износ во USD
    }

}

