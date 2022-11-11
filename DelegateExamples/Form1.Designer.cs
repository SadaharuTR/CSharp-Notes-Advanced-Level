namespace DelegateExamples
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
            this.ekleButton = new System.Windows.Forms.Button();
            this.alinacaklarListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ekleButton
            // 
            this.ekleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekleButton.Location = new System.Drawing.Point(69, 55);
            this.ekleButton.Name = "ekleButton";
            this.ekleButton.Size = new System.Drawing.Size(150, 82);
            this.ekleButton.TabIndex = 0;
            this.ekleButton.Text = "Ekle";
            this.ekleButton.UseVisualStyleBackColor = true;
            this.ekleButton.Click += new System.EventHandler(this.ekleButton_Click);
            // 
            // alinacaklarListBox
            // 
            this.alinacaklarListBox.FormattingEnabled = true;
            this.alinacaklarListBox.Location = new System.Drawing.Point(304, 55);
            this.alinacaklarListBox.Name = "alinacaklarListBox";
            this.alinacaklarListBox.Size = new System.Drawing.Size(211, 303);
            this.alinacaklarListBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.alinacaklarListBox);
            this.Controls.Add(this.ekleButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ekleButton;
        private System.Windows.Forms.ListBox alinacaklarListBox;
    }
}

