/*****************************************************************************************************************************  
**� 2019 Datamatics Robotics Software Limited, Inc, All Rights Reserved 
* Datamatics Robotics Software Limited Group, Inc. (Encounter Data Manager) Proprietary Product Software *
* Not to be modified by customer *  
* Not Customer maintainable *
** AUTHOR:			Datamatics Robotics Software Limited.   
** CREATED ON:		2/13/2019
** CREATED BY:		TruBot
** Description:   
** 
** Revision History:
**
** Date     Author      Description   
*******************************************************************************************************************************/


using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.Entities
{
    [Table("IDN_TRN_ROLEDETAILS")]
    public class RoleDetail : IAuditable
    {
        [Column("ROLE_CODE")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? RoleCode { get; set; }

        [Column("ID")]
        public string Id { get; set; }

        [Column("ROLE_ID")]
        public string Role_Id { get; set; }

        [MaxLength(1000)]
        [Column("DESCRIPTION")]
        public string Description { get; set; }

        [Column("CREATED_BY")]
        [MaxLength(256)]
        public string CreatedBy { get; set; }

        [Column("CREATED_DATE")]
        public DateTime CreatedDate { get; set; }

        [Column("UPDATED_BY")]
        [MaxLength(256)]
        public string UpdatedBy { get; set; }

        [Column("UPDATED_DATE")]
        public DateTime UpdatedDate { get; set; }

        [Column("VERSION_NUMBER")]
        [MaxLength(11)]
        public string VersionNumber { get; set; }
        [Column("VALID_FROM")]
        public DateTime? ValidateFrom { get; set; }

        [Column("VALID_TO")]
        public DateTime? ValidateTo { get; set; }

        [Column("Status")]
        [Required]
        public bool Status { get; set; }

        [ForeignKey("ROLE_TYPE_ID")]
        public int ROLE_TYPEID { get; set; }
        public virtual RoleType RolesTypeId { get; set; }

    }
}
