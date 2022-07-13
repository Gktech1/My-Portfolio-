using System;

namespace MyProfile.ViewModel
{
    public class LIstOfSkillsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Year { get; set; } = DateTime.Now;
    }
}
