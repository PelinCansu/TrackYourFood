namespace TrackYourFood.UI
{
    partial class Form9
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dgvEditorMeal = new System.Windows.Forms.DataGridView();
            this.txtMealType = new System.Windows.Forms.TextBox();
            this.txtMealID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditorMeal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuncelle.Location = new System.Drawing.Point(25, 684);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(208, 58);
            this.btnGuncelle.TabIndex = 99;
            this.btnGuncelle.Text = "UPDATE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListele.Location = new System.Drawing.Point(262, 684);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(208, 58);
            this.btnListele.TabIndex = 98;
            this.btnListele.Text = "GET ALL";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSil.Location = new System.Drawing.Point(262, 574);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(208, 58);
            this.btnSil.TabIndex = 97;
            this.btnSil.Text = "DELETE";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.Location = new System.Drawing.Point(25, 574);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(208, 58);
            this.btnEkle.TabIndex = 96;
            this.btnEkle.Text = "ADD";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dgvEditorMeal
            // 
            this.dgvEditorMeal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditorMeal.Location = new System.Drawing.Point(25, 246);
            this.dgvEditorMeal.Name = "dgvEditorMeal";
            this.dgvEditorMeal.RowHeadersWidth = 62;
            this.dgvEditorMeal.RowTemplate.Height = 33;
            this.dgvEditorMeal.Size = new System.Drawing.Size(445, 288);
            this.dgvEditorMeal.TabIndex = 95;
            // 
            // txtMealType
            // 
            this.txtMealType.Location = new System.Drawing.Point(198, 160);
            this.txtMealType.Name = "txtMealType";
            this.txtMealType.Size = new System.Drawing.Size(272, 31);
            this.txtMealType.TabIndex = 93;
            // 
            // txtMealID
            // 
            this.txtMealID.Location = new System.Drawing.Point(198, 51);
            this.txtMealID.Name = "txtMealID";
            this.txtMealID.Size = new System.Drawing.Size(272, 31);
            this.txtMealID.TabIndex = 94;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(53, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 32);
            this.label11.TabIndex = 92;
            this.label11.Text = "Meal ID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(25, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 32);
            this.label12.TabIndex = 91;
            this.label12.Text = "Meal Type:";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 800);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgvEditorMeal);
            this.Controls.Add(this.txtMealType);
            this.Controls.Add(this.txtMealID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.MaximizeBox = false;
            this.Name = "Form9";
            this.Text = "Meals";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditorMeal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGuncelle;
        private Button btnListele;
        private Button btnSil;
        private Button btnEkle;
        private DataGridView dgvEditorMeal;
        private TextBox txtMealType;
        private TextBox txtMealID;
        private Label label11;
        private Label label12;
    }
}