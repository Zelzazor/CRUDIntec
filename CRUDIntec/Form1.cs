using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDIntec
{
    public partial class Form1 : Form
    {
        private readonly Random random = new Random();

        private int timeLeft = 60 * 5;
        private int result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTime.Text = $"Hoy es: {DateTime.Now.ToString("F")}";
            txtTiempoRestante.Text = $"{timeLeft} segundos(s)";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = $"Hoy es: {DateTime.Now.ToString("F")}";

        }

        private bool SpecificResult(Label lblOperando1, Label lblOperando2, TextBox txtResultado, string operacion, TextBox txtRest)
        {
            if (txtResultado.Text == "") return false;
            if (!int.TryParse(txtResultado.Text, out _)) return false;
            int operando1 = int.Parse(lblOperando1.Text);
            int operando2 = int.Parse(lblOperando2.Text);
            int actualResult = int.Parse(txtResultado.Text);
            int correctedRest = 0;
            int correctResult;
            switch (operacion)
            {
                case "+": correctResult = operando1 + operando2; break;
                case "-": correctResult = operando1 - operando2; break;
                case "*": correctResult = operando1 * operando2; break;
                case "/": correctResult = operando1 / operando2; correctedRest = operando1 % operando2; break;
                default: correctResult = operando1 + operando2; break;
            }

            if (operacion == "/")
            {
                if (txtRest == null || txtRest.Text == "" || !int.TryParse(txtRest.Text, out _)) return false;
                int actualRest = int.Parse(txtRest.Text);
                if (correctResult == actualResult && correctedRest == actualRest) return true;

            }
            else
            {
                if (correctResult == actualResult) return true;
            }

            return false;

        }

        private void GetTestResults()
        {
            if (SpecificResult(lblSumando1, lblSumando2, txtSuma, lblSuma.Text, null)) result++;
            if (SpecificResult(lblMinuendo, lblSustraendo, txtResta, lblResta.Text, null)) result++;
            if (SpecificResult(lblFactor1, lblFactor2, txtMultiplicacion, lblMultiplicacion.Text, null)) result++;
            if (SpecificResult(lblDividendo, lblDivisor, txtDivision, lblDivision.Text, txtResiduo)) result++;

            MessageBox.Show($"Ha sacado {result} de 4 preguntas correctas");
        
        }

        private void tmrTiempoRestante_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            txtTiempoRestante.Text = $"{timeLeft} segundo(s)";

            if(timeLeft == 0)
            {
                FinishTest();
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            tmrTiempoRestante.Start();
            btnIniciar.Enabled = false;
            btnCancelar.Enabled = true;
            btnTerminar.Enabled = true;

            TextBox[] textBoxes = { txtSuma, txtResta, txtMultiplicacion, txtDivision, txtResiduo };

            foreach(TextBox textBox in textBoxes)
            {
                textBox.Enabled = true;
            }

            GenerateTest();
        }

        private void GenerateTest()
        {
            Label[] labels = { lblSumando1, lblSumando2, lblMinuendo, lblSustraendo, lblFactor1, lblFactor2, lblDividendo, lblDivisor };
            
            foreach(Label label in labels)
            {
                label.Text = random.Next(1, 99).ToString();
            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            timeLeft = 300;
            txtTiempoRestante.Text = $"{timeLeft} segundo(s)";
            btnIniciar.Enabled = true;
            btnCancelar.Enabled = false;

            TextBox[] textBoxes = { txtSuma, txtResta, txtMultiplicacion, txtDivision, txtResiduo };

            foreach (TextBox textBox in textBoxes)
            {
                textBox.Text = "";
                textBox.Enabled = false;
            }

            Label[] labels = { lblSumando1, lblSumando2, lblMinuendo, lblSustraendo, lblFactor1, lblFactor2, lblDividendo, lblDivisor };

            foreach (Label label in labels)
            {
                label.Text = "?";
            }
            tmrTiempoRestante.Stop();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            FinishTest();
        }

        private void FinishTest()
        {
            tmrTiempoRestante.Stop();
            timeLeft = 300;
            txtTiempoRestante.Text = $"{timeLeft} segundo(s)";
            btnIniciar.Enabled = true;
            btnCancelar.Enabled = false;
            GetTestResults();
            btnTerminar.Enabled = false;
            
            result = 0;
            TextBox[] textBoxes = { txtSuma, txtResta, txtMultiplicacion, txtDivision, txtResiduo };
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Text = "";
                textBox.Enabled = false;
            }

            Label[] labels = { lblSumando1, lblSumando2, lblMinuendo, lblSustraendo, lblFactor1, lblFactor2, lblDividendo, lblDivisor };

            foreach (Label label in labels)
            {
                label.Text = "?";
            }
         
        }
    }
}
