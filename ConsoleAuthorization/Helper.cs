using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAuthorization
{
	public class Helper
	{
		private static Model.LibraryBase DBEntities;
		public static Model.LibraryBase getContex()
		{
			if(DBEntities == null)
            {
				DBEntities = new Model.LibraryBase();
			}
			return DBEntities;
		}

		public static void CreateUsers(Model.Client client)
        {
			DBEntities.Client.Add(client);
			DBEntities.SaveChanges();
		}

		public static int GetLastID()
        {
			int id = 0;

			try
			{
				id = DBEntities.Client.OrderByDescending(client => client.CL_ID).First().CL_ID;
				return id + 1;
			}
            catch (System.InvalidOperationException)
            {
				id = 0;
				return id + 1;
			}
		}
	}
}