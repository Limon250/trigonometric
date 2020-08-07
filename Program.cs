using System;
using System.Threading;
using System.Diagnostics;

namespace trigonometric
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose a type of value: ");
			Thread.Sleep(800);
            Console.WriteLine("sin, cos, tan or ctg");
	    	string type = Console.ReadLine();
			Thread.Sleep(800);

	    	if (type == "sin")
	    	{
	    		Console.WriteLine("Input a value of sin:");
				Thread.Sleep(800);
    			Console.WriteLine("0, 30, 45, 60, 90, 120, 135, 150, 180, 210, 225, 240, 270, 300, 315, 330, 360");
				Thread.Sleep(800);
				Console.WriteLine("0, pi/6, pi/4, pi/3, pi/2, 2pi/3, 3pi/4, 5pi/6, pi, 7pi/6, 5pi/4, 4pi/3, 3pi/2, 5pi/3, 7pi/4, 11pi/6, 2pi");
				string type_sin = Console.ReadLine();

				if (type_sin == "0") 
				{
					Console.WriteLine("sin 0 = 0");
				}
				else if (type_sin == "30" || type_sin == "pi/6") 
				{
					Console.WriteLine("sin 30 = 1/2");
				}
				else if (type_sin == "45" || type_sin == "pi/4")
				{
					Console.WriteLine("sin 45 = v2/2");
				}
				else if (type_sin == "60" || type_sin == "pi/3")
				{
					Console.WriteLine("sin 60 = v3/2");
				}
				else if (type_sin == "90" || type_sin == "pi/2")
				{
					Console.WriteLine("sin 90 = 1");
				}
				else if (type_sin == "120" || type_sin == "2pi/3") 
				{
					Console.WriteLine("sin 120 = v3/2");
				}
				else if (type_sin == "135" || type_sin == "3pi/4")
				{
					Console.WriteLine("sin 135 = v2/2");
				}
				else if (type_sin == "150" || type_sin == "5pi/6")
				{
					Console.WriteLine("sin 150 = 1/2");
				}
				else if (type_sin == "180" || type_sin == "pi")
				{
					Console.WriteLine("sin 180 = 0");
				}
				else if (type_sin == "210" || type_sin == "7pi/6" )
				{
					Console.WriteLine("sin 210 = -1/2");
				}
				else if (type_sin == "225" || type_sin == "5pi/4")
				{
					Console.WriteLine("sin 225 = -v2/2");
				}
				else if (type_sin == "240" || type_sin == "4pi/3")
				{
					Console.WriteLine("sin 240 = -v3/2");
				}
				else if (type_sin == "270" || type_sin == "3pi/2")
				{
					Console.WriteLine("sin 270 = -1");
				}
				else if (type_sin == "300" || type_sin == "5pi/3")
				{
					Console.WriteLine("sin 300 = -√3/2");
				}
				else if (type_sin == "315" || type_sin == "7pi/4")
				{
					Console.WriteLine("sin 315 == -√2/2");
				}
				else if (type_sin == "330" || type_sin == "11pi/6")
				{
					Console.WriteLine("sin 330 = -1/2");
				}
				else if (type_sin == "360" || type_sin == "2pi")
				{
					Console.WriteLine("sin 360 = 0");
				}
				else
				{
					CloseProgram(new Action(delegate
					{
						Console.WriteLine("Not available value! Exit.");
						Thread.Sleep(2000);
					}));
				}
    		}

	    	else if (type == "cos")
	    	{
	    		Console.WriteLine("Input a value of cos:");
				Thread.Sleep(800);
    			Console.WriteLine("0, 30, 45, 60, 90, 120, 135, 150, 180, 210, 225, 240, 270, 300, 315, 330, 360");
				Thread.Sleep(800);
				Console.WriteLine("0, pi/6, pi/4, pi/3, pi/2, pi, 2pi/3, 3pi/4, 5pi/6, pi, 7pi/6, 5pi/4, 4pi/3, 3pi/2, 5pi/3, 7pi/4, 11pi/6, 2pi");
				string type_cos = Console.ReadLine();
				Thread.Sleep(800);

				if (type_cos == "0")
				{
					Console.WriteLine("cos 0 = 1");
				}
				else if (type_cos == "30" || type_cos == "pi/6")
				{
					Console.WriteLine("cos 30 = √3/2");
				}
				else if (type_cos == "45" || type_cos == "pi/4")
				{
					Console.WriteLine("cos 45 = v2/2");
				}
				else if (type_cos == "60" || type_cos == "pi/3")
				{
					Console.WriteLine("cos 60 = 1/2");
				}
				else if (type_cos == "90" || type_cos == "pi/2")
				{
					Console.WriteLine("cos 90 = 0");
				}
				else if (type_cos == "120" || type_cos == "2pi/3")
				{
					Console.WriteLine("cos 120 = -1/2");
				}
				else if (type_cos == "135" || type_cos == "3pi/4")
				{
					Console.WriteLine("cos 135 = -v2/2");
				}
				else if (type_cos == "150" || type_cos == "5pi/6")
				{
					Console.WriteLine("cos 150 = -√3/2");
				}
				else if (type_cos == "180" || type_cos == "pi")
				{
					Console.WriteLine("cos 180 = -1");
				}
				else if (type_cos == "210" || type_cos == "7pi/6")
				{
					Console.WriteLine("cos 210 = -√3/2");
				}
				else if (type_cos == "225" || type_cos == "5pi/4")
				{
					Console.WriteLine("cos 225 = -v2/2");
				}
				else if (type_cos == "240" || type_cos == "4pi/3")
				{
					Console.WriteLine("cos 240 = -1/2");
				}
				else if (type_cos == "270" || type_cos == "3pi/2")
				{
					Console.WriteLine("cos 270 = 0");
				}
				else if (type_cos == "300" || type_cos == "5pi/3")
				{
					Console.WriteLine("cos 300 = 1/2");
				}
				else if (type_cos == "315" || type_cos == "7pi/4")
				{
					Console.WriteLine("cos 315 = √2/2");
				}
				else if (type_cos == "330" || type_cos == "11pi/6")
				{
					Console.WriteLine("cos 330 = √3/2");
				}
				else if (type_cos == "360" || type_cos == "2pi")
				{
					Console.WriteLine("cos 360 = 0");
				}
				else
				{
					CloseProgram(new Action(delegate{
						Console.WriteLine("Not available value! Exit.");
						Thread.Sleep(2000);
					}));
				}
	    	}

	    	else if (type == "tan") 
	    	{
	    		Console.WriteLine("Input a value of tan:");
				Thread.Sleep(800);
    			Console.WriteLine("0, 30, 45, 60, 90, 120, 135, 150, 180, 210, 225, 240, 270, 300, 315, 330, 360");
				Thread.Sleep(800);
				Console.WriteLine("0, pi/6, pi/4, pi/3, pi/2, pi, 2pi/3, 3pi/4, 5pi/6, pi, 7pi/6, 5pi/4, 4pi/3, 3pi/2, 5pi/3, 7pi/4, 11pi/6, 2pi");
				string type_tan = Console.ReadLine();
				Thread.Sleep(800);

				if (type_tan == "0")
				{
					Console.WriteLine("tan 0 = 0");
				}
				else if (type_tan == "30" || type_tan == "pi/6")
				{
					Console.WriteLine("tan 30 = 1/√3");
				}
				else if (type_tan == "45" || type_tan == "pi/4")
				{
					Console.WriteLine("tan 45 = 1");
				}
				else if (type_tan == "60" || type_tan == "pi/3")
				{
					Console.WriteLine("tan 60 = √3");
				}
				else if (type_tan == "90" || type_tan == "pi/2")
				{
					Console.WriteLine("Not value!");
				}
				else if (type_tan == "120" || type_tan == "2pi/3")
				{
					Console.WriteLine("tan 120 = -√3");
				}
				else if (type_tan == "135" || type_tan == "3pi/4")
				{
					Console.WriteLine("tan 135 = -1");
				}
				else if (type_tan == "150" || type_tan == "5pi/6")
				{
					Console.WriteLine("tan 150 = -1/√3");
				}
				else if (type_tan == "180" || type_tan == "pi")
				{
					Console.WriteLine("tan 180 = 0");
				}
				else if (type_tan == "210" || type_tan == "7pi/6")
				{
					Console.WriteLine("tan 210 = 1/√3");
				}
				else if (type_tan == "225" || type_tan == "5pi/4")
				{
					Console.WriteLine("tan 225 = 1");
				}
				else if (type_tan == "240" || type_tan == "4pi/3")
				{
					Console.WriteLine("tan 240 = √3");
				}
				else if (type_tan == "270" || type_tan == "3pi/2")
				{
					Console.WriteLine("Not value!");
				}
				else if (type_tan == "300" || type_tan == "5pi/3")
				{
					Console.WriteLine("-√3");
				}
				else if (type_tan == "315" || type_tan == "7pi/4")
				{
					Console.WriteLine("tan 315 = -1");
				}
				else if (type_tan == "330" || type_tan == "11pi/6")
				{
					Console.WriteLine("tan 330 = -1/√3");
				}
				else if (type_tan == "360" || type_tan == "2pi")
				{
					Console.WriteLine("tan 360 = 0");
				}
				else
				{
					CloseProgram(new Action(delegate
					{
						Console.WriteLine("Not available value! Exit.");
						Thread.Sleep(2000);
					}));
				}


	    	}

	    	else if (type == "ctg")
	    	{
	    		Console.WriteLine("Input a value of ctg:");
				Thread.Sleep(800);
    			Console.WriteLine("0, 30, 45, 60, 90, 120, 135, 150, 180, 210, 225, 240, 270, 300, 315, 330, 360");
	    		Thread.Sleep(800);
				Console.WriteLine("0, pi/6, pi/4, pi/3, pi/2, pi, 2pi/3, 3pi/4, 5pi/6, pi, 7pi/6, 5pi/4, 4pi/3, 3pi/2, 5pi/3, 7pi/4, 11pi/6, 2pi");
				string type_ctg = Console.ReadLine();
				Thread.Sleep(800);

				if (type_ctg == "0")
				{
					Console.WriteLine("Not values.");
				}
				else if (type_ctg == "30")
				{
					Console.WriteLine("ctg 30 = √3" || type_tan == "pi/6");
				}
				else if (type_ctg == "45" || type_tan == "pi/4")
				{
					Console.WriteLine("ctg 45 = 1");
				}
				else if (type_ctg == "60" || type_tan == "pi/3")
				{
					Console.WriteLine("ctg 60 = 1/√3");
				}
				else if (type_ctg == "90" || type_tan == "pi/2")
				{
					Console.WriteLine("0");
				}
				else if (type_ctg == "120" || type_tan == "2pi/3")
				{
					Console.WriteLine("ctg 120 = -1/√3");
				}
				else if (type_ctg == "135" || type_tan == "3pi/4")
				{
					Console.WriteLine("ctg 135 = -1");
				}
				else if (type_ctg == "150" || type_tan == "5pi/6")
				{
					Console.WriteLine("ctg 150 = -√3");
				}
				else if (type_ctg == "180" || type_tan == "pi")
				{
					Console.WriteLine("Not value!");
				}
				else if (type_ctg == "210" || type_tan == "7pi/6")
				{
					Console.WriteLine("ctg 210 = √3");
				}
				else if (type_ctg == "225" || type_tan == "5pi/4")
				{
					Console.WriteLine("ctg 225 = 1");
				}
				else if (type_ctg == "240" || type_tan == "4pi/3")
				{
					Console.WriteLine("ctg 240 = 1/√3");
				}
				else if (type_ctg == "270" || type_tan == "3pi/2")
				{
					Console.WriteLine("0");
				}
				else if (type_ctg == "300" || type_tan == "5pi/3")
				{
					Console.WriteLine("ctg -1/√3");
				}
				else if (type_ctg == "315" || type_tan == "7pi/4")
				{
					Console.WriteLine("ctg 315 = -1");
				}
				else if (type_ctg == "330" || type_tan == "11pi/6")
				{
					Console.WriteLine("ctg 330 = -√3");
				}
				else if (type_ctg == "360"  || type_tan == "2pi")
				{
					Console.WriteLine("Not value!");
				}
				else
				{
					CloseProgram(new Action(delegate
					{
						Console.WriteLine("Not available values! Exit.");
						Thread.Sleep(2000);
					}));
				}
			}

	    	else 
	    	{
	    		CloseProgram(new Action(delegate
				{
					Console.WriteLine("Not available value! Exit.");
					Thread.Sleep(2000);
				}));
	    	}
	    }
        public static void CloseProgram() => Process.GetCurrentProcess().Kill();
        public static void CloseProgram(Action actionBeforeClosing)
		{
			actionBeforeClosing();
			CloseProgram();
		}
    }
}
