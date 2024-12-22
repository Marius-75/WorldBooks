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
    public partial class WorksForm : Form
    {
        private MySqlConnection sqlConnection;

        public WorksForm(MySqlConnection sqlConn)
        {
            InitializeComponent();

            authorTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            authorTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            sqlConnection = sqlConn;
            MySqlCommand cmd = sqlConn.CreateCommand();
            cmd.CommandText = "SELECT language FROM languages";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                languageComboBox.Items.Add(reader.GetString(0));

            reader.Close();
            languageComboBox.SelectedItem = languageComboBox.Items[0];
        }

        private string[] suggestStrings(string text)
        {
            string[] ret = new string[4];

            ret[0] = text + text;
            ret[1] = text + "1";
            ret[2] = text + "2";
            ret[3] = text + "3";

            return ret;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void authorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (authorTextBox.Text.Length >= 3)
            {
                string[] arr = suggestStrings(authorTextBox.Text);

                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                collection.AddRange(arr);

                authorTextBox.AutoCompleteCustomSource = collection;
            }
        }
    }
}
