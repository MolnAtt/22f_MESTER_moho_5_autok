using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22f_MESTER_moho_5_autok
{
	internal class Program
	{
		class Benzinkut
		{
			public int tav;
			public int benzin;
			public Benzinkut(int tav, int benzin) 
			{
				this.tav = tav;
				this.benzin = benzin;
			}
		}

		static (int, int, int, List<Benzinkut>) Beolvas()
		{
			List<Benzinkut> benzinkutak = new List<Benzinkut>();
			string[] elso = Console.ReadLine().Split(' ');
			for (int i = 0; i < int.Parse(elso[1]); i++)
			{
				string[] sor = Console.ReadLine().Split(' ');
				benzinkutak.Add(new Benzinkut(int.Parse(sor[0]), int.Parse(sor[1])));
			}
			return (int.Parse(elso[0]), int.Parse(elso[2]), int.Parse(elso[3]), benzinkutak);
		}


		static int Feldolgoz(int K, int B, int L, List<Benzinkut> benzinkutak)
		{
			throw new NotImplementedException();
		}

		static void Main(string[] args)
		{
			(int K, int B, int L, List<Benzinkut> benzinkutak) = Beolvas();
			Console.WriteLine(Feldolgoz(K, B, L, benzinkutak));
		}


	}
}
