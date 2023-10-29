using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImageUploadingWeb.ViewModel
{
    public class PersonViewModel
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public IFormFile? Image { get; set; }
    }
}
