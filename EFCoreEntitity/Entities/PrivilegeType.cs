/*****************************************************************************************************************************  
**� 2019 Datamatics Robotics Software Limited, Inc, All Rights Reserved 
* Datamatics Robotics Software Limited Group, Inc. (Encounter Data Manager) Proprietary Product Software *
* Not to be modified by customer *  
* Not Customer maintainable *
** AUTHOR:			Datamatics Robotics Software Limited.   
** CREATED ON:		12/3/2018
** CREATED BY:		TruBot
** Description:   
** 
** Revision History:
**
** Date     Author      Description   
*******************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.Entities
{
    [Table("IDN_MST_PRIVILEGE_TYPE")]
    public class PrivilegeType : IAuditable
    {
        [Column("ID")]
        [Key]
        public string Id { get; set; }

        [MaxLength(100)]
        [Column("NAME")]
        public string Name { get; set; }

        public ICollection<RolePrivilegeType> RolePrivilegeType { get; set; }

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
