namespace TrackYourFood.UI
{
    partial class Form7
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
            this.btnMeals = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnUnits = new System.Windows.Forms.Button();
            this.btnFoods = new System.Windows.Forms.Button();
            this.btnUserStatistics = new System.Windows.Forms.Button();
            this.txtEditorWelcome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMeals
            // 
            this.btnMeals.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMeals.Location = new System.Drawing.Point(414, 77);
            this.btnMeals.Margin = new System.Windows.Forms.Padding(2);
            this.btnMeals.Name = "btnMeals";
            this.btnMeals.Size = new System.Drawing.Size(300, 121);
            this.btnMeals.TabIndex = 1;
            this.btnMeals.Text = "Meals";
            this.btnMeals.UseVisualStyleBackColor = true;
            this.btnMeals.Click += new System.EventHandler(this.btnMeals_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCategory.Location = new System.Drawing.Point(109, 77);
            this.btnCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(300, 121);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.Text = "Categories";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnUnits
            // 
            this.btnUnits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUnits.Location = new System.Drawing.Point(109, 199);
            this.btnUnits.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnits.Name = "btnUnits";
            this.btnUnits.Size = new System.Drawing.Size(300, 121);
            this.btnUnits.TabIndex = 2;
            this.btnUnits.Text = "Units";
            this.btnUnits.UseVisualStyleBackColor = true;
            this.btnUnits.Click += new System.EventHandler(this.btnUnits_Click);
            // 
            // btnFoods
            // 
            this.btnFoods.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFoods.Location = new System.Drawing.Point(414, 199);
            this.btnFoods.Margin = new System.Windows.Forms.Padding(2);
            this.btnFoods.Name = "btnFoods";
            this.btnFoods.Size = new System.Drawing.Size(300, 121);
            this.btnFoods.TabIndex = 3;
            this.btnFoods.Text = "Foods";
            this.btnFoods.UseVisualStyleBackColor = true;
            this.btnFoods.Click += new System.EventHandler(this.btnFoods_Click);
            // 
            // btnUserStatistics
            // 
            this.btnUserStatistics.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUserStatistics.Location = new System.Drawing.Point(109, 329);
            this.btnUserStatistics.Name = "btnUserStatistics";
            this.btnUserStatistics.Size = new System.Drawing.Size(605, 96);
            this.btnUserStatistics.TabIndex = 4;
            this.btnUserStatistics.Text = "User Statistics";
            this.btnUserStatistics.UseVisualStyleBackColor = true;
            this.btnUserStatistics.Click += new System.EventHandler(this.btnUserStatistics_Click);
            // 
            // txtEditorWelcome
            // 
            this.txtEditorWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEditorWelcome.ForeColor = System.Drawing.Color.IndianRed;
            this.txtEditorWelcome.Location = new System.Drawing.Point(224, 43);
            this.txtEditorWelcome.Name = "txtEditorWelcome";
            this.txtEditorWelcome.ReadOnly = true;
            this.txtEditorWelcome.Size = new System.Drawing.Size(407, 29);
            this.txtEditorWelcome.TabIndex = 5;
            this.txtEditorWelcome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 437);
            this.Controls.Add(this.txtEditorWelcome);
            this.Controls.Add(this.btnUserStatistics);
            this.Controls.Add(this.btnMeals);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnUnits);
            this.Controls.Add(this.btnFoods);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnMeals;
        private Button btnCategory;
        private Button btnUnits;
        private Button btnFoods;
        private Button btnUserStatistics;
        private TextBox txtEditorWelcome;
    }
}