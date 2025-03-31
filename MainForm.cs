using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DBContext;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        ModelIF model = new ModelIF();
        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = model.Users.ToList();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            FormAddUsers form = new FormAddUsers();
            form.ShowDialog();
            dataGridView1.DataSource = model.Users.ToList();
        }
    }
}
