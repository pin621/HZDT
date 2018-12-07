using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HZDT.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //连接数据库字符串
            //string connectionString = "Data Source=.;Initial Catalog=NFineBase;User ID=sa;Password=hjf19870810;"; 
            string connectionString = "data source=180.166.36.91;initial catalog=PermissionBasepb;user id=sa;password=hzdt2011;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            System.Data.DataTable schema = conn.GetSchema("TABLES");
            string selectQuery = "select * from @tableName";
            SqlCommand command = new SqlCommand(selectQuery, conn);
            SqlDataAdapter ad = new SqlDataAdapter(command);
            System.Data.DataSet ds = new DataSet();
            string propQuery = "SELECT 表名=sobj.name,字段名=scol.name,字段说明=sprop.[value] FROM syscolumns as scol inner join sys.sysobjects as sobj on scol.id=sobj.id and sobj.xtype='U' and sobj.name<>'dtproperties' left join sys.extended_properties as sprop on scol.id=sprop.major_id and scol.colid=sprop.minor_id where sobj.name='@tableName' and scol.name='@columnName'";
            SqlCommand command2 = new SqlCommand(propQuery, conn);
            SqlDataAdapter ad2 = new SqlDataAdapter(command2);
            System.Data.DataSet ds2 = new DataSet();

            foreach (System.Data.DataRow row in schema.Rows)
            {
                ds.Tables.Clear();
                command.CommandText = selectQuery.Replace("@tableName", row["TABLE_NAME"].ToString());
                ad.FillSchema(ds, SchemaType.Mapped, row["TABLE_NAME"].ToString());
                foreach (DataColumn dc in ds.Tables[0].Columns)
                {
                    ds2.Tables.Clear();
                    command2.CommandText = propQuery.Replace("@tableName", row["TABLE_NAME"].ToString());
                    command2.CommandText = command2.CommandText.Replace("@columnName", dc.ColumnName);
                    ad2.Fill(ds2);
                    string mark = string.Empty;
                    if (ds2.Tables[0].Rows.Count>0)
                    {
                        mark = ds2.Tables[0].Rows[0].ItemArray[2].ToString();
                    }                    
                }
            }

            Console.WriteLine("Hello world");
            Console.Read();
        }
    }
}
