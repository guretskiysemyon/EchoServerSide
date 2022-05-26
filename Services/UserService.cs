using Repository;
using System.Text.Json.Nodes;
using Domain;

namespace Services {
    public class UserService
    {
        ContextData _context;
        public UserService(ContextData cd)
        {
            _context = cd;
        }

        public bool userValidation(JsonObject data)
        {
            if (data == null
                || !data.ContainsKey("username")
                || !data.ContainsKey("password"))
                return false;
            string username = data["username"].ToString();
            string password = data["password"].ToString();
            return _context.userValidation(username, password);
        }
        public List<User> Data()
        {
            return _context.Data();
        }
        public void addUser(JsonObject user)
        {
            User newUser = new User()
            {
                Username = user["username"].ToString(),
                Nickname = user["name"].ToString(),
                Password = user["password"].ToString(),
                contacts = new List<Contact>()
            };
            _context.addUser(newUser);

        }
    }
}
