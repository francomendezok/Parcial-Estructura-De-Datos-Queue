namespace IE1
{
    partial class frmGuardia
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
            lblConsultorioGuardia = new Label();
            label5 = new Label();
            lblDNIGuardia = new Label();
            label2 = new Label();
            lblNombreGuardia = new Label();
            label1 = new Label();
            lstProximosGuardia = new ListBox();
            lblCantidadGuardia = new Label();
            SuspendLayout();
            // 
            // lblConsultorioGuardia
            // 
            lblConsultorioGuardia.AutoSize = true;
            lblConsultorioGuardia.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblConsultorioGuardia.Location = new Point(405, 163);
            lblConsultorioGuardia.Name = "lblConsultorioGuardia";
            lblConsultorioGuardia.Size = new Size(190, 51);
            lblConsultorioGuardia.TabIndex = 23;
            lblConsultorioGuardia.Text = "GUA0001";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label5.Location = new Point(118, 163);
            label5.Name = "label5";
            label5.Size = new Size(305, 51);
            label5.TabIndex = 22;
            label5.Text = "CONSULTORIO: ";
            // 
            // lblDNIGuardia
            // 
            lblDNIGuardia.AutoSize = true;
            lblDNIGuardia.Location = new Point(282, 117);
            lblDNIGuardia.Name = "lblDNIGuardia";
            lblDNIGuardia.Size = new Size(194, 46);
            lblDNIGuardia.TabIndex = 19;
            lblDNIGuardia.Text = "XX.XXX.XXX";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 117);
            label2.Name = "label2";
            label2.Size = new Size(85, 46);
            label2.TabIndex = 18;
            label2.Text = "DNI:";
            // 
            // lblNombreGuardia
            // 
            lblNombreGuardia.Font = new Font("Segoe UI", 35F, FontStyle.Bold);
            lblNombreGuardia.Location = new Point(18, 55);
            lblNombreGuardia.Name = "lblNombreGuardia";
            lblNombreGuardia.Size = new Size(679, 62);
            lblNombreGuardia.TabIndex = 17;
            lblNombreGuardia.Text = "APELLIDO, Nombre";
            lblNombreGuardia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 9);
            label1.Name = "label1";
            label1.Size = new Size(165, 46);
            label1.TabIndex = 16;
            label1.Text = "PACIENTE";
            // 
            // lstProximosGuardia
            // 
            lstProximosGuardia.FormattingEnabled = true;
            lstProximosGuardia.ItemHeight = 45;
            lstProximosGuardia.Location = new Point(41, 263);
            lstProximosGuardia.Name = "lstProximosGuardia";
            lstProximosGuardia.Size = new Size(554, 229);
            lstProximosGuardia.TabIndex = 25;
            // 
            // lblCantidadGuardia
            // 
            lblCantidadGuardia.AutoSize = true;
            lblCantidadGuardia.Location = new Point(41, 214);
            lblCantidadGuardia.Name = "lblCantidadGuardia";
            lblCantidadGuardia.Size = new Size(309, 46);
            lblCantidadGuardia.TabIndex = 24;
            lblCantidadGuardia.Text = "Próximos pacientes";
            // 
            // frmGuardia
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(606, 511);
            ControlBox = false;
            Controls.Add(lstProximosGuardia);
            Controls.Add(lblCantidadGuardia);
            Controls.Add(lblConsultorioGuardia);
            Controls.Add(label5);
            Controls.Add(lblDNIGuardia);
            Controls.Add(label2);
            Controls.Add(lblNombreGuardia);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 25F);
            Margin = new Padding(8, 9, 8, 9);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGuardia";
            Text = "Consualtorio de Guardia";
            Load += frmGuardia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConsultorioGuardia;
        private Label label5;
        private Label lblDNIGuardia;
        private Label label2;
        private Label lblNombreGuardia;
        private Label label1;
        private ListBox lstProximosGuardia;
        private Label lblCantidadGuardia;
    }
}