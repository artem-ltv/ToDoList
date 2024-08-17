using ToDoList.Domain.Enums;

namespace ToDoList.Domain.Entities
{
    public class TaskEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
