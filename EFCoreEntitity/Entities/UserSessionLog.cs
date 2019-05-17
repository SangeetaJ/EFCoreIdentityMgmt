/*****************************************************************************************************************************  
**� 2019 Datamatics Robotics Software Limited, Inc, All Rights Reserved 
* Datamatics Robotics Software Limited Group, Inc. (Encounter Data Manager) Proprietary Product Software *
* Not to be modified by customer *  
* Not Customer maintainable *
** AUTHOR:			Datamatics Robotics Software Limited.   
** CREATED ON:		11/29/2018
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
    [Table("USER_SESSION_LOG")]
    public class UserSessionLog
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("USER_ID")]
        public string UserId { get; set; }
        [Column("USER_TOKEN")]
        public string UserToken { get; set; }
        [Column("LOGIN_TIME")]
        public DateTime LoginDate { get; set; }
        [Column("LOGOUT_TIME")]
        public DateTime LogoutDate { get; set; }
        [Column("IP_ADDRESS")]
        public string IpAddress { get; set; }
        [Column("BROWSER_NAME")]
        public string BrowserName { get; set; }
        [Column("BROWSER_VERSION")]
        public string BrowserVersion { get; set; }
        [Column("OPERATING_SYSTEM")]
        public string OperatingSystem { get; set; }
    }
}
