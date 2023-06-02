namespace TestSoftwareDeveloper.Forms
{
    partial class FrmEmpleado
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
            btnRegistrar=new Button();
            btnEdad=new Button();
            btnOrdenAlfabetico=new Button();
            btnOrdenEdad=new Button();
            txtId=new TextBox();
            txtNombre=new TextBox();
            txtApellidoP=new TextBox();
            txtApellidoM=new TextBox();
            lbl_Id=new Label();
            lblNombre=new Label();
            lblApellidoP=new Label();
            A=new Label();
            label1=new Label();
            groupBox1=new GroupBox();
            txtBuscarID=new TextBox();
            lblBuscar=new Label();
            dtgvEmpleado=new DataGridView();
            txtFechaNac=new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvEmpleado).BeginInit();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location=new Point(262, 444);
            btnRegistrar.Margin=new Padding(4, 3, 4, 3);
            btnRegistrar.Name="btnRegistrar";
            btnRegistrar.Size=new Size(141, 33);
            btnRegistrar.TabIndex=0;
            btnRegistrar.Text="Registrar";
            btnRegistrar.UseVisualStyleBackColor=true;
            btnRegistrar.Click+=btnRegistrar_Click;
            // 
            // btnEdad
            // 
            btnEdad.Location=new Point(770, 87);
            btnEdad.Margin=new Padding(4, 3, 4, 3);
            btnEdad.Name="btnEdad";
            btnEdad.Size=new Size(141, 33);
            btnEdad.TabIndex=1;
            btnEdad.Text="Edad";
            btnEdad.UseVisualStyleBackColor=true;
            btnEdad.Click+=btnEdad_Click;
            // 
            // btnOrdenAlfabetico
            // 
            btnOrdenAlfabetico.Location=new Point(421, 444);
            btnOrdenAlfabetico.Margin=new Padding(4, 3, 4, 3);
            btnOrdenAlfabetico.Name="btnOrdenAlfabetico";
            btnOrdenAlfabetico.Size=new Size(195, 33);
            btnOrdenAlfabetico.TabIndex=2;
            btnOrdenAlfabetico.Text="Lista Alfabética";
            btnOrdenAlfabetico.UseVisualStyleBackColor=true;
            btnOrdenAlfabetico.Click+=btnOrdenAlfabetico_Click;
            // 
            // btnOrdenEdad
            // 
            btnOrdenEdad.Location=new Point(421, 483);
            btnOrdenEdad.Margin=new Padding(4, 3, 4, 3);
            btnOrdenEdad.Name="btnOrdenEdad";
            btnOrdenEdad.Size=new Size(195, 33);
            btnOrdenEdad.TabIndex=3;
            btnOrdenEdad.Text="Lista por Edad";
            btnOrdenEdad.UseVisualStyleBackColor=true;
            btnOrdenEdad.Click+=btnOrdenEdad_Click;
            // 
            // txtId
            // 
            txtId.Location=new Point(236, 71);
            txtId.Margin=new Padding(4, 3, 4, 3);
            txtId.Name="txtId";
            txtId.Size=new Size(351, 38);
            txtId.TabIndex=4;
            // 
            // txtNombre
            // 
            txtNombre.Location=new Point(236, 139);
            txtNombre.Margin=new Padding(4, 3, 4, 3);
            txtNombre.Name="txtNombre";
            txtNombre.Size=new Size(351, 38);
            txtNombre.TabIndex=5;
            // 
            // txtApellidoP
            // 
            txtApellidoP.Location=new Point(236, 210);
            txtApellidoP.Margin=new Padding(4, 3, 4, 3);
            txtApellidoP.Name="txtApellidoP";
            txtApellidoP.Size=new Size(351, 38);
            txtApellidoP.TabIndex=6;
            // 
            // txtApellidoM
            // 
            txtApellidoM.Location=new Point(236, 288);
            txtApellidoM.Margin=new Padding(4, 3, 4, 3);
            txtApellidoM.Name="txtApellidoM";
            txtApellidoM.Size=new Size(351, 38);
            txtApellidoM.TabIndex=7;
            // 
            // lbl_Id
            // 
            lbl_Id.AutoSize=true;
            lbl_Id.Location=new Point(12, 74);
            lbl_Id.Margin=new Padding(4, 0, 4, 0);
            lbl_Id.Name="lbl_Id";
            lbl_Id.Size=new Size(35, 23);
            lbl_Id.TabIndex=9;
            lbl_Id.Text="Id:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize=true;
            lblNombre.Location=new Point(12, 142);
            lblNombre.Margin=new Padding(4, 0, 4, 0);
            lblNombre.Name="lblNombre";
            lblNombre.Size=new Size(94, 23);
            lblNombre.TabIndex=10;
            lblNombre.Text="Nombre:";
            // 
            // lblApellidoP
            // 
            lblApellidoP.AutoSize=true;
            lblApellidoP.Location=new Point(12, 214);
            lblApellidoP.Margin=new Padding(4, 0, 4, 0);
            lblApellidoP.Name="lblApellidoP";
            lblApellidoP.Size=new Size(175, 23);
            lblApellidoP.TabIndex=11;
            lblApellidoP.Text="Apellido Paterno:";
            // 
            // A
            // 
            A.AutoSize=true;
            A.Location=new Point(12, 292);
            A.Margin=new Padding(4, 0, 4, 0);
            A.Name="A";
            A.Size=new Size(181, 23);
            A.TabIndex=13;
            A.Text="Apellido Materno:";
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(12, 364);
            label1.Margin=new Padding(4, 0, 4, 0);
            label1.Name="label1";
            label1.Size=new Size(216, 23);
            label1.TabIndex=14;
            label1.Text="Fecha de Nacimiento:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtFechaNac);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(A);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtApellidoP);
            groupBox1.Controls.Add(lblApellidoP);
            groupBox1.Controls.Add(txtApellidoM);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(lbl_Id);
            groupBox1.Location=new Point(22, 23);
            groupBox1.Name="groupBox1";
            groupBox1.Size=new Size(599, 406);
            groupBox1.TabIndex=15;
            groupBox1.TabStop=false;
            groupBox1.Text="Registro Empleado";
            // 
            // txtBuscarID
            // 
            txtBuscarID.Location=new Point(638, 82);
            txtBuscarID.Name="txtBuscarID";
            txtBuscarID.Size=new Size(125, 38);
            txtBuscarID.TabIndex=16;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize=true;
            lblBuscar.Location=new Point(638, 38);
            lblBuscar.Name="lblBuscar";
            lblBuscar.Size=new Size(143, 23);
            lblBuscar.TabIndex=17;
            lblBuscar.Text="Buscar por Id:";
            // 
            // dtgvEmpleado
            // 
            dtgvEmpleado.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvEmpleado.Location=new Point(639, 145);
            dtgvEmpleado.Name="dtgvEmpleado";
            dtgvEmpleado.RowHeadersWidth=51;
            dtgvEmpleado.RowTemplate.Height=29;
            dtgvEmpleado.Size=new Size(682, 371);
            dtgvEmpleado.TabIndex=18;
            // 
            // txtFechaNac
            // 
            txtFechaNac.Location=new Point(236, 349);
            txtFechaNac.Margin=new Padding(4, 3, 4, 3);
            txtFechaNac.Name="txtFechaNac";
            txtFechaNac.Size=new Size(351, 38);
            txtFechaNac.TabIndex=15;
            // 
            // FrmEmpleado
            // 
            AutoScaleDimensions=new SizeF(12F, 23F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.GradientActiveCaption;
            ClientSize=new Size(1345, 704);
            Controls.Add(dtgvEmpleado);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscarID);
            Controls.Add(groupBox1);
            Controls.Add(btnOrdenEdad);
            Controls.Add(btnOrdenAlfabetico);
            Controls.Add(btnEdad);
            Controls.Add(btnRegistrar);
            Font=new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin=new Padding(4, 3, 4, 3);
            Name="FrmEmpleado";
            Text="FrmEmpleado";
            Load+=FrmEmpleado_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvEmpleado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Button btnEdad;
        private Button btnOrdenAlfabetico;
        private Button btnOrdenEdad;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtApellidoP;
        private TextBox txtApellidoM;
        private Label lbl_Id;
        private Label lblNombre;
        private Label lblApellidoP;
        private Label A;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtBuscarID;
        private Label lblBuscar;
        private DataGridView dtgvEmpleado;
        private TextBox txtFechaNac;
    }
}