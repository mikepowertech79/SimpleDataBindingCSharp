namespace SimpleDataBindingCSharp
{
    partial class frmGenericBinding
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
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnLoadEmployees = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(3, 1);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(643, 200);
            this.dgvEmployees.TabIndex = 0;
            // 
            // btnLoadEmployees
            // 
            this.btnLoadEmployees.Location = new System.Drawing.Point(3, 208);
            this.btnLoadEmployees.Name = "btnLoadEmployees";
            this.btnLoadEmployees.Size = new System.Drawing.Size(111, 23);
            this.btnLoadEmployees.TabIndex = 1;
            this.btnLoadEmployees.Text = "Load Employees";
            this.btnLoadEmployees.UseVisualStyleBackColor = true;
            this.btnLoadEmployees.Click += new System.EventHandler(this.btnLoadEmployees_Click);
            // 
            // frmGenericBinding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 246);
            this.Controls.Add(this.btnLoadEmployees);
            this.Controls.Add(this.dgvEmployees);
            this.Name = "frmGenericBinding";
            this.Text = "Generic BindingList Example";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnLoadEmployees;
    }
}

