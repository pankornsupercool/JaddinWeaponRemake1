using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
namespace JaddinWeaponRemake1
{
    public partial class AddWeaponPanel : Form
    {

        SqlConnection sqlCon = new SqlConnection(ConnectionString.GetConnectionString());
        public AddWeaponPanel()
        {
            InitializeComponent();
        }


        void AddDataOrEdit()
        {
            string radioInput = "";

            if (gunCategoryRadio.Checked == true)
            {
                radioInput = gunCategoryRadio.Text;
            }
            else if (missileCategoryRadio.Checked == true)
            {
                radioInput = missileCategoryRadio.Text;
            }


            if (String.IsNullOrEmpty(weaponNameTextBox.Text))
            {
                MessageBox.Show("Please enter the weapon name.");
            }
            else if (String.IsNullOrEmpty(radiusWeaponTextBox.Text))
            {
                MessageBox.Show("Please enter the weapon radius.");
            }
            else if (radioInput == "")
            {
                MessageBox.Show("Please select the weapon category.");
            }
            else
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                DynamicParameters param = new DynamicParameters();
                param.Add("@WeaponID", StaticVariable.weaponId);
                param.Add("@WeaponName", weaponNameTextBox.Text.Trim());
                param.Add("@Category", radioInput);
                param.Add("@Ezradius", radiusWeaponTextBox.Text.Trim());
                param.Add("@Detail", detailWeaponTextBox.Text.Trim());
                sqlCon.Execute("WeaponAddOrModify", param, commandType: CommandType.StoredProcedure);
                Clear();
            }
        }

        void Clear()
        {
            StaticVariable.weaponId = 0;
            weaponNameTextBox.Text = "";
            radiusWeaponTextBox.Text = "";
            detailWeaponTextBox.Text = "";
            if (gunCategoryRadio.Checked == true || missileCategoryRadio.Checked == true)
            {
                gunCategoryRadio.Checked = missileCategoryRadio.Checked = false;
            }
            MessageBox.Show("Added Successfully");
        }








































        private void addWeaponButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddDataOrEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
