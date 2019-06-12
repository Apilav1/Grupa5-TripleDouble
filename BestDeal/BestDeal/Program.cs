using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.IdentityModel.Protocols;
using System.Data.SqlClient;
using System.Text;
using System.Diagnostics;

namespace BestDeal
{
    public class Program
    {
        public static int lastArtikalId
        {
            get;
            set;
        }

        public static int lastTipId
        {
            get;
            set;
        }

        public static void Main(string[] args)
        {
            lastArtikalId = getLastArtikalId();
            lastTipId = getLastTipId();
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        public static int getLastArtikalId()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
             
                builder.DataSource = "bestdeal.database.windows.net";
                builder.UserID = "tripledouble";
                builder.Password = "$triple4double$";
                builder.InitialCatalog = "BestDeal-baza";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    

                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Select TOP 1 *");
                    sb.Append("from dbo.Artikal a  ");
                    sb.Append("order by a.idartikla desc  ");
                    String sql = sb.ToString();

                    int rez = 0;
                   
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                       
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                          
                            while (reader.Read())
                            {
                            
                                Debug.WriteLine("ovo trazim: {0}", reader.GetInt32(0));
                                rez = reader.GetInt32(0);
                                return ++rez;
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Debug.WriteLine("problem {0}", e);
            }
            Console.ReadLine();
            return 0;
        }

        public static int getLastTipId()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
           
                builder.DataSource = "bestdeal.database.windows.net";
                builder.UserID = "tripledouble";
                builder.Password = "$triple4double$";
                builder.InitialCatalog = "BestDeal-baza";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                  

                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Select TOP 1 *");
                    sb.Append("from dbo.Tip a  ");
                    sb.Append("order by a.idTipa desc  ");
                    String sql = sb.ToString();

                    int rez = 0;
                  
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                      
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            
                            while (reader.Read())
                            {
                            
                                Debug.WriteLine("ovo trazim: {0}", reader.GetInt32(0));
                                rez = reader.GetInt32(0);
                                return ++rez;
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Debug.WriteLine("problem {0}", e);
            }
            Console.ReadLine();
            return 0;
        }
    }
}
