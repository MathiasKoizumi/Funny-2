using IrrKlang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public class Form1 : Form
	{
		private int abli = 3000;

		private Jingo bob;

		private List<Afmagt> bollemælk;

		private ISoundEngine bootMeUp;

		private Button button1;

		private Button button2;

		private int cola;

		private ComboBox comboBox1;

		private IContainer components;

		public int cula = 200;

		private string currentMp3 = "Math.mp3";

		public Form1 formular;

		public Graphics gfx;

		private int ibli = 100;

		private bool infinity = true;

		public Random junkie = new Random();

		private BolleHeaven kukur;

		private Assembly myAssembly = Assembly.GetExecutingAssembly();

		private Stream myStream;

		private Panel panel1;

		private string[] resourse = new string[17];

		private double scale = 1.0;

		private string sprach = "Jongonese";

		private Random time = new Random();

		public System.Timers.Timer timer1;

		public bool timer1IsRunning;

		public System.Timers.Timer timer2;

		public bool timer2IsRunning;

		private int tookie = 1000;

		private Jongo trælle;

		private int typeShowUp = 2;

		public Form1()
		{
			InitializeComponent();
			panel1.BackColor = Color.DarkRed;
			unpackSound();
			bootMeUp = new ISoundEngine();
			gfx = panel1.CreateGraphics();
			timer1 = new System.Timers.Timer(8000.0);
			timer1.AutoReset = false;
			timer1.Elapsed += timer1_Elapsed;
			timer2 = new System.Timers.Timer(30000.0);
			timer2.AutoReset = false;
			timer2.Elapsed += timer2_Elapsed;
			timer2.Start();
			myStream = myAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.Elsestænder.jpg");
			kukur = new BolleHeaven(this);
			sprach = "Jongonese";
			nameCalling();
		}

		public void avoidCollisionLabel(Label l, Label j)
		{
			if (l.Location.Y > j.Location.Y && l.Location.Y - j.Location.Y < 30)
			{
				moveLabel(j, junkie);
				avoidCollisionLabel(l, j);
			}
			if (l.Location.Y < j.Location.Y && j.Location.Y - l.Location.Y < 30)
			{
				moveLabel(j, junkie);
				avoidCollisionLabel(l, j);
			}
		}

		public void beregnPosition(Point k, int speed)
		{
		}

		internal void BlackHoleoneTwothousand(int p, Rectangle area)
		{
			int num = junkie.Next(area.Left, area.Left + area.Width);
			int num2 = junkie.Next(area.Top, area.Top + area.Height);
			Color color;
			switch (junkie.Next(5))
			{
			case 0:
				color = Color.FromArgb(2, Color.Red);
				break;
			case 1:
				color = Color.FromArgb(2, Color.SeaGreen);
				break;
			case 2:
				color = Color.FromArgb(2, Color.Yellow);
				break;
			case 3:
				color = Color.FromArgb(2, Color.Brown);
				break;
			case 4:
				color = Color.FromArgb(2, Color.DarkGreen);
				break;
			default:
				color = Color.FromArgb(2, Color.Red);
				break;
			}
			for (int i = 0; i < p; i++)
			{
				gfx.FillEllipse(new SolidBrush(color), new Rectangle(junkie.Next(50) - junkie.Next(50) + num, junkie.Next(50) - junkie.Next(50) + num2, junkie.Next(400) + 300, junkie.Next(400) + 300));
			}
		}

		internal void BlackStrangeCloud(int p)
		{
			for (int i = 0; i < 15; i++)
			{
				if (gfx != null)
				{
					gfx.FillEllipse(new SolidBrush(Color.FromArgb(junkie.Next(7) + 5, junkie.Next(20), junkie.Next(20), junkie.Next(20))), new Rectangle(junkie.Next(700) - junkie.Next(700) + base.ClientSize.Width / 2 - 100, junkie.Next(700) - junkie.Next(700) + base.ClientSize.Height / 2 - 200, junkie.Next(400) + 400, junkie.Next(400) + 400));
				}
			}
		}

		internal void BlackStrangeSpellOut(int p)
		{
			for (int i = 0; i < 50; i++)
			{
				if (gfx != null)
				{
					gfx.FillEllipse(new SolidBrush(Color.FromArgb(junkie.Next(7) + 15, junkie.Next(20), junkie.Next(20), junkie.Next(20))), new Rectangle(junkie.Next(200) - junkie.Next(200) + base.ClientSize.Width / 2 - 500, junkie.Next(200) - junkie.Next(200) + base.ClientSize.Height / 2 - 400, junkie.Next(500) + 500, junkie.Next(500) + 500));
				}
			}
			if (kukur == null || gfx == null)
			{
				return;
			}
			string text = sprach;
			if (text != null)
			{
				if (!(text == "Jongonese"))
				{
					if (text == "Shislak")
					{
						int num = junkie.Next(6);
						Size size = new Size(0, 0);
						string[] array = new string[num];
						for (int j = 0; j < num; j++)
						{
							array[j] = kukur.testMeYO(junkie.Next(1, 7));
						}
						for (int k = 0; k < array.Length; k++)
						{
							gfx.DrawString(array[k], new Font("Segoe Script", 72f, FontStyle.Bold), new SolidBrush(Color.FromArgb(220, 220, 220, 220)), 200 + size.Width, 300f);
							size.Width += (int)gfx.MeasureString(array[k], new Font("Segoe Script", 72f, FontStyle.Bold)).Width;
							num += array[k].Length;
							Thread.Sleep(300);
						}
					}
					else if (text == "Kitara")
					{
						int num2 = junkie.Next(6);
						Size size2 = new Size(0, 0);
						string[] array2 = new string[num2];
						for (int l = 0; l < num2; l++)
						{
							array2[l] = kukur.gEn2Name(200, junkie);
						}
						for (int m = 0; m < array2.Length; m++)
						{
							gfx.DrawString(array2[m], new Font("Segoe Script", 72f, FontStyle.Bold), new SolidBrush(Color.FromArgb(220, 220, 220, 220)), 200 + size2.Width, 300f);
							size2.Width += (int)gfx.MeasureString(array2[m], new Font("Segoe Script", 72f, FontStyle.Bold)).Width;
							num2 += array2[m].Length;
							Thread.Sleep(300);
						}
					}
					else if (text == "Math")
					{
						int num3 = junkie.Next(6);
						Size size3 = new Size(0, 0);
						string[] array3 = new string[num3];
						for (int n = 0; n < num3; n++)
						{
							array3[n] = kukur.bongoDrengenFraVanløse();
						}
						for (int num4 = 0; num4 < array3.Length; num4++)
						{
							gfx.DrawString(array3[num4], new Font("Times New Roman", 28f, FontStyle.Bold), new SolidBrush(Color.FromArgb(220, 220, 220, 220)), 200 + size3.Width, 300f);
							size3.Width += (int)gfx.MeasureString(array3[num4], new Font("Segoe Script", 28f, FontStyle.Bold)).Width;
							num3 += array3[num4].Length;
							Thread.Sleep(300);
						}
					}
					else if (text == "Word")
					{
						int num5 = junkie.Next(6);
						Size size4 = new Size(0, 0);
						string[] array4 = new string[num5];
						for (int num6 = 0; num6 < num5; num6++)
						{
							array4[num6] = kukur.viErToDerSavnerDigHelle();
						}
						for (int num7 = 0; num7 < array4.Length; num7++)
						{
							gfx.DrawString(array4[num7], new Font("Times New Roman", 28f, FontStyle.Bold), new SolidBrush(Color.FromArgb(220, 220, 220, 220)), 200 + size4.Width, 300f);
							size4.Width += (int)gfx.MeasureString(array4[num7], new Font("Segoe Script", 28f, FontStyle.Bold)).Width;
							num5 += array4[num7].Length;
							Thread.Sleep(300);
						}
					}
					else if (text == "KomIndJegHyggerMig")
					{
						int num8 = junkie.Next(6);
						Size size5 = new Size(0, 0);
						string[] array5 = new string[num8];
						for (int num9 = 0; num9 < num8; num9++)
						{
							switch (junkie.Next(5))
							{
							case 0:
								array5[num9] = kukur.viErToDerSavnerDigHelle();
								break;
							case 1:
								array5[num9] = kukur.wordUP();
								break;
							case 2:
								array5[num9] = kukur.bongoDrengenFraVanløse();
								break;
							case 3:
								array5[num9] = kukur.testMeYO(junkie.Next(1, 7));
								break;
							case 4:
								array5[num9] = kukur.gEn2Name(280, junkie);
								break;
							}
						}
						for (int num10 = 0; num10 < array5.Length; num10++)
						{
							gfx.DrawString(array5[num10], new Font("Times New Roman", 28f, FontStyle.Bold), new SolidBrush(Color.FromArgb(220, 220, 220, 220)), 200 + size5.Width, 300f);
							size5.Width += (int)gfx.MeasureString(array5[num10], new Font("Segoe Script", 28f, FontStyle.Bold)).Width;
							num8 += array5[num10].Length;
							Thread.Sleep(300);
						}
					}
				}
				else
				{
					int num11 = junkie.Next(6);
					Size size6 = new Size(0, 0);
					string[] array6 = new string[num11];
					for (int num12 = 0; num12 < num11; num12++)
					{
						array6[num12] = kukur.wordUP();
					}
					for (int num13 = 0; num13 < array6.Length; num13++)
					{
						gfx.DrawString(array6[num13], new Font("Segoe Script", 72f, FontStyle.Bold), new SolidBrush(Color.FromArgb(220, 220, 220, 220)), 200 + size6.Width, 300f);
						size6.Width += (int)gfx.MeasureString(array6[num13], new Font("Segoe Script", 72f, FontStyle.Bold)).Width;
						num11 += array6[num13].Length;
						Thread.Sleep(300);
					}
				}
			}
			Thread.Sleep(400);
		}

		private void bongo(object sender, EventArgs e)
		{
			timer1 = new System.Timers.Timer(8000.0);
			timer1.AutoReset = false;
			timer1.Elapsed += timer1_Elapsed;
			timer2.Start();
			timer2IsRunning = true;
			button1.Visible = false;
			button2.Visible = false;
			comboBox1.Visible = false;
			switch (new Random().Next(28))
			{
			case 0:
				button1.Text = "F4\u00b4 zi-h\u00b4 neu-n";
				break;
			case 1:
				button1.Text = "3afs";
				break;
			case 2:
				button1.Text = kukur.gEn2Name(200, junkie);
				break;
			case 3:
				button1.Text = "Combat f-yr\u00b4";
				break;
			case 4:
				button1.Text = "Spra\u00b4ch me\u00b4";
				break;
			case 5:
				button1.Text = "Før-\u00b4e li\u00b4d\u00b4";
				break;
			case 6:
				button1.Text = "TilbageSåLængeViSerTv";
				break;
			case 7:
				button1.Text = "GameOn43nul,5";
				break;
			case 8:
				button1.Text = "HolaEspaniolTrinkenBitteSehr";
				break;
			case 9:
				button1.Text = "BørneTVTidsFornøjelse";
				break;
			case 10:
				button1.Text = "f-4zehn2426nineundnine";
				break;
			case 11:
				button1.Text = "GræskLegeBarnLegerViTo";
				break;
			case 12:
				button1.Text = "GrønLilKærBotMig";
				break;
			case 13:
				button1.Text = "FjendenErNærPåGræsk";
				break;
			case 14:
				button1.Text = "NiftigeTankerOmRuslandsTerratorium";
				break;
			case 15:
				button1.Text = "RussiskStatsborgerskabBetyderNada";
				break;
			case 16:
				button1.Text = "LandflygtigeTankerBørneMigHeltIHampen";
				break;
			case 17:
				button1.Text = "Sa-yo-nara-";
				break;
			case 18:
				button1.Text = "ViGårHjemTilVinter";
				break;
			case 19:
				button1.Text = "BoTTedej";
				break;
			case 20:
				button1.Text = "|\u00b4na-do";
				break;
			case 21:
				button1.Text = "Yg\u00b4dra-\u00b4sil";
				break;
			case 22:
				button1.Text = "BummiBedste";
				break;
			case 23:
				button1.Text = "\u00b4ov be\u00b4n";
				break;
			case 24:
				button1.Text = "Vi-go";
				break;
			case 25:
				button1.Text = "BørneTroldeSnavs";
				break;
			case 26:
				button1.Text = kukur.gEn2Name(200, junkie);
				break;
			case 27:
				button1.Text = kukur.gEn2Name(200, junkie);
				break;
			default:
				button1.Text = "Dummy!!!";
				break;
			}
			for (int i = 0; i < 2; i++)
			{
				denneErFedNokIkVelNokSådanUdråbstegnIkke();
			}
			button1.Visible = true;
			button2.Visible = true;
			comboBox1.Visible = true;
		}

		internal void brunstigCookie(Børnetid børnetid, int p)
		{
		}

		internal void burnRubber(double p, float p_2, int colorpoint)
		{
			if (gfx != null && junkie.Next((int)p_2) <= 800)
			{
				for (int i = 0; i < 300; i++)
				{
					gfx.FillEllipse(new SolidBrush(Color.FromArgb(junkie.Next(10), colorpoint - junkie.Next(colorpoint), colorpoint - junkie.Next(colorpoint), colorpoint - junkie.Next(colorpoint))), new Rectangle(junkie.Next((int)p) - junkie.Next((int)p), junkie.Next((int)p) - junkie.Next((int)p), junkie.Next((int)p) - junkie.Next((int)p), junkie.Next((int)p) - junkie.Next((int)p)));
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			playMP3();
		}

		public void CallMe(int p)
		{
			if (junkie.Next(20) != 0)
			{
				return;
			}
			for (int i = 0; i < 10; i++)
			{
				switch (junkie.Next(9))
				{
				case 0:
				{
					Image image8 = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.flask.png"));
					if (junkie.Next(2) == 0)
					{
						for (int num3 = 0; num3 < 1; num3++)
						{
							gfx.DrawImage(image8, junkie.Next(1400), junkie.Next(800), (float)((double)image8.Width * 0.3), (float)((double)image8.Height * 0.3));
							Thread.Sleep(100);
						}
					}
					break;
				}
				case 1:
				{
					Image image5 = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.flask2.png"));
					if (junkie.Next(2) == 0)
					{
						for (int n = 0; n < 1; n++)
						{
							gfx.DrawImage(image5, junkie.Next(1400), junkie.Next(800), (float)((double)image5.Width * 0.3), (float)((double)image5.Height * 0.3));
							Thread.Sleep(100);
						}
					}
					break;
				}
				case 2:
				{
					Image image9 = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.flask.png"));
					if (junkie.Next(2) == 0)
					{
						for (int num4 = 0; num4 < 1; num4++)
						{
							gfx.DrawImage(image9, junkie.Next(1400), junkie.Next(800), (float)((double)image9.Width * 0.3), (float)((double)image9.Height * 0.3));
							Thread.Sleep(100);
						}
					}
					break;
				}
				case 3:
				{
					Image image3 = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.flask2.png"));
					if (junkie.Next(2) == 0)
					{
						for (int l = 0; l < 1; l++)
						{
							gfx.DrawImage(image3, junkie.Next(1400), junkie.Next(800), (float)((double)image3.Width * 0.3), (float)((double)image3.Height * 0.3));
							Thread.Sleep(100);
						}
					}
					break;
				}
				case 4:
				{
					Image image6 = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.flask3.png"));
					if (junkie.Next(2) == 0)
					{
						for (int num = 0; num < 1; num++)
						{
							gfx.DrawImage(image6, junkie.Next(1400), junkie.Next(800), (float)((double)image6.Width * 0.3), (float)((double)image6.Height * 0.3));
							Thread.Sleep(100);
						}
					}
					break;
				}
				case 5:
				{
					Image image2 = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.flask3.png"));
					if (junkie.Next(2) == 0)
					{
						for (int k = 0; k < 1; k++)
						{
							gfx.DrawImage(image2, junkie.Next(1400), junkie.Next(800), (float)((double)image2.Width * 0.3), (float)((double)image2.Height * 0.3));
							Thread.Sleep(100);
						}
					}
					break;
				}
				case 6:
				{
					Image image7 = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.flask.png"));
					if (junkie.Next(2) == 0)
					{
						for (int num2 = 0; num2 < 1; num2++)
						{
							gfx.DrawImage(image7, junkie.Next(1400), junkie.Next(800), (float)((double)image7.Width * 0.3), (float)((double)image7.Height * 0.3));
							Thread.Sleep(100);
						}
					}
					break;
				}
				case 7:
				{
					Image image4 = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.flask2.png"));
					if (junkie.Next(2) == 0)
					{
						for (int m = 0; m < 1; m++)
						{
							gfx.DrawImage(image4, junkie.Next(1400), junkie.Next(800), (float)((double)image4.Width * 0.3), (float)((double)image4.Height * 0.3));
							Thread.Sleep(100);
						}
					}
					break;
				}
				case 8:
				{
					Image image = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.flask3.png"));
					if (junkie.Next(2) == 0)
					{
						for (int j = 0; j < 1; j++)
						{
							gfx.DrawImage(image, junkie.Next(1400), junkie.Next(800), (float)((double)image.Width * 0.3), (float)((double)image.Height * 0.3));
							Thread.Sleep(100);
						}
					}
					break;
				}
				}
			}
		}

		private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
		{
			bootMeUp.StopAllSounds();
			bootMeUp.Play2D("mixalot tape 4 2 whatever!!!lol.mp3");
		}

		internal void ConnectTheLightsBabyJohnny(int p)
		{
			List<Point> list = new List<Point>();
			for (int i = 0; i < 10; i++)
			{
				int num = 100;
				int num2 = junkie.Next(1200);
				int num3 = junkie.Next(900);
				list.Add(new Point(num2 + 75, num3 + 75));
				int maxValue = junkie.Next(25) + 45;
				int maxValue2 = junkie.Next(25) + 45;
				int maxValue3 = junkie.Next(25) + 45;
				for (int j = 0; j < 10; j++)
				{
					if (gfx != null)
					{
						gfx.FillEllipse(new SolidBrush(Color.FromArgb(junkie.Next(40) + 20, junkie.Next(maxValue) + 85, junkie.Next(maxValue2) + 85, junkie.Next(maxValue3) + 85)), new Rectangle(junkie.Next(100) - junkie.Next(100) + num2, junkie.Next(100) - junkie.Next(100) + num3, junkie.Next(100) + num, junkie.Next(100) + num));
					}
				}
				if (list.Count > 1)
				{
					gfx.DrawLine(new Pen(Color.Black), list[i - 1], list[i]);
				}
			}
		}

		public static void CopyStream(Stream input, Stream output)
		{
			byte[] array = new byte[8192];
			int count;
			while ((count = input.Read(array, 0, array.Length)) > 0)
			{
				output.Write(array, 0, count);
			}
		}

		private Point[] createPoints(int k)
		{
			Point[] array = new Point[k];
			for (int num = k - 1; num >= 0; num--)
			{
				array[num] = new Point(new Random().Next(630) + 200, new Random().Next(350) + 150);
			}
			modifyPoints(array);
			return array;
		}

		private Point[] createPoints(int p, int p_2)
		{
			Point[] array = new Point[p];
			for (int num = p - 1; num >= 0; num--)
			{
				array[num] = new Point(new Random().Next(530) + 50, new Random().Next(200));
			}
			return array;
		}

		public void nuFunktionMartin()
		{
			double num = 0.0;
			Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
			Bitmap image = new Bitmap(bitmap.Width, bitmap.Height);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
			}
			kukur.mumblejumbo(3, 10, 5);
			for (int i = 0; i < 900; i++)
			{
				num += 1.7;
				Graphics graphics2 = Graphics.FromImage(image);
				graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics2.DrawImage(bitmap, 0, 0);
				graphics2.DrawString("Hejsa", new Font("Verdana", 24f), Brushes.White, new PointF(200f, (float)(950.0 - num)));
				graphics2.Save();
				gfx.DrawImage(image, 0, 0);
			}
		}

		public void denneErFedNokIkVelNokSådanUdråbstegnIkke()
		{
			Image image = Image.FromStream(myAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.butterfly.png"));
			Image image2 = Image.FromStream(myAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.butterfly.png"));
			Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
			Bitmap image3 = new Bitmap(bitmap.Width, bitmap.Height);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
			}
			string[] array = new string[29];
			for (int i = 0; i < 29; i++)
			{
				array[i] = kukur.testMeYO(junkie.Next(1, 5)) + " " + kukur.testMeYO(junkie.Next(1, 5)) + " " + kukur.testMeYO(junkie.Next(1, 5)) + " " + kukur.testMeYO(junkie.Next(1, 5)) + " " + kukur.testMeYO(junkie.Next(1, 5));
			}
			double num = 0.0;
			double num2 = 0.0;
			int num3 = 0;
			int num4 = 0;
			double num5 = 0.0;
			string[] array2 = new string[15];
			junkie.Next(-1000, 300);
			Math.Pow(34.0, 5.0);
			for (int j = 0; j < 900; j++)
			{
				num += 1.7;
				if (num4 > 40000)
				{
					num5 += 0.3;
				}
				switch (junkie.Next(2))
				{
				case 0:
					num2 += (double)junkie.Next(20);
					num4 += junkie.Next(5, 60);
					break;
				case 1:
					num2 -= (double)junkie.Next(20);
					num4 -= junkie.Next(5, 60);
					break;
				}
				switch (junkie.Next(2))
				{
				case 0:
					num3 += junkie.Next(4, 8);
					break;
				case 1:
					num3 += junkie.Next(2, 6);
					break;
				}
				if (j == 10)
				{
					string path = "C:\\test\\";
					if (!Directory.Exists(path))
					{
						Directory.CreateDirectory(path);
					}
					File.WriteAllLines("C:\\test\\jongonese.txt", array);
				}
				Graphics graphics2 = Graphics.FromImage(image3);
				graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics2.DrawImage(bitmap, 0, 0);
				int num6 = 40;
				graphics2.DrawImage(image, -800 + num3, (float)(300.0 + num2));
				graphics2.DrawImage(image2, -50, -9000 + num4);
				if (num4 > 4000)
				{
					graphics2.DrawImage(image2, 500 - num4, 600 - num4);
				}
				if (num4 > 10000)
				{
					num4 = 0;
				}
				for (int k = 0; k < 20; k++)
				{
					if ((float)(int)(1000.0 + (double)num6 - num) < 800f)
					{
						for (int l = 0; l < 15; l++)
						{
							if (junkie.Next(2) == 0)
							{
								array2[l] = kukur.testMeYO(junkie.Next(1, 5));
								if (junkie.Next(2) == 0)
								{
									string[] array3;
									IntPtr value;
									(array3 = array2)[(int)(value = (IntPtr)l)] = array3[(int)value] + kukur.testMeYO(junkie.Next(1, 5));
								}
								if (junkie.Next(2) == 0)
								{
									string[] array4;
									IntPtr value2;
									(array4 = array2)[(int)(value2 = (IntPtr)l)] = array4[(int)value2] + kukur.testMeYO(junkie.Next(1, 5));
								}
								if (junkie.Next(2) == 0)
								{
									string[] array5;
									IntPtr value3;
									(array5 = array2)[(int)(value3 = (IntPtr)l)] = array5[(int)value3] + kukur.testMeYO(junkie.Next(1, 5));
								}
								if (junkie.Next(2) == 0)
								{
									string[] array6;
									IntPtr value4;
									(array6 = array2)[(int)(value4 = (IntPtr)l)] = array6[(int)value4] + kukur.testMeYO(junkie.Next(1, 5));
								}
							}
						}
						if (junkie.Next(1) == 0)
						{
							graphics2.DrawString(array2[junkie.Next(15)] + " " + array2[junkie.Next(15)] + " " + array2[junkie.Next(15)] + " " + array2[junkie.Next(15)], new Font("Segoe Script", 22f, FontStyle.Bold), Brushes.White, new PointF(100f, (int)(1000.0 + (double)num6 - num)));
						}
						if (junkie.Next(10, 20) == 0)
						{
							graphics2.DrawString(array2[junkie.Next(15)] + " " + junkie.Next(20, 400), new Font("Verdana", 12f), Brushes.White, new PointF(50f, 50f));
							graphics2.DrawString(array2[junkie.Next(15)] + " " + junkie.Next(5, 100), new Font("Verdana", 12f), Brushes.White, new PointF(50f, 70f));
							graphics2.DrawString(array2[junkie.Next(15)] + " " + (float)Math.Pow(junkie.Next(5, 15), junkie.Next(5, 50)), new Font("Verdana", 12f), Brushes.White, new PointF(50f, 90f));
						}
					}
					num6 += 45;
				}
				graphics2.DrawString("Jongonese is space-japanese.....Translate your self", new Font("Verdana", 24f), Brushes.White, new PointF(200f, (float)(950.0 - num)));
				graphics2.Save();
				gfx.DrawImage(image3, 0, 0);
			}
		}

		private Image detErDetJegMener()
		{
			Image.FromStream(myStream);
			myStream = myAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.Migselfies.jpg");
			return Image.FromStream(myStream);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		public void drawAlienFishTank()
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.parrot.png");
			Image image = Image.FromStream(manifestResourceStream);
			Image.FromStream(manifestResourceStream);
			switch (junkie.Next(14))
			{
			case 0:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.parrot.png"));
				break;
			case 1:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.shark.png"));
				break;
			case 2:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.whale.png"));
				break;
			case 3:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.fish.png"));
				break;
			case 4:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.fish2.png"));
				break;
			case 5:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.fish3.png"));
				break;
			case 6:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.parrot2.png"));
				break;
			case 7:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.dino.png"));
				break;
			case 8:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.dino2.png"));
				break;
			case 9:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.dino3.png"));
				break;
			case 10:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.monkey.png"));
				break;
			case 11:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.monkey2.png"));
				break;
			case 12:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.monkey3.png"));
				break;
			case 13:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.donkey.png"));
				break;
			}
			int num = junkie.Next(1600);
			int num2 = junkie.Next(1050);
			int num3 = junkie.Next(300, 700);
			int num4 = junkie.Next(300, 700);
			for (int i = 0; i < junkie.Next(50, 500); i++)
			{
				double num5 = junkie.NextDouble() + 0.1;
				if (junkie.Next(17) != 0)
				{
					gfx.DrawImage(image, new Rectangle(new Point(num + (int)((double)num3 * Math.Sin(junkie.Next(10000))), num2 + (int)((double)num4 * Math.Sin(junkie.Next(10000)))), new Size(new Point((int)((double)image.Width * num5), (int)((double)image.Height * num5)))));
					Thread.Sleep(junkie.Next(100));
				}
			}
		}

		internal void drawFunnyShapes(int p, int p_2)
		{
			if (gfx == null)
			{
				return;
			}
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Image image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.Spaceship.png"));
			Image image2 = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.Pill-icon.png"));
			SetImgOpacity(image, (float)junkie.NextDouble());
			SetImgOpacity(image2, (float)junkie.NextDouble());
			for (int i = 0; i < p + junkie.Next(500); i++)
			{
				double num = Math.Abs((double)junkie.Next(20) + 3.0 * Math.Sin(junkie.Next(360)));
				if (num < 2.0)
				{
					num = 3.0;
				}
				gfx.DrawImage(image, junkie.Next((int)Math.Abs((double)p_2 * Math.Sin(junkie.Next(360)) * 2.0)) - junkie.Next((int)Math.Abs((double)p_2 * Math.Sin(junkie.Next(360)) * 2.0)) + 500, junkie.Next((int)Math.Abs((double)p_2 * Math.Sin(junkie.Next(360)) * 2.0)) - junkie.Next((int)Math.Abs((double)p_2 * Math.Sin(junkie.Next(360)) * 2.0)) + 400, (int)((double)image.Width / num), (int)((double)image.Height / num));
				gfx.DrawImage(image2, junkie.Next((int)Math.Abs((double)p_2 * Math.Sin(junkie.Next(360)) * 2.0)) - junkie.Next((int)Math.Abs((double)p_2 * Math.Sin(junkie.Next(360)) * 2.0)) + 500, junkie.Next((int)Math.Abs((double)p_2 * Math.Sin(junkie.Next(360)) * 2.0)) - junkie.Next((int)Math.Abs((double)p_2 * Math.Sin(junkie.Next(360)) * 2.0)) + 400, (int)((double)image.Width / num), (int)((double)image.Height / num));
			}
		}

		internal void drawSprialythingys(int p)
		{
			int num = 0;
			for (int i = 0; i < 200; i++)
			{
				if (gfx != null)
				{
					gfx.FillEllipse(new SolidBrush(Color.FromArgb(junkie.Next(10) + 5, junkie.Next(155) + 85, junkie.Next(155) + 85, junkie.Next(155) + 85)), new Rectangle(junkie.Next(1) - junkie.Next(1) + (int)((double)num * Math.Cos(num)) + junkie.Next(1200), junkie.Next(1) - junkie.Next(1) + (int)((double)num * Math.Sin(num)) + junkie.Next(900), junkie.Next(30) + p, junkie.Next(30) + p));
				}
				num++;
			}
		}

		public void dropDownMyHoney()
		{
			bootMeUp.SoundVolume = 2f;
			ISoundEngine soundEngine = new ISoundEngine();
			soundEngine.Play2D("18870__zippi1__sound-alien7.wav", playLooped: true);
			Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
			}
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Image image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.icarus.png"));
			Image image2 = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.icarus2.png"));
			Image image3 = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.icarus3.png"));
			Image image4 = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.icarus4.png"));
			Image image5 = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.icarus5.png"));
			Point point = new Point(junkie.Next(800), -junkie.Next(500, 2000));
			Point point2 = new Point(junkie.Next(800), -junkie.Next(500, 2000));
			Point point3 = new Point(junkie.Next(800), -junkie.Next(500, 2000));
			Point point4 = new Point(junkie.Next(800), -junkie.Next(500, 2000));
			Point point5 = new Point(junkie.Next(800), -junkie.Next(500, 2000));
			Bitmap image6 = new Bitmap(bitmap.Width, bitmap.Height);
			double num = junkie.NextDouble();
			Size size = new Size((int)((double)image.Width * num), (int)((double)image.Height * num));
			num = junkie.NextDouble();
			Size size2 = new Size((int)((double)image2.Width * num), (int)((double)image2.Height * num));
			num = junkie.NextDouble();
			Size size3 = new Size((int)((double)image3.Width * num), (int)((double)image3.Height * num));
			num = junkie.NextDouble();
			Size size4 = new Size((int)((double)image4.Width * num), (int)((double)image4.Height * num));
			num = junkie.NextDouble();
			Size size5 = new Size((int)((double)image5.Width * num), (int)((double)image5.Height * num));
			num = junkie.NextDouble();
			for (int i = 0; i < junkie.Next(35, 60); i++)
			{
				if (junkie.Next(1) == 0)
				{
					point.Y += junkie.Next(28);
					point2.Y += junkie.Next(junkie.Next(100));
					point3.Y += junkie.Next(junkie.Next(169));
					point4.Y += junkie.Next(junkie.Next(300));
					point5.Y += junkie.Next(junkie.Next(40));
					point.X += junkie.Next(junkie.Next(8));
					point2.X -= junkie.Next(junkie.Next(15));
					point3.X += junkie.Next(junkie.Next(69));
					point4.X -= junkie.Next(junkie.Next(30));
					point5.X += junkie.Next(junkie.Next(40));
				}
				double num2 = junkie.Next(5, 25);
				if ((double)size.Width * num2 <= 0.0)
				{
					size.Width = 2;
				}
				else
				{
					size.Width += (int)(num2 + 0.5);
				}
				if ((double)size.Height * num2 <= 0.0)
				{
					size.Height = 2;
				}
				else
				{
					size.Height += (int)(num2 + 0.5);
				}
				num2 = junkie.Next(5, 25);
				size2.Width += (int)(num2 + 0.5);
				size2.Height += (int)(num2 + 0.5);
				num2 = junkie.Next(5, 25);
				if ((double)size3.Width * num2 <= 0.0)
				{
					size3.Width = 2;
				}
				else
				{
					size3.Width += (int)(num2 + 0.5);
				}
				if ((double)size3.Height * num2 <= 0.0)
				{
					size3.Height = 2;
				}
				else
				{
					size3.Height += (int)(num2 + 0.5);
				}
				num2 = junkie.Next(5, 25);
				size4.Width += (int)(num2 + 0.5);
				size4.Height += (int)(num2 + 0.5);
				num2 = junkie.Next(5, 25);
				size5.Width += (int)(num2 + 0.5);
				size5.Height += (int)(num2 + 0.5);
				Graphics graphics2 = Graphics.FromImage(image6);
				graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics2.DrawImage(bitmap, 0, 0);
				graphics2.DrawImage(image, point.X, point.Y, size.Width, size.Height);
				graphics2.DrawImage(image2, point2.X, point2.Y, size2.Width, size2.Height);
				graphics2.DrawImage(image3, point3.X, point3.Y, size3.Width, size3.Height);
				graphics2.DrawImage(image4, point4.X, point4.Y, size4.Width, size4.Height);
				graphics2.DrawImage(image5, point5.X, point5.Y, size5.Width, size5.Height);
				graphics2.Save();
				gfx.DrawImage(image6, 0, 0);
			}
			soundEngine.StopAllSounds();
			bootMeUp.SoundVolume = 10f;
		}

		private void explodeMe(Rectangle area)
		{
			if (gfx == null)
			{
				return;
			}
			int num = 60;
			int num2 = junkie.Next(area.X, area.X + area.Width);
			int num3 = junkie.Next(area.Y, area.Y + area.Height);
			int num4 = junkie.Next(15) + 60;
			int num5 = junkie.Next(15) + 60;
			int num6 = junkie.Next(15) + 60;
			switch (junkie.Next(7))
			{
			case 0:
				num4 -= 60;
				break;
			case 1:
				num5 -= 60;
				break;
			case 2:
				num6 -= 60;
				break;
			case 3:
				num4 -= 60;
				num6 -= 60;
				break;
			case 4:
				num5 -= 60;
				num4 -= 60;
				break;
			case 5:
				num6 -= 60;
				num5 -= 60;
				break;
			}
			for (int i = 0; i < 10; i++)
			{
				if (gfx != null)
				{
					gfx.FillEllipse(new SolidBrush(Color.FromArgb(junkie.Next(40) + 10, junkie.Next(num4) + 175, junkie.Next(num5) + 175, junkie.Next(num6) + 175)), new Rectangle(junkie.Next(30) - junkie.Next(30) + num2, junkie.Next(30) - junkie.Next(30) + num3, junkie.Next(20) + num, junkie.Next(20) + num));
				}
			}
		}

		public void explodeMe(int x, int y)
		{
			int num = 100;
			int num2 = junkie.Next(210);
			int num3 = junkie.Next(500);
			int maxValue = junkie.Next(25) + 45;
			int maxValue2 = junkie.Next(25) + 45;
			int maxValue3 = junkie.Next(25) + 45;
			for (int i = 0; i < 10; i++)
			{
				if (gfx != null)
				{
					gfx.FillEllipse(new SolidBrush(Color.FromArgb(junkie.Next(40) + 20, junkie.Next(maxValue) + 185, junkie.Next(maxValue2) + 185, junkie.Next(maxValue3) + 185)), new Rectangle(junkie.Next(100) - junkie.Next(100) + num2, junkie.Next(100) - junkie.Next(100) + num3, junkie.Next(100) + num, junkie.Next(100) + num));
				}
			}
		}

		internal void Explosionshow(int numbers, Rectangle area)
		{
			for (int i = 0; i < numbers; i++)
			{
				explodeMe(area);
			}
		}

		public void fillArrayBollemælk()
		{
			Jingo jingo = new Jingo(this);
			jingo.showBirth();
			jingo.jingoTime(tidspres());
			jingo.timesTwenty(DateTime.Now);
		}

		public void FlashMob(int p)
		{
			switch (junkie.Next(2))
			{
			case 0:
			{
				Image image2 = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.peace.png"));
				if (junkie.Next(2) == 0)
				{
					gfx.DrawImage(image2, 500 - image2.Width / 2, 200 - image2.Height / 2, (float)((double)image2.Width * 2.5), (float)((double)image2.Height * 2.5));
				}
				break;
			}
			case 1:
			{
				Image image = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.skullandguns.png"));
				if (junkie.Next(2) == 0)
				{
					gfx.DrawImage(image, 600 - image.Width / 2, 300 - image.Height / 2, (float)((double)image.Width * 1.5), (float)((double)image.Height * 1.5));
				}
				break;
			}
			}
		}

		public void flyBy()
		{
			ISoundEngine soundEngine = new ISoundEngine();
			soundEngine.Play2D("157886__setuniman__funny-bassoon-0p-17bs4.wav");
			Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
			}
			Image image = detErDetJegMener();
			Image image2 = detErDetJegMener();
			Image image3 = detErDetJegMener();
			Image image4 = detErDetJegMener();
			Point point = new Point(junkie.Next(1400), junkie.Next(800));
			Point point2 = new Point(junkie.Next(1400), junkie.Next(800));
			Point point3 = new Point(junkie.Next(1400), junkie.Next(800));
			Point point4 = new Point(junkie.Next(1400), junkie.Next(800));
			Bitmap image5 = new Bitmap(bitmap.Width, bitmap.Height);
			Size size = new Size((int)((double)image.Width * 0.2), (int)((double)image.Height * 0.2));
			Size size2 = new Size((int)((double)image2.Width * 0.2), (int)((double)image2.Height * 0.2));
			Size size3 = new Size((int)((double)image3.Width * 0.2), (int)((double)image3.Height * 0.2));
			Size size4 = new Size((int)((double)image4.Width * 0.2), (int)((double)image4.Height * 0.2));
			int num = junkie.Next(4);
			junkie.Next(25, 50);
			double num2 = 1.0;
			Graphics graphics2 = Graphics.FromImage(image5);
			for (int i = 0; i < junkie.Next(65, 85); i++)
			{
				switch (num)
				{
				case 0:
					switch (junkie.Next(4))
					{
					case 1:
						point.X -= junkie.Next(50);
						break;
					case 2:
						point.Y += junkie.Next(50);
						break;
					case 3:
						point.Y -= junkie.Next(50);
						break;
					}
					switch (junkie.Next(2))
					{
					case 0:
						size.Width += (int)num2;
						size.Height += (int)num2;
						break;
					case 1:
						size.Width += (int)num2;
						size.Height += (int)num2;
						break;
					}
					graphics2 = Graphics.FromImage(image5);
					graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
					graphics2.DrawImage(bitmap, 0, 0);
					graphics2.DrawImage(image2, point.X, point.Y, size.Width, size.Height);
					graphics2.Save();
					gfx.DrawImage(image5, 0, 0);
					break;
				case 1:
					switch (junkie.Next(4))
					{
					case 0:
						point.X += junkie.Next(50);
						break;
					case 1:
						point.X -= junkie.Next(50);
						break;
					case 2:
						point.Y += junkie.Next(50);
						break;
					case 3:
						point.Y -= junkie.Next(50);
						break;
					}
					switch (junkie.Next(2))
					{
					case 0:
						size.Width += (int)num2;
						size.Height += (int)num2;
						break;
					case 1:
						size.Width += (int)num2;
						size.Height += (int)num2;
						break;
					}
					switch (junkie.Next(4))
					{
					case 0:
						point2.X += junkie.Next(50);
						break;
					case 1:
						point2.X -= junkie.Next(50);
						break;
					case 2:
						point2.Y += junkie.Next(50);
						break;
					case 3:
						point2.Y -= junkie.Next(50);
						break;
					}
					switch (junkie.Next(2))
					{
					case 0:
						size2.Width += (int)num2;
						size2.Height += (int)num2;
						break;
					case 1:
						size2.Width += (int)num2;
						size2.Height += (int)num2;
						break;
					}
					graphics2 = Graphics.FromImage(image5);
					graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
					graphics2.DrawImage(bitmap, 0, 0);
					graphics2.DrawImage(image, point.X, point.Y, size.Width, size.Height);
					graphics2.DrawImage(image2, point2.X, point2.Y, size2.Width, size2.Height);
					graphics2.Save();
					gfx.DrawImage(image5, 0, 0);
					break;
				case 2:
					switch (junkie.Next(4))
					{
					case 0:
						point.X += junkie.Next(50);
						break;
					case 1:
						point.X -= junkie.Next(50);
						break;
					case 2:
						point.Y += junkie.Next(50);
						break;
					case 3:
						point.Y -= junkie.Next(50);
						break;
					}
					switch (junkie.Next(2))
					{
					case 0:
						size.Width += (int)num2;
						size.Height += (int)num2;
						break;
					case 1:
						size.Width += (int)num2;
						size.Height += (int)num2;
						break;
					}
					switch (junkie.Next(4))
					{
					case 0:
						point2.X += junkie.Next(50);
						break;
					case 1:
						point2.X -= junkie.Next(50);
						break;
					case 2:
						point2.Y += junkie.Next(50);
						break;
					case 3:
						point2.Y -= junkie.Next(50);
						break;
					}
					switch (junkie.Next(2))
					{
					case 0:
						size2.Width += (int)num2;
						size2.Height += (int)num2;
						break;
					case 1:
						size2.Width += (int)num2;
						size2.Height += (int)num2;
						break;
					}
					switch (junkie.Next(4))
					{
					case 0:
						point3.X += junkie.Next(50);
						break;
					case 1:
						point3.X -= junkie.Next(50);
						break;
					case 2:
						point3.Y += junkie.Next(50);
						break;
					case 3:
						point3.Y -= junkie.Next(50);
						break;
					}
					switch (junkie.Next(2))
					{
					case 0:
						size3.Width += (int)num2;
						size3.Height += (int)num2;
						break;
					case 1:
						size3.Width += (int)num2;
						size3.Height += (int)num2;
						break;
					}
					graphics2 = Graphics.FromImage(image5);
					graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
					graphics2.DrawImage(bitmap, 0, 0);
					graphics2.DrawImage(image, point.X, point.Y, size.Width, size.Height);
					graphics2.DrawImage(image2, point2.X, point2.Y, size2.Width, size2.Height);
					graphics2.DrawImage(image3, point3.X, point3.Y, size3.Width, size3.Height);
					graphics2.Save();
					gfx.DrawImage(image5, 0, 0);
					break;
				case 3:
					switch (junkie.Next(4))
					{
					case 0:
						point.X += junkie.Next(50);
						break;
					case 1:
						point.X -= junkie.Next(50);
						break;
					case 2:
						point.Y += junkie.Next(50);
						break;
					case 3:
						point.Y -= junkie.Next(50);
						break;
					}
					switch (junkie.Next(2))
					{
					case 0:
						size.Width += (int)num2;
						size.Height += (int)num2;
						break;
					case 1:
						size.Width += (int)num2;
						size.Height += (int)num2;
						break;
					}
					switch (junkie.Next(4))
					{
					case 0:
						point2.X += junkie.Next(50);
						break;
					case 1:
						point2.X -= junkie.Next(50);
						break;
					case 2:
						point2.Y += junkie.Next(50);
						break;
					case 3:
						point2.Y -= junkie.Next(50);
						break;
					}
					switch (junkie.Next(2))
					{
					case 0:
						size2.Width += (int)num2;
						size2.Height += (int)num2;
						break;
					case 1:
						size2.Width += (int)num2;
						size2.Height += (int)num2;
						break;
					}
					switch (junkie.Next(4))
					{
					case 0:
						point3.X += junkie.Next(50);
						break;
					case 1:
						point3.X -= junkie.Next(50);
						break;
					case 2:
						point3.Y += junkie.Next(50);
						break;
					case 3:
						point3.Y -= junkie.Next(50);
						break;
					}
					switch (junkie.Next(2))
					{
					case 0:
						size3.Width += (int)num2;
						size3.Height += (int)num2;
						break;
					case 1:
						size3.Width += (int)num2;
						size3.Height += (int)num2;
						break;
					}
					switch (junkie.Next(4))
					{
					case 0:
						point4.X += junkie.Next(50);
						break;
					case 1:
						point4.X -= junkie.Next(50);
						break;
					case 2:
						point4.Y += junkie.Next(50);
						break;
					case 3:
						point4.Y -= junkie.Next(50);
						break;
					}
					switch (junkie.Next(2))
					{
					case 0:
						size4.Width += (int)num2;
						size4.Height += (int)num2;
						break;
					case 1:
						size4.Width += (int)num2;
						size4.Height += (int)num2;
						break;
					}
					graphics2 = Graphics.FromImage(image5);
					graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
					graphics2.DrawImage(bitmap, 0, 0);
					graphics2.DrawImage(image, point.X, point.Y, size.Width, size.Height);
					graphics2.DrawImage(image2, point2.X, point2.Y, size2.Width, size2.Height);
					graphics2.DrawImage(image3, point3.X, point3.Y, size3.Width, size3.Height);
					graphics2.DrawImage(image4, point4.X, point4.Y, size4.Width, size4.Height);
					graphics2.Save();
					gfx.DrawImage(image5, 0, 0);
					break;
				}
			}
			soundEngine.StopAllSounds();
		}

		private void Form_loadme(object sender, EventArgs e)
		{
		}

		private void Form1_Shown(object sender, EventArgs e)
		{
			playMP3();
		}

		private void FormClosingMeDown(object sender, FormClosingEventArgs e)
		{
			TryToDelete("Math.mp3");
		}

		public Bitmap GrayScale(Bitmap Bmp)
		{
			for (int i = 0; i < Bmp.Height; i++)
			{
				for (int j = 0; j < Bmp.Width; j++)
				{
					Color pixel = Bmp.GetPixel(j, i);
					int num = (pixel.R + pixel.G + pixel.B) / 3;
					Bmp.SetPixel(j, i, Color.FromArgb(num, num, num));
				}
			}
			return Bmp;
		}

		public void herKommerJeg()
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Image image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.Elsestænder.jpg"));
			image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.Migselfies.jpg"));
			double num = 0.5;
			gfx.DrawImage(image, junkie.Next(1400), junkie.Next(800), (float)((double)image.Width * num), (float)((double)image.Height * num));
			Thread.Sleep(100);
		}

		private void InitializeComponent()
		{
			panel1 = new System.Windows.Forms.Panel();
			comboBox1 = new System.Windows.Forms.ComboBox();
			button2 = new System.Windows.Forms.Button();
			button1 = new System.Windows.Forms.Button();
			panel1.SuspendLayout();
			SuspendLayout();
			panel1.AutoSize = true;
			panel1.Controls.Add(comboBox1);
			panel1.Controls.Add(button2);
			panel1.Controls.Add(button1);
			panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			panel1.Font = new System.Drawing.Font("Verdana", 20.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			panel1.Location = new System.Drawing.Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = base.ClientSize;
			panel1.TabIndex = 1;
			panel1.Click += new System.EventHandler(bongo);
			panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
			comboBox1.Font = new System.Drawing.Font("Verdana", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[17]
			{
				"dmitebeats+dmitebeatsrebellionfreedl.mp3",
				"bleedingskies+entrosoletyoullnevergetoutaliveinstr.mp3",
				"sodymanic+tosmooth.mp3",
				"ascenzion+needfulthings.mp3",
				"Mathias Koizumi - WhiteRiver.mp3",
				"ascenzion+getonthefunktrain.mp3",
				"eddrury+jordanstheme.mp3",
				"swampmanthemachine+fadetoblue.mp3",
				"eddrury+mistystheme.mp3",
				"ericrfairhurst+catch22.mp3",
				"phroneeino+fourfortyfour.mp3",
				"phroneeino+pink.mp3",
				"phroneeino+theangelssing.mp3",
				"phroneeino+whoisincontrolhousemix.mp3",
				"Mathias Koizumi - Alien Wars.mp3",
				"Mathias Koizumi - Blue sky.mp3",
				"Silence me not....."
			});
			comboBox1.Location = new System.Drawing.Point(524, 160);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new System.Drawing.Size(251, 24);
			comboBox1.TabIndex = 5;
			comboBox1.Text = "Hej musik!!! :) !!! :--->";
			comboBox1.Visible = false;
			comboBox1.SelectedValueChanged += new System.EventHandler(comboBox1_SelectedValueChanged);
			button2.Location = new System.Drawing.Point(762, 3);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(22, 20);
			button2.TabIndex = 3;
			button2.UseVisualStyleBackColor = true;
			button2.Visible = false;
			button2.Click += new System.EventHandler(button2_Click);
			button1.BackColor = System.Drawing.Color.Transparent;
			button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			button1.Font = new System.Drawing.Font("Segoe Print", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button1.Location = new System.Drawing.Point(524, 201);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(251, 42);
			button1.TabIndex = 2;
			button1.Text = "T\u00b4-i\u00b4m- i\u00b4s s\u00b4o-";
			button1.UseVisualStyleBackColor = false;
			button1.Visible = false;
			button1.Click += new System.EventHandler(bongo);
			base.AutoScrollMargin = new System.Drawing.Size(500, 500);
			base.AutoScrollMinSize = new System.Drawing.Size(500, 500);
			base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			base.ClientSize = new System.Drawing.Size(787, 455);
			base.ControlBox = false;
			base.Controls.Add(panel1);
			Cursor = System.Windows.Forms.Cursors.Default;
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Form1";
			base.Opacity = 0.8;
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "-Kviol";
			base.Activated += new System.EventHandler(Loadup);
			base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(FormClosingMeDown);
			base.Load += new System.EventHandler(Form_loadme);
			base.Shown += new System.EventHandler(Form1_Shown);
			base.ResizeEnd += new System.EventHandler(ResizeDone);
			base.EnabledChanged += new System.EventHandler(TryEnabled);
			panel1.ResumeLayout(performLayout: false);
			ResumeLayout(performLayout: false);
			PerformLayout();
		}

		public void jongoTime()
		{
			if (!timer2IsRunning)
			{
				return;
			}
			if (trælle == null)
			{
				newJongo();
			}
			int num = junkie.Next(1700);
			int num2 = junkie.Next(1000);
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Image image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman.png"));
			switch (junkie.Next(7))
			{
			case 0:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman.png"));
				break;
			case 1:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman2.png"));
				break;
			case 2:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman3.png"));
				break;
			case 3:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman4.png"));
				break;
			case 4:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman5.png"));
				break;
			case 5:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman6.png"));
				break;
			case 6:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman7.png"));
				break;
			}
			string[] manifestResourceNames = executingAssembly.GetManifestResourceNames();
			foreach (string text in manifestResourceNames)
			{
			}
			BolleHeaven bolleHeaven = new BolleHeaven(this);
			for (int num3 = junkie.Next(4) + 3; num3 >= 0; num3--)
			{
				if (junkie.Next(2) == 0)
				{
					bolleHeaven = new BolleHeaven(this);
				}
				if (cula < 4)
				{
					sprach = "Jongonese";
					nameCalling();
					cula = 200;
				}
				cula--;
				for (int num4 = 23; num4 > 0; num4--)
				{
					if (ibli < 3)
					{
						ibli = 300;
					}
					else
					{
						ibli -= 2;
					}
					if (abli < 3)
					{
						abli = 6000;
					}
					else
					{
						abli -= 2;
					}
					tookie--;
					timetoJongoisme();
					switch (time.Next(8))
					{
					case 1:
						for (int num9 = 100; num9 >= 0; num9--)
						{
							Random random = new Random();
							gfx.FillClosedCurve(new SolidBrush(Color.FromArgb(random.Next(150), random.Next(25) + 200, random.Next(15) + 200, random.Next(40) + 215)), createPoints(3));
						}
						break;
					case 2:
						for (int num8 = 40; num8 >= 0; num8--)
						{
							Point[] points = createPoints(4, 0);
							gfx.FillPolygon(new SolidBrush(Color.FromArgb(new Random().Next(180), new Random().Next(40) + 200, new Random().Next(40) + 200, new Random().Next(55) + 200)), points);
						}
						break;
					case 3:
						gfx.DrawLine(new Pen(new SolidBrush(Color.FromArgb(50, 0, 0, 0))), junkie.Next(900), junkie.Next(700), junkie.Next(900), junkie.Next(700));
						gfx.DrawLine(new Pen(new SolidBrush(Color.FromArgb(50, 0, 0, 0))), junkie.Next(900), junkie.Next(10), junkie.Next(100) + 800, junkie.Next(10) + 700);
						gfx.DrawLine(new Pen(new SolidBrush(Color.FromArgb(50, 0, 0, 0))), junkie.Next(10), junkie.Next(10), junkie.Next(800) + 10, junkie.Next(10) + 700);
						gfx.DrawLine(new Pen(new SolidBrush(Color.FromArgb(50, 0, 0, 0))), 450, 350, junkie.Next(900), junkie.Next(700));
						break;
					case 4:
						if (junkie.Next(cula) <= 200)
						{
							if (sprach == "Kitara")
							{
								if (junkie.Next(3) == 0)
								{
									gfx.DrawString(bolleHeaven.gEn2Name(245, junkie) + " " + bolleHeaven.gEn2Name(245, junkie), new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(1000 - junkie.Next(1000), 1600 - junkie.Next(1600)));
								}
								else
								{
									gfx.DrawString(bolleHeaven.gEn2Name(245, junkie), new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(junkie.Next(1000) + 10, junkie.Next(1600) + 10));
								}
							}
							else if (sprach == "Jongonese")
							{
								if (junkie.Next(3) == 0)
								{
									gfx.DrawString(bolleHeaven.wordUP() + " " + bolleHeaven.wordUP(), new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(1000 - junkie.Next(1000), 1600 - junkie.Next(1600)));
								}
								else
								{
									gfx.DrawString(bolleHeaven.wordUP(), new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(junkie.Next(1000) + 10, junkie.Next(1600) + 10));
								}
							}
							else if (sprach == "Shislak")
							{
								if (junkie.Next(3) == 0)
								{
									gfx.DrawString(bolleHeaven.testMeYO(junkie.Next(1, 7)) + " " + bolleHeaven.testMeYO(junkie.Next(1, 7)), new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(1000 - junkie.Next(1000), 1600 - junkie.Next(1600)));
								}
								else
								{
									gfx.DrawString(bolleHeaven.testMeYO(junkie.Next(1, 7)), new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(junkie.Next(1000) + 10, junkie.Next(1600) + 10));
								}
							}
							else if (sprach == "Math")
							{
								if (junkie.Next(3) == 0)
								{
									gfx.DrawString(bolleHeaven.bongoDrengenFraVanløse() + " " + bolleHeaven.bongoDrengenFraVanløse(), new Font("Times New Roman", 28f, FontStyle.Bold), Brushes.White, new PointF(1000 - junkie.Next(1000), 1600 - junkie.Next(1600)));
								}
								else
								{
									gfx.DrawString(bolleHeaven.bongoDrengenFraVanløse(), new Font("Times New Roman", 28f, FontStyle.Bold), Brushes.White, new PointF(junkie.Next(1000) + 10, junkie.Next(1600) + 10));
								}
							}
							else if (sprach == "Word")
							{
								if (junkie.Next(3) == 0)
								{
									gfx.DrawString(bolleHeaven.viErToDerSavnerDigHelle() + " " + bolleHeaven.viErToDerSavnerDigHelle(), new Font("Times New Roman", 28f, FontStyle.Bold), Brushes.White, new PointF(1000 - junkie.Next(1000), 1600 - junkie.Next(1600)));
								}
								else
								{
									gfx.DrawString(bolleHeaven.viErToDerSavnerDigHelle(), new Font("Times New Roman", 28f, FontStyle.Bold), Brushes.White, new PointF(junkie.Next(1000) + 10, junkie.Next(1600) + 10));
								}
							}
							else if (sprach == "KomIndJegHyggerMig")
							{
								switch (junkie.Next(5))
								{
								case 0:
									if (junkie.Next(3) == 0)
									{
										gfx.DrawString(bolleHeaven.viErToDerSavnerDigHelle() + " " + bolleHeaven.viErToDerSavnerDigHelle(), new Font("Times New Roman", 28f, FontStyle.Bold), Brushes.White, new PointF(1000 - junkie.Next(1000), 1600 - junkie.Next(1600)));
									}
									else
									{
										gfx.DrawString(bolleHeaven.viErToDerSavnerDigHelle(), new Font("Times New Roman", 28f, FontStyle.Bold), Brushes.White, new PointF(junkie.Next(1000) + 10, junkie.Next(1600) + 10));
									}
									break;
								case 1:
									if (junkie.Next(3) == 0)
									{
										gfx.DrawString(bolleHeaven.wordUP() + " " + bolleHeaven.wordUP(), new Font("Times New Roman", 28f, FontStyle.Bold), Brushes.White, new PointF(1000 - junkie.Next(1000), 1600 - junkie.Next(1600)));
									}
									else
									{
										gfx.DrawString(bolleHeaven.wordUP(), new Font("Times New Roman", 28f, FontStyle.Bold), Brushes.White, new PointF(junkie.Next(1000) + 10, junkie.Next(1600) + 10));
									}
									break;
								case 2:
									if (junkie.Next(3) == 0)
									{
										gfx.DrawString(bolleHeaven.gEn2Name(200, junkie) + " " + bolleHeaven.gEn2Name(200, junkie), new Font("Times New Roman", 28f, FontStyle.Bold), Brushes.White, new PointF(1000 - junkie.Next(1000), 1600 - junkie.Next(1600)));
									}
									else
									{
										gfx.DrawString(bolleHeaven.gEn2Name(200, junkie), new Font("Times New Roman", 28f, FontStyle.Bold), Brushes.White, new PointF(junkie.Next(1000) + 10, junkie.Next(1600) + 10));
									}
									break;
								case 3:
									if (junkie.Next(3) == 0)
									{
										gfx.DrawString(bolleHeaven.bongoDrengenFraVanløse() + " " + bolleHeaven.bongoDrengenFraVanløse(), new Font("Times New Roman", 28f, FontStyle.Bold), Brushes.White, new PointF(1000 - junkie.Next(1000), 1600 - junkie.Next(1600)));
									}
									else
									{
										gfx.DrawString(bolleHeaven.bongoDrengenFraVanløse(), new Font("Times New Roman", 28f, FontStyle.Bold), Brushes.White, new PointF(junkie.Next(1000) + 10, junkie.Next(1600) + 10));
									}
									break;
								case 4:
									if (junkie.Next(3) == 0)
									{
										gfx.DrawString(bolleHeaven.testMeYO(junkie.Next(1, 7)) + " " + bolleHeaven.testMeYO(junkie.Next(1, 7)), new Font("Times New Roman", 28f, FontStyle.Bold), Brushes.White, new PointF(1000 - junkie.Next(1000), 1600 - junkie.Next(1600)));
									}
									else
									{
										gfx.DrawString(bolleHeaven.testMeYO(junkie.Next(1, 7)), new Font("Times New Roman", 28f, FontStyle.Bold), Brushes.White, new PointF(junkie.Next(1000) + 10, junkie.Next(1600) + 10));
									}
									break;
								}
							}
						}
						if (junkie.Next(300) == 0)
						{
							switch (junkie.Next(8))
							{
							case 0:
								gfx.DrawString("B\u00b4or te med\u00b4 bte-læ-s\u00b4en", new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(new Random().Next(250) + 100, new Random().Next(350)));
								break;
							case 1:
								gfx.DrawString("To-Hundrede-Mennesker", new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(new Random().Next(250) + 100, new Random().Next(350)));
								break;
							case 2:
								gfx.DrawString("Bliv model istedet for, jeg er ligeglad om det bliver læst", new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(new Random().Next(250) + 100, new Random().Next(350)));
								break;
							case 3:
								gfx.DrawString("En tanke til og du fatter jeg ikke er begavet om noget som helst.", new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(new Random().Next(250) + 100, new Random().Next(350)));
								break;
							case 4:
								gfx.DrawString("Gå hjem og men det er mærkeligt ikke, sådan", new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(new Random().Next(250) + 100, new Random().Next(350)));
								break;
							case 5:
								gfx.DrawString("Lige meget om det sneglefart her, ligegyldigt ikke", new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(new Random().Next(250) + 100, new Random().Next(350)));
								break;
							case 6:
								gfx.DrawString("Du skal sige vi kommer afsted hurtigt ikke", new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(new Random().Next(250) + 100, new Random().Next(350)));
								break;
							case 7:
								gfx.DrawString("Den har ingen tanker vel...", new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(new Random().Next(250) + 100, new Random().Next(350)));
								break;
							}
							cola = 1;
						}
						if (junkie.Next(400) == 0)
						{
							gfx.DrawString(bolleHeaven.gEn2Name(245, junkie), new Font("Segoe Script", 72f, FontStyle.Bold), new LinearGradientBrush(new Point(0, 0), new Point(600, 600), Color.White, Color.DarkSlateGray), new PointF(1000 - junkie.Next(1000), 1600 - junkie.Next(1600)));
						}
						break;
					case 5:
					{
						int num6 = -200;
						int num7 = 1000;
						if (tookie < 0)
						{
							for (int j = 0; j < 20; j++)
							{
								gfx.FillEllipse(new SolidBrush(Color.FromArgb(junkie.Next(60) + 100, junkie.Next(25) + 230, junkie.Next(25) + 230, junkie.Next(25) + 230)), new Rectangle(junkie.Next(100) + num6, junkie.Next(50) + num6, junkie.Next(1000) + num7, junkie.Next(1000) + num7));
							}
						}
						break;
					}
					case 6:
						if (junkie.Next(2) != 0)
						{
							double num5 = junkie.NextDouble();
							Image image2;
							switch (junkie.Next(5))
							{
							case 0:
								image2 = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.Planet.png"));
								break;
							case 1:
								image2 = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.planet2.png"));
								break;
							case 2:
								image2 = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.planet3.png"));
								break;
							case 3:
								image2 = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.planet4.png"));
								break;
							case 4:
								image2 = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.planet5.png"));
								break;
							default:
								image2 = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.world.png"));
								break;
							}
							if (junkie.Next(abli) > 2500)
							{
								gfx.DrawImage(image2, (int)(100.0 + (double)num * Math.Sin(junkie.Next(10000))) + 200, 100 + num2 + (int)(200.0 * Math.Sin(junkie.Next(10000))), (int)((double)image2.Width * 0.1 * num5) + image2.Width / 9, (int)((double)image2.Height * 0.1 * num5) + image2.Height / 9);
							}
							if (junkie.Next(ibli) > 150)
							{
								gfx.DrawImage(image, new Rectangle(new Point(100 + num + (int)(100.0 * Math.Sin(junkie.Next(10000))), 100 + num2 + (int)(200.0 * Math.Sin(junkie.Next(10000)))), new Size(new Point((int)((double)image.Width * 0.3), (int)((double)image.Height * 0.3)))));
							}
							image2.Dispose();
						}
						break;
					case 7:
						if (junkie.Next(5) == 0)
						{
							BlackStrangeCloud(100);
						}
						break;
					}
				}
			}
		}

		private void juggleMeNotPleaseHornyBilbaoWorksFine()
		{
			for (int i = 0; i < 1; i++)
			{
				new Spaceship1(this);
			}
		}

		internal void JumpOut(int p)
		{
			if (junkie.Next(1) == 0)
			{
				typeShowUp = junkie.Next(2);
			}
			if (typeShowUp == 0)
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.robot.png");
				switch (junkie.Next(11))
				{
				case 0:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.wasp.png");
					break;
				case 1:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.Classicrobot.png");
					break;
				case 2:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.eyerobot.png");
					break;
				case 3:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.insect_robot.png");
					break;
				case 4:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.robot.png");
					break;
				case 5:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.robot2.png");
					break;
				case 6:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.troll.png");
					break;
				case 7:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.uglything.png");
					break;
				case 8:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.mowglibarn.png");
					break;
				case 9:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.angel.png");
					break;
				case 10:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.mowglibarn.png");
					break;
				default:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.robot2.png");
					break;
				}
				Image image = Image.FromStream(manifestResourceStream);
				int num = junkie.Next(1600);
				int num2 = junkie.Next(1000);
				double num3 = (double)junkie.Next(10) + 0.6;
				Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
				Bitmap image2 = new Bitmap(bitmap.Width, bitmap.Height);
				using (Graphics graphics = Graphics.FromImage(bitmap))
				{
					graphics.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
				}
				for (int i = 0; i < 22; i++)
				{
					Graphics graphics2 = Graphics.FromImage(image2);
					graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
					graphics2.DrawImage(bitmap, 0, 0);
					graphics2.DrawImage(image, num - (int)((double)image.Width / num3) / 2, num2 - (int)((double)image.Width / num3) / 2, (int)((double)image.Width / num3), (int)((double)image.Height / num3));
					gfx.DrawImage(image2, 0, 0);
					if (num3 >= 0.6)
					{
						num3 -= 0.2;
					}
					if (num3 <= 0.2)
					{
						num3 = 0.2;
					}
				}
			}
			else if (typeShowUp == 1)
			{
				Assembly executingAssembly2 = Assembly.GetExecutingAssembly();
				Stream manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alieninvader.png");
				switch (junkie.Next(6))
				{
				case 0:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alieninvader.png");
					break;
				case 1:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alieninvader2.png");
					break;
				case 2:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alieninvader3.png");
					break;
				case 3:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alieninvader4.png");
					break;
				case 4:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alieninvader5.png");
					break;
				case 5:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alieninvader5.png");
					break;
				default:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alieninvader5.png");
					break;
				}
				Image image3 = Image.FromStream(manifestResourceStream2);
				int num4 = junkie.Next(1600);
				int num5 = junkie.Next(1000);
				double num6 = (double)junkie.Next(10) + 0.9;
				Size size = default(Size);
				for (int j = 0; j < 22; j++)
				{
					gfx.DrawImage(image3, num4 - (int)((double)image3.Width / num6) / 2 - (int)((double)image3.Width / num6) / 2, num5 - (int)((double)image3.Width / num6) / 2, (int)((double)image3.Width / num6), (int)((double)image3.Height / num6));
					if (num6 >= 0.9)
					{
						num6 -= 0.2;
					}
					if (num6 <= 0.2)
					{
						num6 = 0.2;
					}
				}
				size.Width = (int)((double)image3.Width / num6);
				size.Height = (int)((double)image3.Height / num6);
				switch (junkie.Next(13))
				{
				case 0:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.airforcethought.png");
					break;
				case 1:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.heart.png");
					break;
				case 2:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.heart2.png");
					break;
				case 3:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.justice.png");
					break;
				case 4:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.pig.png");
					break;
				case 5:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.playMeNow.png");
					break;
				case 6:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.speakerMeNot.jpg");
					break;
				case 7:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.militaryrobot.png");
					break;
				case 8:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.peacealien.png");
					break;
				case 9:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.sejetanker.png");
					break;
				case 10:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.sonicboom.png");
					break;
				case 11:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.whatYouUpTo.png");
					break;
				case 12:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.youreAlright.png");
					break;
				}
				Image image4 = Image.FromStream(manifestResourceStream2);
				Image image5 = Image.FromStream(executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.speakerscorner.png"));
				new Bitmap(image5.Width, image5.Height);
				Graphics graphics3 = Graphics.FromImage(image5);
				graphics3.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics3.DrawImage(image5, 0, 0);
				graphics3.DrawImage(image4, (float)((double)image5.Width * 0.2), (float)((double)image5.Height * 0.2), (float)((double)image5.Width * 0.7), (float)((double)image5.Height * 0.7));
				graphics3.Save();
				gfx.DrawImage(image5, num4 - (int)((double)image3.Width / num6) / 2 + (int)((double)image3.Width / num6), (float)((double)num5 - (double)image5.Height * 0.5), (float)((double)image5.Width * 0.4), (float)((double)image5.Height * 0.4));
			}
			else
			{
				if (typeShowUp != 2)
				{
					return;
				}
				Assembly executingAssembly3 = Assembly.GetExecutingAssembly();
				Stream manifestResourceStream3 = executingAssembly3.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.satellite.png");
				switch (junkie.Next(6))
				{
				case 0:
					manifestResourceStream3 = executingAssembly3.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.satellite.png");
					break;
				case 1:
					manifestResourceStream3 = executingAssembly3.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.Satellite2.png");
					break;
				case 2:
					manifestResourceStream3 = executingAssembly3.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.satellite3.png");
					break;
				case 3:
					manifestResourceStream3 = executingAssembly3.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.satellite4.png");
					break;
				case 4:
					manifestResourceStream3 = executingAssembly3.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.satellite5.png");
					break;
				case 5:
					manifestResourceStream3 = executingAssembly3.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.satellite5.png");
					break;
				default:
					manifestResourceStream3 = executingAssembly3.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.satellite5.png");
					break;
				}
				Image image6 = Image.FromStream(manifestResourceStream3);
				int num7 = junkie.Next(1600);
				int num8 = junkie.Next(1000);
				double num9 = (double)junkie.Next(10) + 1.9;
				for (int k = 0; k < 22; k++)
				{
					gfx.DrawImage(image6, num7 - (int)((double)image6.Width / num9) / 2, num8 - (int)((double)image6.Width / num9) / 2, (int)((double)image6.Width / num9), (int)((double)image6.Height / num9));
					if (num9 >= 1.9)
					{
						num9 -= 0.2;
					}
					if (num9 <= 0.2)
					{
						num9 = 0.2;
					}
				}
			}
		}

		public void junkieBeMyGuest(int bolMigTil)
		{
			Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
			}
			bitmap = GrayScale(bitmap);
			gfx.DrawImage(bitmap, new Point(0, 0));
		}

		internal void JusticeFormMoney(int k, int p)
		{
			if (gfx != null)
			{
				GraphicsPath graphicsPath = new GraphicsPath();
				graphicsPath.AddBezier(junkie.Next(k + 600) - junkie.Next(k + 600) + 450, junkie.Next(k + 500) - junkie.Next(k + 500) + 450, junkie.Next(k + 300) - junkie.Next(k + 300) + 450, junkie.Next(k + 600) - junkie.Next(k + 600) + 450, junkie.Next(k + 800) - junkie.Next(k + 800) + 450, junkie.Next(k + 400) - junkie.Next(k + 400) + 450, junkie.Next(k) - junkie.Next(k) + 450, junkie.Next(k + 500) - junkie.Next(k + 500) + 450);
				PathGradientBrush brush = new PathGradientBrush(graphicsPath)
				{
					CenterColor = Color.FromArgb(junkie.Next(5), junkie.Next(250), junkie.Next(250), junkie.Next(250))
				};
				gfx.FillPath(brush, graphicsPath);
			}
		}

		public void landingIsHere(int p)
		{
			explodeMe(junkie.Next(500), junkie.Next(500));
			Thread.Sleep(400);
			new ISoundEngine().Play2D("136702__hoscalegeek__laser-zap.wav");
			switch (junkie.Next(4))
			{
			case 0:
			{
				Image image4 = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.SpaceShip2.png"));
				if (junkie.Next(1) == 0)
				{
					gfx.DrawImage(image4, (float)junkie.Next(1300), (float)junkie.Next(900), (float)image4.Width, (float)image4.Height);
				}
				break;
			}
			case 1:
			{
				Image image2 = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.spaceship3.png"));
				if (junkie.Next(1) == 0)
				{
					gfx.DrawImage(image2, junkie.Next(1300), junkie.Next(900), (float)((double)image2.Width * 0.7), (float)((double)image2.Height * 0.7));
				}
				break;
			}
			case 2:
			{
				Image image3 = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.spaceship4.png"));
				if (junkie.Next(1) == 0)
				{
					gfx.DrawImage(image3, junkie.Next(1300), junkie.Next(900), (float)((double)image3.Width * 1.5), (float)((double)image3.Height * 1.5));
				}
				break;
			}
			case 3:
			{
				Image image = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.spaceship5.png"));
				if (junkie.Next(1) == 0)
				{
					gfx.DrawImage(image, junkie.Next(1300), junkie.Next(900), (float)((double)image.Width * 0.5), (float)((double)image.Height * 0.5));
				}
				break;
			}
			}
			Thread.Sleep(400);
		}

		public void ligegyldigtÆvl()
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Image image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.1.jpg"));
			switch (junkie.Next(7))
			{
			case 0:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.1.jpg"));
				break;
			case 1:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.man.jpg"));
				break;
			case 2:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.woman.jpg"));
				break;
			case 3:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.blob.jpg"));
				break;
			case 4:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.homeless.jpg"));
				break;
			case 5:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.numse.jpg"));
				break;
			case 6:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.potato.jpg"));
				break;
			case 7:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.Hejjegergod.jpg"));
				break;
			case 8:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.Hejhejigen.jpg"));
				break;
			case 9:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.Makihere.jpg"));
				break;
			case 10:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.Martinshjel.jpg"));
				break;
			case 11:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.Mortentænker.jpg"));
				break;
			case 12:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.Migselfies.jpg"));
				break;
			}
			double num = 1.0;
			gfx.DrawImage(image, junkie.Next(1400), junkie.Next(800), (float)((double)image.Width * num), (float)((double)image.Height * num));
			Thread.Sleep(100);
		}

		private void Loadup(object sender, EventArgs e)
		{
			gfx = panel1.CreateGraphics();
			button1.Location = new Point(base.ClientSize.Width - (button1.Width + 100), base.ClientSize.Height - (button1.Height + 50));
			button2.Location = new Point(base.ClientSize.Width - 45, 10);
			Point location = button1.Location;
			location.Y -= button1.Height + 10;
			comboBox1.Location = location;
		}

		public void modifyPoints(Point[] j)
		{
			for (int num = j.Length - 1; num >= 0; num--)
			{
				double num2 = Math.Sin(new Random().Next(500));
				if (num2 == 0.0)
				{
					num2 = 1.0;
				}
				int num3 = num;
				j[num3].X = j[num3].X * (int)(Math.Sin(new Random().Next(500)) / num2);
			}
		}

		public void moveLabel(Label lal, Random kf)
		{
			Point point2 = lal.Location = new Point(kf.Next(200) + 610, kf.Next(140));
		}

		public void nameCalling()
		{
			if (sprach == "Kitara")
			{
				if (junkie.Next(1) == 0)
				{
					gfx.DrawString("Kitara is here", new Font("Segoe Script", 72f, FontStyle.Bold), Brushes.White, new PointF(300f, 500f));
				}
			}
			else if (sprach == "Jongonese")
			{
				if (junkie.Next(1) == 0)
				{
					gfx.DrawString("Jongonese is back", new Font("Segoe Script", 72f, FontStyle.Bold), Brushes.White, new PointF(300f, 500f));
				}
			}
			else if (sprach == "Shislak")
			{
				if (junkie.Next(1) == 0)
				{
					gfx.DrawString("The name is Shislak", new Font("Segoe Script", 72f, FontStyle.Bold), Brushes.White, new PointF(300f, 500f));
				}
			}
			else if (sprach == "Math")
			{
				if (junkie.Next(1) == 0)
				{
					gfx.DrawString("Im in the zone!!!", new Font("Segoe Script", 72f, FontStyle.Bold), Brushes.White, new PointF(300f, 500f));
				}
			}
			else if (sprach == "Word")
			{
				if (junkie.Next(1) == 0)
				{
					gfx.DrawString("Nok om det ikke!!!", new Font("Segoe Script", 72f, FontStyle.Bold), Brushes.White, new PointF(300f, 500f));
				}
			}
			else if (sprach == "KomIndJegHyggerMig" && junkie.Next(1) == 0)
			{
				gfx.DrawString("Tilpas dig selv ikke....", new Font("Segoe Script", 72f, FontStyle.Bold), Brushes.White, new PointF(300f, 500f));
			}
		}

		public void newJongo()
		{
			trælle = new Jongo(this);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			panel1_Paint(0, e);
			base.OnPaint(e);
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		public void pitViper()
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.pit.png");
			Image image = Image.FromStream(manifestResourceStream);
			Image.FromStream(manifestResourceStream);
			switch (junkie.Next(6))
			{
			case 0:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.pit.png"));
				break;
			case 1:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.pit2.png"));
				break;
			case 2:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.pit3.png"));
				break;
			case 3:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.pit4.png"));
				break;
			case 4:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.pit5.png"));
				break;
			case 5:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.pit6.png"));
				break;
			}
			int num = junkie.Next(1600);
			int num2 = junkie.Next(1050);
			double num3 = junkie.NextDouble() + 0.1;
			for (int i = 0; i < junkie.Next(50, 1000); i++)
			{
				if (junkie.Next(17) != 0)
				{
					gfx.DrawImage(image, new Rectangle(new Point(num + (int)(1000.0 * Math.Sin(junkie.Next(10000))), num2 + (int)(600.0 * Math.Sin(junkie.Next(10000)))), new Size(new Point((int)((double)image.Width * num3), (int)((double)image.Height * num3)))));
					Thread.Sleep(junkie.Next(100));
				}
			}
		}

		public void plakMeOn()
		{
			Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
			Bitmap image = new Bitmap(bitmap.Width, bitmap.Height);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
			}
			for (int i = 0; i < junkie.Next(10, 20); i++)
			{
				Graphics graphics2 = Graphics.FromImage(image);
				graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics2.DrawImage(bitmap, 0, 0);
				if (kukur == null)
				{
					break;
				}
				string[] sentenceVolaHovskiPovski = kukur.getSentenceVolaHovskiPovski(junkie.Next(4, 12), junkie.Next(8, 20));
				if (gfx != null)
				{
					int num = junkie.Next(600);
					int num2 = junkie.Next(800);
					List<string> list = new List<string>();
					for (int j = 0; j < sentenceVolaHovskiPovski.Length; j++)
					{
						list.AddRange(sentenceVolaHovskiPovski[j].Split(' '));
					}
					list.RemoveAll((string item) => item == "");
					list.RemoveAll((string item) => item == ",");
					int num3 = 0;
					Size size = new Size(0, 0);
					for (int k = 0; k < junkie.Next(10, 20); k++)
					{
						graphics2.DrawString(list[k], new Font("Arial", 48f), Brushes.White, -300 + size.Width + num, num2);
						size.Width += TextRenderer.MeasureText(list[k], new Font("Arial", 48f)).Width;
						num3 += list[k].Length;
						Thread.Sleep(200);
					}
					Thread.Sleep(100);
				}
				gfx.DrawImage(image, 0, 0);
			}
		}

		public void playMP3()
		{
			junkie.Next(15);
			comboBox1.SelectedIndex = 3;
		}

		public override void Refresh()
		{
		}

		private void ResizeDone(object sender, EventArgs e)
		{
		}

		public void sayonaraCaptainHereComesTheRain()
		{
			if (junkie.Next(1) == 0)
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Image image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.scene.jpg"));
				switch (junkie.Next(12))
				{
				case 0:
					image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.scene.jpg"));
					break;
				case 1:
					image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.scene2.jpg"));
					break;
				case 2:
					image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.scene4.jpg"));
					break;
				case 3:
					image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.scene4.jpg"));
					break;
				case 4:
					image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.scene5.jpg"));
					break;
				case 5:
					image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.scene6.jpg"));
					break;
				case 6:
					image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.scene7.jpg"));
					break;
				case 7:
					image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.scene8.jpg"));
					break;
				case 8:
					image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.scene9.jpg"));
					break;
				case 9:
					image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.scene10.jpg"));
					break;
				case 10:
					image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.scene11.jpg"));
					break;
				case 11:
					image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.scene.png"));
					break;
				}
				gfx.DrawImage(image, 0, 0, 1750, 1100);
				Thread.Sleep(2000);
				weatherManHereICome();
			}
		}

		public Form1 sendForm()
		{
			return this;
		}

		public static Image SetImgOpacity(Image imgPic, float imgOpac)
		{
			Bitmap bitmap = new Bitmap(imgPic.Width, imgPic.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			ColorMatrix newColorMatrix = new ColorMatrix
			{
				Matrix33 = imgOpac
			};
			ImageAttributes imageAttributes = new ImageAttributes();
			imageAttributes.SetColorMatrix(newColorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
			graphics.DrawImage(imgPic, new Rectangle(0, 0, bitmap.Width, bitmap.Height), 0, 0, imgPic.Width, imgPic.Height, GraphicsUnit.Pixel, imageAttributes);
			graphics.Dispose();
			return bitmap;
		}

		public void ShowME()
		{
			if (junkie.Next(3) == 0)
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Image image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.galaxy4.png"));
				switch (junkie.Next(7))
				{
				case 0:
					image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.galaxy.jpg"));
					break;
				case 1:
					image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.galaxy2.jpg"));
					break;
				case 2:
					image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.galaxy3.png"));
					break;
				case 3:
					image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.galaxy4.png"));
					break;
				case 4:
					image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.nebula.png"));
					break;
				case 5:
					image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.nebula2.png"));
					break;
				case 6:
					image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.nebula3.png"));
					break;
				}
				gfx.DrawImage(image, 0, 0, 1750, 1100);
			}
		}

		private int sinusModifier(int posX)
		{
			return Math.Abs((int)(Math.Sin(junkie.Next(360)) * (double)posX));
		}

		public void SpellOut(int p)
		{
			if (kukur == null)
			{
				return;
			}
			string[] sentenceVolaHovskiPovski = kukur.getSentenceVolaHovskiPovski(junkie.Next(4, 12), junkie.Next(8, 20));
			if (gfx != null)
			{
				int num = junkie.Next(600);
				int num2 = junkie.Next(800);
				List<string> list = new List<string>();
				for (int i = 0; i < sentenceVolaHovskiPovski.Length; i++)
				{
					list.AddRange(sentenceVolaHovskiPovski[i].Split(' '));
				}
				list.RemoveAll((string item) => item == "");
				list.RemoveAll((string item) => item == ",");
				int num3 = 0;
				Size size = new Size(0, 0);
				for (int j = 0; j < p; j++)
				{
					gfx.DrawString(list[j], new Font("Arial", 48f), Brushes.White, 50 + size.Width + num, 100 + num2);
					size.Width += TextRenderer.MeasureText(list[j], new Font("Arial", 48f)).Width;
					num3 += list[j].Length;
					Thread.Sleep(200);
				}
				Thread.Sleep(100);
			}
		}

		public Bitmap Superimpose(Bitmap largeBmp, Bitmap smallBmp, Point say)
		{
			Graphics graphics = Graphics.FromImage(largeBmp);
			graphics.CompositingMode = CompositingMode.SourceCopy;
			smallBmp.MakeTransparent();
			graphics.DrawImage(smallBmp, say);
			return largeBmp;
		}

		internal void TeleTubingDoneWrong(int p, string p_2)
		{
			if (gfx != null)
			{
				gfx.DrawString(p_2, new Font("Verdana", 32f, FontStyle.Italic), Brushes.White, new PointF(junkie.Next(1000), junkie.Next(1600)));
			}
		}

		private Juklas tidspres()
		{
			throw new NotImplementedException();
		}

		private void timer1_Elapsed(object sender, ElapsedEventArgs e)
		{
			timer1IsRunning = false;
			Console.WriteLine("Timer stopped");
		}

		private void timer2_Elapsed(object sender, ElapsedEventArgs e)
		{
			timer2IsRunning = false;
			Console.WriteLine("Timer2 stopped");
		}

		public void timetoJongoisme()
		{
			for (int i = 0; i < trælle.getJohn().Count; i++)
			{
				Point[] waypoints = trælle.getJohn()[i].getWaypoints();
				for (int j = 0; j < waypoints.Length; j++)
				{
					Point[] array = waypoints;
					int num = j;
					array[num].X = array[num].X + 1;
					Point[] array2 = waypoints;
					int num2 = j;
					array2[num2].Y = array2[num2].Y + 200;
				}
				trælle.getJohn()[i].changeCourse();
			}
		}

		private void TryEnabled(object sender, EventArgs e)
		{
		}

		internal void trySpiralExplosions(int p, int p_2, int p_3)
		{
			if (gfx == null)
			{
				return;
			}
			int num = junkie.Next(80);
			int posX = junkie.Next(1500);
			int posX2 = junkie.Next(900);
			int num2 = junkie.Next(15) + 60;
			int num3 = junkie.Next(15) + 60;
			int num4 = junkie.Next(15) + 60;
			switch (junkie.Next(7))
			{
			case 0:
				num2 -= 60;
				break;
			case 1:
				num3 -= 60;
				break;
			case 2:
				num4 -= 60;
				break;
			case 3:
				num2 -= 60;
				num4 -= 60;
				break;
			case 4:
				num3 -= 60;
				num2 -= 60;
				break;
			case 5:
				num4 -= 60;
				num3 -= 60;
				break;
			}
			for (int i = 0; i < p; i++)
			{
				if (gfx != null)
				{
					gfx.FillEllipse(new SolidBrush(Color.FromArgb(junkie.Next(40) + 50, junkie.Next(num2) + 175, junkie.Next(num3) + 175, junkie.Next(num4) + 175)), new Rectangle(junkie.Next(30) - junkie.Next(30) + sinusModifier(posX), junkie.Next(30) - junkie.Next(30) + sinusModifier(posX2), junkie.Next(30) + num, junkie.Next(30) + num));
				}
			}
		}

		private static bool TryToDelete(string f)
		{
			try
			{
				File.Delete(f);
				return true;
			}
			catch (IOException)
			{
				return false;
			}
		}

		private void unpackSound()
		{
			resourse[0] = (string)comboBox1.Items[0];
			resourse[1] = (string)comboBox1.Items[1];
			resourse[2] = (string)comboBox1.Items[2];
			resourse[3] = (string)comboBox1.Items[3];
			resourse[4] = (string)comboBox1.Items[4];
			resourse[5] = (string)comboBox1.Items[5];
			resourse[6] = (string)comboBox1.Items[6];
			resourse[7] = (string)comboBox1.Items[7];
			resourse[8] = (string)comboBox1.Items[8];
			resourse[9] = (string)comboBox1.Items[9];
			resourse[10] = (string)comboBox1.Items[10];
			resourse[11] = (string)comboBox1.Items[11];
			resourse[12] = (string)comboBox1.Items[12];
			resourse[13] = (string)comboBox1.Items[13];
			resourse[14] = (string)comboBox1.Items[14];
			resourse[15] = (string)comboBox1.Items[15];
			resourse[16] = (string)comboBox1.Items[16];
			Stream manifestResourceStream = GetType().Assembly.GetManifestResourceStream("mixalot tape 4 2 whatever!!!lol.mp3");
			if (!File.Exists("mixalot tape 4 2 whatever!!!lol.mp3"))
			{
				using (Stream output = File.Create("mixalot tape 4 2 whatever!!!lol.mp3"))
				{
					CopyStream(manifestResourceStream, output);
				}
			}
			manifestResourceStream = GetType().Assembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.ikpMP3.dll");
			if (!File.Exists("ikpMP3.dll"))
			{
				using (Stream output2 = File.Create("ikpMP3.dll"))
				{
					CopyStream(manifestResourceStream, output2);
				}
			}
			manifestResourceStream = GetType().Assembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.irrKlang.NET4.dll");
			if (!File.Exists("irrKlang.NET4.dll"))
			{
				using (Stream output3 = File.Create("irrKlang.NET4.dll"))
				{
					CopyStream(manifestResourceStream, output3);
				}
			}
		}

		public void violenceNearby()
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.wasp.png");
			Image image = Image.FromStream(manifestResourceStream);
			Image.FromStream(manifestResourceStream);
			int num = junkie.Next(800);
			int num2 = junkie.Next(650);
			int num3 = junkie.Next(200, 800);
			int num4 = junkie.Next(200, 600);
			for (int i = 0; i < junkie.Next(50, 500); i++)
			{
				if (junkie.Next(17) != 0)
				{
					switch (junkie.Next(5))
					{
					case 0:
						image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.wasp.png"));
						break;
					case 1:
						image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.wasp2.png"));
						break;
					case 2:
						image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.wasp3.png"));
						break;
					case 3:
						image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.wasp4.png"));
						break;
					case 4:
						image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.waspboss.png"));
						break;
					}
					double num5 = junkie.NextDouble() + 0.3;
					gfx.DrawImage(image, new Rectangle(new Point(num + (int)((double)num3 * Math.Sin(junkie.Next(10000))), num2 + (int)((double)num4 * Math.Sin(junkie.Next(10000)))), new Size(new Point((int)((double)image.Width * num5), (int)((double)image.Height * num5)))));
					Thread.Sleep(junkie.Next(100));
					image.Dispose();
				}
			}
			image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.airforce.png"));
			Thread.Sleep(junkie.Next(200));
			for (int j = 0; j < junkie.Next(2, 10); j++)
			{
				int num6 = junkie.Next(5, 10);
				double num7 = junkie.NextDouble() + 0.1;
				gfx.DrawImage(image, new Rectangle(new Point(junkie.Next(800), junkie.Next(300)), new Size(new Point((int)((double)image.Width / ((double)num6 * num7)), (int)((double)image.Height / ((double)num6 * num7))))));
				Thread.Sleep(junkie.Next(2000));
			}
			num = junkie.Next(800);
			num2 = junkie.Next(650);
			for (int k = 0; k < junkie.Next(50, 200); k++)
			{
				switch (junkie.Next(6))
				{
				case 0:
					image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.soldier.png"));
					break;
				case 1:
					image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.soldier2.png"));
					break;
				case 2:
					image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.soldier3.png"));
					break;
				case 3:
					image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.turret.png"));
					break;
				case 4:
					image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.turret2.png"));
					break;
				case 5:
					image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.forceToReckonWith.png"));
					break;
				}
				double num8 = junkie.NextDouble() + 0.1;
				int num9 = junkie.Next(1, 10);
				gfx.DrawImage(image, new Rectangle(new Point(num + (int)(400.0 * Math.Sin(junkie.Next(10000))), num2 + (int)(200.0 * Math.Sin(junkie.Next(10000)))), new Size(new Point((int)((double)image.Width * num8) / num9, (int)((double)image.Height * num8) / num9))));
				Thread.Sleep(junkie.Next(100));
				image.Dispose();
			}
			num = junkie.Next(800);
			num2 = junkie.Next(650);
			ISoundEngine soundEngine = new ISoundEngine();
			bool flag = true;
			if (junkie.Next(200) >= 50)
			{
				flag = false;
			}
			for (int l = 0; l < junkie.Next(50, 200); l++)
			{
				switch (junkie.Next(4))
				{
				case 0:
					image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.explosion.png"));
					soundEngine.Play2D("109753__soundcollectah__tre-hit-long.wav");
					break;
				case 1:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.explosion2.png");
					soundEngine.Play2D("35464__jobro__explosion-7.wav");
					image = Image.FromStream(manifestResourceStream);
					break;
				case 2:
					image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.explosion3.png"));
					soundEngine.Play2D("86026__harpoyume__explosion-3.wav");
					break;
				case 3:
					image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.explosion4.png"));
					soundEngine.Play2D("93846__cgeffex__huge-explosion6.wav");
					break;
				}
				double num10 = junkie.NextDouble() + 0.1;
				int num11 = junkie.Next(1, 10);
				gfx.DrawImage(image, new Rectangle(new Point(num + (int)(400.0 * Math.Sin(junkie.Next(10000))), num2 + (int)(200.0 * Math.Sin(junkie.Next(10000)))), new Size(new Point((int)((double)image.Width * num10) / num11, (int)((double)image.Height * num10) / num11))));
				int millisecondsTimeout = junkie.Next(300);
				int millisecondsTimeout2 = junkie.Next(600);
				if (flag)
				{
					Thread.Sleep(millisecondsTimeout2);
				}
				else
				{
					Thread.Sleep(millisecondsTimeout);
				}
				image.Dispose();
			}
		}

		public void WalkAroundSpaceman()
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.pit.png");
			Image image = Image.FromStream(manifestResourceStream);
			Image.FromStream(manifestResourceStream);
			switch (junkie.Next(6))
			{
			case 0:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.pit.png"));
				break;
			case 1:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.pit2.png"));
				break;
			case 2:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.pit3.png"));
				break;
			case 3:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.pit4.png"));
				break;
			case 4:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.pit5.png"));
				break;
			case 5:
				image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.pit6.png"));
				break;
			}
			Assembly executingAssembly2 = Assembly.GetExecutingAssembly();
			Stream manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman.png");
			Image image2 = Image.FromStream(manifestResourceStream2);
			Image image3 = Image.FromStream(manifestResourceStream2);
			switch (junkie.Next(7))
			{
			case 0:
				image2 = Image.FromStream(executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman.png"));
				break;
			case 1:
				image2 = Image.FromStream(executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman2.png"));
				break;
			case 2:
				image2 = Image.FromStream(executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman3.png"));
				break;
			case 3:
				image2 = Image.FromStream(executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman4.png"));
				break;
			case 4:
				image2 = Image.FromStream(executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman5.png"));
				break;
			case 5:
				image2 = Image.FromStream(executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman6.png"));
				break;
			case 6:
				image2 = Image.FromStream(executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman7.png"));
				break;
			}
			switch (junkie.Next(7))
			{
			case 0:
				image3 = Image.FromStream(executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman.png"));
				break;
			case 1:
				image3 = Image.FromStream(executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman2.png"));
				break;
			case 2:
				image3 = Image.FromStream(executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman3.png"));
				break;
			case 3:
				image3 = Image.FromStream(executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman4.png"));
				break;
			case 4:
				image3 = Image.FromStream(executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman5.png"));
				break;
			case 5:
				image3 = Image.FromStream(executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman6.png"));
				break;
			case 6:
				image3 = Image.FromStream(executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman7.png"));
				break;
			}
			int num = junkie.Next(1600);
			int num2 = junkie.Next(1050);
			double num3 = junkie.NextDouble() + 0.1;
			if (num3 > 0.6)
			{
				num3 = 0.6;
			}
			for (int i = 0; i < junkie.Next(50, 1000); i++)
			{
				if (junkie.Next(17) != 0)
				{
					gfx.DrawImage(image2, new Rectangle(new Point(num + (int)(1000.0 * Math.Sin(junkie.Next(10000))), num2 + (int)(300.0 * Math.Sin(junkie.Next(10000)))), new Size(new Point((int)((double)image2.Width * num3), (int)((double)image2.Height * num3)))));
					Thread.Sleep(junkie.Next(100));
				}
				else
				{
					gfx.DrawImage(image3, new Rectangle(new Point(num + (int)(1000.0 * Math.Sin(junkie.Next(10000))), num2 + (int)(300.0 * Math.Sin(junkie.Next(10000)))), new Size(new Point((int)((double)image3.Width * num3), (int)((double)image3.Height * num3)))));
					Thread.Sleep(junkie.Next(100));
				}
				if (junkie.Next(2) == 0)
				{
					gfx.DrawImage(image, new Rectangle(new Point(num + (int)(1000.0 * Math.Sin(junkie.Next(10000))), num2 + (int)(300.0 * Math.Sin(junkie.Next(10000)))), new Size(new Point((int)((double)image.Width * num3), (int)((double)image.Height * num3)))));
					Thread.Sleep(junkie.Next(100));
				}
			}
		}

		public void weatherManHereICome()
		{
			if (junkie.Next(1) != 0)
			{
				return;
			}
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Image image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.rain.png"));
			if (junkie.Next(5) == 0)
			{
				if (junkie.Next(1) == 0)
				{
					image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.rain.png"));
				}
				gfx.DrawImage(image, 0, 0, 1750, 1100);
			}
			if (junkie.Next(3) == 0)
			{
				switch (junkie.Next(3))
				{
				case 0:
					image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.voltage.png"));
					break;
				case 1:
					image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.voltage2.png"));
					break;
				case 2:
					image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.voltage3.png"));
					break;
				}
				gfx.DrawImage(image, 0, 0, 1750, 1100);
			}
			if (junkie.Next(4) != 0)
			{
				return;
			}
			image = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.cloud.png"));
			Image image2 = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.cloud2.png"));
			Image image3 = Image.FromStream(executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.cloud3.png"));
			double num = junkie.NextDouble();
			if (num > 0.5)
			{
				num = 0.5;
			}
			switch (junkie.Next(2))
			{
			case 0:
				for (int j = 0; j < 15; j++)
				{
					if (junkie.Next(2) == 0)
					{
						gfx.DrawImage(image, junkie.Next(1600), junkie.Next(200), (float)((double)image.Width * num), (float)((double)image.Height * num));
					}
					else
					{
						gfx.DrawImage(image2, junkie.Next(1600), junkie.Next(200), (float)((double)image2.Width * num), (float)((double)image2.Height * num));
					}
				}
				break;
			case 1:
				for (int i = 0; i < 15; i++)
				{
					if (junkie.Next(1) == 0)
					{
						gfx.DrawImage(image3, junkie.Next(1600), junkie.Next(400), (float)((double)image.Width * num), (float)((double)image.Height * num));
					}
				}
				break;
			}
		}

		public void wierdoFuckMe(int p)
		{
			if (kukur == null)
			{
				return;
			}
			string[] sentenceVolaHovskiPovski = kukur.getSentenceVolaHovskiPovski(junkie.Next(4, 12), junkie.Next(8, 20));
			if (gfx != null)
			{
				int num = junkie.Next(600);
				int num2 = junkie.Next(800);
				List<string> list = new List<string>();
				for (int i = 0; i < sentenceVolaHovskiPovski.Length; i++)
				{
					list.AddRange(sentenceVolaHovskiPovski[i].Split(' '));
				}
				list.RemoveAll((string item) => item == "");
				list.RemoveAll((string item) => item == ",");
				string[] array = new string[10]
				{
					"Arial",
					"Times New Roman",
					"Verdana",
					"Tahoma",
					"Garamond",
					"",
					"",
					"",
					"",
					""
				};
				new Size(0, 0);
				string familyName = array[3];
				string text = "";
				for (int j = 0; j < p; j++)
				{
					text = text + list[j] + " ";
				}
				gfx.DrawString(text, new Font(familyName, 48f), Brushes.White, 50 + num, 100 + num2);
			}
			Thread.Sleep(600);
		}

		internal void writeMeAStory()
		{
			int num = junkie.Next(600);
			int num2 = junkie.Next(800);
			string[] sentenceVolaHovskiPovski = kukur.getSentenceVolaHovskiPovski(junkie.Next(4, 12), junkie.Next(8, 20));
			if (gfx != null)
			{
				for (int i = 0; i < sentenceVolaHovskiPovski.Length; i++)
				{
					gfx.DrawString(sentenceVolaHovskiPovski[i], new Font("Arial", 24f), Brushes.White, 100 + num, 100 + num2 + i * 30);
				}
				Thread.Sleep(2000);
			}
		}
	}
}
