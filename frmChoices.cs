namespace Project5Dorse
{
    public partial class frmChoices : Form
    {
        public frmChoices()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRightNumber.Text = string.Empty;
            txtLeftNumber.Text = string.Empty;
            lblMessage.Text = string.Empty;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtRightNumber.Text, out int right) && int.TryParse(txtLeftNumber.Text, out int left))
            {
                if (right > left)
                {
                    lblMessage.Text = "Right number is larger. Good job!";
                }
                else
                {
                    lblMessage.Text = "Right number is not larger, please change the number and make sure the left number is smaller.";
                }
            }
            else
            {
                lblMessage.Text = "Please enter valid numbers.";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
