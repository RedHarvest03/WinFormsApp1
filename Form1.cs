namespace WinFormsApp1
{
    public partial class Form1 : Form //bu ona gore 'partial' dirki arxa planda frameworkun classin ishledirik...
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="xiyar" && textBox2.Text == "1234")
            {
                MessageBox.Show("Correct..You Enter Your Profile", "Message");
                
            }
            else if(textBox1.Text != "xiyar" && textBox2.Text == "1234")
            {
                MessageBox.Show("Login Wrong...", "Message");
            }
            else if(textBox1.Text == "xiyar" && textBox2.Text != "1234")
            {
                MessageBox.Show("Pin Wrong...", "Message");
            }
            else
            {
                MessageBox.Show("Please Write Correct!!!", "Message", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            lbl2.Text= e.Location.ToString();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}


//lbl1.Text = textBox1.Text;  //lebel beraberdir text e 'button'u basanda...
////lbl1.Text += textBox1.Text; //eger 'button' basandan sonra label deki silinmesin isteyirsizse '+=' qoymalisiz...
//MessageBox.Show(lbl1.Text);
//MessageBox.Show("Xiyarsan?? Hara silirsen?", "Message", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);