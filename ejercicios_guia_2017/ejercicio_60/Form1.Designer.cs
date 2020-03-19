namespace ejercicio_60
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nacionalidadTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.personasListBox = new System.Windows.Forms.ListBox();
            this.guardarButton = new System.Windows.Forms.Button();
            this.borrarButton = new System.Windows.Forms.Button();
            this.modificarButton = new System.Windows.Forms.Button();
            this.leerButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nacionalidadTextBox);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.apellidoTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Campos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nacionalidad";
            // 
            // nacionalidadTextBox
            // 
            this.nacionalidadTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nacionalidadTextBox.Location = new System.Drawing.Point(112, 102);
            this.nacionalidadTextBox.Name = "nacionalidadTextBox";
            this.nacionalidadTextBox.Size = new System.Drawing.Size(100, 22);
            this.nacionalidadTextBox.TabIndex = 9;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(112, 50);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 22);
            this.nombreTextBox.TabIndex = 8;
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(112, 24);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 22);
            this.idTextBox.TabIndex = 1;
            this.idTextBox.Leave += new System.EventHandler(this.idTextBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre";
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoTextBox.Location = new System.Drawing.Point(112, 76);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(100, 22);
            this.apellidoTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Id";
            // 
            // personasListBox
            // 
            this.personasListBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personasListBox.FormattingEnabled = true;
            this.personasListBox.ItemHeight = 18;
            this.personasListBox.Location = new System.Drawing.Point(261, 12);
            this.personasListBox.Name = "personasListBox";
            this.personasListBox.Size = new System.Drawing.Size(353, 274);
            this.personasListBox.TabIndex = 3;
            this.personasListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.personasListBox_MouseDoubleClick);
            // 
            // guardarButton
            // 
            this.guardarButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarButton.Location = new System.Drawing.Point(135, 19);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(86, 32);
            this.guardarButton.TabIndex = 4;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // borrarButton
            // 
            this.borrarButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrarButton.Location = new System.Drawing.Point(135, 57);
            this.borrarButton.Name = "borrarButton";
            this.borrarButton.Size = new System.Drawing.Size(86, 32);
            this.borrarButton.TabIndex = 5;
            this.borrarButton.Text = "Borrar";
            this.borrarButton.UseVisualStyleBackColor = true;
            this.borrarButton.Click += new System.EventHandler(this.borrarButton_Click);
            // 
            // modificarButton
            // 
            this.modificarButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarButton.Location = new System.Drawing.Point(9, 57);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(86, 32);
            this.modificarButton.TabIndex = 6;
            this.modificarButton.Text = "Modificar";
            this.modificarButton.UseVisualStyleBackColor = true;
            this.modificarButton.Click += new System.EventHandler(this.modificarButton_Click);
            // 
            // leerButton
            // 
            this.leerButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leerButton.Location = new System.Drawing.Point(9, 19);
            this.leerButton.Name = "leerButton";
            this.leerButton.Size = new System.Drawing.Size(86, 32);
            this.leerButton.TabIndex = 7;
            this.leerButton.Text = "Leer";
            this.leerButton.UseVisualStyleBackColor = true;
            this.leerButton.Click += new System.EventHandler(this.leerButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.limpiarButton);
            this.groupBox2.Controls.Add(this.modificarButton);
            this.groupBox2.Controls.Add(this.borrarButton);
            this.groupBox2.Controls.Add(this.leerButton);
            this.groupBox2.Controls.Add(this.guardarButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 134);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operadores";
            // 
            // limpiarButton
            // 
            this.limpiarButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarButton.Location = new System.Drawing.Point(71, 95);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(86, 32);
            this.limpiarButton.TabIndex = 8;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 292);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.personasListBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nacionalidadTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox personasListBox;
        private System.Windows.Forms.Button guardarButton;
        private System.Windows.Forms.Button borrarButton;
        private System.Windows.Forms.Button modificarButton;
        private System.Windows.Forms.Button leerButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button limpiarButton;
    }
}

