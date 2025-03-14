using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }



        // Add other properties as needed (e.g., FirstName, LastName, etc.)
    }
}