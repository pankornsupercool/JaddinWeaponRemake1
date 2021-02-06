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
    public partial class ViewWeaponPanel : Form
    {
        SqlConnection sqlCon = new SqlConnection(ConnectionString.GetConnectionString());
        public ViewWeaponPanel()
        {
            InitializeComponent();
        }

        void FillDataGridView_ViewPanel_ViewAll()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@SearchText", searchTextBox.Text.Trim());
            List<WeaponDataMapping> list_all = sqlCon.Query<WeaponDataMapping>("WeaponViewAllOrSearch", param, commandType: CommandType.StoredProcedure).ToList();
            viewDataGridView.DataSource = list_all;
        }
        void FillDataGridView_ViewPanel_Search()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@SearchText", searchTextBox.Text.Trim());
            List<WeaponDataMapping> list_search = sqlCon.Query<WeaponDataMapping>("WeaponSearchByName2", param, commandType: CommandType.StoredProcedure).ToList();
            viewDataGridView.DataSource = list_search;
        }






























































        private void ViewWeaponPanel_Load(object sender, EventArgs e)
        {
            viewDataGridView.Refresh();
            try
            {
                FillDataGridView_ViewPanel_ViewAll();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viewAllButton_Click(object sender, EventArgs e)
        {
            viewDataGridView.Refresh();
            try
            {
                FillDataGridView_ViewPanel_ViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            viewDataGridView.Refresh();
            try
            {
                FillDataGridView_ViewPanel_Search();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
