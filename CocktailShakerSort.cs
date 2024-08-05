class CocktailShakerSortAscending
{
	static void Main(string[] args)
	{
		int startPt = 0;
		string s = Console.ReadLine();

		Stopwatch sw = Stopwatch.StartNew();

		//int[] result = input.Split(',')
		//												.Select(int.Parse)
		//												.ToArray();

		int len = s.Length;
		int endPt = len-1;
		int m = startPt;
		int n = endPt;
		int compCounter = 0;
		char[] charList = s.ToCharArray();
		int i = 0;
		while (i < n + 1)	
		{
			char curNum = charList[m];
			for (int f = m; f < n + 1; f++)
			{
				if (f + 2 <= len)
				{
					compCounter++;
					char nextNum = charList[f + 1];
					if (i % 2 == 0)
					{
						if (curNum >= nextNum)
						{
							curNum = charList[f];
							charList[f] = nextNum;
							charList[f + 1] = curNum;
						}
						else
						{
							curNum = nextNum;
						}
					}
					else
					{
						if (curNum >= nextNum)
						{
							curNum = nextNum;
						}
						else
						{
							curNum = charList[f];
							charList[f] = nextNum;
							charList[f + 1] = curNum;
						}
					}
				}
				else
				{
					break;
				}
			}
			if (i % 2 == 0)
			{
				m++;
				n = n;
			} 
			else 
			{
				m = m;
				n--;
			}
			i++;
			Array.Reverse(charList);	
		}
		if (charList[len-1] < charList[0])
		{
			Array.Reverse(charList);
		}
		  string finalOrder = new string(charList);
			Console.WriteLine(finalOrder);
			Console.WriteLine(compCounter.ToString());
		sw.Stop();
		Console.WriteLine("Time taken: {0}ms", sw.Elapsed.TotalMilliseconds);
	}
}
