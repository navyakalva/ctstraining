using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMvc.Models
{
    public class Item
    {
        [Key]
        public int Iid { get; set; }
        public double Price { get; set; }
        public string Itemname { get; set; }
        public string Description { get; set; }
        public int Stock_number { get; set; }
        public string Remarks { get; set; }



        public Item(int Iid, double Price, string Itemname, string Description, int Stock_number, string Remarks)
        {
            this.Iid = Iid;
            this.Price = Price;
            this.Itemname = Itemname;
            this.Description = Description;
            this.Stock_number = Stock_number;
            this.Remarks = Remarks;
        }

    }

}

