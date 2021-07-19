using System;
using Zoo.Models.Enums;

namespace Zoo.Models.ApiModels
{
    public class AnimalApiModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfArrival { get; set; }
        public Classification Classification { get; set; }
        public Sex Sex { get; set; }
        public string Species { get; set; }
    }
}
