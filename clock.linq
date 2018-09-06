<Query Kind="Program" />

void Main()
{
//	var ბლოკი_მარცხნივ = new Block() { Type = 17, Location = "მარცხნივ" };
//	var ბლოკი_მარჯვნივ = new Block() { Type = 19, Location = "მარჯვნივ" };
//
//	ბლოკი_მარცხნივ.Dump();
//	ბლოკი_მარჯვნივ.Dump();

	var clock = new Clock() { Hour = 0, Minute = 0, Second = 0 };
	clock.Dump();

	clock.SetTime(23, 58, 8);
	clock.Dump();

	clock.Start();
		
//	var dc = new DigitalClock();
//	var ac = new AnalogClock();

//	dc.Dump();
//	ac.Dump();
}

//სიგრძე, სიგანე, სიმაღლე
//ფერი, წონა

//სახეობა - 17, 19

//public class Block
//{
//	public int Type { get; set; }
//	public string Location { get; set; }
//}

//public class AnalogClock : Clock
//{
//	public bool IsMechanic { get; set; }
//}
//
//public class DigitalClock : Clock
//{
//	public string DisplayType { get; set; }
//}


public class Clock
{
	public int Hour { get; set; }
	public int Minute { get; set; }
	public int Second { get; set; }

	public void SetTime(int hour, int minute, int second)
	{
		SetTimeInternal(hour, minute, second);
	}

	private void SetTimeInternal(int hour, int minute, int second)
	{
		Hour = hour;
		Minute = minute;
		Second = second;
	}

	public void Start()
	{


		while (true) 
		{
		if (Second <= 59)
		

			Second = Second + 1;
			this.Dump();
			Thread.Sleep(1000);
			if (Second == 60)
			{
				Minute = Minute + 1;
				Second = 0;
				
			}
			if (Minute==60)
			{
				Hour = Hour + 1;
				Minute = 0;
				
			}
			if (Hour==24)
			{
				Hour = 0;
				continue;
			}
					
		
		
			
		
		
		
		
		{
			
			
			
		}
			}
			
		}
		
	}
	public void Stop()
	{
	}
		
	

