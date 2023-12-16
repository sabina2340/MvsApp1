using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication.Models
{
    public class TgroupRelation
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("ParentGroup")]
        public int ParentGroupId { get; set; }

        [Key]
        [Column(Order = 1)]
        [ForeignKey("ChildGroup")]
        public int ChildGroupId { get; set; }

        public Tgroup ParentGroup { get; set; }
        public Tgroup ChildGroup { get; set; }
    }
}
