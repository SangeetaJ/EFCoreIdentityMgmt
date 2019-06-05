/*****************************************************************************************************************************  
**� 2019 Datamatics Robotics Software Limited, Inc, All Rights Reserved 
* Datamatics Robotics Software Limited Group, Inc. (Encounter Data Manager) Proprietary Product Software *
* Not to be modified by customer *  
* Not Customer maintainable *
** AUTHOR:			Datamatics Robotics Software Limited.   
** CREATED ON:		1/22/2019
** CREATED BY:		TruBot
** Description:   
** 
** Revision History:
**
** Date     Author      Description   
*******************************************************************************************************************************/

using static EFCore.Entities.IdnDBContext;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using EFCore.Entities;

namespace EFCore.DataAccess
{
    public interface IUserDataService
    {
        Task<IdentityResult> AddUser(User model, List<string> roleNames);

        string GetUserRoleId(string userId);
        //Task<bool> UpdateUserSessionLog(DateTime logoutDate, string sessionId);

        dynamic GetUserClaimsForToken(string uname, out string rolename, string modulename = "");
        List<string> GetClaimNames(string uname);
        Task<bool> UpdateRefreshToken(string username, string refreshToken);
        Task<string> GetRefreshToken(string username);
        Task<bool> UpdateUserSessionId(string username, string sessionId);
        Task<List<DependencyMap>> InactivateExpiredEntities();
        Task<string[]> GetAuthorizedUserList(string UserCode);
        Task<string> GetLoggedinUserRoleType(string UserCode);
        Task<int> GetLoggedinUserRoleTypeId(string UserCode);
        Task<IdentityUser> FindUserByUserName(string userName);
        List<User> FindAllUser();
        List<Role> GetAllRoles();
       
    }
}
