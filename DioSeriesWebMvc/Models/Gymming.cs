﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DioSeriesWebMvc.Models
{
    public class Gymming
    {   
        //seller
        // Gym = gym training
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public int Categorie { get; set; }
        public GymDepartment GymDepartment { get; set; }
        public ICollection<GymmingRecord> Gym { get; set; } = new List<GymmingRecord>();
        // 
        
        public Gymming()
        {
        }

        public Gymming(int id, string name, string email, DateTime birthDate, int categorie, GymDepartment gymDepartment)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            Categorie = categorie;
            GymDepartment = gymDepartment;
        }
        //adicionando e removendo os treinos
        public void AddGym(GymmingRecord gr)
        {
            Gym.Add(gr);
        }
        public void RemoveGym(GymmingRecord gr)
        {
            Gym.Remove(gr);
        }
        public double TotalGym(DateTime initial, DateTime final)
        {
            // filtrando valores entre as extremidades dadas como referencia.
            return Gym.Where(gr => gr.Date >= initial && gr.Date <= final).Sum(gr => gr.Amount);
        }
    }
}
