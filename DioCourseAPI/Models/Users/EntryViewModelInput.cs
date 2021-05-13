using System.ComponentModel.DataAnnotations;

namespace DioCourseAPI.Models.Users
{
    public class EntryViewModelInput
    {
        [Required(ErrorMessage = "This field is mandatory")]
        public string Login { get; set; }
        [Required(ErrorMessage = "This field is mandatory")]
        public string Email { get; set; }
        [Required(ErrorMessage = "This field is mandatory")]
        public string Password { get; set; }
    }
}