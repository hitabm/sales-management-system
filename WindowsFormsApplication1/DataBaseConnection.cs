using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace System_Forush
{
    class DataBaseConnection
    {
        SqlConnection conn;
        SqlDataAdapter adap;
        SqlCommandBuilder comb;
        DataSet ds;
        DataTable dt;
        SqlCommand cmd;

        public object SelectQuery(string query)
        {
            conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = ForushDB;");
            try
            {
                conn.Open();
                adap = new SqlDataAdapter(query, conn);
                comb = new SqlCommandBuilder(adap);
                ds = new DataSet();
                adap.Fill(ds);
                object ob = ds.Tables[0];
                conn.Close();
                return ob;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable GetTable(string query)
        {
            conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = ForushDB;");
            try
            {
                conn.Open();
                adap = new SqlDataAdapter(query, conn);
                comb = new SqlCommandBuilder(adap);
                dt = new DataTable();
                adap.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool InsertQuery(string TblName, string[] values)
        {
            conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = ForushDB;");
            string query = "insert into " + TblName + " values (";
            for (int i = 0; i < values.Length; i++)
            {
                query += "N\'" + values[i] + '\'';
                if (i != values.Length - 1)
                    query += ',';
                else
                    query += ')';
            }
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.Connection = conn;
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateQuery(string TblName, string Statement)
        {
            conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = ForushDB;");
            string query = "update " + TblName + " set " + Statement;
            try
            {
                conn.Open();
                cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.Connection = conn;
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public string LastRow_FirstCell_Value(string TableName, string ColumnName)
        {
            try
            {
                string sel = "select " + ColumnName + " from " + TableName;
                DataGridView dgv = new DataGridView();
                Form f = new Form();
                f.Controls.Add(dgv);
                dgv.DataSource = SelectQuery(sel);
                int rows = dgv.Rows.Count;
                string val = dgv.Rows[rows - 2].Cells[0].Value.ToString();
                return val;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public string FindRow(string TableName, string Const, int ColumnIndex)
        {
            try
            {
                string sel = "select * from " + TableName + " where " + Const;
                DataGridView dgv = new DataGridView();
                Form f = new Form();
                f.Controls.Add(dgv);
                dgv.DataSource = SelectQuery(sel);
                string val = dgv.Rows[0].Cells[ColumnIndex].Value.ToString();
                return val;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
