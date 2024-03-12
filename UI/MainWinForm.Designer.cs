namespace AGRevitCommandSimple.UI
{
    partial class MainWinForm
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
            this.btnSelectElement = new System.Windows.Forms.Button();
            this.tbElementId = new System.Windows.Forms.TextBox();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectElement
            // 
            this.btnSelectElement.Location = new System.Drawing.Point(12, 64);
            this.btnSelectElement.Name = "btnSelectElement";
            this.btnSelectElement.Size = new System.Drawing.Size(120, 35);
            this.btnSelectElement.TabIndex = 0;
            this.btnSelectElement.Text = "SelectElement";
            this.btnSelectElement.UseVisualStyleBackColor = true;
            this.btnSelectElement.Click += new System.EventHandler(this.btnSelectElement_Click);
            // 
            // tbElementId
            // 
            this.tbElementId.Location = new System.Drawing.Point(76, 26);
            this.tbElementId.Name = "tbElementId";
            this.tbElementId.Size = new System.Drawing.Size(135, 20);
            this.tbElementId.TabIndex = 1;
            this.tbElementId.Text = "----------";
            this.tbElementId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(153, 64);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(120, 35);
            this.btClose.TabIndex = 2;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // MainWinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.tbElementId);
            this.Controls.Add(this.btnSelectElement);
            this.Name = "MainWinForm";
            this.Text = "MainWinForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbElementId;
        private Button btnSelectElement;
        private Button btClose;
    }
}