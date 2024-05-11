using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Данное поле обязательное")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Данное поле обязательное")]
        public string Password { get; set; }

        [Required(ErrorMessage = "данное поле обязательное")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string RepeatPassword { get; set; }
    }
}
