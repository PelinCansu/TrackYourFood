namespace TrackYourFood.UI
{
    partial class Form4
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
            this.btnAylikRapor2 = new System.Windows.Forms.Button();
            this.dgvWeeklyReport = new System.Windows.Forms.DataGridView();
            this.txtWeeklyTotalCarbo = new System.Windows.Forms.TextBox();
            this.txtWeeklyTotalFat = new System.Windows.Forms.TextBox();
            this.txtWeeklyTotalPro = new System.Windows.Forms.TextBox();
            this.txtWeeklyKcalTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeeklyReport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGeriDon.Location = new System.Drawing.Point(30, 808);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(338, 60);
            this.btnGeriDon.TabIndex = 1;
            this.btnGeriDon.Text = "Get Back!";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnAylikRapor2
            // 
            this.btnAylikRapor2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAylikRapor2.Location = new System.Drawing.Point(30, 888);
            this.btnAylikRapor2.Name = "btnAylikRapor2";
            this.btnAylikRapor2.Size = new System.Drawing.Size(338, 60);
            this.btnAylikRapor2.TabIndex = 1;
            this.btnAylikRapor2.Text = "Go to Monthly Report!";
            this.btnAylikRapor2.UseVisualStyleBackColor = true;
            this.btnAylikRapor2.Click += new System.EventHandler(this.btnAylikRapor2_Click);
            // 
            // dgvWeeklyReport
            // 
            this.dgvWeeklyReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWeeklyReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWeeklyReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvWeeklyReport.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvWeeklyReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvWeeklyReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWeeklyReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWeeklyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWeeklyReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWeeklyReport.GridColor = System.Drawing.Color.RosyBrown;
            this.dgvWeeklyReport.Location = new System.Drawing.Point(30, 24);
            this.dgvWeeklyReport.Name = "dgvWeeklyReport";
            this.dgvWeeklyReport.RowHeadersWidth = 62;
            this.dgvWeeklyReport.RowTemplate.Height = 33;
            this.dgvWeeklyReport.Size = new System.Drawing.Size(1532, 604);
            this.dgvWeeklyReport.TabIndex = 2;
            this.dgvWeeklyReport.VirtualMode = true;
            // 
            // txtWeeklyTotalCarbo
            // 
            this.txtWeeklyTotalCarbo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtWeeklyTotalCarbo.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtWeeklyTotalCarbo.Location = new System.Drawing.Point(370, 714);
            this.txtWeeklyTotalCarbo.Name = "txtWeeklyTotalCarbo";
            this.txtWeeklyTotalCarbo.Size = new System.Drawing.Size(296, 31);
            this.txtWeeklyTotalCarbo.TabIndex = 13;
            // 
            // txtWeeklyTotalFat
            // 
            this.txtWeeklyTotalFat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtWeeklyTotalFat.ForeColor = System.Drawing.Color.Firebrick;
            this.txtWeeklyTotalFat.Location = new System.Drawing.Point(30, 714);
            this.txtWeeklyTotalFat.Name = "txtWeeklyTotalFat";
            this.txtWeeklyTotalFat.Size = new System.Drawing.Size(296, 31);
            this.txtWeeklyTotalFat.TabIndex = 14;
            // 
            // txtWeeklyTotalPro
            // 
            this.txtWeeklyTotalPro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtWeeklyTotalPro.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtWeeklyTotalPro.Location = new System.Drawing.Point(711, 714);
            this.txtWeeklyTotalPro.Name = "txtWeeklyTotalPro";
            this.txtWeeklyTotalPro.Size = new System.Drawing.Size(296, 31);
            this.txtWeeklyTotalPro.TabIndex = 15;
            // 
            // txtWeeklyKcalTotal
            // 
            this.txtWeeklyKcalTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtWeeklyKcalTotal.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtWeeklyKcalTotal.Location = new System.Drawing.Point(1047, 714);
            this.txtWeeklyKcalTotal.Name = "txtWeeklyKcalTotal";
            this.txtWeeklyKcalTotal.Size = new System.Drawing.Size(296, 31);
            this.txtWeeklyKcalTotal.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(370, 652);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 44);
            this.label5.TabIndex = 9;
            this.label5.Text = "Weekly Total Carbo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(30, 652);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 44);
            this.label4.TabIndex = 10;
            this.label4.Text = "Weekly Total Fat:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(711, 647);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 44);
            this.label3.TabIndex = 11;
            this.label3.Text = "Weekly Total Protein:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1047, 647);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 44);
            this.label6.TabIndex = 12;
            this.label6.Text = "Weekly Total Kcal:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1597, 960);
            this.Controls.Add(this.txtWeeklyTotalCarbo);
            this.Controls.Add(this.txtWeeklyTotalFat);
            this.Controls.Add(this.txtWeeklyTotalPro);
            this.Controls.Add(this.txtWeeklyKcalTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvWeeklyReport);
            this.Controls.Add(this.btnAylikRapor2);
            this.Controls.Add(this.btnGeriDon);
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.Text = "Weekly Report!";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeeklyReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnGeriDon;
        private Button btnAylikRapor2;
        private DataGridView dgvWeeklyReport;
        private TextBox txtWeeklyTotalCarbo;
        private TextBox txtWeeklyTotalFat;
        private TextBox txtWeeklyTotalPro;
        private TextBox txtWeeklyKcalTotal;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
    }
}