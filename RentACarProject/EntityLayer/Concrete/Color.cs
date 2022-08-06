using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Color:IEntity
     {
        [Key]
        public int colorId { get; set; }
        [StringLength(30)]
        public string colorName { get; set; }

        public ICollection<Car> cars { get; set; }
    }
}
