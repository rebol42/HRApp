namespace HumanResourcesApp
{
    partial class frmHR
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
            this.dgfHR = new System.Windows.Forms.DataGridView();
            this.cbSelectEmpl = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgfHR)).BeginInit();
            this.SuspendLayout();
            // 
            // dgfHR
            // 
            this.dgfHR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgfHR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgfHR.BackgroundColor = System.Drawing.Color.White;
            this.dgfHR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgfHR.Location = new System.Drawing.Point(9, 51);
            this.dgfHR.Margin = new System.Windows.Forms.Padding(2);
            this.dgfHR.Name = "dgfHR";
            this.dgfHR.RowHeadersVisible = false;
            this.dgfHR.RowTemplate.Height = 24;
            this.dgfHR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgfHR.Size = new System.Drawing.Size(827, 306);
            this.dgfHR.TabIndex = 5;
            // 
            // cbSelectEmpl
            // 
            this.cbSelectEmpl.FormattingEnabled = true;
            this.cbSelectEmpl.Location = new System.Drawing.Point(251, 11);
            this.cbSelectEmpl.Name = "cbSelectEmpl";
            this.cbSelectEmpl.Size = new System.Drawing.Size(121, 21);
            this.cbSelectEmpl.TabIndex = 10;
            this.cbSelectEmpl.SelectedIndexChanged += new System.EventHandler(this.cbSelectEmpl_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Orange;
            this.btnEdit.Location = new System.Drawing.Point(69, 7);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(56, 25);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LawnGreen;
            this.btnAdd.Location = new System.Drawing.Point(9, 9);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Dodaj ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Wybierz grupę:";
            // 
            // frmHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSelectEmpl);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgfHR);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHR";
            this.Text = "Program Kadrowy";
            ((System.ComponentModel.ISupportInitialize)(this.dgfHR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgfHR;
        private System.Windows.Forms.ComboBox cbSelectEmpl;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
    }
}

