namespace Recipe_Manager
{
    partial class AddRecipe
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblRecpName = new System.Windows.Forms.Label();
            this.lblIngred = new System.Windows.Forms.Label();
            this.lblInstruct = new System.Windows.Forms.Label();
            this.txtRecipe = new System.Windows.Forms.TextBox();
            this.txtIngred = new System.Windows.Forms.TextBox();
            this.txtInstruct = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(86, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(227, 46);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Add Recipe";
            this.lblHeader.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRecpName
            // 
            this.lblRecpName.AutoSize = true;
            this.lblRecpName.Location = new System.Drawing.Point(66, 72);
            this.lblRecpName.Name = "lblRecpName";
            this.lblRecpName.Size = new System.Drawing.Size(97, 17);
            this.lblRecpName.TabIndex = 1;
            this.lblRecpName.Text = "Recipe Name:";
            // 
            // lblIngred
            // 
            this.lblIngred.AutoSize = true;
            this.lblIngred.Location = new System.Drawing.Point(68, 106);
            this.lblIngred.Name = "lblIngred";
            this.lblIngred.Size = new System.Drawing.Size(82, 17);
            this.lblIngred.TabIndex = 2;
            this.lblIngred.Text = "Ingredients:";
            // 
            // lblInstruct
            // 
            this.lblInstruct.AutoSize = true;
            this.lblInstruct.Location = new System.Drawing.Point(72, 164);
            this.lblInstruct.Name = "lblInstruct";
            this.lblInstruct.Size = new System.Drawing.Size(84, 17);
            this.lblInstruct.TabIndex = 3;
            this.lblInstruct.Text = "Instructions:";
            // 
            // txtRecipe
            // 
            this.txtRecipe.Location = new System.Drawing.Point(169, 72);
            this.txtRecipe.Name = "txtRecipe";
            this.txtRecipe.Size = new System.Drawing.Size(144, 22);
            this.txtRecipe.TabIndex = 4;
            this.txtRecipe.TextChanged += new System.EventHandler(this.txtRecipe_TextChanged);
            // 
            // txtIngred
            // 
            this.txtIngred.Location = new System.Drawing.Point(75, 126);
            this.txtIngred.Name = "txtIngred";
            this.txtIngred.Size = new System.Drawing.Size(238, 22);
            this.txtIngred.TabIndex = 5;
            this.txtIngred.TextChanged += new System.EventHandler(this.txtIngred_TextChanged);
            // 
            // txtInstruct
            // 
            this.txtInstruct.Location = new System.Drawing.Point(75, 184);
            this.txtInstruct.Multiline = true;
            this.txtInstruct.Name = "txtInstruct";
            this.txtInstruct.Size = new System.Drawing.Size(238, 144);
            this.txtInstruct.TabIndex = 6;
            this.txtInstruct.TextChanged += new System.EventHandler(this.txtInstruct_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(75, 334);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 42);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add Recipe";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnCan
            // 
            this.btnCan.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCan.Location = new System.Drawing.Point(207, 334);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(106, 42);
            this.btnCan.TabIndex = 8;
            this.btnCan.Text = "Cancel";
            this.btnCan.UseVisualStyleBackColor = true;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // AddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 396);
            this.Controls.Add(this.btnCan);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtInstruct);
            this.Controls.Add(this.txtIngred);
            this.Controls.Add(this.txtRecipe);
            this.Controls.Add(this.lblInstruct);
            this.Controls.Add(this.lblIngred);
            this.Controls.Add(this.lblRecpName);
            this.Controls.Add(this.lblHeader);
            this.Name = "AddRecipe";
            this.Text = "AddRecipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblRecpName;
        private System.Windows.Forms.Label lblIngred;
        private System.Windows.Forms.Label lblInstruct;
        private System.Windows.Forms.TextBox txtRecipe;
        private System.Windows.Forms.TextBox txtIngred;
        private System.Windows.Forms.TextBox txtInstruct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCan;
    }
}