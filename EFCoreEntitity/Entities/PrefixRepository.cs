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
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.Entities
{
    public class PrefixRepository
    {
        [Column("ID")]
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        [Column("MENU_NAME")]
        public string MenuName { get; set; }

        [MaxLength(100)]
        [Column("PREFIX")]
        public string Prefix { get; set; }

    }
}
