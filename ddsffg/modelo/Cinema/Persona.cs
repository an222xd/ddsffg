using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddsffg.modelo.Cinema
{
	public abstract class Persona
	{
		protected int id;
		protected string nombre;
		protected string domicilio;
		protected string email;
		protected string usuario;
		protected string password;
		//constructor defauld
		public Persona()
		{
			nombre = "Juanito Perez Rodriguez";

		}

		public Persona(string nombre1)
		{
			nombre = nombre1;
		}

		public Persona(int id1, string nombre1, string domisilio, string email1 , string usuario1 , string password1)
		{
			id = id1;
			nombre = nombre1;
			domicilio = domisilio;
			email = email1;
			usuario = usuario1;
			password = password1;
		}

		public int Id
		{
			get
			{
				return id;
			}
			set
			{
				if (value > 0)
					id = value;
			}
		}

		public string Nombre
		{
			get
			{
				return nombre;
			}
			set
			{
				if (value != null || (value.Length >= 3 && value.Length <= 30))
				{
					this.nombre = value;
				}
			}
		}

		public string Domicilio
		{
			get
			{
				return domicilio;
			}
			set
			{
				if (value != null || value.Length > 0)
					this.domicilio = value;
			}
		}

		public string Email
		{
			get
			{
				return email;
			}
			set
			{
				if (value != null || value.Length > 0)
					this.email = value;
			}
		}

		public string Usuario
		{
			get
			{
				return usuario;
			}
			set
			{
				if (value != null || value.Length > 0)
					this.usuario = value;
			}
		}

		public string Password
		{
			get
			{
				return password;
			}
			set
			{
				if (value != null || value.Length > 0)
					this.password = value;
			}
		}
		public override string ToString()
		{
			return "Id" + id + "|Nombre" + nombre + "|Domicilio" + domicilio + "|Email" + email + "|Usuario" + usuario + "|Password" + password;
		}
	}
}
