/*
 * Created by SharpDevelop.
 * User: CC2-PC15
 * Date: 14/11/2024
 * Time: 03:00 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tapetes
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void btn(object sender, EventArgs e)
		{
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			//variables para almacenar los datos de las textboxes
			double tot, to, aser, agua, pint, frut, flor, hrs, person, mano, anch, larg;
			//El if se asegura de que se hallan llenado todos los campos
			if (txt1.Text != "" && txt2.Text != "" && txt3.Text != "" && txt4.Text != "" && txt5.Text != "" && txt6.Text != "" && txt7.Text != "" && txt8.Text != "" && txt9.Text != "" && txt10.Text != "")
			{
				//Transformar los datos de las textbox para guardarlos como doubles
				aser = Convert.ToDouble(txt1.Text);
				agua = Convert.ToDouble(txt2.Text);
				pint = Convert.ToDouble(txt3.Text);
				frut = Convert.ToDouble(txt4.Text);
				flor = Convert.ToDouble(txt5.Text);
				hrs = Convert.ToDouble(txt6.Text);
				person = Convert.ToDouble(txt7.Text);
				mano = Convert.ToDouble(txt8.Text);
				anch = Convert.ToDouble(txt9.Text);
				larg = Convert.ToDouble(txt10.Text);
			
				//precio de un metro cuadrado basado en lo que investigue que se usa de material
				to = (aser * 3) + (agua * 0.9) + (pint* 0.2) + (frut*0.8) + (flor*1) + (hrs * 0.33);
				//multiplica el precio de un metro por el tamaño del tapate y suma a eso el gasto de mano de obra, tiempo, etc
				tot = (anch*larg) * (to) + (person*120) + (mano*person);
				//Transforma el resultado a un string para mostrarlo en la textBox que lo enseñara
				string total = tot.ToString();
				textBox1.Text = total;
			}	
		}
	}
}
