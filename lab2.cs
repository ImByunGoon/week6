using System;

namespace Drawing
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			halftriangle (3,1,'*');
			halftriangle (4,2,'#');
			halftriangle (5,4,'%');


		}
		public static void halftriangle(int num,int width,char simbol){
			for (int outer = 1; outer <=num; outer++) {
				for (int inner = 1; inner <= outer*width; inner++) {
					Console.Write ("{0}",simbol);
				}
				Console.WriteLine ();
			}
			Console.WriteLine ();
		}
	}
}
