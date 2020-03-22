namespace ejercicio_1
{
    partial class calculadoraForm
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
            this.numero1TextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.operadorComboBox = new System.Windows.Forms.ComboBox();
            this.operarButton = new System.Windows.Forms.Button();
            this.numero2TextBox = new System.Windows.Forms.TextBox();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.cerrarButton = new System.Windows.Forms.Button();
            this.aBinarioButton = new System.Windows.Forms.Button();
            this.aDecimalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numero1TextBox
            // 
            this.numero1TextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero1TextBox.Location = new System.Drawing.Point(12, 43);
            this.numero1TextBox.Name = "numero1TextBox";
            this.numero1TextBox.Size = new System.Drawing.Size(92, 29);
            this.numero1TextBox.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.AutoSize = true;
            this.resultadoLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.resultadoLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoLabel.Location = new System.Drawing.Point(331, 0);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(0, 22);
            this.resultadoLabel.TabIndex = 0;
            // 
            // operadorComboBox
            // 
            this.operadorComboBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operadorComboBox.FormattingEnabled = true;
            this.operadorComboBox.Location = new System.Drawing.Point(133, 43);
            this.operadorComboBox.Name = "operadorComboBox";
            this.operadorComboBox.Size = new System.Drawing.Size(69, 30);
            this.operadorComboBox.TabIndex = 2;
            // 
            // operarButton
            // 
            this.operarButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operarButton.Location = new System.Drawing.Point(12, 86);
            this.operarButton.Name = "operarButton";
            this.operarButton.Size = new System.Drawing.Size(92, 32);
            this.operarButton.TabIndex = 4;
            this.operarButton.Text = "Operar";
            this.operarButton.UseVisualStyleBackColor = true;
            this.operarButton.Click += new System.EventHandler(this.operarButton_Click);
            // 
            // numero2TextBox
            // 
            this.numero2TextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero2TextBox.Location = new System.Drawing.Point(228, 43);
            this.numero2TextBox.Name = "numero2TextBox";
            this.numero2TextBox.Size = new System.Drawing.Size(92, 29);
            this.numero2TextBox.TabIndex = 3;
            // 
            // limpiarButton
            // 
            this.limpiarButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarButton.Location = new System.Drawing.Point(120, 86);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(92, 32);
            this.limpiarButton.TabIndex = 5;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
            // 
            // cerrarButton
            // 
            this.cerrarButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarButton.Location = new System.Drawing.Point(228, 86);
            this.cerrarButton.Name = "cerrarButton";
            this.cerrarButton.Size = new System.Drawing.Size(92, 32);
            this.cerrarButton.TabIndex = 6;
            this.cerrarButton.Text = "Cerrar";
            this.cerrarButton.UseVisualStyleBackColor = true;
            this.cerrarButton.Click += new System.EventHandler(this.cerrarButton_Click);
            // 
            // aBinarioButton
            // 
            this.aBinarioButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aBinarioButton.Location = new System.Drawing.Point(12, 123);
            this.aBinarioButton.Name = "aBinarioButton";
            this.aBinarioButton.Size = new System.Drawing.Size(149, 32);
            this.aBinarioButton.TabIndex = 7;
            this.aBinarioButton.Text = "Convertir a binario";
            this.aBinarioButton.UseVisualStyleBackColor = true;
            this.aBinarioButton.Click += new System.EventHandler(this.aBinarioButton_Click);
            // 
            // aDecimalButton
            // 
            this.aDecimalButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aDecimalButton.Location = new System.Drawing.Point(171, 123);
            this.aDecimalButton.Name = "aDecimalButton";
            this.aDecimalButton.Size = new System.Drawing.Size(149, 32);
            this.aDecimalButton.TabIndex = 8;
            this.aDecimalButton.Text = "Convertir a decimal";
            this.aDecimalButton.UseVisualStyleBackColor = true;
            this.aDecimalButton.Click += new System.EventHandler(this.aDecimalButton_Click);
            // 
            // calculadoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 163);
            this.Controls.Add(this.aDecimalButton);
            this.Controls.Add(this.aBinarioButton);
            this.Controls.Add(this.cerrarButton);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.numero2TextBox);
            this.Controls.Add(this.operarButton);
            this.Controls.Add(this.operadorComboBox);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.numero1TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "calculadoraForm";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numero1TextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label resultadoLabel;
        private System.Windows.Forms.ComboBox operadorComboBox;
        private System.Windows.Forms.Button operarButton;
        private System.Windows.Forms.TextBox numero2TextBox;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Button cerrarButton;
        private System.Windows.Forms.Button aBinarioButton;
        private System.Windows.Forms.Button aDecimalButton;
    }
}

