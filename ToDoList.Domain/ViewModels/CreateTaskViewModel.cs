using ToDoList.Domain.Enums;

namespace ToDoList.Domain.ViewModels
{
    public class CreateTaskViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; }
    }
}
