using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using UserRegistrationWebApp.Attributes;

namespace UserRegistrationWebApp.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter User Name")]
        [StringLength(100, MinimumLength = 3)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please Enter Email")]
        [EmailAddress(ErrorMessage = "Please Enter Correct Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password)]
       // [RegularExpression("^(?=.{8,})(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+*!=]).*$")]
        //[StringLength(100, ErrorMessage = "The {0} must be at least {8} characters long.", MinimumLength = 8)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter Confirm Password")]
        //[RegularExpression("^(?=.{8,})(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+*!=]).*$")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Confirm Password doesn't match")]
        public string ConfirmPassword { get; set; }

        [RegularExpression("^[6789]\\d{9}$", ErrorMessage = "Please Enter Correct Mobile")]
        public string Contact { get; set; }

        [Required(ErrorMessage ="Please Select Gender")]
        [Display(Name = "Gender")]
        public char Gender { get; set; }

        [Display(Name = "Accept Terms")]
        [ValidateCheckBox(ErrorMessage = "Please Accept Terms")]
        public bool IsTerms { get; set; }
    }
}
