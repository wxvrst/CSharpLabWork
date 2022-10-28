using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLabWork
{
    public partial class Form2 : Form
    {
        public Form2(string p1, string p2, decimal p3, bool p4)
        {
            InitializeComponent(); 
            Random rnd = new Random();
            label1.Text = $"Pupil: {p1}    Group: {p2}";
            int n = Convert.ToInt32(p3);
            tableLayoutPanel1.RowCount = n;
            for (int i = 0; i < n; i++)
            {
                tableLayoutPanel1.Controls.Add(new TextBox() { Text = $"Some simple task #{i}", Dock = DockStyle.Fill, ReadOnly = true }, 0, i + 1);
                if (p4)
                {
                    tableLayoutPanel1.Controls.Add(new CheckBox() { Text = $"Some simple answer #{i}", Dock = DockStyle.Fill }, 1, i + 1);
                }
                else
                {
                    ComboBox cb = new ComboBox();
                    cb.Dock = DockStyle.Fill;
                    for (int j = 0; j < 6; j++)
                    {
                        cb.Items.Add(rnd.Next(12));
                    }
                    tableLayoutPanel1.Controls.Add(cb, 1, i + 1);
                }
            }
        }
    }
}
