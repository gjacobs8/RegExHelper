namespace RegExHelper
{
    partial class FormRegExHelper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegExHelper));
            this.textBoxRegEx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.checkBoxDistinctValues = new System.Windows.Forms.CheckBox();
            this.checkBoxWordWrap = new System.Windows.Forms.CheckBox();
            this.checkBoxRemoveNewline = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxRegEx
            // 
            this.textBoxRegEx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRegEx.Location = new System.Drawing.Point(57, 6);
            this.textBoxRegEx.Name = "textBoxRegEx";
            this.textBoxRegEx.Size = new System.Drawing.Size(495, 20);
            this.textBoxRegEx.TabIndex = 0;
            this.textBoxRegEx.TextChanged += new System.EventHandler(this.textBoxRegEx_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "RegEx";
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToAddRows = false;
            this.dataGridViewResult.AllowUserToDeleteRows = false;
            this.dataGridViewResult.AllowUserToResizeColumns = false;
            this.dataGridViewResult.AllowUserToResizeRows = false;
            this.dataGridViewResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Location = new System.Drawing.Point(12, 276);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.ReadOnly = true;
            this.dataGridViewResult.Size = new System.Drawing.Size(540, 245);
            this.dataGridViewResult.TabIndex = 6;
            // 
            // textBoxData
            // 
            this.textBoxData.AcceptsReturn = true;
            this.textBoxData.AcceptsTab = true;
            this.textBoxData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxData.Location = new System.Drawing.Point(12, 52);
            this.textBoxData.MaxLength = 99999999;
            this.textBoxData.Multiline = true;
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxData.Size = new System.Drawing.Size(540, 205);
            this.textBoxData.TabIndex = 3;
            this.textBoxData.WordWrap = false;
            this.textBoxData.TextChanged += new System.EventHandler(this.textBoxData_TextChanged);
            this.textBoxData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxData_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data";
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Location = new System.Drawing.Point(12, 260);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(42, 13);
            this.labelResults.TabIndex = 5;
            this.labelResults.Text = "Results";
            // 
            // checkBoxDistinctValues
            // 
            this.checkBoxDistinctValues.AutoSize = true;
            this.checkBoxDistinctValues.Location = new System.Drawing.Point(212, 259);
            this.checkBoxDistinctValues.Name = "checkBoxDistinctValues";
            this.checkBoxDistinctValues.Size = new System.Drawing.Size(130, 17);
            this.checkBoxDistinctValues.TabIndex = 7;
            this.checkBoxDistinctValues.Text = "Return Distinct values";
            this.checkBoxDistinctValues.UseVisualStyleBackColor = true;
            this.checkBoxDistinctValues.CheckedChanged += new System.EventHandler(this.textBoxRegEx_TextChanged);
            // 
            // checkBoxWordWrap
            // 
            this.checkBoxWordWrap.AutoSize = true;
            this.checkBoxWordWrap.Location = new System.Drawing.Point(299, 32);
            this.checkBoxWordWrap.Name = "checkBoxWordWrap";
            this.checkBoxWordWrap.Size = new System.Drawing.Size(111, 17);
            this.checkBoxWordWrap.TabIndex = 8;
            this.checkBoxWordWrap.Text = "EnableWordWrap";
            this.checkBoxWordWrap.UseVisualStyleBackColor = true;
            this.checkBoxWordWrap.CheckedChanged += new System.EventHandler(this.checkBoxWordWrap_CheckedChanged);
            // 
            // checkBoxRemoveNewline
            // 
            this.checkBoxRemoveNewline.AutoSize = true;
            this.checkBoxRemoveNewline.Checked = true;
            this.checkBoxRemoveNewline.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRemoveNewline.Location = new System.Drawing.Point(348, 259);
            this.checkBoxRemoveNewline.Name = "checkBoxRemoveNewline";
            this.checkBoxRemoveNewline.Size = new System.Drawing.Size(108, 17);
            this.checkBoxRemoveNewline.TabIndex = 9;
            this.checkBoxRemoveNewline.Text = "Remove new line";
            this.checkBoxRemoveNewline.UseVisualStyleBackColor = true;
            this.checkBoxRemoveNewline.CheckedChanged += new System.EventHandler(this.checkBoxRemoveNewline_CheckedChanged);
            // 
            // FormRegExHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 533);
            this.Controls.Add(this.checkBoxRemoveNewline);
            this.Controls.Add(this.checkBoxWordWrap);
            this.Controls.Add(this.checkBoxDistinctValues);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.dataGridViewResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRegEx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegExHelper";
            this.Text = "Regular Expression Helper";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRegEx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.CheckBox checkBoxDistinctValues;
        private System.Windows.Forms.CheckBox checkBoxWordWrap;
        private System.Windows.Forms.CheckBox checkBoxRemoveNewline;
    }
}

