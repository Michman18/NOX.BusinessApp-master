using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace businessApp.Models.Item
{
    public class ItemConfig
    {
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int itemConfigID { get; set; }

        [Column(Order = 1)]
        public int CompanyID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "El código del producto es obligatorio")]
        [StringLength(50, ErrorMessage = "La longitud máxima es 50"), Column(Order = 2)]
        public string ItemCode { get; set; }

        [StringLength(200, ErrorMessage = "La longitud máxima es 200"), Column(Order = 3)]
        public string Description { get; set; }

        [Column(Order = 4)]
        public byte[] picture { get; set; }

        [StringLength(500, ErrorMessage = "La longitud máxima es 500"), Column(Order = 5)]
        public string character { get; set; }

        [StringLength(100, ErrorMessage = "La longitud máxima es 100"), Column(Order = 6)]
        public string barCode { get; set; }



        #region SysControlFields
        [Column(Order = 7)]
        public bool Inactive { get; set; }
        [Column(Order = 8)]
        public DateTime CreatedAt { get; set; } = new DateTime();
        [Column(Order = 9)]
        public DateTime ModifyDate { get; set; } = new DateTime();
        [Column(Order = 10)]
        public string ModifiedBy { get; set; }
        [Column(Order = 11)]
        public string CreatedBy { get; set; }
        #endregion

    }
}
