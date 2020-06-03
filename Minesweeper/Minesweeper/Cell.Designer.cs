namespace Minesweeper
{
    partial class Cell
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cell));
            this.label = new System.Windows.Forms.Label();
            this.marker = new System.Windows.Forms.PictureBox();
            this.mine = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.marker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mine)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label.Enabled = false;
            this.label.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(0, 0);
            this.label.Margin = new System.Windows.Forms.Padding(0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(29, 29);
            this.label.TabIndex = 0;
            this.label.Text = "n";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // marker
            // 
            this.marker.Enabled = false;
            this.marker.Image = ((System.Drawing.Image)(resources.GetObject("marker.Image")));
            this.marker.Location = new System.Drawing.Point(0, 0);
            this.marker.Name = "marker";
            this.marker.Size = new System.Drawing.Size(29, 29);
            this.marker.TabIndex = 1;
            this.marker.TabStop = false;
            // 
            // mine
            // 
            this.mine.Enabled = false;
            this.mine.Image = ((System.Drawing.Image)(resources.GetObject("mine.Image")));
            this.mine.Location = new System.Drawing.Point(0, 0);
            this.mine.Name = "mine";
            this.mine.Size = new System.Drawing.Size(29, 29);
            this.mine.TabIndex = 2;
            this.mine.TabStop = false;
            // 
            // Cell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.mine);
            this.Controls.Add(this.marker);
            this.Controls.Add(this.label);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Cell";
            this.Size = new System.Drawing.Size(29, 29);
            this.Load += new System.EventHandler(this.Cell_Load);
            this.Click += new System.EventHandler(this.Cell_Click);
            ((System.ComponentModel.ISupportInitialize)(this.marker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox marker;
        private System.Windows.Forms.PictureBox mine;
    }
}
