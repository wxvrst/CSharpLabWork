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
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("First name was not entered");
            }
            if(textBox2.Text.Length == 0)
            {
                MessageBox.Show("last name was not entered");
            }
            if(textBox3.Text.Length == 0)
            {
                MessageBox.Show("Middle name was not entered");
            }
            if(comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Group was not chosen");
            }
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Complexity was not chosen");
            }

            Form2 tf = new Form2(
                textBox1.Text + " " + textBox2.Text + " " + textBox3.Text,
                comboBox1.Text,
                numericUpDown1.Value,
                radioButton1.Checked
                ) ;
            tf.ShowDialog();
        }
    }
}