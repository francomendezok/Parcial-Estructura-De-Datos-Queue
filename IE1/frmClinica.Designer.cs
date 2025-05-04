namespace IE1
{
    partial class frmClinica
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
            label1 = new Label();
            lblNombreClinica = new Label();
            label2 = new Label();
            lblDNIClinica = new Label();
            lblCantidadClinica = new Label();
            label5 = new Label();
            lblConsultorioClinica = new Label();
            lstProximosClinica = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(252, 18);
            label1.Name = "label1";
            label1.Size = new Size(165, 46);
            label1.TabIndex = 0;
            label1.Text = "PACIENTE";
            // 
            // lblNombreClinica
            // 
            lblNombreClinica.Font = new Font("Segoe UI", 35F, FontStyle.Bold);
            lblNombreClinica.Location = new Point(12, 64);
            lblNombreClinica.Name = "lblNombreClinica";
            lblNombreClinica.Size = new Size(679, 62);
            lblNombreClinica.TabIndex = 1;
            lblNombreClinica.Text = "APELLIDO, Nombre";
            lblNombreClinica.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 126);
            label2.Name = "label2";
            label2.Size = new Size(85, 46);
            label2.TabIndex = 2;
            label2.Text = "DNI:";
            // 
            // lblDNIClinica
            // 
            lblDNIClinica.AutoSize = true;
            lblDNIClinica.Location = new Point(276, 126);
            lblDNIClinica.Name = "lblDNIClinica";
            lblDNIClinica.Size = new Size(194, 46);
            lblDNIClinica.TabIndex = 3;
            lblDNIClinica.Text = "XX.XXX.XXX";
            // 
            // lblCantidadClinica
            // 
            lblCantidadClinica.AutoSize = true;
            lblCantidadClinica.Location = new Point(37, 223);
            lblCantidadClinica.Name = "lblCantidadClinica";
            lblCantidadClinica.Size = new Size(309, 46);
            lblCantidadClinica.TabIndex = 4;
            lblCantidadClinica.Text = "Próximos pacientes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label5.Location = new Point(112, 172);
            label5.Name = "label5";
            label5.Size = new Size(305, 51);
            label5.TabIndex = 6;
            label5.Text = "CONSULTORIO: ";
            // 
            // lblConsultorioClinica
            // 
            lblConsultorioClinica.AutoSize = true;
            lblConsultorioClinica.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblConsultorioClinica.Location = new Point(410, 172);
            lblConsultorioClinica.Name = "lblConsultorioClinica";
            lblConsultorioClinica.Size = new Size(165, 51);
            lblConsultorioClinica.TabIndex = 7;
            lblConsultorioClinica.Text = "CLI0001";
            // 
            // lstProximosClinica
            // 
            lstProximosClinica.FormattingEnabled = true;
            lstProximosClinica.ItemHeight = 45;
            lstProximosClinica.Location = new Point(37, 272);
            lstProximosClinica.Name = "lstProximosClinica";
            lstProximosClinica.Size = new Size(538, 229);
            lstProximosClinica.TabIndex = 8;
            // 
            // frmClinica
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(585, 510);
            ControlBox = false;
            Controls.Add(lstProximosClinica);
            Controls.Add(lblConsultorioClinica);
            Controls.Add(label5);
            Controls.Add(lblCantidadClinica);
            Controls.Add(lblDNIClinica);
            Controls.Add(label2);
            Controls.Add(lblNombreClinica);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 25F);
            Margin = new Padding(8, 9, 8, 9);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmClinica";
            Text = "Consultorio Clínico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNombreClinica;
        private Label label2;
        private Label lblDNIClinica;
        private Label lblCantidadClinica;
        private Label label5;
        private Label lblConsultorioClinica;
        private ListBox lstProximosClinica;
    }
}