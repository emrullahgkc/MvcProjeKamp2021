using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
public    class Contact
    {
        [Key]
        public int ContactID { get; set; }
        [StringLength(50)]

        public string  UserName { get; set; }
        [StringLength(50)]

        public string  UserMail { get; set; }
        [StringLength(50)]

        public string  Subject { get; set; }
        public string  Message { get; set; }
        public int HeadingID { get; set; }//ilişki yi aldıgı yerin ismi
        public virtual Heading Heading { get; set; }//ilişkiyi  alan
  
    }
}
