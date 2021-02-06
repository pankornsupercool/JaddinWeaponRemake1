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
    public partial class ControlPanel : Form
    {
        // Sql Connection
        static SqlConnection sqlCon = new SqlConnection(ConnectionString.GetConnectionString());
        
        // Dragging Form
        DraggingWindowFormVariable dragging = new DraggingWindowFormVariable();

        public ControlPanel()
        {
            InitializeComponent();
            FillDataGridView_ControlPanel_AllData();
        }

        // Show Weapon name in DataGridView ()
        void FillDataGridView_ControlPanel_WeaponName()
        {
            var data_WeaponName = sqlCon.Query<WeaponNameDataMapping>($"select WeaponName from WeaponDatabasePanel").ToList<WeaponNameDataMapping>();
            controlDataGridView.DataSource = data_WeaponName;
        }

        // Show Weapon category in DataGridView ( Not used)
        void FillDataGridView_ControlPanel_Category()
        {
            var data_Category = sqlCon.Query<CategoryDataMapping>($"select WeaponName,Category from WeaponDatabasePanel").ToList<CategoryDataMapping>();
            controlDataGridView.DataSource = data_Category;
        }


        // Show Weapon radius in DataGridView ( Not used ) 
        void FillDataGridView_ControlPanel_Radius()
        {
            var data_Radius = sqlCon.Query<RadiusDataMapping>($"select WeaponName,Category,Ezradius from WeaponDatabasePanel").ToList<RadiusDataMapping>();
            controlDataGridView.DataSource = data_Radius;
        }

        // Show Weapon All data in DataGridView 
        void FillDataGridView_ControlPanel_AllData()
        {
            var data_AllData = sqlCon.Query<WeaponDataMapping>($"select * from WeaponDatabasePanel").ToList<WeaponDataMapping>();
            controlDataGridView.DataSource = data_AllData;
            controlDataGridView.Columns[0].Visible = false;
        }


















































































        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging.move = 1;
            dragging.moveX = e.X;
            dragging.moveY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging.move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - dragging.moveX, MousePosition.Y - dragging.moveY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging.move = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addWeaponButton_Click(object sender, EventArgs e)
        {
            AddWeaponPanel add_weapon_panel = new AddWeaponPanel();
            add_weapon_panel.Show();
        }

        private void viewWeaponButton_Click(object sender, EventArgs e)
        {
            ViewWeaponPanel view_weapon_panel = new ViewWeaponPanel();
            view_weapon_panel.Show();
        }

        private void showWeaponButton_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView_ControlPanel_AllData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void showWeaponTypeButton_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView_ControlPanel_Category();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void showWeaponRadiusButton_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView_ControlPanel_Radius();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void summaryWeaponButton_Click(object sender, EventArgs e)
        {
            SummaryWeaponPanel summary_weapon_panel = new SummaryWeaponPanel();
            summary_weapon_panel.Show();
        }

        private void modifyWeaponButton_Click(object sender, EventArgs e)
        {
            ModifyWeaponPanel modify_weapon_panel = new ModifyWeaponPanel();
            modify_weapon_panel.Show();
        }

        private void controlDataGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if(controlDataGridView.CurrentRow.Index != -1)
                {
                    StaticVariable.weaponId = Convert.ToInt32(controlDataGridView.CurrentRow.Cells[0].Value.ToString());
                    StaticVariable.WeaponName_Text = controlDataGridView.CurrentRow.Cells[1].Value.ToString();
                    StaticVariable.Category_Text = controlDataGridView.CurrentRow.Cells[2].Value.ToString();
                    StaticVariable.Ezradius_Text = controlDataGridView.CurrentRow.Cells[3].Value.ToString();
                    StaticVariable.Detail_Text = controlDataGridView.CurrentRow.Cells[4].Value.ToString();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ModifyWeaponPanel modify_weapon_panel = new ModifyWeaponPanel();
                modify_weapon_panel.Show();
            }
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            StaticVariable.weaponId = 0;
        }

        private void controlDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (controlDataGridView.CurrentRow.Index != -1)
                {
                    StaticVariable.weaponId = Convert.ToInt32(controlDataGridView.CurrentRow.Cells[0].Value.ToString());
                    StaticVariable.WeaponName_Text = controlDataGridView.CurrentRow.Cells[1].Value.ToString();
                    StaticVariable.Category_Text = controlDataGridView.CurrentRow.Cells[2].Value.ToString();
                    StaticVariable.Ezradius_Text = controlDataGridView.CurrentRow.Cells[3].Value.ToString();
                    StaticVariable.Detail_Text = controlDataGridView.CurrentRow.Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteWeaponButton_Click(object sender, EventArgs e)
        {
            DeleteWeaponPanel delete_weapon_panel = new DeleteWeaponPanel();
            delete_weapon_panel.Show();
        }
    }
}
