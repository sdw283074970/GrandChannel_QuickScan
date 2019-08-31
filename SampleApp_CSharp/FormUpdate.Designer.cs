namespace GrandChannel_QuickScan
{
    partial class FormUpdate
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.labelUPC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelStyle = new System.Windows.Forms.Label();
            this.txtUPC = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtStyle = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRowIndex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(59, 263);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(167, 263);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // labelUPC
            // 
            this.labelUPC.AutoSize = true;
            this.labelUPC.Location = new System.Drawing.Point(82, 83);
            this.labelUPC.Name = "labelUPC";
            this.labelUPC.Size = new System.Drawing.Size(36, 13);
            this.labelUPC.TabIndex = 2;
            this.labelUPC.Text = "UPC#";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Size";
            // 
            // labelStyle
            // 
            this.labelStyle.AutoSize = true;
            this.labelStyle.Location = new System.Drawing.Point(88, 118);
            this.labelStyle.Name = "labelStyle";
            this.labelStyle.Size = new System.Drawing.Size(30, 13);
            this.labelStyle.TabIndex = 5;
            this.labelStyle.Text = "Style";
            // 
            // txtUPC
            // 
            this.txtUPC.Location = new System.Drawing.Point(166, 80);
            this.txtUPC.Name = "txtUPC";
            this.txtUPC.ReadOnly = true;
            this.txtUPC.Size = new System.Drawing.Size(129, 20);
            this.txtUPC.TabIndex = 6;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(166, 184);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(129, 20);
            this.txtSize.TabIndex = 7;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(166, 148);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(129, 20);
            this.txtColor.TabIndex = 8;
            // 
            // txtStyle
            // 
            this.txtStyle.Location = new System.Drawing.Point(166, 111);
            this.txtStyle.Name = "txtStyle";
            this.txtStyle.Size = new System.Drawing.Size(129, 20);
            this.txtStyle.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(276, 263);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Row Index";
            // 
            // txtRowIndex
            // 
            this.txtRowIndex.AutoSize = true;
            this.txtRowIndex.Location = new System.Drawing.Point(337, 229);
            this.txtRowIndex.Name = "txtRowIndex";
            this.txtRowIndex.Size = new System.Drawing.Size(13, 13);
            this.txtRowIndex.TabIndex = 12;
            this.txtRowIndex.Text = "0";
            // 
            // FormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 347);
            this.Controls.Add(this.txtRowIndex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtStyle);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtUPC);
            this.Controls.Add(this.labelStyle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUPC);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRegister);
            this.Name = "FormUpdate";
            this.Text = "Register/Update UPC Infomation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelUPC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelStyle;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.TextBox txtUPC;
        public System.Windows.Forms.TextBox txtSize;
        public System.Windows.Forms.TextBox txtColor;
        public System.Windows.Forms.TextBox txtStyle;
        public System.Windows.Forms.Button btnRegister;
        public System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label txtRowIndex;
    }
}