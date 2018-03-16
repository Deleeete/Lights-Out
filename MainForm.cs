/*
 * Created by SharpDevelop.
 * User: User
 * Date: 2017/10/6
 * Time: 12:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lights_out
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		
		public Button[,] Btn=new Button[5,5];
		public int Steps=0;
		//public Color Bck=Color.Black;
		//public Color Wte=Color.White;
		
		
		
		static int GetRandomSeed( )
		{
			byte[] bytes = new byte[4]; 
			System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
			rng.GetBytes(bytes);
			return BitConverter.ToInt32(bytes,0);
		}
		public void Change(int x,int y)
		{
			if (this.Btn[x,y].BackColor==Color.Black)
			{
				this.Btn[x,y].BackColor=Color.White;
			}
			else
			{
				this.Btn[x,y].BackColor=Color.Black;
			}
			
			if (x!=0)
			{
				if (this.Btn[x-1,y].BackColor==Color.Black)
				{
					this.Btn[x-1,y].BackColor=Color.White;
				}
				else
				{
					this.Btn[x-1,y].BackColor=Color.Black;
				}
			}
			
			if (x!=4)
			{
				if (this.Btn[x+1,y].BackColor==Color.Black)
				{
					this.Btn[x+1,y].BackColor=Color.White;
				}
				else
				{
					this.Btn[x+1,y].BackColor=Color.Black;
				}
			}
			
			if (y!=0)
			{
				if (this.Btn[x,y-1].BackColor==Color.Black)
				{
					this.Btn[x,y-1].BackColor=Color.White;
				}
				else
				{
					this.Btn[x,y-1].BackColor=Color.Black;
				}
			}
			
			if (y!=4)
			{
				if (this.Btn[x,y+1].BackColor==Color.Black)
				{
					this.Btn[x,y+1].BackColor=Color.White;
				}
				else
				{
					this.Btn[x,y+1].BackColor=Color.Black;
				}
			}
			
				Steps++;
				this.label27.Text=Convert.ToString(Steps);
				
				for (int i=0;i<=4;i++)
				{	
					for (int j=0;j<=4;j++)
					{
						if (Btn[i,j].BackColor==Color.Black)
						{
							Btn[i,j].FlatAppearance.MouseOverBackColor=Color.DarkCyan;
						}
						if (Btn[i,j].BackColor==Color.White)
						{
							Btn[i,j].FlatAppearance.MouseOverBackColor=Color.LightCyan;
						}
					}
				}
				
		}
		
		
		
		public MainForm()
		{
			
			InitializeComponent();
			this.label27.Text=Convert.ToString(Steps);
			
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			Random ro = new Random(GetRandomSeed());
			Btn[0,0]=this.l0;
			Btn[0,1]=this.l1;
			Btn[0,2]=this.l2;
			Btn[0,3]=this.l3;
			Btn[0,4]=this.l4;
			Btn[1,0]=this.l5;
			Btn[1,1]=this.l6;
			Btn[1,2]=this.l7;
			Btn[1,3]=this.l8;
			Btn[1,4]=this.l9;
			Btn[2,0]=this.l10;
			Btn[2,1]=this.l11;
			Btn[2,2]=this.l12;
			Btn[2,3]=this.l13;
			Btn[2,4]=this.l14;
			Btn[3,0]=this.l15;
			Btn[3,1]=this.l16;
			Btn[3,2]=this.l17;
			Btn[3,3]=this.l18;
			Btn[3,4]=this.l19;
			Btn[4,0]=this.l20;
			Btn[4,1]=this.l21;
			Btn[4,2]=this.l22;
			Btn[4,3]=this.l23;
			Btn[4,4]=this.l24;
			
			
			for (int i=1;i<=666;i++)
			{
				int rnd=ro.Next(0,5);
				int RND=ro.Next(0,5);
				Change(rnd,RND);
			}
			for (int i=0;i<=4;i++)
			{	
				for (int j=0;j<=4;j++)
				{
					this.Btn[i,j].Enabled=true;			//Enable Btn
					
				}
			}
			Steps=0;
			this.label27.Text=Convert.ToString(Steps);
			this.button2.Enabled=true;
				
		}
		
	
			
			
			
			
			
	
		void L9Click(object sender, EventArgs e)
		{
			Change(1,4);
		}
		void L4Click(object sender, EventArgs e)
		{
			Change(0,4);
		}
		void L3Click(object sender, EventArgs e)
		{
			Change(0,3);
		}
		void L2Click(object sender, EventArgs e)
		{
			Change(0,2);
		}
		void L1Click(object sender, EventArgs e)
		{
			Change(0,1);
		}
		void L0Click(object sender, EventArgs e)
		{
			Change(0,0);
		}
		void L5Click(object sender, EventArgs e)
		{
			Change(1,0);
		}
		void L6Click(object sender, EventArgs e)
		{
			Change(1,1);
		}
		void L7Click(object sender, EventArgs e)
		{
			Change(1,2);
		}
		void L8Click(object sender, EventArgs e)
		{
			Change(1,3);
		}
		void L10Click(object sender, EventArgs e)
		{
			Change(2,0);
		}
		void L11Click(object sender, EventArgs e)
		{
			Change(2,1);
		}
		void L12Click(object sender, EventArgs e)
		{
			Change(2,2);
		}
		void L13Click(object sender, EventArgs e)
		{
			Change(2,3);
		}
		void L14Click(object sender, EventArgs e)
		{
			Change(2,4);
		}
		void L15Click(object sender, EventArgs e)
		{
			Change(3,0);
		}
		void L16Click(object sender, EventArgs e)
		{
			Change(3,1);
		}
		void L17Click(object sender, EventArgs e)
		{
			Change(3,2);
		}
		void L18Click(object sender, EventArgs e)
		{
			Change(3,3);
		}
		void L19Click(object sender, EventArgs e)
		{
			Change(3,4);
		}
		void L20Click(object sender, EventArgs e)
		{
			Change(4,0);
		}
		void L21Click(object sender, EventArgs e)
		{
			Change(4,1);
		}
		void L22Click(object sender, EventArgs e)
		{
			Change(4,2);
		}
		void L23Click(object sender, EventArgs e)
		{
			Change(4,3);
		}
		void L24Click(object sender, EventArgs e)
		{
			Change(4,4);
		}
		void Button2Click(object sender, EventArgs e)
		{
			Steps=0;
			this.label27.Text=Convert.ToString(Steps);
			for (int k=0;k<=4;k++)
			{
				for (int l=0;l<=4;l++)
				{
					Btn[k,l].BackColor=Color.Black;
				}
			}
		}
		void Label26Click(object sender, EventArgs e)
		{
			
		}
		void Label1Click(object sender, EventArgs e)
		{
			
			Steps=0;
			this.label27.Text=Convert.ToString(Steps);
		}
		public void Form_KeyPress(object sender, KeyPressEventArgs e) 
		{ 
			if (e.KeyChar == (char)Keys.W)
			{
				MessageBox.Show("Cheating code activated.");
			} 

		}
		void Label2Click(object sender, EventArgs e)
		{
			Btn[3,0].BackColor=Color.White;
			Btn[1,0].BackColor=Color.White;
		} 
		
		
	}
}