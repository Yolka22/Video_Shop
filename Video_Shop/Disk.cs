using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Shop
{
    internal class Disk
    {

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string regicer;

		public string Regicer
		{
			get { return regicer; }
			set { regicer = value; }
		}

		private string ganre;

		public string Ganre
        {
			get { return ganre; }
			set { ganre = value; }
		}


		private double rating;

		public double Rating
        {
			get { return rating; }
			set { rating = value; }
		}


		private double cost;

		public double Cost
		{
			get { return cost; }
			set { cost = value; }
		}



	}
}
