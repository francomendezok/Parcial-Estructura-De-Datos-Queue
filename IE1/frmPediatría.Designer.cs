namespace IE1
{
    partial class frmPediatría
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
            lblConsultorioPediatria = new Label();
            label5 = new Label();
            lblDNIPediatria = new Label();
            label2 = new Label();
            lblNombrePediatria = new Label();
            label1 = new Label();
            lstProximosPediatria = new ListBox();
            lblCantidadPediatria = new Label();
            SuspendLayout();
            // 
            // lblConsultorioPediatria
            // 
            lblConsultorioPediatria.AutoSize = true;
            lblConsultorioPediatria.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblConsultorioPediatria.Location = new Point(411, 163);
            lblConsultorioPediatria.Name = "lblConsultorioPediatria";
            lblConsultorioPediatria.Size = new Size(181, 51);
            lblConsultorioPediatria.TabIndex = 15;
            lblConsultorioPediatria.Text = "PED0001";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label5.Location = new Point(115, 163);
            label5.Name = "label5";
            label5.Size = new Size(305, 51);
            label5.TabIndex = 14;
            label5.Text = "CONSULTORIO: ";
            // 
            // lblDNIPediatria
            // 
            lblDNIPediatria.AutoSize = true;
            lblDNIPediatria.Location = new Point(276, 117);
            lblDNIPediatria.Name = "lblDNIPediatria";
            lblDNIPediatria.Size = new Size(194, 46);
            lblDNIPediatria.TabIndex = 11;
            lblDNIPediatria.Text = "XX.XXX.XXX";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 117);
            label2.Name = "label2";
            label2.Size = new Size(85, 46);
            label2.TabIndex = 10;
            label2.Text = "DNI:";
            // 
            // lblNombrePediatria
            // 
            lblNombrePediatria.Font = new Font("Segoe UI", 35F, FontStyle.Bold);
            lblNombrePediatria.Location = new Point(12, 55);
            lblNombrePediatria.Name = "lblNombrePediatria";
            lblNombrePediatria.Size = new Size(679, 62);
            lblNombrePediatria.TabIndex = 9;
            lblNombrePediatria.Text = "APELLIDO, Nombre";
            lblNombrePediatria.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(252, 9);
            label1.Name = "label1";
            label1.Size = new Size(165, 46);
            label1.TabIndex = 8;
            label1.Text = "PACIENTE";
            // 
            // lstProximosPediatria
            // 
            lstProximosPediatria.FormattingEnabled = true;
            lstProximosPediatria.ItemHeight = 45;
            lstProximosPediatria.Location = new Point(48, 263);
            lstProximosPediatria.Name = "lstProximosPediatria";
            lstProximosPediatria.Size = new Size(544, 229);
            lstProximosPediatria.TabIndex = 27;
            // 
            // lblCantidadPediatria
            // 
            lblCantidadPediatria.AutoSize = true;
            lblCantidadPediatria.Location = new Point(48, 214);
            lblCantidadPediatria.Name = "lblCantidadPediatria";
            lblCantidadPediatria.Size = new Size(309, 46);
            lblCantidadPediatria.TabIndex = 26;
            lblCantidadPediatria.Text = "Próximos pacientes";
            // 
            // frmPediatría
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(599, 501);
            ControlBox = false;
            Controls.Add(lstProximosPediatria);
            Controls.Add(lblCantidadPediatria);
            Controls.Add(lblConsultorioPediatria);
            Controls.Add(label5);
            Controls.Add(lblDNIPediatria);
            Controls.Add(label2);
            Controls.Add(lblNombrePediatria);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 25F);
            Margin = new Padding(8, 9, 8, 9);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPediatría";
            StartPosition = FormStartPosition.Manual;
            Text = "Consultorio de Pediatría";
            Load += frmPediatría_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConsultorioPediatria;
        private Label label5;
        private Label lblDNIPediatria;
        private Label label2;
        private Label lblNombrePediatria;
        private Label label1;
        private ListBox lstProximosPediatria;
        private Label lblCantidadPediatria;
    }
}