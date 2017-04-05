namespace Prosty_kalkulator
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
            this.addBtn = new System.Windows.Forms.Button();
            this.arg1 = new System.Windows.Forms.TextBox();
            this.arg2 = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.argument1LBL = new System.Windows.Forms.Label();
            this.argument2LBL = new System.Windows.Forms.Label();
            this.oddBtn = new System.Windows.Forms.Button();
            this.multBtn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.errorMsgLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addBtn.Location = new System.Drawing.Point(42, 60);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(47, 41);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.add_Click);
            // 
            // arg1
            // 
            this.arg1.Location = new System.Drawing.Point(42, 132);
            this.arg1.Name = "arg1";
            this.arg1.Size = new System.Drawing.Size(100, 20);
            this.arg1.TabIndex = 4;
            this.arg1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.arg1.WordWrap = false;
            // 
            // arg2
            // 
            this.arg2.Location = new System.Drawing.Point(148, 132);
            this.arg2.Name = "arg2";
            this.arg2.Size = new System.Drawing.Size(100, 20);
            this.arg2.TabIndex = 5;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(42, 34);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(208, 20);
            this.resultBox.TabIndex = 6;
            this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // argument1LBL
            // 
            this.argument1LBL.AutoSize = true;
            this.argument1LBL.Location = new System.Drawing.Point(39, 116);
            this.argument1LBL.Name = "argument1LBL";
            this.argument1LBL.Size = new System.Drawing.Size(61, 13);
            this.argument1LBL.TabIndex = 7;
            this.argument1LBL.Text = "Argument 1";
            // 
            // argument2LBL
            // 
            this.argument2LBL.AutoSize = true;
            this.argument2LBL.Location = new System.Drawing.Point(145, 116);
            this.argument2LBL.Name = "argument2LBL";
            this.argument2LBL.Size = new System.Drawing.Size(61, 13);
            this.argument2LBL.TabIndex = 8;
            this.argument2LBL.Text = "Argument 2";
            // 
            // oddBtn
            // 
            this.oddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oddBtn.Location = new System.Drawing.Point(97, 60);
            this.oddBtn.Name = "oddBtn";
            this.oddBtn.Size = new System.Drawing.Size(47, 41);
            this.oddBtn.TabIndex = 9;
            this.oddBtn.Text = "-";
            this.oddBtn.UseVisualStyleBackColor = true;
            this.oddBtn.Click += new System.EventHandler(this.oddBtn_Click);
            // 
            // multBtn
            // 
            this.multBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.multBtn.Location = new System.Drawing.Point(150, 60);
            this.multBtn.Name = "multBtn";
            this.multBtn.Size = new System.Drawing.Size(47, 41);
            this.multBtn.TabIndex = 10;
            this.multBtn.Text = "x";
            this.multBtn.UseVisualStyleBackColor = true;
            this.multBtn.Click += new System.EventHandler(this.multBtn_Click);
            // 
            // divBtn
            // 
            this.divBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.divBtn.Location = new System.Drawing.Point(203, 60);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(47, 41);
            this.divBtn.TabIndex = 11;
            this.divBtn.Text = "/";
            this.divBtn.UseVisualStyleBackColor = true;
            this.divBtn.Click += new System.EventHandler(this.divBtn_Click);
            // 
            // errorMsgLbl
            // 
            this.errorMsgLbl.AutoSize = true;
            this.errorMsgLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.errorMsgLbl.Location = new System.Drawing.Point(39, 164);
            this.errorMsgLbl.Name = "errorMsgLbl";
            this.errorMsgLbl.Size = new System.Drawing.Size(125, 13);
            this.errorMsgLbl.TabIndex = 12;
            this.errorMsgLbl.Text = "Niepoprawne argumenty!";
            this.errorMsgLbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.errorMsgLbl);
            this.Controls.Add(this.divBtn);
            this.Controls.Add(this.multBtn);
            this.Controls.Add(this.oddBtn);
            this.Controls.Add(this.argument2LBL);
            this.Controls.Add(this.argument1LBL);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.arg2);
            this.Controls.Add(this.arg1);
            this.Controls.Add(this.addBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox arg1;
        private System.Windows.Forms.TextBox arg2;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label argument1LBL;
        private System.Windows.Forms.Label argument2LBL;
        private System.Windows.Forms.Button oddBtn;
        private System.Windows.Forms.Button multBtn;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Label errorMsgLbl;
    }
}

