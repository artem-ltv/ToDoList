using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Обязательное поле")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        public string Password { get; set; }
    }
}
