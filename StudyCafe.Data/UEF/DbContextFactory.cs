
#region
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
#endregion

namespace StudyCafe.Data
{
    public partial class DbContextFactory
    {
        static DbContextFactory()
        {
            RawConnectionString = "data source=192.168.8.127;initial catalog=KoreanStudyCafe;user id=sa;password=3512;MultipleActiveResultSets=True;App=EntityFramework";
        }

        public static string RawConnectionString { get; }

        static partial void GetConnectionStringCore(ref string connectionString)
        {
            connectionString = "metadata=res://*/KoreanStudyCafe.csdl|res://*/KoreanStudyCafe.ssdl|res://*/KoreanStudyCafe.msl;provider=System.Data.SqlClient;provider connection string=\"" + RawConnectionString + ";App=EntityFramework\"";
        }

        static partial void CreateCore(KoreanStudyCafeEntities context)
        {
            context.Database.Log = x => Debug.WriteLine(x);
        }
    }
}