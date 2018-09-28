using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace CommunalPayments
{
    public partial class ModelDB
    {
        public static string ServerName = System.Environment.MachineName;
        
        static string DefaultConnectionString = "metadata=res://*/DatabaseModel.csdl|res://*/DatabaseModel.ssdl|res://*/DatabaseModel.msl;provider=System.Data.SqlClient;provider connection string=\"data source =" + ServerName + "; initial catalog = CommunalPayments; integrated security = True; MultipleActiveResultSets=True;App=EntityFramework\"";
        
        public ModelDB(string connectionString) 
            : base(connectionString)
        {
        }

        public static ModelDB Context
        {
            get
            {
                return new ModelDB(DefaultConnectionString);
            }
        }
    }
}
