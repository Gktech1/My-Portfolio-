using System;
using System.Collections.Generic;
using MyProfile.Models;

namespace MyProfile.ViewModel
{
    public class ListOfProjectViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProjectLink { get; set; }
        public DateTime Year { get; set; } = DateTime.Now;
    }
}
