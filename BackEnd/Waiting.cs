using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static ClinicCat.DataAccessLayer.DataAccessLayer;
namespace ClinicCat.BackEnd
{
    public static class Waiting
    {
        public static string getVideoPath()
        {
            try
            {
                return ExecuteScalar<string>(@"select VideoURL from Settings where ID='1'");
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
