
namespace Root13
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.txtB_String = new System.Windows.Forms.TextBox();
            this.btn_encrypting = new System.Windows.Forms.Button();
            this.txtB_TextEngrypting = new System.Windows.Forms.TextBox();
            this.txtB_StringEncrypting = new System.Windows.Forms.TextBox();
            this.btn_Desencrypting = new System.Windows.Forms.Button();
            this.txtB_TextDesencrypting = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Stencil", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(289, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(163, 42);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "ROOT 13";
            // 
            // txtB_String
            // 
            this.txtB_String.Location = new System.Drawing.Point(34, 68);
            this.txtB_String.Name = "txtB_String";
            this.txtB_String.Size = new System.Drawing.Size(554, 20);
            this.txtB_String.TabIndex = 1;
            // 
            // btn_encrypting
            // 
            this.btn_encrypting.Location = new System.Drawing.Point(618, 65);
            this.btn_encrypting.Name = "btn_encrypting";
            this.btn_encrypting.Size = new System.Drawing.Size(75, 23);
            this.btn_encrypting.TabIndex = 2;
            this.btn_encrypting.Text = "Encriptar";
            this.btn_encrypting.UseVisualStyleBackColor = true;
            this.btn_encrypting.Click += new System.EventHandler(this.btn_encrypting_Click);
            // 
            // txtB_TextEngrypting
            // 
            this.txtB_TextEngrypting.Enabled = false;
            this.txtB_TextEngrypting.Location = new System.Drawing.Point(34, 103);
            this.txtB_TextEngrypting.Multiline = true;
            this.txtB_TextEngrypting.Name = "txtB_TextEngrypting";
            this.txtB_TextEngrypting.Size = new System.Drawing.Size(659, 157);
            this.txtB_TextEngrypting.TabIndex = 3;
            // 
            // txtB_StringEncrypting
            // 
            this.txtB_StringEncrypting.Location = new System.Drawing.Point(34, 296);
            this.txtB_StringEncrypting.Name = "txtB_StringEncrypting";
            this.txtB_StringEncrypting.Size = new System.Drawing.Size(554, 20);
            this.txtB_StringEncrypting.TabIndex = 4;
            // 
            // btn_Desencrypting
            // 
            this.btn_Desencrypting.Location = new System.Drawing.Point(618, 296);
            this.btn_Desencrypting.Name = "btn_Desencrypting";
            this.btn_Desencrypting.Size = new System.Drawing.Size(75, 23);
            this.btn_Desencrypting.TabIndex = 5;
            this.btn_Desencrypting.Text = "Desencriptar";
            this.btn_Desencrypting.UseVisualStyleBackColor = true;
            this.btn_Desencrypting.Click += new System.EventHandler(this.btn_Desencrypting_Click);
            // 
            // txtB_TextDesencrypting
            // 
            this.txtB_TextDesencrypting.Enabled = false;
            this.txtB_TextDesencrypting.Location = new System.Drawing.Point(34, 337);
            this.txtB_TextDesencrypting.Multiline = true;
            this.txtB_TextDesencrypting.Name = "txtB_TextDesencrypting";
            this.txtB_TextDesencrypting.Size = new System.Drawing.Size(659, 171);
            this.txtB_TextDesencrypting.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(734, 566);
            this.Controls.Add(this.txtB_TextDesencrypting);
            this.Controls.Add(this.btn_Desencrypting);
            this.Controls.Add(this.txtB_StringEncrypting);
            this.Controls.Add(this.txtB_TextEngrypting);
            this.Controls.Add(this.btn_encrypting);
            this.Controls.Add(this.txtB_String);
            this.Controls.Add(this.lbl_title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txtB_String;
        private System.Windows.Forms.Button btn_encrypting;
        private System.Windows.Forms.TextBox txtB_TextEngrypting;
        private System.Windows.Forms.TextBox txtB_StringEncrypting;
        private System.Windows.Forms.Button btn_Desencrypting;
        private System.Windows.Forms.TextBox txtB_TextDesencrypting;
    }
}

