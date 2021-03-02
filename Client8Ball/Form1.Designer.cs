namespace Client8Ball
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxQuestion = new System.Windows.Forms.TextBox();
            this.btnShake8 = new System.Windows.Forms.Button();
            this.txtboxResponse = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShake8);
            this.groupBox1.Controls.Add(this.txtBoxQuestion);
            this.groupBox1.Location = new System.Drawing.Point(35, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtboxResponse);
            this.groupBox2.Location = new System.Drawing.Point(35, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 264);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox1";
            // 
            // txtBoxQuestion
            // 
            this.txtBoxQuestion.Location = new System.Drawing.Point(6, 35);
            this.txtBoxQuestion.Name = "txtBoxQuestion";
            this.txtBoxQuestion.Size = new System.Drawing.Size(644, 26);
            this.txtBoxQuestion.TabIndex = 0;
            // 
            // btnShake8
            // 
            this.btnShake8.Location = new System.Drawing.Point(186, 113);
            this.btnShake8.Name = "btnShake8";
            this.btnShake8.Size = new System.Drawing.Size(271, 44);
            this.btnShake8.TabIndex = 1;
            this.btnShake8.Text = "Shake 8 Ball";
            this.btnShake8.UseVisualStyleBackColor = true;
            this.btnShake8.Click += new System.EventHandler(this.btnShake8_Click);
            // 
            // txtboxResponse
            // 
            this.txtboxResponse.Location = new System.Drawing.Point(7, 53);
            this.txtboxResponse.Multiline = true;
            this.txtboxResponse.Name = "txtboxResponse";
            this.txtboxResponse.ReadOnly = true;
            this.txtboxResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtboxResponse.Size = new System.Drawing.Size(643, 135);
            this.txtboxResponse.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 583);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Kyle\'s 8 Ball App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShake8;
        private System.Windows.Forms.TextBox txtBoxQuestion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtboxResponse;
    }
}

