
namespace Homework_Lesson7_TininA_Task1
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
            this.PlusButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.Label();
            this.ActionsCountText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblGameNumber = new System.Windows.Forms.Label();
            this.lblMinSteps = new System.Windows.Forms.Label();
            this.lblPlayerSteps = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(335, 12);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(182, 35);
            this.PlusButton.TabIndex = 0;
            this.PlusButton.Text = "+1";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "x2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(335, 126);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(182, 35);
            this.Reset.TabIndex = 2;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Location = new System.Drawing.Point(101, 56);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(51, 20);
            this.number.TabIndex = 3;
            this.number.Text = "label1";
            // 
            // ActionsCountText
            // 
            this.ActionsCountText.AutoSize = true;
            this.ActionsCountText.Location = new System.Drawing.Point(101, 103);
            this.ActionsCountText.Name = "ActionsCountText";
            this.ActionsCountText.Size = new System.Drawing.Size(18, 20);
            this.ActionsCountText.TabIndex = 4;
            this.ActionsCountText.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Загаданное число:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Минимальное количество ходов:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество ваших ходов:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "New game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(533, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 35);
            this.button3.TabIndex = 9;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblGameNumber
            // 
            this.lblGameNumber.AutoSize = true;
            this.lblGameNumber.Location = new System.Drawing.Point(197, 215);
            this.lblGameNumber.Name = "lblGameNumber";
            this.lblGameNumber.Size = new System.Drawing.Size(0, 20);
            this.lblGameNumber.TabIndex = 10;
            // 
            // lblMinSteps
            // 
            this.lblMinSteps.AutoSize = true;
            this.lblMinSteps.Location = new System.Drawing.Point(304, 257);
            this.lblMinSteps.Name = "lblMinSteps";
            this.lblMinSteps.Size = new System.Drawing.Size(0, 20);
            this.lblMinSteps.TabIndex = 11;
            // 
            // lblPlayerSteps
            // 
            this.lblPlayerSteps.AutoSize = true;
            this.lblPlayerSteps.Location = new System.Drawing.Point(243, 295);
            this.lblPlayerSteps.Name = "lblPlayerSteps";
            this.lblPlayerSteps.Size = new System.Drawing.Size(0, 20);
            this.lblPlayerSteps.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 347);
            this.Controls.Add(this.lblPlayerSteps);
            this.Controls.Add(this.lblMinSteps);
            this.Controls.Add(this.lblGameNumber);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActionsCountText);
            this.Controls.Add(this.number);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PlusButton);
            this.Name = "Form1";
            this.Text = "Удвоитель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label ActionsCountText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblGameNumber;
        private System.Windows.Forms.Label lblMinSteps;
        private System.Windows.Forms.Label lblPlayerSteps;
    }
}

