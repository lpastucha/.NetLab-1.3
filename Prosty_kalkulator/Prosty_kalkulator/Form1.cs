using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Prosty_kalkulator
{
    
    public partial class Form1 : Form
    {
        public enum Operacja
        {
            ADD, ODD, MULT, DIV
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            calculate(Operacja.ADD);
           
        }
        private void showError()
        {
            errorMsgLbl.Visible = true;
        }

        private void hideError()
        {
            errorMsgLbl.Visible = false;
        }

        private void calculate(Operacja op)
        {
            try
            {
               float value1 = float.Parse(arg1.Text);
               float value2 = float.Parse(arg2.Text);
                
                hideError();
                switch (op)
                {
                    case Operacja.ADD:
                        {
                            resultBox.Text = (value1 + value2).ToString();
                            break;
                        }
                    case Operacja.ODD:
                        {
                            resultBox.Text = (value1 - value2).ToString();
                            break;
                        }
                    case Operacja.MULT:
                        {
                            resultBox.Text = (value1 * value2).ToString();
                            break;
                        }
                    case Operacja.DIV:
                        {
                            if(value2 == 0)
                            {
                                showError();
                            }
                            else { resultBox.Text = (value1 / value2).ToString(); }
                            
                            break;
                        }
                }
            }
            catch (FormatException)
            {
                showError();
            }
            
        }

        private void oddBtn_Click(object sender, EventArgs e)
        {
            calculate(Operacja.ODD);
        }

        private void multBtn_Click(object sender, EventArgs e)
        {
            calculate(Operacja.MULT);
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            calculate(Operacja.DIV);
        }
    }
}
