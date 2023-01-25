using System.Windows.Forms;

namespace Serial_Root_Adder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ioTextBox.Focus();
        }

        private void okButton_Click(object sender, System.EventArgs e)
        {
            int input;
            if (int.TryParse(ioTextBox.Text, out input))
                ioTextBox.Text = Utils.Calculate(input).ToString();
            else
                ioTextBox.Text = "";
        }
    }
}
