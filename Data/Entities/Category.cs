using System.Collections.Generic;

namespace SepetSistemi.Data.Entities
{
    public class Category : BaseModify
    {
        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}
