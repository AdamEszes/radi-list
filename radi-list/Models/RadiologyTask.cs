using System.ComponentModel.DataAnnotations;

namespace radi_list.Models
{
    public class RadiologyTask
    {
        public int Id { get; set; }

        [Display(Name = "Title")]
        public string? Title { get; set; }

        [Display(Name = "Completed")]
        public bool IsCompleted { get; set; }
    }
}
