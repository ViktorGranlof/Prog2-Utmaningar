namespace Recipe_Manager
{
    partial class ShowRecipe
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
            this.lblChosen = new System.Windows.Forms.Label();
            this.txtInstruct = new System.Windows.Forms.TextBox();
            this.txtIngred = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingredients:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Instructions:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblChosen
            // 
            this.lblChosen.AutoSize = true;
            this.lblChosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChosen.Location = new System.Drawing.Point(86, 9);
            this.lblChosen.Name = "lblChosen";
            this.lblChosen.Size = new System.Drawing.Size(275, 42);
            this.lblChosen.TabIndex = 2;
            this.lblChosen.Text = "Chosen Recipe";
            this.lblChosen.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtInstruct
            // 
            this.txtInstruct.Location = new System.Drawing.Point(23, 214);
            this.txtInstruct.Multiline = true;
            this.txtInstruct.Name = "txtInstruct";
            this.txtInstruct.ReadOnly = true;
            this.txtInstruct.Size = new System.Drawing.Size(420, 192);
            this.txtInstruct.TabIndex = 3;
            this.txtInstruct.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtIngred
            // 
            this.txtIngred.Location = new System.Drawing.Point(23, 94);
            this.txtIngred.Multiline = true;
            this.txtIngred.Name = "txtIngred";
            this.txtIngred.ReadOnly = true;
            this.txtIngred.Size = new System.Drawing.Size(420, 66);
            this.txtIngred.TabIndex = 4;
            this.txtIngred.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ShowRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 418);
            this.Controls.Add(this.txtIngred);
            this.Controls.Add(this.txtInstruct);
            this.Controls.Add(this.lblChosen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ShowRecipe";
            this.Text = "ShowRecipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblChosen;
        private System.Windows.Forms.TextBox txtInstruct;
        private System.Windows.Forms.TextBox txtIngred;
    }
}