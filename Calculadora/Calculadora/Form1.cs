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
        private void BntLimparHistorico_Click(object sender, EventArgs e)
        {
            RtBoxDisplayHistorico.Clear();
            if (RtBoxDisplayHistorico.Text == string.Empty)
                RtBoxDisplayHistorico.Text = "Ainda não há historico!";
        }
        private void BtnApagar_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text.Length > 0)
                TxtDisplay1.Text = TxtDisplay1.Text.Remove(TxtDisplay1.Text.Length - 1, 1);
            if (TxtDisplay1.Text == string.Empty) TxtDisplay1.Text = "0";
        }
        private void BtnC_Click(object sender, EventArgs e)
        {
            TxtDisplay1.Text = "0";
            TxtDisplay2.Text = string.Empty;
            result = 0;
        }
        private void BtnCE_Click(object sender, EventArgs e)
        {
            TxtDisplay1.Text = "0";
        }

        private void BtnOperacoes_Click(object sender, EventArgs e)
        {
            MordenButtonCalculater button = (MordenButtonCalculater)sender;
            operation = button.Text;
            switch (operation)
            {
                case "√x":
                    TxtDisplay2.Text = $"√x({TxtDisplay1.Text})";
                    TxtDisplay1.Text = Convert.ToString(Math.Sqrt(Double.Parse(TxtDisplay1.Text)));
                    break;
                case "^2":
                    TxtDisplay2.Text = $"({TxtDisplay1.Text})^2";
                    TxtDisplay1.Text = Convert.ToString(Convert.ToDouble(TxtDisplay1.Text) * Convert.ToDouble(TxtDisplay1.Text));
                    break;
                case "¹/x":
                    TxtDisplay2.Text = $"¹/({TxtDisplay1.Text})";
                    TxtDisplay1.Text = Convert.ToString(1.0 / Convert.ToDouble(TxtDisplay1.Text));
                    break;
                case "%":
                    TxtDisplay2.Text = $"%({TxtDisplay1.Text})";
                    TxtDisplay1.Text = Convert.ToString(Convert.ToDouble(TxtDisplay1.Text) / Convert.ToDouble(100));
                    break;
                case "±":
                    TxtDisplay1.Text = Convert.ToString(-1 * Convert.ToDouble(TxtDisplay1.Text));
                    break;
            }
            RtBoxDisplayHistorico.AppendText($"{TxtDisplay2.Text} = {TxtDisplay1.Text} \n");
        }

        private void BntExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Fecha o aplicativo
        }

        private void BntMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Minimiza a janela
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                // Se a janela está maximizada, restaura para o tamanho normal
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                // Se a janela está no tamanho normal, maximiza
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void TxtDisplay1_TextChanged(object sender, EventArgs e)
        {

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
