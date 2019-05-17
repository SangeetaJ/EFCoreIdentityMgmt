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

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using static EFCore.Entities.IdnDBContext;
using EFCore.Entities;
using AutoMapper;

namespace EFCore.DataAccess
{

    public class UserDataService : IUserDataService
    {
        private readonly IdnDBContext idbContext;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;
        private readonly IMapper mapper;

        public UserDataService(IdnDBContext idbContext, RoleManager<IdentityRole> _roleManager, UserManager<IdentityUser> _userManager, IMapper _mapper)
        {
            this.idbContext = idbContext;
            roleManager = _roleManager;
            userManager = _userManager;
        }


        public async Task<IdentityResult> AddUser(User model)
        {
            try
            {
                var result = await userManager.CreateAsync(model).ConfigureAwait(false);
                idbContext.SaveChanges();
                return result;
            }
            catch (Exception ex)
            {
                //handle exception here
                return IdentityResult.Failed(new IdentityError()
                {
                    Code = "0",
                    Description = ex.ToString()
                });
            }
        }

        public async Task<IdentityResult> UpdateUser(User model)
        {
            try
            {
                var result = await userManager.UpdateAsync(model).ConfigureAwait(false);
                idbContext.SaveChanges();
                return result;
            }
            catch (Exception ex)
            {
                //handle exception here
                return IdentityResult.Failed(new IdentityError()
                {
                    Code = "0",
                    Description = ex.ToString()
                });
            }
        }

        public async Task<IdentityResult> DeleteUser(User model)
        {
            try
            {
                var result = await userManager.DeleteAsync(model).ConfigureAwait(false);
                idbContext.SaveChanges();
                return result;
            }
            catch (Exception ex)
            {
                //handle exception here
                return IdentityResult.Failed(new IdentityError()
                {
                    Code = "0",
                    Description = ex.ToString()
                });
            }
        }

        public async Task<IdentityUser> FindUserByEmail(User model)
        {
            try
            {
                var result = await userManager.FindByEmailAsync(model.Email).ConfigureAwait(false);
                return result;
            }
            catch (Exception ex)
            {
                //handle exception here
                return null;
            }
        }

        public string GetUserRoleId(string userId)
        {
            return idbContext.UserRoles.Where(x => x.UserId == userId).Select(x => x.RoleId).FirstOrDefault() ?? string.Empty;
        }
        //public async Task<bool> UpdateUserSessionLog(DateTime logoutDate, string sessionId)
        //{
        //    UserSessionLog userSessionLog = await idbContext.UserSessionLogs.FirstOrDefaultAsync(obj => obj.UserToken == sessionId).ConfigureAwait(false);
        //    if (userSessionLog == null)
        //    {
        //        return false;
        //    }
        //    userSessionLog.LogoutDate = logoutDate;
        //    dbContext.UserSessionLogs.Update(userSessionLog);
        //    return await dbContext.SaveChangesAsync().ConfigureAwait(false) > 0;
        //}

        public dynamic GetUserClaimsForToken(string uname, out string rolename, string modulename = "")
        {
            try
            {
                string UId = idbContext.Users.AsNoTracking().Where(exuser => exuser.UserName == uname).FirstOrDefault().Id;
                string RoleId = idbContext.UserRoles.AsNoTracking().Where(exuser => exuser.UserId == UId).FirstOrDefault().RoleId;

                if (!string.IsNullOrEmpty(UId) && !string.IsNullOrEmpty(RoleId))
                {
                    var results = (from permission in idbContext.Permissions
                                   join roleManager in roleManager.Roles on permission.RoleId equals roleManager.Id
                                   join claim in idbContext.Claims on permission.ClaimsId equals claim.Id
                                   join privilege in idbContext.Privileges on claim.Privilegeid equals privilege.Id
                                   //join usr in _userMgr.Users on uname equals usr.UserName
                                   where permission.RoleId == RoleId
                                   select new
                                   {
                                       ModuleName = privilege.Name, // User or Alerts etc.
                                       RoleName = roleManager.Name, // Designer or Administrator etc.
                                       ClaimName = claim.Name // CanAddUser or CanUpdateUser etc.
                                   }).ToList();

                    rolename = results.FirstOrDefault().RoleName;
                    return results;
                }
                rolename = string.Empty;
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> GetClaimNames(string uname)
        {
            string UId = idbContext.Users.AsNoTracking().Where(exuser => exuser.UserName == uname).FirstOrDefault().Id;
            string RoleId = idbContext.UserRoles.AsNoTracking().Where(exuser => exuser.UserId == UId).FirstOrDefault().RoleId;

            if (!string.IsNullOrEmpty(UId) && !string.IsNullOrEmpty(RoleId))
            {
                var results = (from permission in idbContext.Permissions
                               join roleManager in roleManager.Roles on permission.RoleId equals roleManager.Id
                               join claim in idbContext.Claims on permission.ClaimsId equals claim.Id
                               join privilege in idbContext.Privileges on claim.Privilegeid equals privilege.Id
                               where permission.RoleId == RoleId

                               select claim.Name
                                ).ToList();
                return results;
            }
            return new List<string>();
        }

        public async Task<bool> UpdateRefreshToken(string username, string refreshToken)
        {
            User user = await idbContext.Users.FirstOrDefaultAsync(x => x.UserName == username).ConfigureAwait(false);
            if (user == null)
            {
                return false;
            }
            user.RefreshToken = refreshToken;
            idbContext.Users.Update(user);
            return await idbContext.SaveChangesAsync().ConfigureAwait(false) > 0;
        }

        public async Task<string> GetRefreshToken(string username)
        {
            User user = await idbContext.Users.FirstOrDefaultAsync(x => x.UserName == username).ConfigureAwait(false);
            return user.RefreshToken;
        }

        public async Task<bool> UpdateUserSessionId(string username, string sessionId)
        {
            User user = await idbContext.Users.FirstOrDefaultAsync(x => x.UserName == username).ConfigureAwait(false);
            if (user == null)
            {
                return false;
            }
            user.SessionId = sessionId;
            idbContext.Users.Update(user);
            return await idbContext.SaveChangesAsync().ConfigureAwait(false) > 0;
        }

        public async Task<List<DependencyMap>> InactivateExpiredEntities()
        {
            var dependencies = new List<DependencyMap>();

            // inactivate users
            idbContext.Users.Where(x => x.ValidateTo <= DateTime.UtcNow).ToList().ForEach(x => x.Status_Id = Constants.UserInactiveKey);

            // inactivate roles 
            dependencies.AddRange(InactivateExpiredRoles());

            await idbContext.SaveChangesAsync().ConfigureAwait(false);

            return dependencies;
        }

        private List<DependencyMap> InactivateExpiredRoles()
        {
            var dependencies = new List<DependencyMap>();

            var rolesToInactivate = idbContext.RoleDetails.Where(x => x.ValidateTo <= DateTime.UtcNow && x.Status).ToList();

            var query = from usr in idbContext.Users
                        join ur in idbContext.UserRoles on usr.Id equals ur.UserId
                        join rol in roleManager.Roles on ur.RoleId equals rol.Id
                        join rold in rolesToInactivate on rol.Id equals rold.Role_Id
                        where usr.Status_Id == Constants.UserActiveKey // && usr.ValidateTo >= DateTime.Now 
                        orderby usr.UserName
                        group new { rol, rold, usr } by new { rol.Name, rold.RoleCode } into gby
                        select new
                        DependencyMap()
                        {
                            Parent = new DependencyModule() { Type = "Role", Name = gby.Key.Name, Id = (int)gby.Key.RoleCode },
                            Dependents = gby.Select(x => new DependencyModule() { Type = "User", Name = x.usr.UserName, Id = x.usr.UserCode }).ToList()
                        };

            dependencies.AddRange(query.ToList());

            var rolesWithoutDependency = rolesToInactivate.Where(x => dependencies.All(y => y.Parent.Id != x.RoleCode)).ToList();

            rolesWithoutDependency.ForEach(x => x.Status = false);

            return dependencies;
        }

        public async Task<string> GetLoggedinUserRoleType(string UserCode)
        {
            string userRoleType = await (from u in idbContext.Users
                                         join r in idbContext.UserRoles on u.Id equals r.UserId
                                         join d in idbContext.RoleDetails on r.RoleId equals d.Role_Id
                                         join t in idbContext.RoleTypes on d.ROLE_TYPEID equals t.Id
                                         where u.UserCode.ToString(CultureInfo.InvariantCulture) == UserCode
                                         select t.RoleTypeName).FirstOrDefaultAsync().ConfigureAwait(false);
            return userRoleType != null ? userRoleType : string.Empty;
        }

        public async Task<int> GetLoggedinUserRoleTypeId(string UserCode)
        {
            int userRoleType = await (from u in idbContext.Users
                                      join r in idbContext.UserRoles on u.Id equals r.UserId
                                      join d in idbContext.RoleDetails on r.RoleId equals d.Role_Id
                                      join t in idbContext.RoleTypes on d.ROLE_TYPEID equals t.Id
                                      where u.UserCode.ToString(CultureInfo.InvariantCulture) == UserCode
                                      select t.Id).FirstOrDefaultAsync().ConfigureAwait(false);
            return userRoleType;
        }

        public async Task<string[]> GetAuthorizedUserList(string UserCode)
        {

            var userRoleType = await (from u in idbContext.Users
                                      join r in idbContext.UserRoles on u.Id equals r.UserId
                                      join d in idbContext.RoleDetails on r.RoleId equals d.Role_Id
                                      join t in idbContext.RoleTypes on d.ROLE_TYPEID equals t.Id
                                      where u.UserCode.ToString() == UserCode
                                      select t.RoleTypeName).ToListAsync().ConfigureAwait(false);
            string[] userlist = null;

            if (userRoleType[0] == Constants.RoleTypeGroupAdministrator)
            {
                List<UserGroup> lstgroups = await idbContext.UserGroups.Where(x => x.UserCode.ToString() == UserCode).ToListAsync().ConfigureAwait(false);
                //SELECT USER_CODE FROM IDN_TRN_USER_GROUP WHERE GROUP_ID IN(SELECT GROUP_ID FROM IDN_TRN_USER_GROUP WHERE USER_CODE = @User_code)

                userlist = await (from grp in idbContext.UserGroups
                                  join lst in lstgroups on grp.GroupId equals lst.GroupId
                                  select grp.UserCode.ToString()).ToArrayAsync<string>().ConfigureAwait(false);
            }
            else if (userRoleType[0] == Constants.RoleTypeAdministrator)
            {
                userlist = await idbContext.Users.Select(obj => obj.UserCode.ToString(CultureInfo.InvariantCulture)).ToArrayAsync<string>().ConfigureAwait(false);
            }
            else
            {
                userlist = new string[1];
                userlist[0] = UserCode;
            }
            return userlist;
        }
    }

    public class DependencyMap
    {
        public DependencyModule Parent { get; set; }
        public List<DependencyModule> Dependents { get; set; }
    }

    public class DependencyModule
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }

    //
    // Summary:
    //     Represents the result of an identity operation.
    public class CRUDResult
    {
        public CRUDResult() { }

        public static CRUDResult Success { get; }

        public bool Succeeded { get; protected set; }
        public IEnumerable<CRUDError> Errors { get; }

        public static CRUDResult Failed(params CRUDError[] errors)
        {
            throw new NotImplementedException();
        }
    }

    public class CRUDError
    {
        public CRUDError() { }

        public string Code { get; set; }

        public string Description { get; set; }
    }
}
