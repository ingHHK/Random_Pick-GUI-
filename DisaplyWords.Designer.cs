namespace WindowsFormsApplication1
{
    partial class DisaplyWords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisaplyWords));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.answer_btn = new System.Windows.Forms.Button();
            this.repick_btn = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(300, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(524, 756);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // answer_btn
            // 
            this.answer_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.answer_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answer_btn.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.answer_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.answer_btn.Location = new System.Drawing.Point(35, 45);
            this.answer_btn.Name = "answer_btn";
            this.answer_btn.Size = new System.Drawing.Size(226, 75);
            this.answer_btn.TabIndex = 1;
            this.answer_btn.Text = "답 보기";
            this.answer_btn.UseVisualStyleBackColor = false;
            this.answer_btn.Click += new System.EventHandler(this.answer_btn_Click);
            // 
            // repick_btn
            // 
            this.repick_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.repick_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.repick_btn.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.repick_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.repick_btn.Location = new System.Drawing.Point(35, 149);
            this.repick_btn.Name = "repick_btn";
            this.repick_btn.Size = new System.Drawing.Size(226, 75);
            this.repick_btn.TabIndex = 2;
            this.repick_btn.Text = "다시 뽑기";
            this.repick_btn.UseVisualStyleBackColor = false;
            this.repick_btn.Click += new System.EventHandler(this.repick_btn_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.SystemColors.HotTrack;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.close.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.close.Location = new System.Drawing.Point(35, 254);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(226, 75);
            this.close.TabIndex = 3;
            this.close.Text = "닫기";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // DisaplyWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.CancelButton = this.close;
            this.ClientSize = new System.Drawing.Size(852, 765);
            this.Controls.Add(this.close);
            this.Controls.Add(this.repick_btn);
            this.Controls.Add(this.answer_btn);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(868, 804);
            this.MinimumSize = new System.Drawing.Size(868, 804);
            this.Name = "DisaplyWords";
            this.Text = "Random Pick";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button answer_btn;
        private System.Windows.Forms.Button repick_btn;
        private System.Windows.Forms.Button close;
    }
}