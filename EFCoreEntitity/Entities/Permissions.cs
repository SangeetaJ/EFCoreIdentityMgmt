/*****************************************************************************************************************************  
**� 2019 Datamatics Robotics Software Limited, Inc, All Rights Reserved 
* Datamatics Robotics Software Limited Group, Inc. (Encounter Data Manager) Proprietary Product Software *
* Not to be modified by customer *  
* Not Customer maintainable *
** AUTHOR:			Datamatics Robotics Software Limited.   
** CREATED ON:		12/27/2018
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
    [Table("IDN_TRN_CLAIMS")]
    public class Permission
    {

        [Key]
        [Column("ID")]
        public int Id { get; set; }

        //[Column("Role_Id")]
        //[ForeignKey("FK_Role_Role_ID")]
        //public string Role_Id { get; set; }

    
        [Column("ROLE_ID")]
        public string RoleId { get; set; }        

        [Column("CLAIMS_ID")]
        [ForeignKey("FK_CLAIMS_ID")]
        public int ClaimsId { get; set; }
        public virtual Claim Claims { get; set; }

        [Column("CREATEDBY")]
        public string CreatedBy { get; set; }

        [Column("CREATEDDATE")]
        public DateTime CreatedDate { get; set; }

        [Column("UPDATEDBY")]
        public string UpdatedBy { get; set; }


        [Column("UPDATEDDATE")]
        public DateTime UpdatedDate { get; set; }

        [Column("VERSIONNO")]
        public string VersionNo { get; set; }
    }
}
