using System.ComponentModel.DataAnnotations;

namespace FQ23L056_FakeApi.DTOs
{
    public class CreateTaskDto
    {
#nullable disable
        [Required]
        [StringLength(128, MinimumLength = 1)]
        public string Title { get; set; }
    }
}
