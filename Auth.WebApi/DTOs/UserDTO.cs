using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auth.WebApi.DTOs
{
    public class UserDTO
    {
        public int UserCode { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public string Status_Id { get; set; }

        public string PhoneNumber { get; set; }

        public string Mobile { get; set; }

        public string ProfileImgName { get; set; }

        public DateTime? ValidateFrom { get; set; }

        public DateTime? ValidateTo { get; set; }

        public string RefreshToken { get; set; }
        public string SessionId { get; set; }

        public int PrimaryGroupId { get; set; }

        public List<string> UserRoles { get; set; }

        public List<RoleDTO> roles { get; set; }
    }

    public class UserRolesDTO
    {
        public int RoleCode { get; set; }
    }

    public class RoleDTO
    {
        public int RoleCode { get; set; }

        public DateTime? ValidateFrom { get; set; }

        public DateTime? ValidateTo { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public string VersionNumber { get; set; }
    }
}
