namespace therapy_application
{
    partial class show_therapy
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
            this.button_choice = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_choice
            // 
            this.button_choice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_choice.Location = new System.Drawing.Point(44, 331);
            this.button_choice.Name = "button_choice";
            this.button_choice.Size = new System.Drawing.Size(565, 38);
            this.button_choice.TabIndex = 4;
            this.button_choice.Text = "WYBIERZ";
            this.button_choice.UseVisualStyleBackColor = false;
            this.button_choice.Click += new System.EventHandler(this.button_choice_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(44, 375);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(565, 30);
            this.button_exit.TabIndex = 5;
            this.button_exit.Text = "Anuluj";
            this.button_exit.UseVisualStyleBackColor = true;
            // 
            // show_therapy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 414);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_choice);
            this.Name = "show_therapy";
            this.Text = "show_therapy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_choice;
        private System.Windows.Forms.Button button_exit;
    }
}