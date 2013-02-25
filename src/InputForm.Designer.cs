namespace Solvator
{
    partial class InputForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(52, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(266, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(41, 39);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(165, 20);
            this.text1.TabIndex = 2;
            this.toolTip1.SetToolTip(this.text1, "Sintaxis: 10 -11");
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(263, 39);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(165, 20);
            this.text2.TabIndex = 3;
            this.toolTip2.SetToolTip(this.text2, "Sintaxis: 5 5");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "¡Hecho!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 123);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InputForm";
            this.Text = "Entrada de datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}