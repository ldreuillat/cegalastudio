namespace CegalaStudio
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.recordDataGridView = new System.Windows.Forms.DataGridView();
            this.nextButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.triggerTextBox = new System.Windows.Forms.RichTextBox();
            this.ArtisteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SketchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusiqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DureeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.recordDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // recordDataGridView
            // 
            this.recordDataGridView.AutoGenerateColumns = false;
            this.recordDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.recordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArtisteDataGridViewTextBoxColumn,
            this.SketchDataGridViewTextBoxColumn,
            this.MusiqueDataGridViewTextBoxColumn,
            this.DureeDataGridViewTextBoxColumn});
            this.recordDataGridView.DataSource = this.recordBindingSource;
            this.recordDataGridView.Location = new System.Drawing.Point(12, 12);
            this.recordDataGridView.Name = "recordDataGridView";
            this.recordDataGridView.Size = new System.Drawing.Size(535, 318);
            this.recordDataGridView.TabIndex = 1;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(364, 336);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(183, 66);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 336);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(170, 66);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(188, 336);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(170, 66);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // triggerTextBox
            // 
            this.triggerTextBox.Location = new System.Drawing.Point(588, 31);
            this.triggerTextBox.Name = "triggerTextBox";
            this.triggerTextBox.Size = new System.Drawing.Size(341, 298);
            this.triggerTextBox.TabIndex = 5;
            this.triggerTextBox.Text = "";
            // 
            // ArtisteDataGridViewTextBoxColumn
            // 
            this.ArtisteDataGridViewTextBoxColumn.DataPropertyName = "Artiste";
            this.ArtisteDataGridViewTextBoxColumn.HeaderText = "Artiste";
            this.ArtisteDataGridViewTextBoxColumn.Name = "ArtisteDataGridViewTextBoxColumn";
            this.ArtisteDataGridViewTextBoxColumn.Width = 61;
            // 
            // SketchDataGridViewTextBoxColumn
            // 
            this.SketchDataGridViewTextBoxColumn.DataPropertyName = "Sketch";
            this.SketchDataGridViewTextBoxColumn.HeaderText = "Sketch";
            this.SketchDataGridViewTextBoxColumn.Name = "SketchDataGridViewTextBoxColumn";
            this.SketchDataGridViewTextBoxColumn.Width = 66;
            // 
            // MusiqueDataGridViewTextBoxColumn
            // 
            this.MusiqueDataGridViewTextBoxColumn.DataPropertyName = "Musique";
            this.MusiqueDataGridViewTextBoxColumn.HeaderText = "Musique";
            this.MusiqueDataGridViewTextBoxColumn.Name = "MusiqueDataGridViewTextBoxColumn";
            this.MusiqueDataGridViewTextBoxColumn.Width = 72;
            // 
            // DureeDataGridViewTextBoxColumn
            // 
            this.DureeDataGridViewTextBoxColumn.DataPropertyName = "Duree";
            this.DureeDataGridViewTextBoxColumn.HeaderText = "Duree";
            this.DureeDataGridViewTextBoxColumn.Name = "DureeDataGridViewTextBoxColumn";
            this.DureeDataGridViewTextBoxColumn.Width = 61;
            // 
            // recordBindingSource
            // 
            this.recordBindingSource.DataSource = typeof(CegalaStudio.Model.Record);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 450);
            this.Controls.Add(this.triggerTextBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.recordDataGridView);
            this.Name = "Form1";
            this.Text = "Studio";
            ((System.ComponentModel.ISupportInitialize)(this.recordDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView recordDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtisteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SketchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusiqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DureeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource recordBindingSource;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.RichTextBox triggerTextBox;
    }
}

