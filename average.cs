/* this program calculates the average of a set marks
 until the user types "end"*/

using System;

public class Average
{
	
	public static void Main()
	{
		
		double a=0, b, c=0, d;
		string mark;

		Console.Write("Insert a mark: ");
		mark = Console.ReadLine();
				 
		while(mark != "end")
		{  
			b=Convert.ToDouble(mark);
			c++;   //counter of numbers
			a+=b;  // sum of all the notes
			
			Console.Write("Insert a mark: ");
			mark = Console.ReadLine();
		}

		if(c != 0)
		{
			d = a/c;  //calculate the average
			Console.WriteLine("The average is {0}.",d);
		}
		
	}
	
}
