using System.ComponentModel.DataAnnotations;

namespace zad1_1
{
	public class User
	{
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }
    }
}