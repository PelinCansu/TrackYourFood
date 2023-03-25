namespace TrackYourFood.UI
{
    partial class Form11
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
            this.dgvEditor = new System.Windows.Forms.DataGridView();
            this.txtKcalValue = new System.Windows.Forms.TextBox();
            this.txtCarboValue = new System.Windows.Forms.TextBox();
            this.txtFatValue = new System.Windows.Forms.TextBox();
            this.txtProteinValue = new System.Windows.Forms.TextBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCatId = new System.Windows.Forms.ComboBox();
            this.cmbUnitId = new System.Windows.Forms.ComboBox();
            this.cmbMealId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPicture = new System.Windows.Forms.TextBox();
            this.btnResimEkle = new System.Windows.Forms.Button();
            this.pbFood = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFoodID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFood)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuncelle.Location = new System.Drawing.Point(639, 871);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(208, 58);
            this.btnGuncelle.TabIndex = 90;
            this.btnGuncelle.Text = "UPDATE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListele.Location = new System.Drawing.Point(930, 871);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(208, 58);
            this.btnListele.TabIndex = 89;
            this.btnListele.Text = "GET ALL";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSil.Location = new System.Drawing.Point(348, 871);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(208, 58);
            this.btnSil.TabIndex = 88;
            this.btnSil.Text = "DELETE";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.Location = new System.Drawing.Point(57, 871);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(208, 58);
            this.btnEkle.TabIndex = 87;
            this.btnEkle.Text = "ADD";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dgvEditor
            // 
            this.dgvEditor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditor.Location = new System.Drawing.Point(57, 577);
            this.dgvEditor.Name = "dgvEditor";
            this.dgvEditor.RowHeadersWidth = 62;
            this.dgvEditor.RowTemplate.Height = 33;
            this.dgvEditor.Size = new System.Drawing.Size(1081, 288);
            this.dgvEditor.TabIndex = 86;
            // 
            // txtKcalValue
            // 
            this.txtKcalValue.Location = new System.Drawing.Point(755, 335);
            this.txtKcalValue.Name = "txtKcalValue";
            this.txtKcalValue.Size = new System.Drawing.Size(365, 31);
            this.txtKcalValue.TabIndex = 84;
            // 
            // txtCarboValue
            // 
            this.txtCarboValue.Location = new System.Drawing.Point(755, 261);
            this.txtCarboValue.Name = "txtCarboValue";
            this.txtCarboValue.Size = new System.Drawing.Size(365, 31);
            this.txtCarboValue.TabIndex = 83;
            // 
            // txtFatValue
            // 
            this.txtFatValue.Location = new System.Drawing.Point(755, 187);
            this.txtFatValue.Name = "txtFatValue";
            this.txtFatValue.Size = new System.Drawing.Size(365, 31);
            this.txtFatValue.TabIndex = 82;
            // 
            // txtProteinValue
            // 
            this.txtProteinValue.Location = new System.Drawing.Point(755, 113);
            this.txtProteinValue.Name = "txtProteinValue";
            this.txtProteinValue.Size = new System.Drawing.Size(365, 31);
            this.txtProteinValue.TabIndex = 81;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(755, 39);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(365, 31);
            this.txtFoodName.TabIndex = 77;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(680, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 32);
            this.label10.TabIndex = 72;
            this.label10.Text = "Kcal:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(591, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 32);
            this.label6.TabIndex = 71;
            this.label6.Text = "Carbo Value:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(626, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 32);
            this.label5.TabIndex = 70;
            this.label5.Text = "Fat Value:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(575, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 32);
            this.label4.TabIndex = 69;
            this.label4.Text = "Protein Value:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(58, 375);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 32);
            this.label11.TabIndex = 68;
            this.label11.Text = "Meal ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(66, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 32);
            this.label9.TabIndex = 67;
            this.label9.Text = "Unit ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(10, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 32);
            this.label8.TabIndex = 66;
            this.label8.Text = "Category ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(57, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 32);
            this.label7.TabIndex = 63;
            this.label7.Text = "Food ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(597, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 62;
            this.label1.Text = "Food Name:";
            // 
            // cmbCatId
            // 
            this.cmbCatId.FormattingEnabled = true;
            this.cmbCatId.Location = new System.Drawing.Point(187, 184);
            this.cmbCatId.Name = "cmbCatId";
            this.cmbCatId.Size = new System.Drawing.Size(307, 33);
            this.cmbCatId.TabIndex = 91;
            // 
            // cmbUnitId
            // 
            this.cmbUnitId.FormattingEnabled = true;
            this.cmbUnitId.Location = new System.Drawing.Point(187, 280);
            this.cmbUnitId.Name = "cmbUnitId";
            this.cmbUnitId.Size = new System.Drawing.Size(307, 33);
            this.cmbUnitId.TabIndex = 91;
            // 
            // cmbMealId
            // 
            this.cmbMealId.FormattingEnabled = true;
            this.cmbMealId.Location = new System.Drawing.Point(187, 376);
            this.cmbMealId.Name = "cmbMealId";
            this.cmbMealId.Size = new System.Drawing.Size(307, 33);
            this.cmbMealId.TabIndex = 91;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(55, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 32);
            this.label2.TabIndex = 72;
            this.label2.Text = "Picture:";
            // 
            // txtPicture
            // 
            this.txtPicture.Location = new System.Drawing.Point(183, 443);
            this.txtPicture.Name = "txtPicture";
            this.txtPicture.Size = new System.Drawing.Size(311, 31);
            this.txtPicture.TabIndex = 84;
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResimEkle.Location = new System.Drawing.Point(500, 443);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(56, 42);
            this.btnResimEkle.TabIndex = 92;
            this.btnResimEkle.Text = "...";
            this.btnResimEkle.UseVisualStyleBackColor = true;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // pbFood
            // 
            this.pbFood.Location = new System.Drawing.Point(606, 392);
            this.pbFood.Name = "pbFood";
            this.pbFood.Size = new System.Drawing.Size(208, 165);
            this.pbFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFood.TabIndex = 93;
            this.pbFood.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(57, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 32);
            this.label3.TabIndex = 72;
            this.label3.Text = "Choose Food ID for update...";
            // 
            // cmbFoodID
            // 
            this.cmbFoodID.FormattingEnabled = true;
            this.cmbFoodID.Location = new System.Drawing.Point(187, 90);
            this.cmbFoodID.Name = "cmbFoodID";
            this.cmbFoodID.Size = new System.Drawing.Size(307, 33);
            this.cmbFoodID.TabIndex = 91;
            this.cmbFoodID.SelectedIndexChanged += new System.EventHandler(this.cmbFoodID_SelectedIndexChanged);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 945);
            this.Controls.Add(this.pbFood);
            this.Controls.Add(this.btnResimEkle);
            this.Controls.Add(this.cmbMealId);
            this.Controls.Add(this.cmbUnitId);
            this.Controls.Add(this.cmbFoodID);
            this.Controls.Add(this.cmbCatId);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgvEditor);
            this.Controls.Add(this.txtPicture);
            this.Controls.Add(this.txtKcalValue);
            this.Controls.Add(this.txtCarboValue);
            this.Controls.Add(this.txtFatValue);
            this.Controls.Add(this.txtProteinValue);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "Form11";
            this.Text = "Foods";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGuncelle;
        private Button btnListele;
        private Button btnSil;
        private Button btnEkle;
        private DataGridView dgvEditor;
        private TextBox txtKcalValue;
        private TextBox txtCarboValue;
        private TextBox txtFatValue;
        private TextBox txtProteinValue;
        private TextBox txtFoodName;
        private Label label10;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label11;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label1;
        private ComboBox cmbCatId;
        private ComboBox cmbUnitId;
        private ComboBox cmbMealId;
        private Label label2;
        private TextBox txtPicture;
        private Button btnResimEkle;
        private PictureBox pbFood;
        private OpenFileDialog openFileDialog1;
        private Label label3;
        private ComboBox cmbFoodID;
    }
}