using System;
namespace ProyectoFinal.Models
{
	public class User
	{

		private int id;
        private string name;
        private string lastName;
        private string userName;
        private string password;
        private string email;

        public User(int id, string name, string lastName, string userName, string password, string email)
        {
	        this.id = id;
	        this.name = name;
	        this.lastName = lastName;
	        this.userName = userName;
	        this.password = password;
	        this.email = email;
        }

        public int Id
        {
	        get => id;
	        set => id = value;
        }

        public string Name
        {
	        get => name;
	        set => name = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string LastName
        {
	        get => lastName;
	        set => lastName = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string UserName
        {
	        get => userName;
	        set => userName = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Password
        {
	        get => password;
	        set => password = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Email
        {
	        get => email;
	        set => email = value ?? throw new ArgumentNullException(nameof(value));
        }
	}
}

