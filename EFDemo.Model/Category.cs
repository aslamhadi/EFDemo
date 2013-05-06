using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFDemo.Model
{
    public class Category
    {
        [Key]
        public int ID { get; set; }

        public virtual string Name { get; set; }

        public virtual string Title { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
