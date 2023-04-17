using System.ComponentModel.DataAnnotations;

namespace FQ23L056_FakeApi.DTOs
{
#nullable disable
    public class UpdateTaskDto
    {
#nullable disable
        [Required]
        [StringLength(128, MinimumLength = 1)]
        public string Title { get; set; }

        [Required]
        public bool Done { get; set; }
    }
}
