/* this program calculates how many numbers of 1,2,3
 or more digits are entered by the user until he/she
 types "end"*/
 
using System;

class digits
{
	
	static void Main()
	{
	 
		int a = 0, b = 0, c = 0, d = 0;
		string number;
     
		Console.Write("Insert a number: ");
		number = Console.ReadLine();
		
		while(number !="end")
		{
			int input = Convert.ToInt32(number);
			
			if(input != 0)
			{
				if(input/10 == 0)
				{
					a++;  // it only has one digit
				}
				
				else if (input/100 == 0)
				{
					b++;  // the number has 2 digits
				}
				
				else if (input/1000 == 0)
				{
					c++;  // the number has 3 digits
				}
				else
				{
					d++;  // the number has more than 3 digits
				}
			
				number = Console.ReadLine();
			}
		}
		
		Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", a, b, c, d); 
	}
	
}

