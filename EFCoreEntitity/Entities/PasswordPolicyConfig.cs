/*****************************************************************************************************************************  
**� 2019 Datamatics Robotics Software Limited, Inc, All Rights Reserved 
* Datamatics Robotics Software Limited Group, Inc. (Encounter Data Manager) Proprietary Product Software *
* Not to be modified by customer *  
* Not Customer maintainable *
** AUTHOR:			Datamatics Robotics Software Limited.   
** CREATED ON:		1/29/2019
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
    [Table("CON_MST_PASSWORD_POLICY_CONFIG")]
    public class PasswordPolicyConfig
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("PASSWORD_MINIMUM_LENGTH")]
        public int PasswordMinimumLength { get; set; }

        [Column("PASSWORD_MAXIMUM_LENGTH")]
        public int PasswordMaximumLength { get; set; }

        [Column("WRONG_PASSWORD_RETRIES")]
        public int WrongPasswordRetries { get; set; }

        [Column("FORGOT_PASSWORD_RETRIES")]
        public int ForgotPasswordRetries { get; set; }

        [Column("TWO_FACTOR_AUTHENTICATION")]
        public bool TwoFactorAuthentication { get; set; }

        [ForeignKey("FK_PASSWORD_POLICY_CONFIG__PASSWORD_COMPLEXITY_RULE")]
        [Column("PASSWORD_COMPLEXITY_RULE")]
        public PasswordComplexityRule ComplexityRule { get; set; }

        [MaxLength(256)]
        [Column("CREATED_BY")]
        public string CreatedBy { get; set; }
        [Column("CREATED_DATE")]
        public DateTime CreatedDate { get; set; }

        [MaxLength(256)]
        [Column("UPDATED_BY")]
        public string UpdatedBy { get; set; }
        [Column("UPDATED_DATE")]
        public DateTime UpdatedDate { get; set; }
    }

    [Table("CON_MST_PASSWORD_COMPLEXITY_RULE")]
    public class PasswordComplexityRule
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("NO_OF_SPECIAL_CHARACTERS_TO_INCLUDE")]
        public int NoOfSpecialCharactersToInclude { get; set; }

        [Column("USE_UPPERCASE_CHARACTERS")]
        public bool UseUpperCaseCharacters { get; set; }

        [Column("USE_LOWER_CASE_CHARACTERS")]
        public bool UseLowerCaseCharacters { get; set; }

        [Column("USE_NUMBERS")]
        public bool UseNumbers { get; set; }

        [Column("BEGIN_WITH_LETTER")]
        public bool BeginWithLetter { get; set; }

        [Column("REUSE_CHARACTER_THRICE_CONSECUTIVELY")]
        public bool ReuseCharacterThriceConsecutively { get; set; }

        [Column("USE_USER_NAME")]
        public bool UseUserName { get; set; }

        [MaxLength(256)]
        [Column("CREATED_BY")]
        public string CreatedBy { get; set; }
        [Column("CREATED_DATE")]
        public DateTime CreatedDate { get; set; }

        [MaxLength(256)]
        [Column("UPDATED_BY")]
        public string UpdatedBy { get; set; }
        [Column("UPDATED_DATE")]
        public DateTime UpdatedDate { get; set; }
    }
}
