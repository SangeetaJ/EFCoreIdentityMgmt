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

using DGSL.TruBot.Console.Common.Enums;
using DGSL.TruBot.Console.DataService.Entities;

namespace DGSL.TruBot.Console.DataService
{
    public interface IPrefixDataService
    {
        PrefixRepository GetPrefixByName(PrefixEnum name);
    }
}