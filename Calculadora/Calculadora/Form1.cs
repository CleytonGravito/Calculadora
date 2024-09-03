using MorderButton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        //Campos
        Double result = 0;
        string operation = string.Empty;
        string fstNum, sndNum;
        bool enterValue = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mordenButton2_Click(object sender, EventArgs e)
        {

        }

        private void mordenButton4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mordenButtonCalculater13_Click(object sender, EventArgs e)
        {

        }

        private void BtnOperacao_Click(object sender, EventArgs e)
        {
            if (result != 0) BtnEquals.PerformClick();
            else result = Double.Parse(TxtDisplay1.Text);

            MordenButtonCalculater button = (MordenButtonCalculater)sender;
            operation = button.Text;
            enterValue = true;
            if (TxtDisplay1.Text != "0")
            {
                TxtDisplay2.Text = fstNum = $"{result}{operation}";
                TxtDisplay1.Text = string.Empty;
            }
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            sndNum = TxtDisplay1.Text;
            TxtDisplay2.Text = $"{TxtDisplay2.Text} {TxtDisplay1.Text} =";
            if (TxtDisplay1.Text != string.Empty)
            {
                if (TxtDisplay1.Text == "0") TxtDisplay2.Text = string.Empty;
                switch (operation)
                {
                    case "+":
                        TxtDisplay1.Text = (result + Double.Parse(TxtDisplay1.Text)).ToString();
                        RtBoxDisplayHistorico.AppendText($"{fstNum} {sndNum} = {TxtDisplay1.Text} \n");
                        break;
                    case "-":
                        TxtDisplay1.Text = (result - Double.Parse(TxtDisplay1.Text)).ToString();
                        RtBoxDisplayHistorico.AppendText($"{fstNum} {sndNum} = {TxtDisplay1.Text} \n");
                        break;
                    case "x":
                        TxtDisplay1.Text = (result * Double.Parse(TxtDisplay1.Text)).ToString();
                        RtBoxDisplayHistorico.AppendText($"{fstNum} {sndNum} = {TxtDisplay1.Text} \n");
                        break;
                    case "÷":
                        TxtDisplay1.Text = (result / Double.Parse(TxtDisplay1.Text)).ToString();
                        RtBoxDisplayHistorico.AppendText($"{fstNum} {sndNum} = {TxtDisplay1.Text} \n");
                        break;
                    default: TxtDisplay2.Text = $"{TxtDisplay1.Text} =";
                        break;
                }
            }
        }

        private void BntHistorico_Click(object sender, EventArgs e)
        {
            PnlHistorico.Height = (PnlHistorico.Height == 5) ? PnlHistorico.Height = 345 : 5;
        }

        private void BtnNum_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text == "0" || enterValue) TxtDisplay1.Text = string.Empty;

            enterValue = false;
            MordenButtonCalculater button = (MordenButtonCalculater)sender;
            if (button.Text == ".")
            {
                if (!TxtDisplay1.Text.Contains("."))
                    TxtDisplay1.Text = TxtDisplay1.Text + button.Text;
            }
            else TxtDisplay1.Text = TxtDisplay1.Text + button.Text;
        }
    }
}
