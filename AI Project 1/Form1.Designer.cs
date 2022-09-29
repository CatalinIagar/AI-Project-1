namespace AI_Project_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblInput = new System.Windows.Forms.Label();
            this.valueInput = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblGInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.InputRadioPanel = new System.Windows.Forms.Panel();
            this.btnMaxim = new System.Windows.Forms.RadioButton();
            this.btnMin = new System.Windows.Forms.RadioButton();
            this.btnProdus = new System.Windows.Forms.RadioButton();
            this.btnSuma = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLiniara = new System.Windows.Forms.RadioButton();
            this.btnTanh = new System.Windows.Forms.RadioButton();
            this.btnSigm = new System.Windows.Forms.RadioButton();
            this.tetaInput = new System.Windows.Forms.NumericUpDown();
            this.btnSemn = new System.Windows.Forms.RadioButton();
            this.gInput = new System.Windows.Forms.NumericUpDown();
            this.btnTreapta = new System.Windows.Forms.RadioButton();
            this.lblG = new System.Windows.Forms.Label();
            this.lblTeta = new System.Windows.Forms.Label();
            this.txtActivare = new System.Windows.Forms.TextBox();
            this.lblActivare = new System.Windows.Forms.Label();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.lblOut = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBinar = new System.Windows.Forms.CheckBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.valueInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.InputRadioPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tetaInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gInput)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(12, 19);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(90, 13);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "Number of inputs:";
            // 
            // valueInput
            // 
            this.valueInput.Location = new System.Drawing.Point(108, 16);
            this.valueInput.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.valueInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valueInput.Name = "valueInput";
            this.valueInput.ReadOnly = true;
            this.valueInput.Size = new System.Drawing.Size(50, 20);
            this.valueInput.TabIndex = 2;
            this.valueInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valueInput.ValueChanged += new System.EventHandler(this.valueInput_ValueChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 47);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 375);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // lblGInput
            // 
            this.lblGInput.AutoSize = true;
            this.lblGInput.Location = new System.Drawing.Point(238, 19);
            this.lblGInput.Name = "lblGInput";
            this.lblGInput.Size = new System.Drawing.Size(34, 13);
            this.lblGInput.TabIndex = 4;
            this.lblGInput.Text = "Input:";
            // 
            // txtInput
            // 
            this.txtInput.Enabled = false;
            this.txtInput.Location = new System.Drawing.Point(274, 16);
            this.txtInput.Name = "txtInput";
            this.txtInput.ReadOnly = true;
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 5;
            // 
            // InputRadioPanel
            // 
            this.InputRadioPanel.AutoSize = true;
            this.InputRadioPanel.Controls.Add(this.btnMaxim);
            this.InputRadioPanel.Controls.Add(this.btnMin);
            this.InputRadioPanel.Controls.Add(this.btnProdus);
            this.InputRadioPanel.Controls.Add(this.btnSuma);
            this.InputRadioPanel.Location = new System.Drawing.Point(274, 58);
            this.InputRadioPanel.Name = "InputRadioPanel";
            this.InputRadioPanel.Size = new System.Drawing.Size(100, 95);
            this.InputRadioPanel.TabIndex = 6;
            this.InputRadioPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.InputRadioPanel_Paint);
            // 
            // btnMaxim
            // 
            this.btnMaxim.AutoSize = true;
            this.btnMaxim.Location = new System.Drawing.Point(3, 75);
            this.btnMaxim.Name = "btnMaxim";
            this.btnMaxim.Size = new System.Drawing.Size(55, 17);
            this.btnMaxim.TabIndex = 3;
            this.btnMaxim.Text = "Maxim";
            this.btnMaxim.UseVisualStyleBackColor = true;
            // 
            // btnMin
            // 
            this.btnMin.AutoSize = true;
            this.btnMin.Location = new System.Drawing.Point(3, 51);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(52, 17);
            this.btnMin.TabIndex = 2;
            this.btnMin.Text = "Minim";
            this.btnMin.UseVisualStyleBackColor = true;
            // 
            // btnProdus
            // 
            this.btnProdus.AutoSize = true;
            this.btnProdus.Location = new System.Drawing.Point(3, 28);
            this.btnProdus.Name = "btnProdus";
            this.btnProdus.Size = new System.Drawing.Size(58, 17);
            this.btnProdus.TabIndex = 1;
            this.btnProdus.Text = "Produs";
            this.btnProdus.UseVisualStyleBackColor = true;
            // 
            // btnSuma
            // 
            this.btnSuma.AutoSize = true;
            this.btnSuma.Checked = true;
            this.btnSuma.Location = new System.Drawing.Point(3, 3);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(52, 17);
            this.btnSuma.TabIndex = 0;
            this.btnSuma.TabStop = true;
            this.btnSuma.Text = "Suma";
            this.btnSuma.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btnLiniara);
            this.panel1.Controls.Add(this.btnTanh);
            this.panel1.Controls.Add(this.btnSigm);
            this.panel1.Controls.Add(this.tetaInput);
            this.panel1.Controls.Add(this.btnSemn);
            this.panel1.Controls.Add(this.gInput);
            this.panel1.Controls.Add(this.btnTreapta);
            this.panel1.Controls.Add(this.lblG);
            this.panel1.Controls.Add(this.lblTeta);
            this.panel1.Location = new System.Drawing.Point(454, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 203);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLiniara
            // 
            this.btnLiniara.AutoSize = true;
            this.btnLiniara.Location = new System.Drawing.Point(6, 98);
            this.btnLiniara.Name = "btnLiniara";
            this.btnLiniara.Size = new System.Drawing.Size(56, 17);
            this.btnLiniara.TabIndex = 4;
            this.btnLiniara.Text = "Liniara";
            this.btnLiniara.UseVisualStyleBackColor = true;
            // 
            // btnTanh
            // 
            this.btnTanh.AutoSize = true;
            this.btnTanh.Location = new System.Drawing.Point(6, 75);
            this.btnTanh.Name = "btnTanh";
            this.btnTanh.Size = new System.Drawing.Size(74, 17);
            this.btnTanh.TabIndex = 3;
            this.btnTanh.Text = "Tangenta ";
            this.btnTanh.UseVisualStyleBackColor = true;
            // 
            // btnSigm
            // 
            this.btnSigm.AutoSize = true;
            this.btnSigm.Location = new System.Drawing.Point(6, 51);
            this.btnSigm.Name = "btnSigm";
            this.btnSigm.Size = new System.Drawing.Size(76, 17);
            this.btnSigm.TabIndex = 2;
            this.btnSigm.Text = "Sigmoidala";
            this.btnSigm.UseVisualStyleBackColor = true;
            // 
            // tetaInput
            // 
            this.tetaInput.DecimalPlaces = 2;
            this.tetaInput.Increment = 0.1M;
            this.tetaInput.Location = new System.Drawing.Point(41, 154);
            this.tetaInput.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.tetaInput.Name = "tetaInput";
            this.tetaInput.Size = new System.Drawing.Size(59, 20);
            this.tetaInput.TabIndex = 15;
            this.tetaInput.ValueChanged += new System.EventHandler(this.tetaInput_ValueChanged);
            // 
            // btnSemn
            // 
            this.btnSemn.AutoSize = true;
            this.btnSemn.Location = new System.Drawing.Point(6, 28);
            this.btnSemn.Name = "btnSemn";
            this.btnSemn.Size = new System.Drawing.Size(52, 17);
            this.btnSemn.TabIndex = 1;
            this.btnSemn.Text = "Semn";
            this.btnSemn.UseVisualStyleBackColor = true;
            // 
            // gInput
            // 
            this.gInput.Enabled = false;
            this.gInput.DecimalPlaces = 2;
            this.gInput.Increment = 0.1M;
            this.gInput.Location = new System.Drawing.Point(41, 180);
            this.gInput.Name = "gInput";
            this.gInput.Size = new System.Drawing.Size(59, 20);
            this.gInput.TabIndex = 14;
            this.gInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gInput.ValueChanged += new System.EventHandler(this.gInput_ValueChanged);
            // 
            // btnTreapta
            // 
            this.btnTreapta.AutoSize = true;
            this.btnTreapta.Checked = true;
            this.btnTreapta.Location = new System.Drawing.Point(6, 3);
            this.btnTreapta.Name = "btnTreapta";
            this.btnTreapta.Size = new System.Drawing.Size(62, 17);
            this.btnTreapta.TabIndex = 0;
            this.btnTreapta.TabStop = true;
            this.btnTreapta.Text = "Treapta";
            this.btnTreapta.UseVisualStyleBackColor = true;
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Enabled = false;
            this.lblG.Location = new System.Drawing.Point(3, 182);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(31, 13);
            this.lblG.TabIndex = 11;
            this.lblG.Text = "g (a):";
            // 
            // lblTeta
            // 
            this.lblTeta.AutoSize = true;
            this.lblTeta.Enabled = false;
            this.lblTeta.Location = new System.Drawing.Point(3, 156);
            this.lblTeta.Name = "lblTeta";
            this.lblTeta.Size = new System.Drawing.Size(35, 13);
            this.lblTeta.TabIndex = 10;
            this.lblTeta.Text = "Teta: ";
            // 
            // txtActivare
            // 
            this.txtActivare.Enabled = false;
            this.txtActivare.Location = new System.Drawing.Point(454, 16);
            this.txtActivare.Name = "txtActivare";
            this.txtActivare.ReadOnly = true;
            this.txtActivare.Size = new System.Drawing.Size(100, 20);
            this.txtActivare.TabIndex = 8;
            // 
            // lblActivare
            // 
            this.lblActivare.AutoSize = true;
            this.lblActivare.Location = new System.Drawing.Point(399, 19);
            this.lblActivare.Name = "lblActivare";
            this.lblActivare.Size = new System.Drawing.Size(49, 13);
            this.lblActivare.TabIndex = 7;
            this.lblActivare.Text = "Activare:";
            // 
            // txtOut
            // 
            this.txtOut.Enabled = false;
            this.txtOut.Location = new System.Drawing.Point(628, 16);
            this.txtOut.Name = "txtOut";
            this.txtOut.ReadOnly = true;
            this.txtOut.Size = new System.Drawing.Size(100, 20);
            this.txtOut.TabIndex = 17;
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(573, 19);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(42, 13);
            this.lblOut.TabIndex = 16;
            this.lblOut.Text = "Output:";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.btnBinar);
            this.panel2.Location = new System.Drawing.Point(628, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 24);
            this.panel2.TabIndex = 18;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnBinar
            // 
            this.btnBinar.AutoSize = true;
            this.btnBinar.Location = new System.Drawing.Point(3, 4);
            this.btnBinar.Name = "btnBinar";
            this.btnBinar.Size = new System.Drawing.Size(50, 17);
            this.btnBinar.TabIndex = 1;
            this.btnBinar.Text = "Binar";
            this.btnBinar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtActivare);
            this.Controls.Add(this.lblActivare);
            this.Controls.Add(this.InputRadioPanel);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblGInput);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.valueInput);
            this.Controls.Add(this.lblInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.BackColor = System.Drawing.Color.LightGray;
            this.Text = "Project 1";
            ((System.ComponentModel.ISupportInitialize)(this.valueInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.InputRadioPanel.ResumeLayout(false);
            this.InputRadioPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tetaInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gInput)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.NumericUpDown valueInput;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblGInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Panel InputRadioPanel;
        private System.Windows.Forms.RadioButton btnMaxim;
        private System.Windows.Forms.RadioButton btnMin;
        private System.Windows.Forms.RadioButton btnProdus;
        private System.Windows.Forms.RadioButton btnSuma;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton btnLiniara;
        private System.Windows.Forms.RadioButton btnTanh;
        private System.Windows.Forms.RadioButton btnSigm;
        private System.Windows.Forms.RadioButton btnSemn;
        private System.Windows.Forms.RadioButton btnTreapta;
        private System.Windows.Forms.TextBox txtActivare;
        private System.Windows.Forms.Label lblActivare;
        private System.Windows.Forms.Label lblTeta;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.NumericUpDown gInput;
        private System.Windows.Forms.NumericUpDown tetaInput;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox btnBinar;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

