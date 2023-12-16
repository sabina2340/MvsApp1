using System.ComponentModel.DataAnnotations;

namespace MvcApplication.Models
{
    public class Tgroup
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

        // Навигационное свойство для связи многие ко многим
        public ICollection<TgroupRelation> ParentRelations { get; set; }
        public ICollection<TgroupRelation> ChildRelations { get; set; }
    }
}
