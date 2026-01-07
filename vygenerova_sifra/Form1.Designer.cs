namespace vygenerova_sifra
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textIn = new System.Windows.Forms.TextBox();
            this.textOut = new System.Windows.Forms.TextBox();
            this.textKey = new System.Windows.Forms.TextBox();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.labelKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textIn
            // 
            this.textIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textIn.Location = new System.Drawing.Point(24, 13);
            this.textIn.Multiline = true;
            this.textIn.Name = "textIn";
            this.textIn.Size = new System.Drawing.Size(323, 121);
            this.textIn.TabIndex = 0;
            this.textIn.TextChanged += new System.EventHandler(this.textIn_TextChanged);
            // 
            // textOut
            // 
            this.textOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textOut.Location = new System.Drawing.Point(24, 160);
            this.textOut.Multiline = true;
            this.textOut.Name = "textOut";
            this.textOut.Size = new System.Drawing.Size(323, 121);
            this.textOut.TabIndex = 1;
            // 
            // textKey
            // 
            this.textKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textKey.Location = new System.Drawing.Point(362, 78);
            this.textKey.Multiline = true;
            this.textKey.Name = "textKey";
            this.textKey.Size = new System.Drawing.Size(323, 56);
            this.textKey.TabIndex = 2;
            // 
            // buttonEncode
            // 
            this.buttonEncode.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEncode.Location = new System.Drawing.Point(362, 145);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(323, 65);
            this.buttonEncode.TabIndex = 3;
            this.buttonEncode.Text = "Encode";
            this.buttonEncode.UseVisualStyleBackColor = true;
            // 
            // buttonDecode
            // 
            this.buttonDecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDecode.Location = new System.Drawing.Point(362, 216);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(323, 65);
            this.buttonDecode.TabIndex = 4;
            this.buttonDecode.Text = "Decode";
            this.buttonDecode.UseVisualStyleBackColor = true;
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKey.Location = new System.Drawing.Point(357, 50);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(50, 25);
            this.labelKey.TabIndex = 5;
            this.labelKey.Text = "Klíč:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 297);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.textKey);
            this.Controls.Add(this.textOut);
            this.Controls.Add(this.textIn);
            this.Name = "Form1";
            this.Text = "Vigenerova Šifra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textIn;
        private System.Windows.Forms.TextBox textOut;
        private System.Windows.Forms.TextBox textKey;
        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.Label labelKey;
    }
}

