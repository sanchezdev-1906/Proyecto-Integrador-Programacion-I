namespace Proyecto_Integrador_Programacion_I
{
    partial class OpConjuntos
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
            lblRes = new Label();
            txtResultado = new TextBox();
            lblConj = new Label();
            rBtnConjs3 = new RadioButton();
            rBtnConjs2 = new RadioButton();
            lblConjC = new Label();
            lblConjB = new Label();
            lblConjA = new Label();
            txtConjC = new TextBox();
            txtConjB = new TextBox();
            txtConjA = new TextBox();
            txtOper = new TextBox();
            lblOperar = new Label();
            BtnCchar = new Button();
            BtnBchar = new Button();
            BtnUchar = new Button();
            BtnAchart = new Button();
            BtnCalcular = new Button();
            BtnVacioChart = new Button();
            BtnCompleChart = new Button();
            BtnDifSimeChart = new Button();
            BtnDiferenciaChart = new Button();
            BtnUnionChart = new Button();
            BtnInterChart = new Button();
            PnlPrincipal = new Panel();
            PnlGraficos = new Panel();
            PnlPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Location = new Point(233, 10);
            lblRes.Margin = new Padding(4, 0, 4, 0);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(86, 24);
            lblRes.TabIndex = 47;
            lblRes.Text = "Resultado";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(34, 39);
            txtResultado.Margin = new Padding(4, 5, 4, 5);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(492, 31);
            txtResultado.TabIndex = 46;
            // 
            // lblConj
            // 
            lblConj.AutoSize = true;
            lblConj.Location = new Point(114, 86);
            lblConj.Margin = new Padding(4, 0, 4, 0);
            lblConj.Name = "lblConj";
            lblConj.Size = new Size(88, 24);
            lblConj.TabIndex = 45;
            lblConj.Text = "Conjuntos";
            // 
            // rBtnConjs3
            // 
            rBtnConjs3.AutoSize = true;
            rBtnConjs3.Location = new Point(174, 132);
            rBtnConjs3.Margin = new Padding(4, 5, 4, 5);
            rBtnConjs3.Name = "rBtnConjs3";
            rBtnConjs3.Size = new Size(40, 28);
            rBtnConjs3.TabIndex = 44;
            rBtnConjs3.TabStop = true;
            rBtnConjs3.Text = "3";
            rBtnConjs3.UseVisualStyleBackColor = true;
            rBtnConjs3.CheckedChanged += rBtnConjs3_CheckedChanged;
            // 
            // rBtnConjs2
            // 
            rBtnConjs2.AutoSize = true;
            rBtnConjs2.Location = new Point(107, 132);
            rBtnConjs2.Margin = new Padding(4, 5, 4, 5);
            rBtnConjs2.Name = "rBtnConjs2";
            rBtnConjs2.Size = new Size(40, 28);
            rBtnConjs2.TabIndex = 43;
            rBtnConjs2.TabStop = true;
            rBtnConjs2.Text = "2";
            rBtnConjs2.UseVisualStyleBackColor = true;
            rBtnConjs2.CheckedChanged += rBtnConjs2_CheckedChanged;
            // 
            // lblConjC
            // 
            lblConjC.AutoSize = true;
            lblConjC.Location = new Point(36, 283);
            lblConjC.Margin = new Padding(4, 0, 4, 0);
            lblConjC.Name = "lblConjC";
            lblConjC.Size = new Size(24, 24);
            lblConjC.TabIndex = 42;
            lblConjC.Text = "C:";
            lblConjC.Visible = false;
            // 
            // lblConjB
            // 
            lblConjB.AutoSize = true;
            lblConjB.Location = new Point(36, 228);
            lblConjB.Margin = new Padding(4, 0, 4, 0);
            lblConjB.Name = "lblConjB";
            lblConjB.Size = new Size(24, 24);
            lblConjB.TabIndex = 41;
            lblConjB.Text = "B:";
            // 
            // lblConjA
            // 
            lblConjA.AutoSize = true;
            lblConjA.Location = new Point(36, 177);
            lblConjA.Margin = new Padding(4, 0, 4, 0);
            lblConjA.Name = "lblConjA";
            lblConjA.Size = new Size(24, 24);
            lblConjA.TabIndex = 40;
            lblConjA.Text = "A:";
            // 
            // txtConjC
            // 
            txtConjC.Location = new Point(68, 280);
            txtConjC.Margin = new Padding(4, 5, 4, 5);
            txtConjC.Name = "txtConjC";
            txtConjC.Size = new Size(209, 31);
            txtConjC.TabIndex = 39;
            txtConjC.Visible = false;
            // 
            // txtConjB
            // 
            txtConjB.Location = new Point(68, 225);
            txtConjB.Margin = new Padding(4, 5, 4, 5);
            txtConjB.Name = "txtConjB";
            txtConjB.Size = new Size(210, 31);
            txtConjB.TabIndex = 38;
            // 
            // txtConjA
            // 
            txtConjA.Location = new Point(68, 170);
            txtConjA.Margin = new Padding(4, 5, 4, 5);
            txtConjA.Name = "txtConjA";
            txtConjA.Size = new Size(210, 31);
            txtConjA.TabIndex = 37;
            // 
            // txtOper
            // 
            txtOper.Location = new Point(345, 115);
            txtOper.Margin = new Padding(4, 5, 4, 5);
            txtOper.Name = "txtOper";
            txtOper.Size = new Size(181, 31);
            txtOper.TabIndex = 36;
            // 
            // lblOperar
            // 
            lblOperar.AutoSize = true;
            lblOperar.Location = new Point(393, 86);
            lblOperar.Margin = new Padding(4, 0, 4, 0);
            lblOperar.Name = "lblOperar";
            lblOperar.Size = new Size(90, 24);
            lblOperar.TabIndex = 35;
            lblOperar.Text = "Operacion";
            // 
            // BtnCchar
            // 
            BtnCchar.BackColor = Color.FromArgb(217, 217, 217);
            BtnCchar.Enabled = false;
            BtnCchar.Location = new Point(448, 166);
            BtnCchar.Margin = new Padding(4, 5, 4, 5);
            BtnCchar.Name = "BtnCchar";
            BtnCchar.Size = new Size(35, 35);
            BtnCchar.TabIndex = 34;
            BtnCchar.Text = "C";
            BtnCchar.UseVisualStyleBackColor = false;
            BtnCchar.Click += BtnCchar_Click;
            // 
            // BtnBchar
            // 
            BtnBchar.BackColor = Color.FromArgb(217, 217, 217);
            BtnBchar.Location = new Point(388, 166);
            BtnBchar.Margin = new Padding(4, 5, 4, 5);
            BtnBchar.Name = "BtnBchar";
            BtnBchar.Size = new Size(35, 35);
            BtnBchar.TabIndex = 33;
            BtnBchar.Text = "B";
            BtnBchar.UseVisualStyleBackColor = false;
            BtnBchar.Click += BtnBchar_Click;
            // 
            // BtnUchar
            // 
            BtnUchar.BackColor = Color.FromArgb(217, 217, 217);
            BtnUchar.Location = new Point(491, 166);
            BtnUchar.Margin = new Padding(4, 5, 4, 5);
            BtnUchar.Name = "BtnUchar";
            BtnUchar.Size = new Size(35, 35);
            BtnUchar.TabIndex = 32;
            BtnUchar.Text = "U";
            BtnUchar.UseVisualStyleBackColor = false;
            BtnUchar.Click += BtnUchar_Click;
            // 
            // BtnAchart
            // 
            BtnAchart.BackColor = Color.FromArgb(217, 217, 217);
            BtnAchart.Location = new Point(345, 166);
            BtnAchart.Margin = new Padding(4, 5, 4, 5);
            BtnAchart.Name = "BtnAchart";
            BtnAchart.Size = new Size(35, 35);
            BtnAchart.TabIndex = 31;
            BtnAchart.Text = "A";
            BtnAchart.UseVisualStyleBackColor = false;
            BtnAchart.Click += BtnAchart_Click;
            // 
            // BtnCalcular
            // 
            BtnCalcular.BackColor = Color.FromArgb(217, 217, 217);
            BtnCalcular.Location = new Point(345, 291);
            BtnCalcular.Margin = new Padding(4, 5, 4, 5);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(181, 34);
            BtnCalcular.TabIndex = 30;
            BtnCalcular.Text = "Calcular";
            BtnCalcular.UseVisualStyleBackColor = false;
            BtnCalcular.Click += BtnCalcular_Click;
            // 
            // BtnVacioChart
            // 
            BtnVacioChart.BackColor = Color.FromArgb(217, 217, 217);
            BtnVacioChart.Location = new Point(471, 251);
            BtnVacioChart.Margin = new Padding(4, 5, 4, 5);
            BtnVacioChart.Name = "BtnVacioChart";
            BtnVacioChart.Size = new Size(55, 30);
            BtnVacioChart.TabIndex = 29;
            BtnVacioChart.Text = "∅";
            BtnVacioChart.UseVisualStyleBackColor = false;
            BtnVacioChart.Click += BtnVacioChart_Click;
            // 
            // BtnCompleChart
            // 
            BtnCompleChart.BackColor = Color.FromArgb(217, 217, 217);
            BtnCompleChart.Location = new Point(408, 251);
            BtnCompleChart.Margin = new Padding(4, 5, 4, 5);
            BtnCompleChart.Name = "BtnCompleChart";
            BtnCompleChart.Size = new Size(55, 30);
            BtnCompleChart.TabIndex = 28;
            BtnCompleChart.Text = "◻ᶜ";
            BtnCompleChart.UseVisualStyleBackColor = false;
            BtnCompleChart.Click += BtnCompleChart_Click;
            // 
            // BtnDifSimeChart
            // 
            BtnDifSimeChart.BackColor = Color.FromArgb(217, 217, 217);
            BtnDifSimeChart.Location = new Point(345, 251);
            BtnDifSimeChart.Margin = new Padding(4, 5, 4, 5);
            BtnDifSimeChart.Name = "BtnDifSimeChart";
            BtnDifSimeChart.Size = new Size(55, 30);
            BtnDifSimeChart.TabIndex = 27;
            BtnDifSimeChart.Text = "∆";
            BtnDifSimeChart.UseVisualStyleBackColor = false;
            BtnDifSimeChart.Click += BtnDifSimeChart_Click;
            // 
            // BtnDiferenciaChart
            // 
            BtnDiferenciaChart.BackColor = Color.FromArgb(217, 217, 217);
            BtnDiferenciaChart.Location = new Point(471, 211);
            BtnDiferenciaChart.Margin = new Padding(4, 5, 4, 5);
            BtnDiferenciaChart.Name = "BtnDiferenciaChart";
            BtnDiferenciaChart.Size = new Size(55, 30);
            BtnDiferenciaChart.TabIndex = 26;
            BtnDiferenciaChart.Text = "−";
            BtnDiferenciaChart.UseVisualStyleBackColor = false;
            BtnDiferenciaChart.Click += BtnDiferenciaChart_Click;
            // 
            // BtnUnionChart
            // 
            BtnUnionChart.BackColor = Color.FromArgb(217, 217, 217);
            BtnUnionChart.Location = new Point(408, 211);
            BtnUnionChart.Margin = new Padding(4, 5, 4, 5);
            BtnUnionChart.Name = "BtnUnionChart";
            BtnUnionChart.Size = new Size(55, 30);
            BtnUnionChart.TabIndex = 25;
            BtnUnionChart.Text = "∪";
            BtnUnionChart.UseVisualStyleBackColor = false;
            BtnUnionChart.Click += BtnUnionChart_Click;
            // 
            // BtnInterChart
            // 
            BtnInterChart.BackColor = Color.FromArgb(217, 217, 217);
            BtnInterChart.Location = new Point(345, 211);
            BtnInterChart.Margin = new Padding(4, 5, 4, 5);
            BtnInterChart.Name = "BtnInterChart";
            BtnInterChart.Size = new Size(55, 30);
            BtnInterChart.TabIndex = 24;
            BtnInterChart.Text = "∩";
            BtnInterChart.UseVisualStyleBackColor = false;
            BtnInterChart.Click += BtnInterChart_Click;
            // 
            // PnlPrincipal
            // 
            PnlPrincipal.Controls.Add(lblRes);
            PnlPrincipal.Controls.Add(txtResultado);
            PnlPrincipal.Controls.Add(BtnCalcular);
            PnlPrincipal.Controls.Add(lblConjB);
            PnlPrincipal.Controls.Add(BtnInterChart);
            PnlPrincipal.Controls.Add(lblConjA);
            PnlPrincipal.Controls.Add(lblOperar);
            PnlPrincipal.Controls.Add(BtnVacioChart);
            PnlPrincipal.Controls.Add(BtnUnionChart);
            PnlPrincipal.Controls.Add(BtnAchart);
            PnlPrincipal.Controls.Add(txtOper);
            PnlPrincipal.Controls.Add(lblConjC);
            PnlPrincipal.Controls.Add(lblConj);
            PnlPrincipal.Controls.Add(txtConjC);
            PnlPrincipal.Controls.Add(BtnCchar);
            PnlPrincipal.Controls.Add(BtnCompleChart);
            PnlPrincipal.Controls.Add(BtnDiferenciaChart);
            PnlPrincipal.Controls.Add(BtnUchar);
            PnlPrincipal.Controls.Add(txtConjA);
            PnlPrincipal.Controls.Add(rBtnConjs2);
            PnlPrincipal.Controls.Add(rBtnConjs3);
            PnlPrincipal.Controls.Add(txtConjB);
            PnlPrincipal.Controls.Add(BtnBchar);
            PnlPrincipal.Controls.Add(BtnDifSimeChart);
            PnlPrincipal.Dock = DockStyle.Fill;
            PnlPrincipal.Location = new Point(0, 250);
            PnlPrincipal.Name = "PnlPrincipal";
            PnlPrincipal.Size = new Size(564, 351);
            PnlPrincipal.TabIndex = 49;
            // 
            // PnlGraficos
            // 
            PnlGraficos.Dock = DockStyle.Top;
            PnlGraficos.Location = new Point(0, 0);
            PnlGraficos.Name = "PnlGraficos";
            PnlGraficos.Size = new Size(564, 250);
            PnlGraficos.TabIndex = 48;
            PnlGraficos.Paint += PnlGraficos_Paint;
            // 
            // OpConjuntos
            // 
            AutoScaleDimensions = new SizeF(9F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(564, 601);
            Controls.Add(PnlPrincipal);
            Controls.Add(PnlGraficos);
            Font = new Font("Noto Sans Math", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "OpConjuntos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "OpConjuntos";
            PnlPrincipal.ResumeLayout(false);
            PnlPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblRes;
        private TextBox txtResultado;
        private Label lblConj;
        private RadioButton rBtnConjs3;
        private RadioButton rBtnConjs2;
        private Label lblConjC;
        private Label lblConjB;
        private Label lblConjA;
        private TextBox txtConjC;
        private TextBox txtConjB;
        private TextBox txtConjA;
        private TextBox txtOper;
        private Label lblOperar;
        private Button BtnCchar;
        private Button BtnBchar;
        private Button BtnUchar;
        private Button BtnAchart;
        private Button BtnCalcular;
        private Button BtnVacioChart;
        private Button BtnCompleChart;
        private Button BtnDifSimeChart;
        private Button BtnDiferenciaChart;
        private Button BtnUnionChart;
        private Button BtnInterChart;
        private Panel PnlPrincipal;
        private Panel PnlGraficos;
    }
}