namespace CegalaStudio
{
    partial class SelectConduite
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
            this.loadConduite = new System.Windows.Forms.Button();
            this.conduitePath = new System.Windows.Forms.TextBox();
            this.conduitePathLabel = new System.Windows.Forms.Label();
            this.loadConduitesButton = new System.Windows.Forms.Button();
            this.listConduitesLabel = new System.Windows.Forms.Label();
            this.conduitesList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // loadConduite
            // 
            this.loadConduite.Location = new System.Drawing.Point(453, 48);
            this.loadConduite.Name = "loadConduite";
            this.loadConduite.Size = new System.Drawing.Size(75, 21);
            this.loadConduite.TabIndex = 0;
            this.loadConduite.Text = "Ouvrir";
            this.loadConduite.UseVisualStyleBackColor = true;
            this.loadConduite.Click += new System.EventHandler(this.loadConduite_Click);
            // 
            // conduitePath
            // 
            this.conduitePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conduitePath.Location = new System.Drawing.Point(157, 6);
            this.conduitePath.Name = "conduitePath";
            this.conduitePath.Size = new System.Drawing.Size(290, 20);
            this.conduitePath.TabIndex = 1;
            this.conduitePath.Text = "C:\\CeGaLa\\conduites";
            this.conduitePath.TextChanged += new System.EventHandler(this.conduitePath_TextChanged);
            // 
            // conduitePathLabel
            // 
            this.conduitePathLabel.AutoSize = true;
            this.conduitePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conduitePathLabel.Location = new System.Drawing.Point(12, 9);
            this.conduitePathLabel.Name = "conduitePathLabel";
            this.conduitePathLabel.Size = new System.Drawing.Size(139, 13);
            this.conduitePathLabel.TabIndex = 2;
            this.conduitePathLabel.Text = "Chemin des conduites :";
            // 
            // loadConduitesButton
            // 
            this.loadConduitesButton.Location = new System.Drawing.Point(453, 4);
            this.loadConduitesButton.Name = "loadConduitesButton";
            this.loadConduitesButton.Size = new System.Drawing.Size(75, 23);
            this.loadConduitesButton.TabIndex = 3;
            this.loadConduitesButton.Text = "Charger";
            this.loadConduitesButton.UseVisualStyleBackColor = true;
            this.loadConduitesButton.Click += new System.EventHandler(this.loadConduitesButton_Click);
            // 
            // listConduitesLabel
            // 
            this.listConduitesLabel.AutoSize = true;
            this.listConduitesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listConduitesLabel.Location = new System.Drawing.Point(12, 51);
            this.listConduitesLabel.Name = "listConduitesLabel";
            this.listConduitesLabel.Size = new System.Drawing.Size(125, 13);
            this.listConduitesLabel.TabIndex = 4;
            this.listConduitesLabel.Text = "Liste des conduites :";
            this.listConduitesLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // conduitesList
            // 
            this.conduitesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conduitesList.FormattingEnabled = true;
            this.conduitesList.Location = new System.Drawing.Point(157, 48);
            this.conduitesList.Name = "conduitesList";
            this.conduitesList.Size = new System.Drawing.Size(290, 21);
            this.conduitesList.TabIndex = 6;
            // 
            // SelectConduite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.conduitesList);
            this.Controls.Add(this.listConduitesLabel);
            this.Controls.Add(this.loadConduitesButton);
            this.Controls.Add(this.conduitePathLabel);
            this.Controls.Add(this.conduitePath);
            this.Controls.Add(this.loadConduite);
            this.Name = "SelectConduite";
            this.Text = "Sélection de conduite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadConduite;
        private System.Windows.Forms.TextBox conduitePath;
        private System.Windows.Forms.Label conduitePathLabel;
        private System.Windows.Forms.Button loadConduitesButton;
        private System.Windows.Forms.Label listConduitesLabel;
        private System.Windows.Forms.ComboBox conduitesList;
    }
}