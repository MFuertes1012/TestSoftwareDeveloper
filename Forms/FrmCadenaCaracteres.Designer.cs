namespace TestSoftwareDeveloper.Forms
{
    partial class FrmCadenaCaracteres
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
            btnCantidadCaracteres=new Button();
            txtCadenaTexto=new TextBox();
            label1=new Label();
            lblCant_Car=new Label();
            SuspendLayout();
            // 
            // btnCantidadCaracteres
            // 
            btnCantidadCaracteres.Location=new Point(99, 260);
            btnCantidadCaracteres.Margin=new Padding(4, 3, 4, 3);
            btnCantidadCaracteres.Name="btnCantidadCaracteres";
            btnCantidadCaracteres.Size=new Size(141, 33);
            btnCantidadCaracteres.TabIndex=0;
            btnCantidadCaracteres.Text="Contar";
            btnCantidadCaracteres.UseVisualStyleBackColor=true;
            btnCantidadCaracteres.Click+=btnCantidadCaracteres_Click;
            // 
            // txtCadenaTexto
            // 
            txtCadenaTexto.Location=new Point(333, 143);
            txtCadenaTexto.Margin=new Padding(4, 3, 4, 3);
            txtCadenaTexto.Name="txtCadenaTexto";
            txtCadenaTexto.Size=new Size(358, 38);
            txtCadenaTexto.TabIndex=1;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(135, 146);
            label1.Margin=new Padding(4, 0, 4, 0);
            label1.Name="label1";
            label1.Size=new Size(165, 23);
            label1.TabIndex=2;
            label1.Text="Introducir texto:";
            // 
            // lblCant_Car
            // 
            lblCant_Car.AutoSize=true;
            lblCant_Car.Location=new Point(99, 41);
            lblCant_Car.Margin=new Padding(4, 0, 4, 0);
            lblCant_Car.Name="lblCant_Car";
            lblCant_Car.Size=new Size(441, 23);
            lblCant_Car.TabIndex=3;
            lblCant_Car.Text="Cantidad de caracteres en la cadena de texto";
            // 
            // FrmCadenaCaracteres
            // 
            AutoScaleDimensions=new SizeF(12F, 23F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.GradientActiveCaption;
            ClientSize=new Size(1200, 518);
            Controls.Add(lblCant_Car);
            Controls.Add(label1);
            Controls.Add(txtCadenaTexto);
            Controls.Add(btnCantidadCaracteres);
            Font=new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin=new Padding(4, 3, 4, 3);
            Name="FrmCadenaCaracteres";
            Text="FrmCadenaCaracteres";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCantidadCaracteres;
        private TextBox txtCadenaTexto;
        private Label label1;
        private Label lblCant_Car;
    }
}