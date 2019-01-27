using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Convert_Click(object sender, EventArgs e)
        {
            try
            {
                string number = TextBox_Number.Text;
                uint currentBase = uint.Parse(TextBox_CurrentBase.Text);
                uint convertedToBase = uint.Parse(TextBox_ConvertedToBase.Text);

                NumberConverter numberConverter = new NumberConverter(number, currentBase, convertedToBase);

                RichTextBox_Output.Text = numberConverter.Convert();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
