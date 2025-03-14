using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static Microsoft.WindowsAPICodePack.Shell.PropertySystem.SystemProperties.System;

namespace trader_app.DAL
{

    public class Databas_Class
    {
        
        DataAccessLayer dal = new DataAccessLayer();
        public DataRow select_Row(string Tabel_Nema, string Column_Name, TextBox ID, string value)
        {
            DataAccessLayer dal = new DataAccessLayer();
            DataTable dt = new DataTable();
            dt.Columns.Add("Account_ID");
            dt.Columns.Add("A_N");
            dt.Columns.Add("E_N");
            dt.Columns.Add("Note");
            dt.Columns.Add("Class_ID");
            dt.Columns.Add("Account_Group_ID");
            dt.Columns.Add("Type_ID");
            dt.Columns.Add("stutas");
            dt.Columns.Add("Account_Parent_ID");
            dt.Columns.Add("in_date");
            dt.Columns.Add("edit_date");
            dt.Columns.Add("edit_user");
            dt.Columns.Add("by_user");

            DataRow row = dt.NewRow();
            row["Account_ID"] = value;
            row["A_N"] = "Dummy Name";
            row["E_N"] = "Dummy EName";
            row["Note"] = "";
            row["Class_ID"] = "0";
            row["Account_Group_ID"] = "0";
            row["Type_ID"] = "0";
            row["stutas"] = "0";
            row["Account_Parent_ID"] = DBNull.Value;
            row["in_date"] = DateTime.Now.ToString();
            row["edit_date"] = DateTime.Now.ToString();
            row["edit_user"] = "user";
            row["by_user"] = "user";
            return row;

            try
            {
                return dal.FindDataSet("select * from " + Tabel_Nema + " where " + Column_Name + "='" + ID.Text + "'").Rows[0];


            }
            catch (Exception)
            {
                MessageBox.Show("ارجاء التاكد من رقم السجل قد ");
                ID.SelectAll();
                ID.Focus();
                return null;
            }

        }
        public DataRow select_Row(string Tabel_Nema ,string Column_Name ,string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            try
            {
                return dal.FindDataSet("select * from "+Tabel_Nema+" where "+Column_Name+"="+ ID).Rows[0];
               
                
            }
            catch (Exception)
            {
                MessageBox.Show("ارجاء التاكد من رقم السجل قد ");
                return null;
            }

        }
        public Boolean isselect_Row(string Tabel_Nema, string Column_Name, string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            try
            {
                
                    return (dal.FindDataSet("select * from " + Tabel_Nema + " where " + Column_Name + "=" + ID).Rows[0] != null);


            }
            catch (Exception)
            {
                
                return false;
            }

        }
        public DataRow select_Tabel_between_Date(string Tabel_Nema, string Column_Name, string from ,string end)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            try
            {
                return dal.FindDataSet("select * from " + Tabel_Nema + " where " + Column_Name + " between " + from +" and "+end).Rows[0];


            }
            catch (Exception)
            {
                MessageBox.Show("التوجد بيانات في الفترة الحددة ");
                return null;
            }

        }
        public DataRow select_Row(string Tabel_Nema, string Column_Name, string ID, string Column_Name1,string ID1)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            try
            {
                return dal.FindDataSet("select * from " + Tabel_Nema + " where " + Column_Name + " = " + ID+" and "+ Column_Name1+" = "+ID1).Rows[0];


            }
            catch (Exception)
            {
                MessageBox.Show("ارجاء التاكد من رقم السجل قد ");
                return null;
            }

        }
        public void LoadCombo(ComboBox cb, string strsql, string DisplayMember, string ValueMember,int i)
        {
            try
            {
                dal = new DAL.DataAccessLayer();
             
                cb.DisplayMember = DisplayMember;
                cb.ValueMember = ValueMember;

             
                cb.DataSource = dal.FindDataSet(strsql);
           
                cb.DropDownHeight = 100;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }
        public void LoadCombo(ComboBox cb, string strsql, string DisplayMember, string ValueMember)
        {
            try
            {
                dal = new DAL.DataAccessLayer();
                //  SqlDataReader dr = dal.Find(strsql);
                //if (dr.Read())
                //{
                cb.DisplayMember = DisplayMember;
                cb.ValueMember = ValueMember;

                // cb.SelectedIndex = -1;
                //  strsql = strsql + "  order by upper(" + DisplayMember + ")";
                cb.DataSource = dal.FindDataSet(strsql);
              cb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
              cb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
                //  cb.SelectedIndex = -1;
                cb.DropDownHeight = 100;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        
        }

        internal void openConnection()
        {
            throw new NotImplementedException();
        }

        internal SqlConnection getConnection()
        {
            throw new NotImplementedException();
        }

        internal void closeConnection()
        {
            throw new NotImplementedException();
        }
    }
}
