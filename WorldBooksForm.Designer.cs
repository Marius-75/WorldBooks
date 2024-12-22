namespace WorldBooks
{
    partial class worldBooksForm
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
            this.authorsButton = new System.Windows.Forms.Button();
            this.countriesButton = new System.Windows.Forms.Button();
            this.languagesButton = new System.Windows.Forms.Button();
            this.editorsButton = new System.Windows.Forms.Button();
            this.worksButton = new System.Windows.Forms.Button();
            this.publicationsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authorsButton
            // 
            this.authorsButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorsButton.Location = new System.Drawing.Point(430, 32);
            this.authorsButton.Name = "authorsButton";
            this.authorsButton.Size = new System.Drawing.Size(100, 36);
            this.authorsButton.TabIndex = 0;
            this.authorsButton.Text = "Authors";
            this.authorsButton.UseVisualStyleBackColor = true;
            this.authorsButton.Click += new System.EventHandler(this.authorButton_Click);
            // 
            // countriesButton
            // 
            this.countriesButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countriesButton.Location = new System.Drawing.Point(18, 32);
            this.countriesButton.Name = "countriesButton";
            this.countriesButton.Size = new System.Drawing.Size(130, 36);
            this.countriesButton.TabIndex = 1;
            this.countriesButton.Text = "Countries";
            this.countriesButton.UseVisualStyleBackColor = true;
            // 
            // languagesButton
            // 
            this.languagesButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languagesButton.Location = new System.Drawing.Point(154, 32);
            this.languagesButton.Name = "languagesButton";
            this.languagesButton.Size = new System.Drawing.Size(133, 36);
            this.languagesButton.TabIndex = 2;
            this.languagesButton.Text = "Languages";
            this.languagesButton.UseVisualStyleBackColor = true;
            // 
            // editorsButton
            // 
            this.editorsButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editorsButton.Location = new System.Drawing.Point(293, 32);
            this.editorsButton.Name = "editorsButton";
            this.editorsButton.Size = new System.Drawing.Size(131, 36);
            this.editorsButton.TabIndex = 3;
            this.editorsButton.Text = "Editors";
            this.editorsButton.UseVisualStyleBackColor = true;
            // 
            // worksButton
            // 
            this.worksButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worksButton.Location = new System.Drawing.Point(551, 32);
            this.worksButton.Name = "worksButton";
            this.worksButton.Size = new System.Drawing.Size(113, 36);
            this.worksButton.TabIndex = 4;
            this.worksButton.Text = "Works";
            this.worksButton.UseVisualStyleBackColor = true;
            this.worksButton.Click += new System.EventHandler(this.worksButton_Click);
            // 
            // publicationsButton
            // 
            this.publicationsButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicationsButton.Location = new System.Drawing.Point(686, 32);
            this.publicationsButton.Name = "publicationsButton";
            this.publicationsButton.Size = new System.Drawing.Size(141, 36);
            this.publicationsButton.TabIndex = 5;
            this.publicationsButton.Text = "Publications";
            this.publicationsButton.UseVisualStyleBackColor = true;
            // 
            // worldBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 429);
            this.Controls.Add(this.publicationsButton);
            this.Controls.Add(this.worksButton);
            this.Controls.Add(this.editorsButton);
            this.Controls.Add(this.languagesButton);
            this.Controls.Add(this.countriesButton);
            this.Controls.Add(this.authorsButton);
            this.Name = "worldBooksForm";
            this.Text = "World Books";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button authorsButton;
        private System.Windows.Forms.Button countriesButton;
        private System.Windows.Forms.Button languagesButton;
        private System.Windows.Forms.Button editorsButton;
        private System.Windows.Forms.Button worksButton;
        private System.Windows.Forms.Button publicationsButton;
    }
}

