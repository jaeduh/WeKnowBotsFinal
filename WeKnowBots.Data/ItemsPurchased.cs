using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeKnowBots.Data
{ 
    public enum ItemType { Sneaker = 1, Clothing, Collectible }
    public class ItemsPurchased
    {
        [Key]
        public int ItemId { get; set; }

        [Required]
        public ItemType TypeOfItem { get; set; }

        [Required]
        public string ItemDescription { get; set; }
    }
}
