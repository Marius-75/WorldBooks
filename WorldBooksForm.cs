using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WorldBooks
{
    public partial class worldBooksForm : Form
    {
        public worldBooksForm()
        {
            InitializeComponent();

            string connStr = "server=localhost;user=sbUser;database=literatura;port=3306;password=mar75ius";
            mySqlConn = new MySqlConnection(connStr);
            mySqlConn.Open();
            mySqlConn.ChangeDatabase("literatura");
        }

        public MySqlConnection mySqlConn;
        

        private void authorButton_Click(object sender, EventArgs e)
        {
            AuthorsForm authors = new AuthorsForm(mySqlConn);
            authors.ShowDialog();
        }

        private void worksButton_Click(object sender, EventArgs e)
        {
            WorksForm works = new WorksForm(mySqlConn);
            works.ShowDialog();
        }
    }
}
