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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCore.Entities
{
    [Table("IDN_MST_CLAIMS")]
    public class Claim
    {

        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("PRIVILEGE_ID")]
        [ForeignKey("FK_PRIVILEGE_ID")]
        public string Privilegeid { get; set; }
        public virtual Privilege Privilege { get; set; }

        [Column("PRIVILEGETYPE_ID")]
        [ForeignKey("FK_PRIVILEGETYPE_ID")]
        public string PrivilegeTypeid { get; set; }
        public virtual PrivilegeType PrivilegeType { get; set; }

        [MaxLength(100)]
        [Column("NAME")]
        public string Name { get; set; }

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
    }
}
