﻿using System;
using System.Collections.Generic;

namespace BA1F
{
	class Program
	{
		public static List<int> skew(string sequence)
		{
			int c = 0;
			int g = 0;
			int min = 0;
			List<int> skewlist = new List<int>();
			int index = 0;
			for (int i = 0; i < sequence.Length; i++)
			{
				index += 1;
				if (sequence.Substring(i, 1) == "C")
					c += 1;
				if (sequence.Substring(i, 1) == "G")
					g += 1;
				int skew = g - c;
				if (skew < min)
				{
					skewlist.Clear();
					skewlist.Add(index);
					min = skew;
				}
				if (skew == min && skewlist.Contains(index) == false)
				{
					skewlist.Add(index);
				}

			}
			return skewlist;




		}
		static void Main(string[] args)
		{
			string s = "CCTATCGGTGGATTAGCATGTCCCTGTACGTTTCGCCGCGAACTAGTTCACACGGCTTGATGGCAAATGGTTTTTCCGGCGACCGTAATCGTCCACCGAG";
			List<int> rj = skew(s);
			foreach (int r in rj)
			{
				Console.WriteLine(r + " ");
			}
			Console.WriteLine("kraj");
		}

	} 
}