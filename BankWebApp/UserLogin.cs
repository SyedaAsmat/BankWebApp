namespace BankWebApp
{
    public class UserLogin
    {
        public string Login(string username, string password)
        {
            string result;
            if(username == "user123" && password == "user@123")
            {
                result = "Login success";
            }
            else
            {
                result = "Login failed";
            }
            return result;
        }
    }
}
