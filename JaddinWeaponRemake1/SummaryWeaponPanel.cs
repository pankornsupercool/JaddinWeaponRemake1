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
    public partial class SummaryWeaponPanel : Form
    {
        SqlConnection sqlCon = new SqlConnection(ConnectionString.GetConnectionString());

        public SummaryWeaponPanel()
        {
            InitializeComponent();
            Uses();
        }


        void SetSummary()
        {
            int gun_summary = sqlCon.ExecuteScalar<int>("select count (Category) from WeaponDatabasePanel where Category ='Gun'");
            gunSummaryLabel.Text = Convert.ToString(gun_summary);
            int missile_summary = sqlCon.ExecuteScalar<int>("select count (Category) from WeaponDatabasePanel where Category ='Missile'");
            missileSummaryLabel.Text = Convert.ToString(missile_summary);
            totalSummaryLabel.Text = Convert.ToString(gun_summary + missile_summary);
        }

        void Uses()
        {
            try
            {
                SetSummary();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
