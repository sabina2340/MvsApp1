using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace MvcApplication.Models
{
    public class TRELATION
    {
        public int Id { get; set; }

        public long ParentGroupId { get; set; }
        public TGROUP ParentGroup { get; set; }

        public long ChildGroupId { get; set; }
        public TGROUP ChildGroup { get; set; }
    }
}
