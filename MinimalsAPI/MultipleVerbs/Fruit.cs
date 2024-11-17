using System.ComponentModel.DataAnnotations;

namespace MultipleVerbs
{
    public record Fruit
    {
        [Required]
        [StringLength(100)]
        [Display(Name = "Fruit name")]
        public string? Name { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int Store { get; set; }

        public static readonly Dictionary<string, Fruit> All = [];
    };
}