using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public  class Content
    {
        [Key]
        public int ConcentID { get; set; }
        [StringLength(1000)]
        public string ContentValue { get; set; }
       
        public DateTime ContentDate { get; set; }

        public bool ContentStatus{ get; set; }

        public int HeadingID { get; set; } // prımary key
        public virtual Heading Heading { get; set; } //Heading ile ilişki yaratıyor

        public int? WriterID { get; set; } //null enable oldu
        public virtual Writer Writer { get; set; }
    }
}
