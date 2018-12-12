using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mod2P1_MyApp.Models
{
    [Table("rental")]
    public partial class Rental
    {
        public Rental()
        {
            Payment = new HashSet<Payment>();
        }

        [Column("rental_id", TypeName = "int(11)")]
        public int RentalId { get; set; }
        [Column("rental_date", TypeName = "datetime")]
        public DateTime RentalDate { get; set; }
        [Column("inventory_id", TypeName = "mediumint unsigned")]
        public uint InventoryId { get; set; }
        [Column("customer_id")]
        public ushort CustomerId { get; set; }
        [Column("return_date", TypeName = "datetime")]
        public DateTime? ReturnDate { get; set; }
        [Column("staff_id")]
        public byte StaffId { get; set; }
        [Column("last_update", TypeName = "timestamp")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey("CustomerId")]
        [InverseProperty("Rental")]
        public Customer Customer { get; set; }
        [ForeignKey("InventoryId")]
        [InverseProperty("Rental")]
        public Inventory Inventory { get; set; }
        [ForeignKey("StaffId")]
        [InverseProperty("Rental")]
        public Staff Staff { get; set; }
        [InverseProperty("Rental")]
        public ICollection<Payment> Payment { get; set; }
    }
}
