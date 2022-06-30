using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SepetSistemi.Data.Entities
{
    public class SubCategory : BaseModify
    {
        public virtual ICollection<Product> Products { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
