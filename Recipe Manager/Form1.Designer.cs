namespace Recipe_Manager
{
    partial class Form1
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRem = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.lbxMain = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lbl1.Location = new System.Drawing.Point(151, 21);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(293, 42);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Recipe Manager";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(105, 95);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 42);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Recipe";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRem
            // 
            this.btnRem.Location = new System.Drawing.Point(291, 95);
            this.btnRem.Name = "btnRem";
            this.btnRem.Size = new System.Drawing.Size(180, 42);
            this.btnRem.TabIndex = 2;
            this.btnRem.Text = "Remove Recipe";
            this.btnRem.UseVisualStyleBackColor = true;
            this.btnRem.Click += new System.EventHandler(this.btnRem_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(21, 430);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(525, 42);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show Recipe";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lbxMain
            // 
            this.lbxMain.FormattingEnabled = true;
            this.lbxMain.ItemHeight = 16;
            this.lbxMain.Location = new System.Drawing.Point(21, 143);
            this.lbxMain.Name = "lbxMain";
            this.lbxMain.Size = new System.Drawing.Size(525, 276);
            this.lbxMain.TabIndex = 6;
            this.lbxMain.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 484);
            this.Controls.Add(this.lbxMain);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnRem);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRem;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ListBox lbxMain;
    }
}

