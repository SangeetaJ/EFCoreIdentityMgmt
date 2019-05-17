/*****************************************************************************************************************************  
**� 2019 Datamatics Robotics Software Limited, Inc, All Rights Reserved 
* Datamatics Robotics Software Limited Group, Inc. (Encounter Data Manager) Proprietary Product Software *
* Not to be modified by customer *  
* Not Customer maintainable *
** AUTHOR:			Datamatics Robotics Software Limited.   
** CREATED ON:		2/1/2019
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
    [Table("CON_MST_IDENTITY_PROVIDER_CONFIG")]
    public class IdentityProviderConfig
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("IDENTITY_TYPE")]
        public int IdentityType { get; set; }
        [Column("SSO_TYPE")]
        public int SSOType { get; set; }
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


    [Table("CON_MST_ACTIVE_DIRECTORY_CONFIG")]
    public class ActiveDirectoryConfig
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("LDAP_URL")]
        
        public string LDAPURL { get; set; }

        [Column("SERVICE_ACCOUNT_USER")]
        
        public string ServiceAccountUser { get; set; }

        [Column("SERVICE_ACCOUNT_PASSWORD")]
      
        public string ServiceAccountPassword { get; set; }

        [Column("ACCESS_LEVEL")]
       
        public string AccessLevel { get; set; }

       
        [Column("CREATED_BY")]
        public string CreatedBy { get; set; }
        [Column("CREATED_DATE")]
        public DateTime CreatedDate { get; set; }
 
        [Column("UPDATED_BY")]
        public string UpdatedBy { get; set; }
        [Column("UPDATED_DATE")]
        public DateTime UpdatedDate { get; set; }
    }

    [Table("CON_MST_NTLM_CONFIG")]
    public class NtlmConfig
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("DOMAIN_NAME")]
       
        public string DomainName { get; set; }

        [Column("DOMAIN_NAME_SYSTEM_SERVER")]
        
        public string DomainNameSystemServer{ get; set; }

        [Column("DOMAIN_NAME_SYSTEM_SITE")]
        
        public string DomainNameSystemSite { get; set; }

        [Column("COMPUTER_NAME")]
        
        public string ComputerName { get; set; }

        [Column("PASSWORD")]
         
        public string Password { get; set; }

        
        [Column("CREATED_BY")]
        public string CreatedBy { get; set; }
        [Column("CREATED_DATE")]
        public DateTime CreatedDate { get; set; }

        
        [Column("UPDATED_BY")]
        public string UpdatedBy { get; set; }
        [Column("UPDATED_DATE")]
        public DateTime UpdatedDate { get; set; }
    }

    [Table("CON_MST_SAML_CONFIG")]
    public class SamlConfig
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("IDENTITY_PROVIDER")]
        
        public string IdentityProvider { get; set; }

        [Column("CONFIGURATION_MODE")]
        public int ConfigurationMode { get; set; }

        [Column("ISSUER_URL")]
         
        public string IssuerUrl { get; set; }

        [Column("ENTITY_ID")]
       
        public string EntityId { get; set; }

        [Column("IDENTITY_PROVIDER_LOGIN_URL")]
         
        public string IdentityProviderLoginUrl { get; set; }

        [Column("IDENTITY_PROVIDER_LOGOUT_URL")]
        
        public string IdentityProviderLogoutUrl { get; set; }        

        
        [Column("CREATED_BY")]
        public string CreatedBy { get; set; }
        [Column("CREATED_DATE")]
        public DateTime CreatedDate { get; set; }

         
        [Column("UPDATED_BY")]
        public string UpdatedBy { get; set; }
        [Column("UPDATED_DATE")]
        public DateTime UpdatedDate { get; set; }
        public List<DigitalCertificate> DigitalCertificates { get; set; }
    }

    [Table("CON_MST_DIGITAL_CERTIFICATE")]
    public class DigitalCertificate
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [ForeignKey("FK_SAML_CONFIG__DIGITAL_CERTIFICATE")]
        [Column("SAML_CONFIG_ID")]
        public int SamlConfigId { get; set; }
        public virtual SamlConfig SamlConfig { get; set; }
        [Column("X509_CERTIFICATE")]
        public string X509Certificate { get; set; }
        [Column("RELAY_STATE")]
       
        public string RelayState { get; set; }
        [Column("CERTIFICATE_FILE_NAME")]
        
        public string CertificateFileName { get; set; }

        [Column("ASSERTION_CONSUMER_SERVICE_URL")]
        
        public string AssertionConsumerServiceUrl { get; set; }

        [Column("RECIPIENT_URL")]
        
        public string RecipientUrl { get; set; }

        [Column("ISSUER_URL")]
        
        public string IssuerUrl { get; set; }

        [Column("LOGOUT_URL")]
        
        public string LogoutUrl { get; set; }

         
        [Column("CREATED_BY")]
        public string CreatedBy { get; set; }
        [Column("CREATED_DATE")]
        public DateTime CreatedDate { get; set; }

         
        [Column("UPDATED_BY")]
        public string UpdatedBy { get; set; }
        [Column("UPDATED_DATE")]
        public DateTime UpdatedDate { get; set; }
    }
}
