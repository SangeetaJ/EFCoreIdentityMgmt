/*****************************************************************************************************************************  
**� 2019 Datamatics Robotics Software Limited, Inc, All Rights Reserved 
* Datamatics Robotics Software Limited Group, Inc. (Encounter Data Manager) Proprietary Product Software *
* Not to be modified by customer *  
* Not Customer maintainable *
** AUTHOR:			Datamatics Robotics Software Limited.   
** CREATED ON:		1/16/2019
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
    [Table("CON_TRN_USER_ACTIVITY_LOG")]
    public class UserActivityLog
    {
        [Column("ID")]
        [Key]
        public int Id { get; set; }

        [Column("USERCODE")]
        [Required]
        public int UserCode { get; set; }

        [Column("LEVEL")]
        [MaxLength(30)]
        [Required]
        public string Level { get; set; }

        //[Column("NAMESPACE")]
        //[MaxLength(100)]
        //[Required]
        //public string NameSpace { get; set; }

        //[Column("CLASSNAME")]
        //[MaxLength(100)]
        //[Required]
        //public string ClassName { get; set; }

        //[Column("METHODNAME")]
        //[MaxLength(50)]
        //[Required]
        //public string MethodName { get; set; }

        [Column("TIMESTAMP")]
        [Required]
        public DateTime TimeStamp { get; set; }

        [Column("MESSAGE")]
        [MaxLength()]
        [Required]
        public string Message { get; set; }

        [Column("INNEREXCEPTION")]
        [MaxLength()]
        public string InnerException { get; set; }

        [Column("ERRORCODE")]
        [MaxLength(100)]
        public string ErrorCode { get; set; }

        [Column("STACKTRACE")]
        [MaxLength()]
        public string StackTrace { get; set; }

        //public int StatusCode { get; set; }
        //public string Message { get; set; }

        [Column("MACHINENAME")]
        [MaxLength(500)]
        [Required]
        public string MachineName { get; set; }


        [Column("FULLPATH")]
        [MaxLength(3000)]
        [Required]
        public string FullPath { get; set; }


        [Column("EXCEPTIONTYPE")]
        [MaxLength(3000)]
        public string ExceptionType { get; set; }
    }
}
