namespace TrackYourFood.UI
{
    partial class Form5
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.dgvMonthlyReport = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtMonthlyTotalCarbo = new System.Windows.Forms.TextBox();
            this.txtMonthlyTotalFat = new System.Windows.Forms.TextBox();
            this.txtMonthlyTotalPro = new System.Windows.Forms.TextBox();
            this.txtMonthlyKcalTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyReport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGeriDon.Location = new System.Drawing.Point(12, 875);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(327, 74);
            this.btnGeriDon.TabIndex = 1;
            this.btnGeriDon.Text = "Get Back!";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // dgvMonthlyReport
            // 
            this.dgvMonthlyReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonthlyReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMonthlyReport.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvMonthlyReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMonthlyReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonthlyReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMonthlyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonthlyReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMonthlyReport.GridColor = System.Drawing.Color.RosyBrown;
            this.dgvMonthlyReport.Location = new System.Drawing.Point(24, 42);
            this.dgvMonthlyReport.Name = "dgvMonthlyReport";
            this.dgvMonthlyReport.RowHeadersWidth = 62;
            this.dgvMonthlyReport.RowTemplate.Height = 33;
            this.dgvMonthlyReport.Size = new System.Drawing.Size(1352, 555);
            this.dgvMonthlyReport.TabIndex = 3;
            this.dgvMonthlyReport.VirtualMode = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(1010, 866);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(327, 74);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit!";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtMonthlyTotalCarbo
            // 
            this.txtMonthlyTotalCarbo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMonthlyTotalCarbo.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtMonthlyTotalCarbo.Location = new System.Drawing.Point(364, 711);
            this.txtMonthlyTotalCarbo.Name = "txtMonthlyTotalCarbo";
            this.txtMonthlyTotalCarbo.Size = new System.Drawing.Size(296, 31);
            this.txtMonthlyTotalCarbo.TabIndex = 21;
            // 
            // txtMonthlyTotalFat
            // 
            this.txtMonthlyTotalFat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMonthlyTotalFat.ForeColor = System.Drawing.Color.Firebrick;
            this.txtMonthlyTotalFat.Location = new System.Drawing.Point(24, 711);
            this.txtMonthlyTotalFat.Name = "txtMonthlyTotalFat";
            this.txtMonthlyTotalFat.Size = new System.Drawing.Size(296, 31);
            this.txtMonthlyTotalFat.TabIndex = 22;
            // 
            // txtMonthlyTotalPro
            // 
            this.txtMonthlyTotalPro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMonthlyTotalPro.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtMonthlyTotalPro.Location = new System.Drawing.Point(705, 711);
            this.txtMonthlyTotalPro.Name = "txtMonthlyTotalPro";
            this.txtMonthlyTotalPro.Size = new System.Drawing.Size(296, 31);
            this.txtMonthlyTotalPro.TabIndex = 23;
            // 
            // txtMonthlyKcalTotal
            // 
            this.txtMonthlyKcalTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMonthlyKcalTotal.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtMonthlyKcalTotal.Location = new System.Drawing.Point(1041, 711);
            this.txtMonthlyKcalTotal.Name = "txtMonthlyKcalTotal";
            this.txtMonthlyKcalTotal.Size = new System.Drawing.Size(296, 31);
            this.txtMonthlyKcalTotal.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(364, 649);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 44);
            this.label5.TabIndex = 17;
            this.label5.Text = "Monthly Total Carbo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(24, 649);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 44);
            this.label4.TabIndex = 18;
            this.label4.Text = "Monthly Total Fat:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(705, 644);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 44);
            this.label3.TabIndex = 19;
            this.label3.Text = "Monthly Total Protein:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1041, 644);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 44);
            this.label6.TabIndex = 20;
            this.label6.Text = "Monthly Total Kcal:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 961);
            this.Controls.Add(this.txtMonthlyTotalCarbo);
            this.Controls.Add(this.txtMonthlyTotalFat);
            this.Controls.Add(this.txtMonthlyTotalPro);
            this.Controls.Add(this.txtMonthlyKcalTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvMonthlyReport);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGeriDon);
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.Text = "Monthly Report!";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnGeriDon;
        private DataGridView dgvMonthlyReport;
        private Button btnExit;
        private TextBox txtMonthlyTotalCarbo;
        private TextBox txtMonthlyTotalFat;
        private TextBox txtMonthlyTotalPro;
        private TextBox txtMonthlyKcalTotal;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
    }
}