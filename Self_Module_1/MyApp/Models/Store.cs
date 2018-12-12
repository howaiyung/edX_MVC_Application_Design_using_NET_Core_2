using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApp.Models
{
    [Table("store")]
    public partial class Store
    {
        public Store()
        {
            Customer = new HashSet<Customer>();
            Inventory = new HashSet<Inventory>();
            Staff = new HashSet<Staff>();
        }

        [Column("store_id")]
        public byte StoreId { get; set; }
        [Column("manager_staff_id")]
        public byte ManagerStaffId { get; set; }
        [Column("address_id")]
        public ushort AddressId { get; set; }
        [Column("last_update", TypeName = "timestamp")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey("AddressId")]
        [InverseProperty("Store")]
        public Address Address { get; set; }
        [ForeignKey("ManagerStaffId")]
        [InverseProperty("StoreNavigation")]
        public Staff ManagerStaff { get; set; }
        [InverseProperty("Store")]
        public ICollection<Customer> Customer { get; set; }
        [InverseProperty("Store")]
        public ICollection<Inventory> Inventory { get; set; }
        [InverseProperty("Store")]
        public ICollection<Staff> Staff { get; set; }
    }
}
