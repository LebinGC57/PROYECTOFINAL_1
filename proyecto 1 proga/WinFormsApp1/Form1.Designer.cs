namespace InvestigacionAI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtPrompt;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnGuardar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtPrompt = new TextBox();
            txtResultado = new TextBox();
            btnConsultar = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // txtPrompt
            // 
            txtPrompt.BackColor = SystemColors.GradientActiveCaption;
            txtPrompt.Location = new Point(12, 15);
            txtPrompt.Margin = new Padding(3, 4, 3, 4);
            txtPrompt.Multiline = true;
            txtPrompt.Name = "txtPrompt";
            txtPrompt.Size = new Size(466, 52);
            txtPrompt.TabIndex = 0;
            // 
            // txtResultado
            // 
            txtResultado.BackColor = Color.FromArgb(192, 255, 192);
            txtResultado.Location = new Point(21, 105);
            txtResultado.Margin = new Padding(3, 4, 3, 4);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ScrollBars = ScrollBars.Vertical;
            txtResultado.Size = new Size(583, 431);
            txtResultado.TabIndex = 1;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.Chartreuse;
            btnConsultar.Location = new Point(484, 9);
            btnConsultar.Margin = new Padding(3, 4, 3, 4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(100, 38);
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DeepSkyBlue;
            btnGuardar.Location = new Point(484, 59);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 38);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 549);
            Controls.Add(btnGuardar);
            Controls.Add(btnConsultar);
            Controls.Add(txtResultado);
            Controls.Add(txtPrompt);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Investigación AI";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
