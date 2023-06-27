using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegExHelper
{
    public partial class FormRegExHelper : Form
    {
        public FormRegExHelper()
        {
            InitializeComponent();
        }

        // RegEx has changed so update regex output
        private void textBoxRegEx_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxRegEx.Text))
            {
                dataGridViewResult.DataSource = null;
                return;
            }

            try
            {
                MatchCollection Collection = Regex.Matches(textBoxData.Text, textBoxRegEx.Text);

                // Used to store and display data
                DataTable tmpTable = new DataTable();
                tmpTable.Columns.Add("Match");
                // Used to count and display distinct values
                DataView view = new DataView(tmpTable);

                // Copy match data into the table
                foreach (Match match in Collection)
                {
                    string text = match.ToString();
                    if (checkBoxRemoveNewline.Checked)
                        if(!string.IsNullOrEmpty(text.Trim()))
                            text = text.TrimEnd('\r', '\n', ' ', '\t');
                    tmpTable.Rows.Add(text);
                }
                
                // Display count
                labelResults.Text = string.Format("Results = {0} Distinct = {1}", tmpTable.Rows.Count, view.ToTable(true, "Match").Rows.Count);

                if (checkBoxDistinctValues.Checked)
                    dataGridViewResult.DataSource = view.ToTable(true, "Match");
                else
                    dataGridViewResult.DataSource = tmpTable;
            }
            catch (Exception ex)
            {
                labelResults.Text = "Results = Invalid RegEx";

                DataTable tmpTable = new DataTable();
                tmpTable.Columns.Add("Invalid RegEx");
                tmpTable.Rows.Add(ex.Message);

                dataGridViewResult.DataSource = tmpTable;
            }
        }

        // Text to parse has changed so update regex output
        private void textBoxData_TextChanged(object sender, EventArgs e)
        {
            textBoxRegEx_TextChanged(null, null);
        }

        // catch Key press
        void textBoxData_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
                textBoxData.SelectAll();
        }

        /// <summary>
        /// Toggle WordWrap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxWordWrap_CheckedChanged(object sender, EventArgs e)
        {
            textBoxData.WordWrap = checkBoxWordWrap.Checked;
        }

        private void checkBoxRemoveNewline_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}