using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Heading
    {
     [Key]   
        public int HeadingID { get; set; }
        [StringLength(50)]

        public string HeadingName { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CategoryID { get; set; }//ilişki alan 1e çokta çok olan

        public virtual Category Category{ get; set; }//ilişki alan 1e çokta çok olan       
        public int WriterId { get; set; }//ilişki alan 1e çokta çok olan
        public virtual Writer Writer{ get; set; }//ilişki alan 1e çokta çok olan
        public ICollection <Content>Contents { get; set; }//ilişki veren 1e çokta 1 olan
    }
}
