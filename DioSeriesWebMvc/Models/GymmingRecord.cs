using DioSeriesWebMvc.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DioSeriesWebMvc.Models
{
    public class GymmingRecord
    {   
        // SalesRecord
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public GymCategories Status { get; set; }
        public Gymming Gymming { get; set; }

        public GymmingRecord()
        {
        }

        public GymmingRecord(int id, DateTime date, double amount, GymCategories status, Gymming gymming)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Gymming = gymming;
        }
    }
}
