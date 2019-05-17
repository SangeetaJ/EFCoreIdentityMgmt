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

using DGSL.TruBot.Console.DataService.DbContexts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DGSL.TruBot.Console.DataService.Entities;
using DGSL.TruBot.Console.Common.Enums;

namespace DGSL.TruBot.Console.DataService
{
    public class PrefixDataService : IPrefixDataService
    {
        private readonly ConsoleDbContext context;

        public PrefixDataService(ConsoleDbContext context)
        {
            this.context = context;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public PrefixRepository GetPrefixByName(PrefixEnum name)
        {
            return context.PrefixRepositories.FirstOrDefault(obj => obj.MenuName == name.ToString());
        }
    }
}
