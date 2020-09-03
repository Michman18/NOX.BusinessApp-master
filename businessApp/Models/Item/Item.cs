using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace businessApp.Models.Item
{
    public class Item
    {
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemID { get; set; }

        [Column(Order = 1)]
        public int CompanyID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "El código del producto es obligatorio")]
        [StringLength(50, ErrorMessage = "La longitud máxima es 50"), Column(Order = 2)]
        public string ItemCode { get; set; }

        [Required(ErrorMessage = "La descripción del producto es obligatorio"), StringLength(200, ErrorMessage = "La longitud máxima es 200"), Column(Order = 3)]
        public string ItemDescription { get; set; }

        [StringLength(8, ErrorMessage = "La longitud máxima es 8"), Column(Order = 4)]
        public string GroupCode { get; set; }

        [StringLength(8, ErrorMessage = "La longitud máxima es 8"), Column(Order = 5)]
        public string FamilyCode { get; set; }

        [StringLength(8, ErrorMessage = "La longitud máxima es 8"), Column(Order = 6)]
        public string UOMCode { get; set; }

        [Column(Order = 7)]
        public bool? IsInventoryable { get; set; }


        [Column(Order = 8, TypeName = "decimal(30,2)")]
        public decimal SalePrice { get; set; }

        [StringLength(100, ErrorMessage = "La longitud máxima es 100"), Column(Order = 9)]
        public string TaxID { get; set; }


        #region Contabilidad

        [StringLength(20, ErrorMessage = "La longitud máxima es 20"), Column(Order = 10)]
        public string GLTransactionID { get; set; }

        [StringLength(20, ErrorMessage = "La longitud máxima es 20"), Column(Order = 11)]
        public string GLAccountingCode { get; set; }

        #endregion

        #region SysControlFields
        [Column(Order = 12)]
        public bool Inactive { get; set; }
        [Column(Order = 13)]
        public DateTime CreatedAt { get; set; } = new DateTime();
        [Column(Order = 14)]
        public DateTime ModifyDate { get; set; } = new DateTime();
        [Column(Order = 15)]
        public string ModifiedBy { get; set; }
        [Column(Order = 16)]
        public string CreatedBy { get; set; }
        #endregion
    }
}
