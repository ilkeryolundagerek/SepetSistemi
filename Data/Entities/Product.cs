using System.ComponentModel.DataAnnotations.Schema;

namespace SepetSistemi.Data.Entities
{
    public class Product : BaseModify
    {
        public string Picture { get; set; }
        public decimal Price { get; set; }
        public bool Campaign { get; set; }
        public int CampaignRatio { get; set; }
        public int TaxRatio { get; set; }

        [ForeignKey("SubCategory")]
        public int SubCategoryId { get; set; }
        public virtual SubCategory SubCategory { get; set; }

        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
    }
}
