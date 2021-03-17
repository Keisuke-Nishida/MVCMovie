using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
    
        [StringLength(256)]
        [DisplayName("ユーザー名")]
        public string UseName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("パスワード")]
        public string Paaword { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
