namespace BMUdata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adsoyad = textBox1.Text;
            string telebenomresi = maskedTextBox7.Text;

            double sdf1 = Convert.ToDouble(maskedTextBox1.Text);
            double sdf2 = Convert.ToDouble(maskedTextBox2.Text);
            double sdf3 = Convert.ToDouble(maskedTextBox3.Text);
            double seminar = Convert.ToDouble(maskedTextBox4.Text);
            double final = Convert.ToDouble(maskedTextBox5.Text);
            double netice = (sdf1 + sdf2 + sdf3 + seminar + final) / 5;

            dataGridView1.Rows.Add(adsoyad, telebenomresi, netice.ToString("0.00"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            maskedTextBox7.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
            maskedTextBox4.Clear();
            maskedTextBox5.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
