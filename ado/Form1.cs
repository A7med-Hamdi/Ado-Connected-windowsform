using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ado
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=.;Initial Catalog=ITI;Integrated Security=True");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cmd = new SqlCommand("select * from course", con);
            SqlCommand cmd1 = new SqlCommand("select * from topic", con);

            con.Open();
            SqlDataReader r = cmd.ExecuteReader();
            List<course> crs = new List<course>();
            while (r.Read())
            {
                course c = new course();
                c.id = (int)r["crs_id"];
                c.name = r["crs_name"].ToString();
                c.duaration = (int)r["crs_duration"];
                int topid = 0;
                int.TryParse(r["top_id"].ToString(), out topid);
                c.topid = topid;


                crs.Add(c);

            }

            DGV_course.DataSource = crs;

            r.Close();
            SqlDataReader sr = cmd1.ExecuteReader();

            List<topic> topic = new List<topic>();
            while (sr.Read())
            {
                topic t = new topic();
                t.Id = (int)sr["top_id"];
                t.Name = sr["top_name"].ToString();
                topic.Add(t);
            }

            cmb_topic.DataSource = topic;
            cmb_topic.DisplayMember = "Name";
            cmb_topic.ValueMember = "id";

            con.Close();
            btn_add.Visible = true;
            btn_update.Visible = false;
            btn_delete.Visible = false;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into course(crs_id ,crs_name,crs_duration,top_id) values(@id,@name,@duaration,@topic) ", con);

            cmd.Parameters.AddWithValue("id", txt_id.Text);
            cmd.Parameters.AddWithValue("name", txt_name.Text);
            cmd.Parameters.AddWithValue("duaration", txt_duaration.Text);
            cmd.Parameters.AddWithValue("topic", cmb_topic.SelectedValue);


            con.Open();
            int roweffect = cmd.ExecuteNonQuery();

            con.Close();

            if (roweffect > 0)
            {
                txt_duaration.Text = txt_id.Text = txt_name.Text = "";
                Form1_Load(null, null);
            }

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from course where crs_name like @search", con);
            cmd.Parameters.AddWithValue("search", txt_search.Text);
            con.Open();
            SqlDataReader r = cmd.ExecuteReader();
            List<course> crs = new List<course>();
            while (r.Read())
            {
                course c = new course();
                c.id = (int)r["crs_id"];
                c.name = r["crs_name"].ToString();
                c.duaration = (int)r["crs_duration"];
                int topid = 0;
                int.TryParse(r["top_id"].ToString(), out topid);
                c.topid = topid;


                crs.Add(c);

            }

            DGV_course.DataSource = crs;



            con.Close();


        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update course set Crs_Name=@name , Crs_Duration=@duration , Top_Id=@topic  where Crs_Id=@id", con);
            cmd.Parameters.AddWithValue("id", txt_id.Text);
            cmd.Parameters.AddWithValue("name", txt_name.Text);
            cmd.Parameters.AddWithValue("duration", txt_duaration.Text);
            cmd.Parameters.AddWithValue("topic", cmb_topic.SelectedValue);
            con.Open();
            int rowEffect = cmd.ExecuteNonQuery();
            con.Close();
            if (rowEffect > 0)
            {
                txt_duaration.Text = txt_id.Text = txt_name.Text = cmb_topic.SelectedText = "";
                Form1_Load(null, null);
            }
            btn_add.Visible = true;
            btn_update.Visible = false;
            btn_delete.Visible = false;

        }

        private void DGV_course_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {


        }

        private void DGV_course_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_id.Text = DGV_course.SelectedRows[0].Cells[0].Value.ToString();
            txt_name.Text = DGV_course.SelectedRows[0].Cells[1].Value.ToString();
            txt_duaration.Text = DGV_course.SelectedRows[0].Cells[2].Value.ToString();
            cmb_topic.DisplayMember = DGV_course.SelectedRows[0].Cells[3].Value.ToString();
             

            btn_add.Visible = false;
            btn_update.Visible = true;
            btn_delete.Visible = true;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Are you sure you want to delete", "confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                int id = (int)DGV_course.SelectedRows[0].Cells[0].Value;
                cmd = new SqlCommand("delete from course where crs_id =@id", con);
                cmd.Parameters.AddWithValue("id", id);
                con.Open();
                int roweffect = cmd.ExecuteNonQuery();


                con.Close();
                if (roweffect > 0)
                {
                    txt_duaration.Text = txt_id.Text = txt_name.Text = cmb_topic.SelectedText = "";

                    Form1_Load(null, null);
                }
            }
        }
    }
}
