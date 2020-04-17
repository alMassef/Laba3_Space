namespace WindowsFormsApp12
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRefill = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.txtOut = new System.Windows.Forms.RichTextBox();
            this.txtTurn = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnRefill
            // 
            this.btnRefill.Location = new System.Drawing.Point(12, 12);
            this.btnRefill.Name = "btnRefill";
            this.btnRefill.Size = new System.Drawing.Size(291, 32);
            this.btnRefill.TabIndex = 0;
            this.btnRefill.Text = "Перезаполнить";
            this.btnRefill.UseVisualStyleBackColor = true;
            this.btnRefill.Click += new System.EventHandler(this.btnRefill_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Location = new System.Drawing.Point(12, 51);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(239, 40);
            this.txtInfo.TabIndex = 1;
            this.txtInfo.Text = "";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(231, 97);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(72, 97);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "Взять";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(12, 97);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(213, 97);
            this.txtOut.TabIndex = 3;
            this.txtOut.Text = "";
            // 
            // txtTurn
            // 
            this.txtTurn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTurn.Location = new System.Drawing.Point(309, 12);
            this.txtTurn.Name = "txtTurn";
            this.txtTurn.ReadOnly = true;
            this.txtTurn.Size = new System.Drawing.Size(113, 181);
            this.txtTurn.TabIndex = 4;
            this.txtTurn.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 276);
            this.Controls.Add(this.txtTurn);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnRefill);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefill;
        private System.Windows.Forms.RichTextBox txtInfo;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.RichTextBox txtOut;
        private System.Windows.Forms.RichTextBox txtTurn;
    }
}

