using ToDoList.Domain.Interfaces;

namespace ToDoList.Domain.Entities
{
    public abstract class Entity : IEnity
    {
        public int Id { get; set; }
    }
}
