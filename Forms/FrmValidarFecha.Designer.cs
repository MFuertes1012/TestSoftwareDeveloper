namespace TestSoftwareDeveloper.Forms
{
    partial class FrmValidarFecha
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
            btnValidarFecha=new Button();
            txtFecha=new TextBox();
            lblValidacionFechaFormato=new Label();
            lblIngresarFecha=new Label();
            SuspendLayout();
            // 
            // btnValidarFecha
            // 
            btnValidarFecha.Location=new Point(104, 263);
            btnValidarFecha.Margin=new Padding(4, 3, 4, 3);
            btnValidarFecha.Name="btnValidarFecha";
            btnValidarFecha.Size=new Size(157, 62);
            btnValidarFecha.TabIndex=0;
            btnValidarFecha.Text="Validar";
            btnValidarFecha.UseVisualStyleBackColor=true;
            btnValidarFecha.Click+=btnValidarFecha_Click;
            // 
            // txtFecha
            // 
            txtFecha.Location=new Point(325, 156);
            txtFecha.Margin=new Padding(4, 3, 4, 3);
            txtFecha.Name="txtFecha";
            txtFecha.Size=new Size(469, 38);
            txtFecha.TabIndex=1;
            // 
            // lblValidacionFechaFormato
            // 
            lblValidacionFechaFormato.AutoSize=true;
            lblValidacionFechaFormato.Location=new Point(104, 41);
            lblValidacionFechaFormato.Margin=new Padding(4, 0, 4, 0);
            lblValidacionFechaFormato.Name="lblValidacionFechaFormato";
            lblValidacionFechaFormato.Size=new Size(359, 23);
            lblValidacionFechaFormato.TabIndex=2;
            lblValidacionFechaFormato.Text="Validación de fecha y formato válido";
            // 
            // lblIngresarFecha
            // 
            lblIngresarFecha.AutoSize=true;
            lblIngresarFecha.Location=new Point(128, 160);
            lblIngresarFecha.Margin=new Padding(4, 0, 4, 0);
            lblIngresarFecha.Name="lblIngresarFecha";
            lblIngresarFecha.Size=new Size(151, 23);
            lblIngresarFecha.TabIndex=3;
            lblIngresarFecha.Text="Ingresar fecha:";
            // 
            // FrmValidarFecha
            // 
            AutoScaleDimensions=new SizeF(12F, 23F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.GradientActiveCaption;
            ClientSize=new Size(1200, 518);
            Controls.Add(lblIngresarFecha);
            Controls.Add(lblValidacionFechaFormato);
            Controls.Add(txtFecha);
            Controls.Add(btnValidarFecha);
            Font=new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin=new Padding(4, 3, 4, 3);
            Name="FrmValidarFecha";
            Text="FrmValidarFecha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnValidarFecha;
        private TextBox txtFecha;
        private Label lblValidacionFechaFormato;
        private Label lblIngresarFecha;
    }
}