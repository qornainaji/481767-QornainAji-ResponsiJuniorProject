using Npgsql;
using System.Data;
using System.Drawing.Text;
namespace _481767_QornainAji_ResponsiJuniorProyek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //List<Departemen> ListDepartemen = _departemen;
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=responsi";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;



        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                dgvTabel.DataSource = null;
                sql = "select * from st_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvTabel.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select st_insert_karyawan(:_nama, :_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", tbNamaKaryawan.Text);
                cmd.Parameters.AddWithValue("_id_dep", cmbDepartemenKaryawan.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Karyawan berhasil diinputkan");
                    tbNamaKaryawan.Text = cmbDepartemenKaryawan.Text = null;
                    dgvTabel.DataSource = null;
                    sql = "select * from st_select()";
                    cmd = new NpgsqlCommand(sql, conn);
                    dt = new DataTable();
                    NpgsqlDataReader rd = cmd.ExecuteReader();
                    dt.Load(rd);
                    dgvTabel.DataSource = dt;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan diupdate");
                return;
            }
            try
            {
                conn.Open();
                sql = @"select st_update_karyawan(:_id_karyawan, :_nama, :_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["id_karyawan"].Value.ToString());
                cmd.Parameters.AddWithValue("_nama", tbNamaKaryawan.Text);
                cmd.Parameters.AddWithValue("_id_dep", cmbDepartemenKaryawan.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Karyawan berhasil diedit!");
                    tbNamaKaryawan.Text = cmbDepartemenKaryawan.Text = null;
                    dgvTabel.DataSource = null;
                    sql = "select * from st_select()";
                    cmd = new NpgsqlCommand(sql, conn);
                    dt = new DataTable();
                    NpgsqlDataReader rd = cmd.ExecuteReader();
                    dt.Load(rd);
                    dgvTabel.DataSource = dt;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan dihapus");
                return;

            }
            if (MessageBox.Show("Mohon pilih baris data yang akan dihapus " + r.Cells["nama"].Value.ToString()+"?", "Hapus"))
            {
                try
                {
                    conn.Open();
                    sql = @"select st_delete(:_id_karyawan)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["id_karyawan"].Value.ToString());
                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data Karyawan berhasil diedit!");
                        tbNamaKaryawan.Text = cmbDepartemenKaryawan.Text = null;
                        dgvTabel.DataSource = null;
                        sql = "select * from st_select()";
                        cmd = new NpgsqlCommand(sql, conn);
                        dt = new DataTable();
                        NpgsqlDataReader rd = cmd.ExecuteReader();
                        dt.Load(rd);
                        dgvTabel.DataSource = dt;
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
