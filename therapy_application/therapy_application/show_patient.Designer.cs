namespace therapy_application
{
    partial class show_patient
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
            this.button_edit = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_choice
            // 
            this.button_choice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_choice.Location = new System.Drawing.Point(92, 341);
            this.button_choice.Name = "button_choice";
            this.button_choice.Size = new System.Drawing.Size(565, 38);
            this.button_choice.TabIndex = 0;
            this.button_choice.Text = "WYBIERZ";
            this.button_choice.UseVisualStyleBackColor = false;
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_edit.Location = new System.Drawing.Point(385, 385);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(272, 29);
            this.button_edit.TabIndex = 1;
            this.button_edit.Text = "EDYTUJ";
            this.button_edit.UseVisualStyleBackColor = false;
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(92, 420);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(565, 30);
            this.button_exit.TabIndex = 2;
            this.button_exit.Text = "Anuluj";
            this.button_exit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(92, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "DODAJ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // show_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_choice);
            this.Name = "show_patient";
            this.Text = "show_patient";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_choice;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button1;
    }
}