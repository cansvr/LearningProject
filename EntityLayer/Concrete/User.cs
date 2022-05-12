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
        public string USER_IMAGE { get; set; }
        [StringLength(2000)]
        public string USER_ABOUT { get; set; }
        [StringLength(100)]
        public string USER_PASSWORD { get; set; }
        [StringLength(100)]
        public string USER_MAIL { get; set; }
        [StringLength(100)]
        public string USER_TITLE { get; set; }

        public int? ROLE_CODE { get; set; }
        public virtual UserRoles UserRoles { get; set; }

    }
}
