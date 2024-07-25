using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
    public class Authors
    {
        [Key]
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }

        public virtual ICollection<Books> Book { get; set; }
    }
}
