using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        [Key]
        public int USER_CODE { get; set; }
        [StringLength(100)]
        public string USER_NAME { get; set; }
        [StringLength(100)]
        public string USER_SURNAME { get; set; }
        [StringLength(100)]
        public string USER_MAIL { get; set; }
    }
}
