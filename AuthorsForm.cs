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
    public partial class AuthorsForm : Form
    {
        private MySqlConnection sqlConnection;

        public AuthorsForm(MySqlConnection sqlConn)
        {
            InitializeComponent();

            sqlConnection = sqlConn;
            MySqlCommand cmd = sqlConn.CreateCommand();
            cmd.CommandText = "SELECT Name FROM countries";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                countryComboBox.Items.Add(reader.GetString(0));

            reader.Close();

            for (int i = 0; i < countryComboBox.Items.Count; ++i)
                if (countryComboBox.Items[i].ToString() == "United Kingdom")
                    countryComboBox.SelectedItem = countryComboBox.Items[i];
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length == 0 || birthYearTextBox.Text.Length == 0)
                return;

            string country = "";
            if (countryComboBox.SelectedIndex >= 0)
                country = countryComboBox.SelectedItem.ToString();

            MySqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = "INSERT INTO authors VALUES (@Param1, @Param2, @Param3, @Param4)";
            cmd.Parameters.AddWithValue("@Param1", nameTextBox.Text);
            cmd.Parameters.AddWithValue("@Param2", country);
            cmd.Parameters.AddWithValue("@Param3", birthYearTextBox.Text);
            cmd.Parameters.AddWithValue("@Param4", deceaseYearTextBox.Text);
            try
            {
                cmd.ExecuteNonQuery();
                statusLabel.Text = "Author [" + nameTextBox.Text + "] added successful";
                nameTextBox.Text = "";
                birthYearTextBox.Text = "";
                deceaseYearTextBox.Text = "";
            }
            catch (MySqlException ex)
            {
                statusLabel.Text = ex.Message;
            }
            cmd.Dispose();
        }
    }
}
