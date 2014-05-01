using System;

namespace Numbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			printinit ();

			string name = getname ();

			int[] numbers = new int[6];
			numbers = unrepeatnum ();
				
			printresult (name,numbers);

		}




		public static void printinit(){
			Console.WriteLine ("**********************************");
			Console.WriteLine ("******** Lottery Numbers *********");
			Console.WriteLine ("**********************************");
			}


		public static string getname(){
			Console.Write ("Enter yout name: ");
			string name = Console.ReadLine ();
			return name;
		}

		public static int[] unrepeatnum(){
			Random random = new Random ();
			int[] numbers = new int[6];
			int index = 0;

			do {			
				int randomNumber = random.Next(1, 46);
				for(int loop=0; loop <= index; loop++)
				{
					if (numbers[index] == randomNumber) {// check repeat
						break;
					}
				}

				if (numbers [index] != randomNumber) {
					numbers[index] = randomNumber;
					index++;
				}
			} while(index < numbers.Length);

			return numbers;

		}

		public static void printresult(string name,int[] numbers){
			Console.Write ("Name : {0}, Numbers : [", name);//print result 
			foreach(int number in numbers)
			{
				Console.Write ("{0} ", number);
			}
			Console.WriteLine ("]");

		}
	}
}
