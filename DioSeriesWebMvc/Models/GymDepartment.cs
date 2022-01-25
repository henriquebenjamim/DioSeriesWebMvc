using System;
using System.Collections.Generic;
using System.Linq;


namespace DioSeriesWebMvc.Models
{
    public class GymDepartment
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Gymming> Gymmings { get; set; } = new List<Gymming>();

        public GymDepartment()
        {
        }

        public GymDepartment(int id, string name)
        {
            Id = id;
            Name = name;

        }

        public void AddGymming(Gymming gymming)
        {
            Gymmings.Add(gymming);
        }

        public double TotalGym(DateTime initial, DateTime final)
        {
            return Gymmings.Sum(gymming => gymming.TotalGym(initial, final));
        }
    }
}
