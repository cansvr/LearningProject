using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class UserRoles
    {
        [Key]
        public int ROLE_CODE { get; set; }

        [StringLength(100)]
        public string ROLE_NAME { get; set; }

        public ICollection<User> Users { get; set; }

    }
}
