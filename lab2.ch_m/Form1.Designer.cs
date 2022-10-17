namespace lab2.ch_m
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lvDir = new System.Windows.Forms.ListView();
            this.rtbConsole = new System.Windows.Forms.RichTextBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnDirBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvDir
            // 
            this.lvDir.HideSelection = false;
            this.lvDir.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvDir.Location = new System.Drawing.Point(13, 13);
            this.lvDir.Name = "lvDir";
            this.lvDir.Size = new System.Drawing.Size(775, 284);
            this.lvDir.TabIndex = 0;
            this.lvDir.UseCompatibleStateImageBehavior = false;
            this.lvDir.View = System.Windows.Forms.View.List;
            // 
            // rtbConsole
            // 
            this.rtbConsole.Location = new System.Drawing.Point(13, 304);
            this.rtbConsole.Name = "rtbConsole";
            this.rtbConsole.ReadOnly = true;
            this.rtbConsole.Size = new System.Drawing.Size(775, 107);
            this.rtbConsole.TabIndex = 1;
            this.rtbConsole.Text = "";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(13, 418);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(694, 20);
            this.tbInput.TabIndex = 2;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(713, 418);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 3;
            this.btnInput.Text = "Ввод";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnDirBack
            // 
            this.btnDirBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDirBack.BackgroundImage")));
            this.btnDirBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDirBack.Location = new System.Drawing.Point(765, 304);
            this.btnDirBack.Name = "btnDirBack";
            this.btnDirBack.Size = new System.Drawing.Size(23, 23);
            this.btnDirBack.TabIndex = 4;
            this.btnDirBack.UseVisualStyleBackColor = true;
            this.btnDirBack.Click += new System.EventHandler(this.btnDirBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDirBack);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.rtbConsole);
            this.Controls.Add(this.lvDir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvDir;
        private System.Windows.Forms.RichTextBox rtbConsole;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnDirBack;
    }
}

