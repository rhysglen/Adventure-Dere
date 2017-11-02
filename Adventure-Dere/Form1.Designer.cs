namespace Adventure_Dere
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
            this.label1 = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.question2Label = new System.Windows.Forms.Label();
            this.question3Label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adventure-Dere";
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(28, 85);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(336, 177);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.Text = "label2";
            // 
            // questionLabel
            // 
            this.questionLabel.Location = new System.Drawing.Point(12, 328);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(352, 42);
            this.questionLabel.TabIndex = 2;
            this.questionLabel.Text = "label2";
            // 
            // question2Label
            // 
            this.question2Label.Location = new System.Drawing.Point(12, 388);
            this.question2Label.Name = "question2Label";
            this.question2Label.Size = new System.Drawing.Size(352, 42);
            this.question2Label.TabIndex = 3;
            this.question2Label.Text = "label3";
            // 
            // question3Label
            // 
            this.question3Label.Location = new System.Drawing.Point(12, 444);
            this.question3Label.Name = "question3Label";
            this.question3Label.Size = new System.Drawing.Size(352, 42);
            this.question3Label.TabIndex = 4;
            this.question3Label.Text = "label4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(738, 495);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.question3Label);
            this.Controls.Add(this.question2Label);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Adventure-Dere";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label question2Label;
        private System.Windows.Forms.Label question3Label;
        private System.Windows.Forms.Button button1;
    }
}

