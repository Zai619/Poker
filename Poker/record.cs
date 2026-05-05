using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker
{
    public partial class record : Form
    {
        public record(System.Data.DataTable dt)
        {
            InitializeComponent();
            this.dgvRecord.DataSource = dt;
            this.dgvRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
