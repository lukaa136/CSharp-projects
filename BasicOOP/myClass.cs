class User
{
    // properties / fields

    private string password;

    public string Password
    {
        get { return password; }
        set
        {
            try
            {
                if (Validate.PasswordValidator.ValidateAll(value))
                {
                    password = value;
                }
            }
            catch (FormatException ex)
            {
                throw;
            }

        }
    }
    private string name
    { get; set; }

    private string email
    { get; set; }


    // constructors

    public User(string name, string email, string password)
    {
        this.name = name;
        this.email = email;
        this.Password = password;
    }

    //methods

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Email: {email}");
    }

    public bool CheckPassword(string password)
    {
        return this.password == password;
    }

    public void UpdatePassword(string currentPassword, string newPassword)
    {
        bool succeed = false;

        do
        {
            Console.WriteLine("Please enter the current password");

            if (CheckPassword(currentPassword))
            {
                try
                {
                    this.Password = newPassword;
                    succeed = true;
                    Console.WriteLine("Password updated successfully.");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Error updating password: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Incorrect current password, try again.");
            }

        } while (!succeed);

    }


    //auxiliar class
    public static class Validate
    {
        public static class PasswordValidator
        {
            //specific validators
            public static bool Length(string password)
            {
                if (password.Length >= 8)
                    return true;
                throw new FormatException("Your password must be at least 8 character long");
            }

            public static bool HasLower(string password)
            {
                foreach (char c in password)
                {
                    if (char.IsLower(c))
                        return true;
                }
                throw new FormatException("Your password must have a lowercase");
            }

            public static bool HasUpper(string password)
            {
                foreach (char c in password)
                {
                    if (char.IsUpper(c))
                        return true;
                }
                throw new FormatException("Your password must have an uppercase");
            }

            public static bool HasNumb(string password)
            {
                foreach (char c in password)
                {
                    if (char.IsDigit(c))
                        return true;
                }
                throw new FormatException("Your password must have a number");
            }

            //validate all

            public static bool ValidateAll(string password)
            {
                try
                {
                    HasNumb(password);
                    HasLower(password);
                    HasUpper(password);
                    Length(password);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("An error ocurred the process of validate the password");
                    throw;
                }
                return true;
            }
        }
    }
}