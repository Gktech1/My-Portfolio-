using System.Collections.Generic;
using MyProfile.Models;

namespace MyProfile.ViewModel
{
    public class DashboardViewModel
    {
        public ICollection<Project> Projects { get; set; }
        public ICollection<Skill> Skills { get; set; }
        public ICollection<Experience> Experiences { get; set; }
    }
}
