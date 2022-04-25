using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WRITER_CODE { get; set; }
        [StringLength(100)]
        public string WRITER_NAME { get; set; }
        [StringLength(100)]
        public string WRITER_SURNAME { get; set; }
        [StringLength(100)]
        public string WRITER_IMAGE { get; set; }
        [StringLength(100)]
        public string WRITER_ABOUT{ get; set; }
        [StringLength(100)]
        public string WRITER_PASSWORD { get; set; }
        [StringLength(100)]
        public string WRITER_MAIL { get; set; }
        [StringLength(100)]
        public string WRITER_TITLE { get; set; }
    }
}
