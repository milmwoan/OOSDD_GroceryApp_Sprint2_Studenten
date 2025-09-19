
namespace Grocery.Core.Models
{
    public partial class Client : Model
    {
        public string _emailAddress { get; set; }
        public string _password { get; set; }
        public int _id { get; set; }
        public Client(int id, string name, string emailAddress, string password) : base(id, name)
        {
            _emailAddress=emailAddress;
            _password=password;
            _id = id;
        }
    }
}
