using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX0Tutorial5.Entities
{
    internal class Client
    {
        public string Name { get; private set; }
        private string email;
        private DateTime birthday;

        public Client(string name, string email, DateTime birthday)
        {
            this.Name = name;
            this.email = email;
            this.birthday = birthday;
        }
        public override string ToString()
        {
            return $"\nDados do cliente: " +
                $"\n\tNome: {Name}," +
                $"\n\tEmail: {email}," +
                $"\n\tData de nascimento: {birthday}";
        }
    }
}
