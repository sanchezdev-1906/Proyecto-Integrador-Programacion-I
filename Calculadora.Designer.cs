namespace Proyecto_Integrador_Programacion_I
{
    partial class Calculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            PanelMenu = new Panel();
            button2 = new Button();
            pnlPrincipal = new Panel();
            PanelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Dock = DockStyle.Left;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(243, 65);
            button1.TabIndex = 0;
            button1.Text = "Opeeraciones entre conjuntos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = Color.FromArgb(31, 37, 45);
            PanelMenu.Controls.Add(button2);
            PanelMenu.Controls.Add(button1);
            PanelMenu.Dock = DockStyle.Top;
            PanelMenu.ForeColor = Color.White;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Margin = new Padding(3, 4, 3, 4);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(850, 65);
            PanelMenu.TabIndex = 1;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Left;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(243, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(176, 65);
            button2.TabIndex = 1;
            button2.Text = "Cardinalidad";
            button2.UseVisualStyleBackColor = true;
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Dock = DockStyle.Fill;
            pnlPrincipal.Font = new Font("Noto Sans Math", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            pnlPrincipal.Location = new Point(0, 0);
            pnlPrincipal.Margin = new Padding(3, 4, 3, 4);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(850, 800);
            pnlPrincipal.TabIndex = 2;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(850, 800);
            Controls.Add(PanelMenu);
            Controls.Add(pnlPrincipal);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(769, 678);
            Name = "Calculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            SizeChanged += Calculadora_SizeChanged;
            PanelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel PanelMenu;
        private Button button2;
        private Panel pnlPrincipal;
    }
}