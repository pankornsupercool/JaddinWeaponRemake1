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
    public partial class DeleteWeaponPanel : Form
    {
        SqlConnection sqlCon = new SqlConnection(ConnectionString.GetConnectionString());
        public DeleteWeaponPanel()
        {
            InitializeComponent();
            Invoke();
        }

        void Invoke()
        {
            if (StaticVariable.WeaponName_Text != null)
            {
                deleteWeaponButton.Enabled = true;
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
        void DeleteData()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@WeaponID", StaticVariable.weaponId);
                sqlCon.Execute("WeaponDeleteById", param, commandType: CommandType.StoredProcedure);
                Clear();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            MessageBox.Show("Deleted Succesfully");
        }







































        private void addWeaponButton_Click(object sender, EventArgs e)
        {
            DeleteData();
        }
    }
}
