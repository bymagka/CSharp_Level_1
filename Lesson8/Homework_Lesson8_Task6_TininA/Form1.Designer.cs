
namespace Homework_Lesson8_Task6_TininA
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
            this.tbXML = new System.Windows.Forms.TextBox();
            this.tbCSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCSV = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnChoseCSV = new System.Windows.Forms.Button();
            this.btnChoseXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbXML
            // 
            this.tbXML.Location = new System.Drawing.Point(49, 140);
            this.tbXML.Multiline = true;
            this.tbXML.Name = "tbXML";
            this.tbXML.Size = new System.Drawing.Size(146, 110);
            this.tbXML.TabIndex = 0;
            // 
            // tbCSV
            // 
            this.tbCSV.Location = new System.Drawing.Point(573, 140);
            this.tbCSV.Multiline = true;
            this.tbCSV.Name = "tbCSV";
            this.tbCSV.Size = new System.Drawing.Size(170, 126);
            this.tbCSV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "XML";
            // 
            // lblCSV
            // 
            this.lblCSV.AutoSize = true;
            this.lblCSV.Location = new System.Drawing.Point(644, 117);
            this.lblCSV.Name = "lblCSV";
            this.lblCSV.Size = new System.Drawing.Size(42, 20);
            this.lblCSV.TabIndex = 3;
            this.lblCSV.Text = "CSV";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "To CSV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "To XML";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnChoseCSV
            // 
            this.btnChoseCSV.Location = new System.Drawing.Point(749, 142);
            this.btnChoseCSV.Name = "btnChoseCSV";
            this.btnChoseCSV.Size = new System.Drawing.Size(20, 26);
            this.btnChoseCSV.TabIndex = 6;
            this.btnChoseCSV.Text = ".";
            this.btnChoseCSV.UseVisualStyleBackColor = true;
            this.btnChoseCSV.Click += new System.EventHandler(this.btnChoseCSV_Click);
            // 
            // btnChoseXML
            // 
            this.btnChoseXML.Location = new System.Drawing.Point(202, 142);
            this.btnChoseXML.Name = "btnChoseXML";
            this.btnChoseXML.Size = new System.Drawing.Size(18, 24);
            this.btnChoseXML.TabIndex = 7;
            this.btnChoseXML.Text = ".";
            this.btnChoseXML.UseVisualStyleBackColor = true;
            this.btnChoseXML.Click += new System.EventHandler(this.btnChoseXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 294);
            this.Controls.Add(this.btnChoseXML);
            this.Controls.Add(this.btnChoseCSV);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCSV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCSV);
            this.Controls.Add(this.tbXML);
            this.Name = "Form1";
            this.Text = "Сериализатор файлов со студентами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbXML;
        private System.Windows.Forms.TextBox tbCSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCSV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnChoseCSV;
        private System.Windows.Forms.Button btnChoseXML;
    }
}

