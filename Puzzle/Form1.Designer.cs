namespace Puzzle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.btnexit = new System.Windows.Forms.Button();
            this.btngo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // btnexit
            // 
            this.btnexit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnexit.Location = new System.Drawing.Point(112, 154);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "Quit game";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btngo
            // 
            this.btngo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btngo.BackColor = System.Drawing.Color.Transparent;
            this.btngo.Location = new System.Drawing.Point(88, 53);
            this.btngo.MaximumSize = new System.Drawing.Size(127, 58);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(127, 58);
            this.btngo.TabIndex = 1;
            this.btngo.Text = "Start Game";
            this.btngo.UseVisualStyleBackColor = false;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Puzzle.Properties.Resources.puzzle_696725_960_720;
            this.ClientSize = new System.Drawing.Size(307, 236);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btngo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Puzzle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.btngo_Click);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btngo;
    }
}

