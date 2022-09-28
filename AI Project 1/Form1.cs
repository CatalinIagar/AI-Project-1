﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AI_Project_1.Functii;

namespace AI_Project_1
{
    public partial class Form1 : Form
    {
        public int nOfInputs = 0;
        List<NumericUpDown> inputsX = new List<NumericUpDown>();
        List<NumericUpDown> inputsW = new List<NumericUpDown>();
        List<Label> labelsX = new List<Label>();
        List<Label> labelsW = new List<Label>();

        Neuron neuron = new Neuron();
        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.LightGray;

            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;

            tetaInput.DecimalPlaces = 2;
            tetaInput.Increment = 0.1M;
            gInput.DecimalPlaces = 2;
            gInput.Increment = 0.1M;
            updateInfo();
        }

        private void updateInfo()
        {
            if (btnSuma.Checked) neuron.ginput = FunctiiInput.calculInputSuma(neuron) - neuron.teta;
            if (btnProdus.Checked) neuron.ginput = FunctiiInput.calculInputprodus(neuron) - neuron.teta;
            if (btnMin.Checked) neuron.ginput = FunctiiInput.calculInputMinim(neuron) - neuron.teta;
            if (btnMaxim.Checked) neuron.ginput = FunctiiInput.calculInputMaxim(neuron) - neuron.teta;

            if (btnTreapta.Checked) neuron.activation = FunctiiActivare.calculActivareTreapta(neuron);
            if (btnSemn.Checked) neuron.activation = FunctiiActivare.calculActivareSemn(neuron);
            if (btnSigm.Checked) neuron.activation = FunctiiActivare.calculActivareSigmoidala(neuron);
            if (btnTanh.Checked) neuron.activation = FunctiiActivare.calculActivareTanh(neuron);
            if (btnLiniara.Checked) neuron.activation = FunctiiActivare.calculActivareLiniara(neuron);

            neuron.output = calculOuput();

            txtInput.Text = neuron.ginput.ToString();
            txtActivare.Text = neuron.activation.ToString();
            txtOut.Text = neuron.output.ToString();
        }

        private double calculOuput()
        {
            if (btnTreapta.Checked || btnSemn.Checked) return neuron.activation;
            if (btnSigm.Checked)
            {
                if (neuron.activation >= 0.5) return 1;
                return 0;
            }
            if(btnTanh.Checked || btnLiniara.Checked)
            {
                if(neuron.activation >= 0) return 1;
                return -1;
            }
            return 0;
        }

        private void valueInput_ValueChanged(object sender, EventArgs e)
        {
            int newNOfInputs = Convert.ToInt32(valueInput.Value);
            if (newNOfInputs > nOfInputs)
            {
                addNewInput(newNOfInputs);
            }

            if (newNOfInputs < nOfInputs)
            {
                deleteLastInput(newNOfInputs);
            }
        }

        private void addNewInput(int newNOfInputs)
        {
            nOfInputs = newNOfInputs;
            neuron.nOfInputs++;

            Label labelX = new Label();
            labelX.Text = "X" + nOfInputs.ToString();
            labelX.Size = new System.Drawing.Size(30, 30);
            labelX.Margin = new Padding(5, 5, 0, 5);
            NumericUpDown numericUpDownX = new NumericUpDown();
            numericUpDownX.ValueChanged += new EventHandler(inputValueChanged);
            numericUpDownX.Name = nOfInputs.ToString();
            numericUpDownX.Size = new System.Drawing.Size(50, 30);
            numericUpDownX.Maximum = 1000;
            numericUpDownX.Minimum = -1000;
            numericUpDownX.DecimalPlaces = 2;
            numericUpDownX.Increment = 0.01M;
            Array.Resize(ref neuron.x, nOfInputs);
            neuron.x[nOfInputs - 1] = 0f;

            Label labelW = new Label();
            labelW.Text = "W" + nOfInputs.ToString();
            labelW.Size = new System.Drawing.Size(30, 30);
            labelW.Margin = new Padding(5, 5, 0, 5);
            NumericUpDown numericUpDownW = new NumericUpDown();
            numericUpDownW.ValueChanged += new EventHandler(wValueChanged);
            numericUpDownW.Name = nOfInputs.ToString();
            numericUpDownW.Size = new System.Drawing.Size(50, 30);
            numericUpDownW.Maximum = 1000;
            numericUpDownW.Minimum = -1000;
            numericUpDownW.DecimalPlaces = 2;
            numericUpDownW.Increment = 0.01M;
            Array.Resize(ref neuron.w, nOfInputs);
            neuron.w[nOfInputs - 1] = 0f;

            labelsX.Add(labelX);
            inputsX.Add(numericUpDownX);
            labelsW.Add(labelW);
            inputsW.Add(numericUpDownW);
            flowLayoutPanel1.Controls.Add(labelX);
            flowLayoutPanel1.Controls.Add(numericUpDownX);
            flowLayoutPanel1.Controls.Add(labelW);
            flowLayoutPanel1.Controls.Add(numericUpDownW);
            updateInfo();
        }

        private void deleteLastInput(int newNOfInputs)
        {
            flowLayoutPanel1.Controls.Remove(inputsX[nOfInputs - 1]);
            flowLayoutPanel1.Controls.Remove(inputsW[nOfInputs - 1]);
            flowLayoutPanel1.Controls.Remove(labelsX[nOfInputs - 1]);
            flowLayoutPanel1.Controls.Remove(labelsW[nOfInputs - 1]);
            inputsX.RemoveAt(nOfInputs - 1);
            inputsW.RemoveAt(nOfInputs - 1);
            labelsX.RemoveAt(nOfInputs - 1);
            labelsW.RemoveAt(nOfInputs - 1);
            Array.Resize(ref neuron.x, newNOfInputs);
            Array.Resize(ref neuron.w, newNOfInputs);
            neuron.nOfInputs = nOfInputs - 1;
            nOfInputs = newNOfInputs;
            updateInfo();
        }

        private void inputValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;
            int pos = Convert.ToInt32(numeric.Name) - 1;
            neuron.x[pos] = (double)numeric.Value;
            updateInfo();
        }

        private void wValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;
            int pos = Convert.ToInt32(numeric.Name) - 1;
            neuron.w[pos] = (double)numeric.Value;
            updateInfo();
        }

        private void btnSuma_CheckedChanged(object sender, EventArgs e)
        {
            updateInfo();
        }

        private void btnProdus_CheckedChanged(object sender, EventArgs e)
        {
            updateInfo();
        }

        private void btnMin_CheckedChanged(object sender, EventArgs e)
        {
            updateInfo();
        }

        private void btnMaxim_CheckedChanged(object sender, EventArgs e)
        {
            updateInfo();
        }

        private void btnTreapta_CheckedChanged(object sender, EventArgs e)
        {
            lblTeta.Enabled = false;
            tetaInput.Enabled = false;
            lblG.Enabled = false;
            gInput.Enabled = false;
            updateInfo();
        }

        private void btnSemn_CheckedChanged(object sender, EventArgs e)
        {
            lblTeta.Enabled = false;
            tetaInput.Enabled = false;
            lblG.Enabled = false;
            gInput.Enabled = false;
            updateInfo();
        }

        private void btnSigm_CheckedChanged(object sender, EventArgs e)
        {
            lblTeta.Enabled = true;
            tetaInput.Enabled = true;
            lblG.Enabled = true;
            gInput.Enabled = true;
            updateInfo();
        }

        private void btnTanh_CheckedChanged(object sender, EventArgs e)
        {
            lblTeta.Enabled = true;
            tetaInput.Enabled = true;
            lblG.Enabled = true;
            gInput.Enabled = true;
            updateInfo();
        }

        private void btnLiniara_CheckedChanged(object sender, EventArgs e)
        {
            lblTeta.Enabled = true;
            tetaInput.Enabled = true;
            lblG.Enabled = true;
            gInput.Enabled = true;
            updateInfo();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.flowLayoutPanel1.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
        }

        private void InputRadioPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.InputRadioPanel.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel2.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);

        }

        private void tetaInput_ValueChanged(object sender, EventArgs e)
        {
            neuron.teta = (double)tetaInput.Value;
            updateInfo();
        }

        private void gInput_ValueChanged(object sender, EventArgs e)
        {
            neuron.g = (double)gInput.Value;
            updateInfo();
        }
    }
}
