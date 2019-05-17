/*****************************************************************************************************************************  
**� 2019 Datamatics Robotics Software Limited, Inc, All Rights Reserved 
* Datamatics Robotics Software Limited Group, Inc. (Encounter Data Manager) Proprietary Product Software *
* Not to be modified by customer *  
* Not Customer maintainable *
** AUTHOR:			Datamatics Robotics Software Limited.   
** CREATED ON:		12/20/2018
** CREATED BY:		TruBot
** Description:   
** 
** Revision History:
**
** Date     Author      Description   
*******************************************************************************************************************************/

using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.Entities
{
    public class Role : IdentityRole, IAuditable
    {
        [Column("ROLE_CODE")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? RoleCode { get; set; }

        [Column("VALID_FROM")]
        public DateTime? ValidateFrom { get; set; }

        [Column("VALID_TO")]
        public DateTime? ValidateTo { get; set; }

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

   
    }
}
