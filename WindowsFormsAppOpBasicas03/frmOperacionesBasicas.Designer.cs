
namespace WindowsFormsAppOpBasicas03
{
    partial class frmOperacionesBasicas
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
            this.cancelarButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numero2TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numero1TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sumarCheckBox = new System.Windows.Forms.CheckBox();
            this.restarCheckBox = new System.Windows.Forms.CheckBox();
            this.multiplicarCheckBox = new System.Windows.Forms.CheckBox();
            this.divisionCheckBox = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelarButton
            // 
            this.cancelarButton.Image = global::WindowsFormsAppOpBasicas03.Properties.Resources.cancel_36px;
            this.cancelarButton.Location = new System.Drawing.Point(190, 271);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 58);
            this.cancelarButton.TabIndex = 11;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Image = global::WindowsFormsAppOpBasicas03.Properties.Resources.ok_36px;
            this.OkButton.Location = new System.Drawing.Point(28, 271);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 58);
            this.OkButton.TabIndex = 10;
            this.OkButton.Text = "OK";
            this.OkButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.divisionCheckBox);
            this.groupBox1.Controls.Add(this.multiplicarCheckBox);
            this.groupBox1.Controls.Add(this.restarCheckBox);
            this.groupBox1.Controls.Add(this.sumarCheckBox);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(28, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 150);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Operaciones Básicas ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsAppOpBasicas03.Properties.Resources.divide2_20px;
            this.pictureBox4.Location = new System.Drawing.Point(17, 113);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsAppOpBasicas03.Properties.Resources.asterisk_20px;
            this.pictureBox3.Location = new System.Drawing.Point(17, 84);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsAppOpBasicas03.Properties.Resources.minus_2_math_20px;
            this.pictureBox2.Location = new System.Drawing.Point(17, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsAppOpBasicas03.Properties.Resources.plus_math_20px;
            this.pictureBox1.Location = new System.Drawing.Point(17, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // numero2TextBox
            // 
            this.numero2TextBox.Location = new System.Drawing.Point(109, 71);
            this.numero2TextBox.Name = "numero2TextBox";
            this.numero2TextBox.Size = new System.Drawing.Size(100, 20);
            this.numero2TextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Número 2:";
            // 
            // numero1TextBox
            // 
            this.numero1TextBox.Location = new System.Drawing.Point(109, 34);
            this.numero1TextBox.Name = "numero1TextBox";
            this.numero1TextBox.Size = new System.Drawing.Size(100, 20);
            this.numero1TextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Número 1:";
            // 
            // sumarCheckBox
            // 
            this.sumarCheckBox.AutoSize = true;
            this.sumarCheckBox.Checked = true;
            this.sumarCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sumarCheckBox.Location = new System.Drawing.Point(64, 27);
            this.sumarCheckBox.Name = "sumarCheckBox";
            this.sumarCheckBox.Size = new System.Drawing.Size(56, 17);
            this.sumarCheckBox.TabIndex = 2;
            this.sumarCheckBox.Text = "Sumar";
            this.sumarCheckBox.UseVisualStyleBackColor = true;
            // 
            // restarCheckBox
            // 
            this.restarCheckBox.AutoSize = true;
            this.restarCheckBox.Location = new System.Drawing.Point(64, 61);
            this.restarCheckBox.Name = "restarCheckBox";
            this.restarCheckBox.Size = new System.Drawing.Size(57, 17);
            this.restarCheckBox.TabIndex = 2;
            this.restarCheckBox.Text = "Restar";
            this.restarCheckBox.UseVisualStyleBackColor = true;
            // 
            // multiplicarCheckBox
            // 
            this.multiplicarCheckBox.AutoSize = true;
            this.multiplicarCheckBox.Location = new System.Drawing.Point(63, 91);
            this.multiplicarCheckBox.Name = "multiplicarCheckBox";
            this.multiplicarCheckBox.Size = new System.Drawing.Size(73, 17);
            this.multiplicarCheckBox.TabIndex = 2;
            this.multiplicarCheckBox.Text = "Multiplicar";
            this.multiplicarCheckBox.UseVisualStyleBackColor = true;
            // 
            // divisionCheckBox
            // 
            this.divisionCheckBox.AutoSize = true;
            this.divisionCheckBox.Location = new System.Drawing.Point(63, 119);
            this.divisionCheckBox.Name = "divisionCheckBox";
            this.divisionCheckBox.Size = new System.Drawing.Size(63, 17);
            this.divisionCheckBox.TabIndex = 2;
            this.divisionCheckBox.Text = "División";
            this.divisionCheckBox.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmOperacionesBasicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 450);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numero2TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numero1TextBox);
            this.Controls.Add(this.label1);
            this.Name = "frmOperacionesBasicas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox numero2TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numero1TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox divisionCheckBox;
        private System.Windows.Forms.CheckBox multiplicarCheckBox;
        private System.Windows.Forms.CheckBox restarCheckBox;
        private System.Windows.Forms.CheckBox sumarCheckBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

