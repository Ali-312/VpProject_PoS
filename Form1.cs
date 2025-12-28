namespace VpProject_PoS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Basic validation check
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Example hardcoded credentials
            if (username == "admin" && password == "1234")
            {

                //MessageBox.Show("Login Successful! Welcome to Arian's Cafeteria.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                PoS_System posSystem = new PoS_System();
                posSystem.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
