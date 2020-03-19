namespace ejercicio_59
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.productosListBox = new System.Windows.Forms.ListBox();
            this.IdBuscarTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.buscarButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.precioModificarTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nombreModificarTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cantidadModificarTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.modificarButton = new System.Windows.Forms.Button();
            this.idModificarTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.precioAgregarTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nombreAgregarTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cantidadAgregarTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.agregarButton = new System.Windows.Forms.Button();
            this.pesoModificarTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pesoAgregarTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // productosListBox
            // 
            this.productosListBox.FormattingEnabled = true;
            this.productosListBox.Location = new System.Drawing.Point(311, 12);
            this.productosListBox.Name = "productosListBox";
            this.productosListBox.Size = new System.Drawing.Size(516, 394);
            this.productosListBox.TabIndex = 0;
            // 
            // IdBuscarTextBox
            // 
            this.IdBuscarTextBox.Location = new System.Drawing.Point(70, 30);
            this.IdBuscarTextBox.Name = "IdBuscarTextBox";
            this.IdBuscarTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdBuscarTextBox.TabIndex = 1;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(6, 28);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(16, 13);
            this.IdLabel.TabIndex = 2;
            this.IdLabel.Text = "Id";
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(197, 30);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 23);
            this.buscarButton.TabIndex = 3;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buscarButton);
            this.groupBox1.Controls.Add(this.IdBuscarTextBox);
            this.groupBox1.Controls.Add(this.IdLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 74);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pesoModificarTextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.precioModificarTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.nombreModificarTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cantidadModificarTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.modificarButton);
            this.groupBox2.Controls.Add(this.idModificarTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 174);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alta - Baja - Modificacion";
            // 
            // precioModificarTextBox
            // 
            this.precioModificarTextBox.Location = new System.Drawing.Point(70, 115);
            this.precioModificarTextBox.Name = "precioModificarTextBox";
            this.precioModificarTextBox.Size = new System.Drawing.Size(100, 20);
            this.precioModificarTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio";
            // 
            // nombreModificarTextBox
            // 
            this.nombreModificarTextBox.Location = new System.Drawing.Point(70, 57);
            this.nombreModificarTextBox.Name = "nombreModificarTextBox";
            this.nombreModificarTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreModificarTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre";
            // 
            // cantidadModificarTextBox
            // 
            this.cantidadModificarTextBox.Location = new System.Drawing.Point(70, 86);
            this.cantidadModificarTextBox.Name = "cantidadModificarTextBox";
            this.cantidadModificarTextBox.Size = new System.Drawing.Size(100, 20);
            this.cantidadModificarTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantidad";
            // 
            // modificarButton
            // 
            this.modificarButton.Location = new System.Drawing.Point(197, 86);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(75, 23);
            this.modificarButton.TabIndex = 3;
            this.modificarButton.Text = "Modificar";
            this.modificarButton.UseVisualStyleBackColor = true;
            this.modificarButton.Click += new System.EventHandler(this.modificarButton_Click);
            // 
            // idModificarTextBox
            // 
            this.idModificarTextBox.Location = new System.Drawing.Point(70, 28);
            this.idModificarTextBox.Name = "idModificarTextBox";
            this.idModificarTextBox.Size = new System.Drawing.Size(100, 20);
            this.idModificarTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pesoAgregarTextBox);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.precioAgregarTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.nombreAgregarTextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cantidadAgregarTextBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.agregarButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 272);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 134);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Agregar";
            // 
            // precioAgregarTextBox
            // 
            this.precioAgregarTextBox.Location = new System.Drawing.Point(70, 77);
            this.precioAgregarTextBox.Name = "precioAgregarTextBox";
            this.precioAgregarTextBox.Size = new System.Drawing.Size(100, 20);
            this.precioAgregarTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Precio";
            // 
            // nombreAgregarTextBox
            // 
            this.nombreAgregarTextBox.Location = new System.Drawing.Point(70, 19);
            this.nombreAgregarTextBox.Name = "nombreAgregarTextBox";
            this.nombreAgregarTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreAgregarTextBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nombre";
            // 
            // cantidadAgregarTextBox
            // 
            this.cantidadAgregarTextBox.Location = new System.Drawing.Point(70, 48);
            this.cantidadAgregarTextBox.Name = "cantidadAgregarTextBox";
            this.cantidadAgregarTextBox.Size = new System.Drawing.Size(100, 20);
            this.cantidadAgregarTextBox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cantidad";
            // 
            // agregarButton
            // 
            this.agregarButton.Location = new System.Drawing.Point(197, 58);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(75, 23);
            this.agregarButton.TabIndex = 3;
            this.agregarButton.Text = "Agregar";
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // pesoModificarTextBox
            // 
            this.pesoModificarTextBox.Location = new System.Drawing.Point(70, 146);
            this.pesoModificarTextBox.Name = "pesoModificarTextBox";
            this.pesoModificarTextBox.Size = new System.Drawing.Size(100, 20);
            this.pesoModificarTextBox.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Peso";
            // 
            // pesoAgregarTextBox
            // 
            this.pesoAgregarTextBox.Location = new System.Drawing.Point(70, 103);
            this.pesoAgregarTextBox.Name = "pesoAgregarTextBox";
            this.pesoAgregarTextBox.Size = new System.Drawing.Size(100, 20);
            this.pesoAgregarTextBox.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Peso";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 414);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.productosListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox productosListBox;
        private System.Windows.Forms.TextBox IdBuscarTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button modificarButton;
        private System.Windows.Forms.TextBox idModificarTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox precioModificarTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombreModificarTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cantidadModificarTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox precioAgregarTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nombreAgregarTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cantidadAgregarTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.TextBox pesoModificarTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pesoAgregarTextBox;
        private System.Windows.Forms.Label label10;
    }
}

