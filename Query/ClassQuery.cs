using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighyGym2.Query
{
    class ClassQuery
    {
        static public string Query_selectStudent = "SELECT  [ID]  ,[Students].Student_Name ,[Students].pic, [From] ,[To] ,Roles.Employee_Name, [class_name] ,[mount] ,[Entertime]  " +
 " FROM[fightGym].[dbo].[Tbl_eshtrackat] " + 
      "   INNER Join[fightGym].[dbo].Roles " +
 "ON Tbl_eshtrackat.emp_id = Roles.role_Id " +
 "INNER Join[fightGym].[dbo].[Students] " +
   "      ON Tbl_eshtrackat.Student_id = [Students].Deitls_Id " +
 "where Tbl_eshtrackat.Student_id = '1162' " ;
    }
}
