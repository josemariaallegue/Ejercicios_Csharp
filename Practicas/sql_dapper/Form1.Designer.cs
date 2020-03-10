namespace sql_dapper
{
    partial class personasWindow
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
            this.personasList = new System.Windows.Forms.ListBox();
            this.filtrarButton = new System.Windows.Forms.Button();
            this.apellidoText = new System.Windows.Forms.TextBox();
            this.apellidoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idAgregarText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreAgregarText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.apellidoAgregarText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nacionalidadAgregarText = new System.Windows.Forms.TextBox();
            this.agregarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personasList
            // 
            this.personasList.FormattingEnabled = true;
            this.personasList.ItemHeight = 17;
            this.personasList.Location = new System.Drawing.Point(20, 78);
            this.personasList.Margin = new System.Windows.Forms.Padding(4);
            this.personasList.Name = "personasList";
            this.personasList.Size = new System.Drawing.Size(342, 106);
            this.personasList.TabIndex = 0;
            // 
            // filtrarButton
            // 
            this.filtrarButton.Location = new System.Drawing.Point(245, 30);
            this.filtrarButton.Margin = new System.Windows.Forms.Padding(4);
            this.filtrarButton.Name = "filtrarButton";
            this.filtrarButton.Size = new System.Drawing.Size(133, 26);
            this.filtrarButton.TabIndex = 1;
            this.filtrarButton.Text = "Filtrar";
            this.filtrarButton.UseVisualStyleBackColor = true;
            this.filtrarButton.Click += new System.EventHandler(this.filtrarButton_Click);
            // 
            // apellidoText
            // 
            this.apellidoText.Location = new System.Drawing.Point(83, 30);
            this.apellidoText.Margin = new System.Windows.Forms.Padding(4);
            this.apellidoText.Name = "apellidoText";
            this.apellidoText.Size = new System.Drawing.Size(132, 25);
            this.apellidoText.TabIndex = 2;
            // 
            // apellidoLabel
            // 
            this.apellidoLabel.AutoSize = true;
            this.apellidoLabel.Location = new System.Drawing.Point(16, 34);
            this.apellidoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.apellidoLabel.Name = "apellidoLabel";
            this.apellidoLabel.Size = new System.Drawing.Size(58, 17);
            this.apellidoLabel.TabIndex = 3;
            this.apellidoLabel.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 218);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            // 
            // idAgregarText
            // 
            this.idAgregarText.Location = new System.Drawing.Point(83, 214);
            this.idAgregarText.Margin = new System.Windows.Forms.Padding(4);
            this.idAgregarText.Name = "idAgregarText";
            this.idAgregarText.Size = new System.Drawing.Size(132, 25);
            this.idAgregarText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // nombreAgregarText
            // 
            this.nombreAgregarText.Location = new System.Drawing.Point(83, 251);
            this.nombreAgregarText.Margin = new System.Windows.Forms.Padding(4);
            this.nombreAgregarText.Name = "nombreAgregarText";
            this.nombreAgregarText.Size = new System.Drawing.Size(132, 25);
            this.nombreAgregarText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellido";
            // 
            // apellidoAgregarText
            // 
            this.apellidoAgregarText.Location = new System.Drawing.Point(309, 210);
            this.apellidoAgregarText.Margin = new System.Windows.Forms.Padding(4);
            this.apellidoAgregarText.Name = "apellidoAgregarText";
            this.apellidoAgregarText.Size = new System.Drawing.Size(132, 25);
            this.apellidoAgregarText.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nacionalidad";
            // 
            // nacionalidadAgregarText
            // 
            this.nacionalidadAgregarText.Location = new System.Drawing.Point(309, 248);
            this.nacionalidadAgregarText.Margin = new System.Windows.Forms.Padding(4);
            this.nacionalidadAgregarText.Name = "nacionalidadAgregarText";
            this.nacionalidadAgregarText.Size = new System.Drawing.Size(132, 25);
            this.nacionalidadAgregarText.TabIndex = 10;
            // 
            // agregarButton
            // 
            this.agregarButton.Location = new System.Drawing.Point(167, 299);
            this.agregarButton.Margin = new System.Windows.Forms.Padding(4);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(133, 26);
            this.agregarButton.TabIndex = 12;
            this.agregarButton.Text = "Filtrar";
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // personasWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 338);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nacionalidadAgregarText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.apellidoAgregarText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombreAgregarText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idAgregarText);
            this.Controls.Add(this.apellidoLabel);
            this.Controls.Add(this.apellidoText);
            this.Controls.Add(this.filtrarButton);
            this.Controls.Add(this.personasList);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "personasWindow";
            this.Text = "Personas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox personasList;
        private System.Windows.Forms.Button filtrarButton;
        private System.Windows.Forms.TextBox apellidoText;
        private System.Windows.Forms.Label apellidoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idAgregarText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombreAgregarText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox apellidoAgregarText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nacionalidadAgregarText;
        private System.Windows.Forms.Button agregarButton;
    }
}

