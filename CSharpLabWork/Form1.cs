namespace CSharpLabWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //data entry validation
            bool condition = true;
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("First name was not entered");
                condition = false;
            }
            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("last name was not entered");
                condition = false;
            }
            if (textBox3.Text.Length == 0)
            {
                MessageBox.Show("Middle name was not entered");
                condition = false;
            }
            if (comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Group was not chosen");
                condition = false;
            }
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Complexity was not chosen");
                condition = false;
            }
            if (condition)
            {
                Form2 tf = new Form2(
                    textBox1.Text + " " + textBox2.Text + " " + textBox3.Text,
                    comboBox1.Text,
                    numericUpDown1.Value,
                    radioButton1.Checked
                    );
                tf.ShowDialog();
            }
        }
    }
}
