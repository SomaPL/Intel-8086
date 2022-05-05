namespace Intel_8086
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AX = new System.Windows.Forms.Label();
            this.BX = new System.Windows.Forms.Label();
            this.CX = new System.Windows.Forms.Label();
            this.DX = new System.Windows.Forms.Label();
            this.textBoxAX = new System.Windows.Forms.TextBox();
            this.textBoxBX = new System.Windows.Forms.TextBox();
            this.textBoxCX = new System.Windows.Forms.TextBox();
            this.textBoxDX = new System.Windows.Forms.TextBox();
            this.MOVEAXBX = new System.Windows.Forms.Button();
            this.MOVEAXCX = new System.Windows.Forms.Button();
            this.MOVEAXDX = new System.Windows.Forms.Button();
            this.MOVEBXAX = new System.Windows.Forms.Button();
            this.MOVEBXCX = new System.Windows.Forms.Button();
            this.MOVEBXDX = new System.Windows.Forms.Button();
            this.MOVECXAX = new System.Windows.Forms.Button();
            this.MOVECXBX = new System.Windows.Forms.Button();
            this.MOVECXDX = new System.Windows.Forms.Button();
            this.MOVEDXAX = new System.Windows.Forms.Button();
            this.MOVEDXBX = new System.Windows.Forms.Button();
            this.MOVEDXCX = new System.Windows.Forms.Button();
            this.XCHGAXBX = new System.Windows.Forms.Button();
            this.XCHGAXCX = new System.Windows.Forms.Button();
            this.XCHGAXDX = new System.Windows.Forms.Button();
            this.XCHGBXCX = new System.Windows.Forms.Button();
            this.XCHGBXDX = new System.Windows.Forms.Button();
            this.XCHGCXDX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AX
            // 
            this.AX.AutoSize = true;
            this.AX.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AX.Location = new System.Drawing.Point(24, 38);
            this.AX.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.AX.Name = "AX";
            this.AX.Size = new System.Drawing.Size(26, 19);
            this.AX.TabIndex = 0;
            this.AX.Text = "AX";
            // 
            // BX
            // 
            this.BX.AutoSize = true;
            this.BX.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BX.Location = new System.Drawing.Point(24, 73);
            this.BX.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.BX.Name = "BX";
            this.BX.Size = new System.Drawing.Size(25, 19);
            this.BX.TabIndex = 1;
            this.BX.Text = "BX";
            // 
            // CX
            // 
            this.CX.AutoSize = true;
            this.CX.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CX.Location = new System.Drawing.Point(24, 109);
            this.CX.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.CX.Name = "CX";
            this.CX.Size = new System.Drawing.Size(26, 19);
            this.CX.TabIndex = 2;
            this.CX.Text = "CX";
            // 
            // DX
            // 
            this.DX.AutoSize = true;
            this.DX.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DX.Location = new System.Drawing.Point(24, 145);
            this.DX.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.DX.Name = "DX";
            this.DX.Size = new System.Drawing.Size(27, 19);
            this.DX.TabIndex = 3;
            this.DX.Text = "DX";
            // 
            // textBoxAX
            // 
            this.textBoxAX.Location = new System.Drawing.Point(56, 38);
            this.textBoxAX.MaxLength = 4;
            this.textBoxAX.Name = "textBoxAX";
            this.textBoxAX.Size = new System.Drawing.Size(100, 20);
            this.textBoxAX.TabIndex = 4;
            this.textBoxAX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAX_KeyPress);
            // 
            // textBoxBX
            // 
            this.textBoxBX.Location = new System.Drawing.Point(56, 74);
            this.textBoxBX.MaxLength = 4;
            this.textBoxBX.Name = "textBoxBX";
            this.textBoxBX.Size = new System.Drawing.Size(100, 20);
            this.textBoxBX.TabIndex = 5;
            this.textBoxBX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBX_KeyPress);
            // 
            // textBoxCX
            // 
            this.textBoxCX.Location = new System.Drawing.Point(56, 110);
            this.textBoxCX.MaxLength = 4;
            this.textBoxCX.Name = "textBoxCX";
            this.textBoxCX.Size = new System.Drawing.Size(100, 20);
            this.textBoxCX.TabIndex = 6;
            this.textBoxCX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCX_KeyPress);
            // 
            // textBoxDX
            // 
            this.textBoxDX.Location = new System.Drawing.Point(56, 146);
            this.textBoxDX.MaxLength = 4;
            this.textBoxDX.Name = "textBoxDX";
            this.textBoxDX.Size = new System.Drawing.Size(100, 20);
            this.textBoxDX.TabIndex = 7;
            this.textBoxDX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDX_KeyPress);
            // 
            // MOVEAXBX
            // 
            this.MOVEAXBX.Location = new System.Drawing.Point(28, 254);
            this.MOVEAXBX.Name = "MOVEAXBX";
            this.MOVEAXBX.Size = new System.Drawing.Size(111, 23);
            this.MOVEAXBX.TabIndex = 8;
            this.MOVEAXBX.Text = "MOVE AX BX";
            this.MOVEAXBX.UseVisualStyleBackColor = true;
            this.MOVEAXBX.Click += new System.EventHandler(this.MOVEAXBX_Click);
            // 
            // MOVEAXCX
            // 
            this.MOVEAXCX.Location = new System.Drawing.Point(28, 283);
            this.MOVEAXCX.Name = "MOVEAXCX";
            this.MOVEAXCX.Size = new System.Drawing.Size(111, 23);
            this.MOVEAXCX.TabIndex = 9;
            this.MOVEAXCX.Text = "MOVE AX CX";
            this.MOVEAXCX.UseVisualStyleBackColor = true;
            this.MOVEAXCX.Click += new System.EventHandler(this.MOVEAXCX_Click);
            // 
            // MOVEAXDX
            // 
            this.MOVEAXDX.Location = new System.Drawing.Point(28, 312);
            this.MOVEAXDX.Name = "MOVEAXDX";
            this.MOVEAXDX.Size = new System.Drawing.Size(111, 23);
            this.MOVEAXDX.TabIndex = 10;
            this.MOVEAXDX.Text = "MOVE AX DX";
            this.MOVEAXDX.UseVisualStyleBackColor = true;
            this.MOVEAXDX.Click += new System.EventHandler(this.MOVEAXDX_Click);
            // 
            // MOVEBXAX
            // 
            this.MOVEBXAX.Location = new System.Drawing.Point(145, 254);
            this.MOVEBXAX.Name = "MOVEBXAX";
            this.MOVEBXAX.Size = new System.Drawing.Size(111, 23);
            this.MOVEBXAX.TabIndex = 11;
            this.MOVEBXAX.Text = "MOVE BX AX";
            this.MOVEBXAX.UseVisualStyleBackColor = true;
            this.MOVEBXAX.Click += new System.EventHandler(this.MOVEBXAX_Click);
            // 
            // MOVEBXCX
            // 
            this.MOVEBXCX.Location = new System.Drawing.Point(145, 283);
            this.MOVEBXCX.Name = "MOVEBXCX";
            this.MOVEBXCX.Size = new System.Drawing.Size(111, 23);
            this.MOVEBXCX.TabIndex = 12;
            this.MOVEBXCX.Text = "MOVE BX CX";
            this.MOVEBXCX.UseVisualStyleBackColor = true;
            this.MOVEBXCX.Click += new System.EventHandler(this.MOVEBXCX_Click);
            // 
            // MOVEBXDX
            // 
            this.MOVEBXDX.Location = new System.Drawing.Point(145, 312);
            this.MOVEBXDX.Name = "MOVEBXDX";
            this.MOVEBXDX.Size = new System.Drawing.Size(111, 23);
            this.MOVEBXDX.TabIndex = 13;
            this.MOVEBXDX.Text = "MOVE BX DX";
            this.MOVEBXDX.UseVisualStyleBackColor = true;
            this.MOVEBXDX.Click += new System.EventHandler(this.MOVEBXDX_Click);
            // 
            // MOVECXAX
            // 
            this.MOVECXAX.Location = new System.Drawing.Point(262, 254);
            this.MOVECXAX.Name = "MOVECXAX";
            this.MOVECXAX.Size = new System.Drawing.Size(111, 23);
            this.MOVECXAX.TabIndex = 14;
            this.MOVECXAX.Text = "MOVE CX AX";
            this.MOVECXAX.UseVisualStyleBackColor = true;
            this.MOVECXAX.Click += new System.EventHandler(this.MOVECXAX_Click);
            // 
            // MOVECXBX
            // 
            this.MOVECXBX.Location = new System.Drawing.Point(262, 283);
            this.MOVECXBX.Name = "MOVECXBX";
            this.MOVECXBX.Size = new System.Drawing.Size(111, 23);
            this.MOVECXBX.TabIndex = 15;
            this.MOVECXBX.Text = "MOVE CX BX";
            this.MOVECXBX.UseVisualStyleBackColor = true;
            this.MOVECXBX.Click += new System.EventHandler(this.MOVECXBX_Click);
            // 
            // MOVECXDX
            // 
            this.MOVECXDX.Location = new System.Drawing.Point(262, 312);
            this.MOVECXDX.Name = "MOVECXDX";
            this.MOVECXDX.Size = new System.Drawing.Size(111, 23);
            this.MOVECXDX.TabIndex = 16;
            this.MOVECXDX.Text = "MOVE CX DX";
            this.MOVECXDX.UseVisualStyleBackColor = true;
            this.MOVECXDX.Click += new System.EventHandler(this.MOVECXDX_Click);
            // 
            // MOVEDXAX
            // 
            this.MOVEDXAX.Location = new System.Drawing.Point(379, 254);
            this.MOVEDXAX.Name = "MOVEDXAX";
            this.MOVEDXAX.Size = new System.Drawing.Size(111, 23);
            this.MOVEDXAX.TabIndex = 17;
            this.MOVEDXAX.Text = "MOVE DX AX";
            this.MOVEDXAX.UseVisualStyleBackColor = true;
            this.MOVEDXAX.Click += new System.EventHandler(this.MOVEDXAX_Click);
            // 
            // MOVEDXBX
            // 
            this.MOVEDXBX.Location = new System.Drawing.Point(379, 283);
            this.MOVEDXBX.Name = "MOVEDXBX";
            this.MOVEDXBX.Size = new System.Drawing.Size(111, 23);
            this.MOVEDXBX.TabIndex = 18;
            this.MOVEDXBX.Text = "MOVE DX BX";
            this.MOVEDXBX.UseVisualStyleBackColor = true;
            this.MOVEDXBX.Click += new System.EventHandler(this.MOVEDXBX_Click);
            // 
            // MOVEDXCX
            // 
            this.MOVEDXCX.Location = new System.Drawing.Point(379, 312);
            this.MOVEDXCX.Name = "MOVEDXCX";
            this.MOVEDXCX.Size = new System.Drawing.Size(111, 23);
            this.MOVEDXCX.TabIndex = 19;
            this.MOVEDXCX.Text = "MOVE DX CX";
            this.MOVEDXCX.UseVisualStyleBackColor = true;
            this.MOVEDXCX.Click += new System.EventHandler(this.MOVEDXCX_Click);
            // 
            // XCHGAXBX
            // 
            this.XCHGAXBX.Location = new System.Drawing.Point(28, 378);
            this.XCHGAXBX.Name = "XCHGAXBX";
            this.XCHGAXBX.Size = new System.Drawing.Size(110, 23);
            this.XCHGAXBX.TabIndex = 20;
            this.XCHGAXBX.Text = "XCHG AX BX";
            this.XCHGAXBX.UseVisualStyleBackColor = true;
            this.XCHGAXBX.Click += new System.EventHandler(this.XCHGAXBX_Click);
            // 
            // XCHGAXCX
            // 
            this.XCHGAXCX.Location = new System.Drawing.Point(145, 378);
            this.XCHGAXCX.Name = "XCHGAXCX";
            this.XCHGAXCX.Size = new System.Drawing.Size(110, 23);
            this.XCHGAXCX.TabIndex = 21;
            this.XCHGAXCX.Text = "XCHG AX CX";
            this.XCHGAXCX.UseVisualStyleBackColor = true;
            this.XCHGAXCX.Click += new System.EventHandler(this.XCHGAXCX_Click);
            // 
            // XCHGAXDX
            // 
            this.XCHGAXDX.Location = new System.Drawing.Point(262, 378);
            this.XCHGAXDX.Name = "XCHGAXDX";
            this.XCHGAXDX.Size = new System.Drawing.Size(110, 23);
            this.XCHGAXDX.TabIndex = 22;
            this.XCHGAXDX.Text = "XCHG AX DX";
            this.XCHGAXDX.UseVisualStyleBackColor = true;
            this.XCHGAXDX.Click += new System.EventHandler(this.XCHGAXDX_Click);
            // 
            // XCHGBXCX
            // 
            this.XCHGBXCX.Location = new System.Drawing.Point(28, 407);
            this.XCHGBXCX.Name = "XCHGBXCX";
            this.XCHGBXCX.Size = new System.Drawing.Size(110, 23);
            this.XCHGBXCX.TabIndex = 23;
            this.XCHGBXCX.Text = "XCHG BX CX";
            this.XCHGBXCX.UseVisualStyleBackColor = true;
            this.XCHGBXCX.Click += new System.EventHandler(this.XCHGBXCX_Click);
            // 
            // XCHGBXDX
            // 
            this.XCHGBXDX.Location = new System.Drawing.Point(145, 407);
            this.XCHGBXDX.Name = "XCHGBXDX";
            this.XCHGBXDX.Size = new System.Drawing.Size(110, 23);
            this.XCHGBXDX.TabIndex = 24;
            this.XCHGBXDX.Text = "XCHG BX DX";
            this.XCHGBXDX.UseVisualStyleBackColor = true;
            this.XCHGBXDX.Click += new System.EventHandler(this.XCHGBXDX_Click);
            // 
            // XCHGCXDX
            // 
            this.XCHGCXDX.Location = new System.Drawing.Point(261, 407);
            this.XCHGCXDX.Name = "XCHGCXDX";
            this.XCHGCXDX.Size = new System.Drawing.Size(110, 23);
            this.XCHGCXDX.TabIndex = 25;
            this.XCHGCXDX.Text = "XCHG CX DX";
            this.XCHGCXDX.UseVisualStyleBackColor = true;
            this.XCHGCXDX.Click += new System.EventHandler(this.XCHGCXDX_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(587, 474);
            this.Controls.Add(this.XCHGCXDX);
            this.Controls.Add(this.XCHGBXDX);
            this.Controls.Add(this.XCHGBXCX);
            this.Controls.Add(this.XCHGAXDX);
            this.Controls.Add(this.XCHGAXCX);
            this.Controls.Add(this.XCHGAXBX);
            this.Controls.Add(this.MOVEDXCX);
            this.Controls.Add(this.MOVEDXBX);
            this.Controls.Add(this.MOVEDXAX);
            this.Controls.Add(this.MOVECXDX);
            this.Controls.Add(this.MOVECXBX);
            this.Controls.Add(this.MOVECXAX);
            this.Controls.Add(this.MOVEBXDX);
            this.Controls.Add(this.MOVEBXCX);
            this.Controls.Add(this.MOVEBXAX);
            this.Controls.Add(this.MOVEAXDX);
            this.Controls.Add(this.MOVEAXCX);
            this.Controls.Add(this.MOVEAXBX);
            this.Controls.Add(this.textBoxDX);
            this.Controls.Add(this.textBoxCX);
            this.Controls.Add(this.textBoxBX);
            this.Controls.Add(this.textBoxAX);
            this.Controls.Add(this.DX);
            this.Controls.Add(this.CX);
            this.Controls.Add(this.BX);
            this.Controls.Add(this.AX);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Intel 8086";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AX;
        private System.Windows.Forms.Label BX;
        private System.Windows.Forms.Label CX;
        private System.Windows.Forms.Label DX;
        private System.Windows.Forms.TextBox textBoxAX;
        private System.Windows.Forms.TextBox textBoxBX;
        private System.Windows.Forms.TextBox textBoxCX;
        private System.Windows.Forms.TextBox textBoxDX;
        private System.Windows.Forms.Button MOVEAXBX;
        private System.Windows.Forms.Button MOVEAXCX;
        private System.Windows.Forms.Button MOVEAXDX;
        private System.Windows.Forms.Button MOVEBXAX;
        private System.Windows.Forms.Button MOVEBXCX;
        private System.Windows.Forms.Button MOVEBXDX;
        private System.Windows.Forms.Button MOVECXAX;
        private System.Windows.Forms.Button MOVECXBX;
        private System.Windows.Forms.Button MOVECXDX;
        private System.Windows.Forms.Button MOVEDXAX;
        private System.Windows.Forms.Button MOVEDXBX;
        private System.Windows.Forms.Button MOVEDXCX;
        private System.Windows.Forms.Button XCHGAXBX;
        private System.Windows.Forms.Button XCHGAXCX;
        private System.Windows.Forms.Button XCHGAXDX;
        private System.Windows.Forms.Button XCHGBXCX;
        private System.Windows.Forms.Button XCHGBXDX;
        private System.Windows.Forms.Button XCHGCXDX;
    }
}

