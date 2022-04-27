namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

        }

        private void tbsum_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            int num1, num2, num3, num4, sum;
            num1 = Convert.ToInt32(tbno1.Text);
            num2 = Convert.ToInt32(tbno2.Text);
            num3 = Convert.ToInt32(tbno3.Text);
            num4 = Convert.ToInt32(tb4.Text);


            sum = num1 + num2 + num3 - num4;
            tbsum.Text = " " + sum;
        }
    }
}