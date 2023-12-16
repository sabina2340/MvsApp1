using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace MvcApplication.Models
{
    public class TRELATION
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ParentGroup")]
        public int ParentGroupId { get; set; }

        [ForeignKey("ChildGroup")]
        public int ChildGroupId { get; set; }

        // Навигационные свойства для связи многие ко многим
        public Tgroup ParentGroup { get; set; }
        public Tgroup ChildGroup { get; set; }

    }
}
