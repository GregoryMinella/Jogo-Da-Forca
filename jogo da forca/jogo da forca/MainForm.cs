using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace jogo_da_forca
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
		}
		
		//============ Variaveis Globais =======================
		int errou = 0;
		
		void Button1Click(object sender, EventArgs e)
		{
			string palavra = textBox1.Text;
			int encontrar = 0;
			textBox1.Visible = false;
			button1.Visible = false;
			for (int i = 0; i < palavra.Length; i++)
			{
				encontrar++;
				label1.Text = "Existem " + encontrar + " letras na palavra";
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			string palavra = textBox1.Text;
			string letra = textBox2.Text;
			int encontrar = 0;
			
			
			for (int i = 0; i < palavra.Length; i++)
			{
				if (palavra[i].ToString() == letra) 
				{
					encontrar++;
				}
			}
			
			if (encontrar == 0)
			{
				errou++;
			}
			
			if (errou >= 1) 
			{
				listBox1.Items.Add("Voce errou " + errou + " vezes");
			}
			
			if (errou == 6)
			{
				button2.Visible = false;
				textBox2.Visible = false;
				MessageBox.Show("Seu limite de tentativas foi excedido você é obrigado a chutar uma palavra");
			}
			
			listBox1.Items.Add("a letra (" + letra + ") aparece (" + encontrar + ") vezes");
			
			if (errou == 6)
			{
				listBox1.Items.Clear();
			}
			
		}
		void Button3Click(object sender, EventArgs e)
		{
			string palavra = textBox1.Text;
			string chute = textBox3.Text;
			if (palavra == chute) 
			{
				BackColor = Color.Green;
				label2.Text = "Resultado: Você ganhou!!!";
				
			}
			else
			{
				label2.Text = "Resultado: Você perdeu!!!";
				BackColor = Color.Red;
			}
			
		}		
	 }
}
