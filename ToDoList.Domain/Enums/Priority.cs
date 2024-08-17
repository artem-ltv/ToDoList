using System.ComponentModel.DataAnnotations;

namespace ToDoList.Domain.Enums
{
    public enum Priority
    {
        [Display(Name = "Простая задача")]
        Easy = 1,
        [Display(Name = "Важная задача")]
        Medium = 2,
        [Display(Name = "Критичная задача")]
        Hard = 3
    }
}
