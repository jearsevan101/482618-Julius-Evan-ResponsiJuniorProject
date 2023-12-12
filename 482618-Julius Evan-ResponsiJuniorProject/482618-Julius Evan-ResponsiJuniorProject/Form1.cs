using Npgsql;
using System.Data;
using System.Windows;

namespace _482618_Julius_Evan_ResponsiJuniorProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=responsiJunpro";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;
        public List<string> listDepartemen = new List<string>();
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                sql = @"select *from st_insert(:_nama,:_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", tb_namaKaryawan.Text);
                cmd.Parameters.AddWithValue("_id_dep", cmb_dep_karyawan.SelectedIndex);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil di inputkan :", "Well done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btn_Load.PerformClick();
                    tb_namaKaryawan.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message, " Insert FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                sql = "select * from table karyawan";
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Select Row :", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                sql = @"SELECT * from st_update (:_id, :_nama, :_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id", r.Cells["_id"].Value.ToString());
                cmd.Parameters.AddWithValue("_nama", tb_namaKaryawan.Text);
                cmd.Parameters.AddWithValue("_id_dep", cmb_dep_karyawan.SelectedIndex);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil di edit :", "Well done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btn_Load.PerformClick();
                    tb_namaKaryawan.Text = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message, "FAIL to update!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dataGridView1.Rows[e.RowIndex];
                tb_namaKaryawan.Text = r.Cells["_nama"].Value.ToString();
                cmb_dep_karyawan.Text = r.Cells["_id_dep"].Value.ToString();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Select Row :", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Confirm delete data" + r.Cells["_nama"].Value.ToString() + " ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    conn = new NpgsqlConnection(connstring);
                    conn.Open();
                    sql = @"SELECT * from st_delete (:_id)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id", r.Cells["_id"].Value.ToString());
                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data berhasil dihapus :", "Well done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        btn_Load.PerformClick();
                        tb_namaKaryawan.Text = null;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :" + ex.Message, "FAIL to delete!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmb_dep_karyawan_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> listDepartemen = new List<string>();

            listDepartemen.Add("HR");
            listDepartemen.Add("ENG");
            listDepartemen.Add("DEV");
            listDepartemen.Add("PM");
            listDepartemen.Add("FIN");
            for (int i = 0; i < listDepartemen.Count; i++)
            {
                cmb_dep_karyawan.Items.Add(listDepartemen[i]);
            }
        }
    }
}