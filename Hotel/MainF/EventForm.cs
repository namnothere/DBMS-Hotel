using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
        }
        STATISTIC StatisticSQL = new STATISTIC();
        private void EventForm_Load(object sender, EventArgs e)
        {
            try
            {
                dgvEvent.DataSource = StatisticSQL.GetAllEvent();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Toang", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                dgvEvent.DataSource = StatisticSQL.GetEvent(dtpFrom.Value, dtpTo.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Toang", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
