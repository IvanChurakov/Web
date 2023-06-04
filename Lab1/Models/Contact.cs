using System.ComponentModel.DataAnnotations;

namespace Lab1.Models
{
    public class Contact
    {
        [Display(Name = "Ваше ім'я")]
        //[Required(ErrorMessage = "А як же ваше ім'я")]
        public string Name { get; }

        [Display(Name = "Ваше прізвище")]
        //[Required(ErrorMessage = "А як же ваше прізвище")]
        public string Surname { get; }

        [Display(Name = "Ваша пошта")]
        //[Required(ErrorMessage = "А як же ваша пошта")]
        [EmailAddress]
        public string Email { get; }

        [Display(Name = "Ваш телефон")]
        //[Required(ErrorMessage = "А як же ваш телефон")]
        public string Phone { get; }

        [Display(Name = "Ваше повідомлення")]
        //[Required(ErrorMessage = "А як же ваше повідомлення")]
        public string Message { get; }
    }
}
