namespace My_Time_Table
{
    public partial class Login : Form
    {
        private string email, password;

        // Constructor
        public Login()
        {
            InitializeComponent();
        }

        // Hit "Close" Button
        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        // Get "email" & "password"
        private void getEmailPassword()
        {
            email = emailInput.Text;
            password = passwordInput.Text;
        }

        // Check email
        private bool IsValidEmail()
        {
            bool valid = AccountChecker.IsValidEmail(email);

            if (!valid)
                MessageBox.Show("Invalid email id", "Account Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return valid;
        }

        // Check password
        private bool IsValidPassword()
        {
            bool valid = AccountChecker.IsValidPassword(password);

            if (!valid)
            {
                string message = "Invalid password!";

                // If the passord is null or empty
                if (String.IsNullOrEmpty(password) || String.IsNullOrWhiteSpace(password))
                    message += " It can't be null or empty.";

                // If length of the password is less than 8
                if (password.Length < 8)
                    message += " It must have at least 8 characters length.";

                MessageBox.Show(message, "Account Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return valid;
        }

        // Perform Log-in
        private void LogIn()
        {
            // Check email
            if (!IsValidEmail() || !IsValidPassword())
                return;

            // Login - Pass
            MessageBox.Show("Logging...");
        }

        // Perform Sign-in
        private void SignIn()
        {
            // Check email
            if (!IsValidEmail() || !IsValidPassword())
                return;

            // Signin - Pass
            MessageBox.Show("Signing...");
        }

        // Hit Login button
        private void loginButton_Click(object sender, EventArgs e)
        {
            // Get the email and password
            getEmailPassword();

            // Log-in the user
            LogIn();
        }

        // Hit Signin button
        private void signinButton_Click(object sender, EventArgs e)
        {
            // Get the email and password
            getEmailPassword();

            // Sign-in the user
            SignIn();
        }
    }
}
