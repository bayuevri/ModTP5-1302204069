using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_1302204069
{
    internal class SayaTubeVideo
    {
		private int id;
		private string title;
		private int playCount;

		// Deklarasi konstruktor dengan title
		public SayaTubeVideo(string title)
		{
			SetTitle(title);
			this.id = new Random().Next(10000, 99999);
			this.playCount = 0;
		}

		public void SetTitle(string title)
		{
			if (title == null) return;
			if (title.Length > 100) return;

			this.title = title;
		}

		// Tambahkan playCount dengan parameter add
		public void IncreasePlayCount(int add)
		{
			if (add > 10000000) return;

			try
			{
				this.playCount = checked(this.playCount + add);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		// Tampilkan informasi video
		public void PrintVideoDetails()
		{
			Console.WriteLine("Id: " + id + ", Title: " + title + ", Play: " + playCount);
		}
	}
}
