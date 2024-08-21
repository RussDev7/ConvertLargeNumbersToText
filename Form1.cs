using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NumToText
{
    // Original Project: http://www.blackbeltcoder.com/Articles/strings/converting-numbers-to-words
    public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnConvert_Click(object sender, EventArgs e)
		{
			try
			{
				txtText.Clear();
                txtText.Text = NumberToText.Convert(txtNumber.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		// Copy text.
		private void button1_Click(object sender, EventArgs e)
		{
			if (txtText.Text != "")
				Clipboard.SetText(txtText.Text);
		}
    }
}
