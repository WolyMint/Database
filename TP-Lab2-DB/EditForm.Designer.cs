namespace TP_Lab2_DB
{
    partial class EditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ndId = new System.Windows.Forms.NumericUpDown();
            this.tbSN = new System.Windows.Forms.TextBox();
            this.ndMrk = new System.Windows.Forms.NumericUpDown();
            this.tbL = new System.Windows.Forms.TextBox();
            this.cbST = new System.Windows.Forms.ComboBox();
            this.btOk = new System.Windows.Forms.Button();
            this.btCan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ndId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndMrk)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ф.И.О. Ученика";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Оценка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Урок";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Задание";
            // 
            // ndId
            // 
            this.ndId.Location = new System.Drawing.Point(253, 24);
            this.ndId.Name = "ndId";
            this.ndId.Size = new System.Drawing.Size(226, 22);
            this.ndId.TabIndex = 5;
            this.ndId.ValueChanged += new System.EventHandler(this.ndId_ValueChanged);
            // 
            // tbSN
            // 
            this.tbSN.Location = new System.Drawing.Point(253, 74);
            this.tbSN.Name = "tbSN";
            this.tbSN.Size = new System.Drawing.Size(226, 22);
            this.tbSN.TabIndex = 6;
            // 
            // ndMrk
            // 
            this.ndMrk.Location = new System.Drawing.Point(253, 124);
            this.ndMrk.Name = "ndMrk";
            this.ndMrk.Size = new System.Drawing.Size(226, 22);
            this.ndMrk.TabIndex = 7;
            // 
            // tbL
            // 
            this.tbL.Location = new System.Drawing.Point(253, 174);
            this.tbL.Name = "tbL";
            this.tbL.Size = new System.Drawing.Size(226, 22);
            this.tbL.TabIndex = 8;
            // 
            // cbST
            // 
            this.cbST.FormattingEnabled = true;
            this.cbST.Location = new System.Drawing.Point(253, 227);
            this.cbST.Name = "cbST";
            this.cbST.Size = new System.Drawing.Size(226, 24);
            this.cbST.TabIndex = 9;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(12, 292);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(142, 44);
            this.btOk.TabIndex = 10;
            this.btOk.Text = "Применить";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCan
            // 
            this.btCan.Location = new System.Drawing.Point(337, 292);
            this.btCan.Name = "btCan";
            this.btCan.Size = new System.Drawing.Size(142, 44);
            this.btCan.TabIndex = 11;
            this.btCan.Text = "Отмена";
            this.btCan.UseVisualStyleBackColor = true;
            this.btCan.Click += new System.EventHandler(this.btCan_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 362);
            this.Controls.Add(this.btCan);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.cbST);
            this.Controls.Add(this.tbL);
            this.Controls.Add(this.ndMrk);
            this.Controls.Add(this.tbSN);
            this.Controls.Add(this.ndId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditForm";
            this.Text = "EditForm";
            ((System.ComponentModel.ISupportInitialize)(this.ndId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndMrk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ndId;
        private System.Windows.Forms.TextBox tbSN;
        private System.Windows.Forms.NumericUpDown ndMrk;
        private System.Windows.Forms.TextBox tbL;
        private System.Windows.Forms.ComboBox cbST;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCan;
    }
}