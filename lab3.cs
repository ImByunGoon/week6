using System;

namespace mirrorword
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Enter a word:");
			string word = Console.ReadLine ();

			int word_length = word.Length;

		
			int count = 0;
			bool result=check_pali (word_length,count,word);


			if (result == true) {
				Console.WriteLine ("it is pali_word!");
			} else {
				Console.WriteLine ("it isn't pali_word!");
			}
		
		}

		public static bool check_pali (int word_length, int count, string word)
		{

			if (count == word_length / 2) {

					return true;
				} 

				if (word [0 + count] == word [word_length - count - 1]) {
					return check_pali (word_length, count + 1, word);
				} else {
					return false;
				}
			}

		}
	}
	