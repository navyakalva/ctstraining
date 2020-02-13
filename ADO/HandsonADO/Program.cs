using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace HandsonADO
{
    class Program
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IOAS59H\SQLEXPRESS;
   Initial Catalog=PracticeDB;Persist Security Info=True;User ID=SA;Password=pass@word1");
        SqlCommand cmd = null;
        //public  void Add()
        //{
        //    try
        //    {
        //        cmd = new SqlCommand("Insert into project values(@pid,@pname,@sdate,@edate)", con);
        //        //passing values to parameters
        //        cmd.Parameters.AddWithValue("@pid", "P0006");
        //        cmd.Parameters.AddWithValue("@pname", "ADO");
        //        cmd.Parameters.AddWithValue("@sdate", DateTime.Parse("12.2.2019"));
        //        cmd.Parameters.AddWithValue("@edate", DateTime.Parse("12.2.2020"));
        //        con.Open();//open connection
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch(SqlException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        con.Close();//close connection
        //    }
           
        //}
        public void GetProjById(string pid)
        {
            try
            {
                cmd = new SqlCommand("select * from project where pid=@pid", con);
                cmd.Parameters.AddWithValue("@pid", pid);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)//ckecks rows existence
                {
                    dr.Read();//read only 1 record
                    Console.WriteLine("ID:{0} Name:{1} Sdate:{2} Edate:{3}",
                        dr["pid"], dr["pname"], dr["sdate"], dr["edate"]);
                }
                else
                    Console.WriteLine("Invalid project id");
            }
            catch(SqlException ex)
            { 
                Console.WriteLine(ex.Message);
            }
            
        }
        public void GetAllProjects()
        {
            try
            {
                cmd = new SqlCommand("select * from project ", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)//ckecks rows existence
                {
                    while (dr.Read())
                    {
                        Console.WriteLine("ID:{0} Name:{1} Sdate:{2} Edate:{3}",
                           dr["pid"], dr["pname"], dr["sdate"], dr["edate"]);
                    }
                    dr.Read();//read only 1 record

                }
                else
                    Console.WriteLine("table empty");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            //obj.Add();
            //obj.GetProjById("P0006");
            obj.GetAllProjects();
            Console.ReadKey();
        }
    }
}
