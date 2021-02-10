using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;
namespace JaddinWeaponRemake1
{
    public partial class ModifyWeaponPanel : Form 
    {
        SqlConnection sqlCon = new SqlConnection(ConnectionString.GetConnectionString());
        public ModifyWeaponPanel()
        {
            InitializeComponent();
            Invoke();
        } 


        void Invoke()
        {
            if (StaticVariable.WeaponName_Text != null)
            {
                weaponNameTextBox.Enabled = true;
                gunCategoryRadio.Enabled = true;
                missileCategoryRadio.Enabled = true;
                radiusWeaponTextBox.Enabled = true;
                detailWeaponTextBox.Enabled = true;
                modifyWeaponButton.Enabled = true;
            }
            weaponNameTextBox.Text = StaticVariable.WeaponName_Text;
            radiusWeaponTextBox.Text = StaticVariable.Ezradius_Text;
            detailWeaponTextBox.Text = StaticVariable.Detail_Text;
            if (StaticVariable.Category_Text == "Gun")
            {
                gunCategoryRadio.Checked = true;
            }
            else if (StaticVariable.Category_Text == "Missile")
            {
                missileCategoryRadio.Checked = true;
            }
        }
        void AddDataOrEdit()
        {
            string radioInput = StaticVariable.Category_Text;

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
                this.Hide();
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
            MessageBox.Show("Modify Successfully");
        }








































        private void addWeaponButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddDataOrEdit();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        }
    }

