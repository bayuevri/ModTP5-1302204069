

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_1302204069
{
    internal class Program
    {
        static void Main(string[] args)
        {
			// Demo class SayaTubeVideo
			SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – bayu evri saputra");
			video.IncreasePlayCount(7230);
			video.PrintVideoDetails();

			// Test title video di set null
			video.SetTitle(null);

			// Test IncreasePlayCount 10.000.000
			video.IncreasePlayCount(10000001);
			video.PrintVideoDetails();

			// Test untuk jika kapasitas variabel melebihi batas
			for (int i = 0; i < 218; i++)
			{
				video.IncreasePlayCount(9999999);
			}
			video.PrintVideoDetails();
		}
    }
}
