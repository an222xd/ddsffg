using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddsffg.modelo.Cinema
{
	class Sala
	{
		private int id;
		private string nombre;
		private int capasidad;

		public Sala()
		{

		}

		public Sala(int cap)
		{
			capasidad = cap;
		}

		public Sala(int cap , string nom)
		{
			capasidad = cap;
			nombre = nom;
		}
		public int Id { get {return id; } set {id = value; } }
		public string Nombre { get {return nombre; } set {nombre = value; } }
		public int Capacidad { get { return capasidad; } set {capasidad = value; } }

		public override string ToString()
		{
			return "Id" + id + "|Nombre" + nombre + "|Capacidad" + capasidad;
		}
	}
}
