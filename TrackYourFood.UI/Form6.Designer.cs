namespace TrackYourFood.UI
{
    partial class Form6
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
            this.btnEditorGiris = new System.Windows.Forms.Button();
            this.txtEditorPassword = new System.Windows.Forms.TextBox();
            this.txtEditorUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditorGiris
            // 
            this.btnEditorGiris.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditorGiris.Location = new System.Drawing.Point(144, 176);
            this.btnEditorGiris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditorGiris.Name = "btnEditorGiris";
            this.btnEditorGiris.Size = new System.Drawing.Size(180, 44);
            this.btnEditorGiris.TabIndex = 2;
            this.btnEditorGiris.Text = "Sign in!";
            this.btnEditorGiris.UseVisualStyleBackColor = true;
            this.btnEditorGiris.Click += new System.EventHandler(this.btnEditorGiris_Click);
            // 
            // txtEditorPassword
            // 
            this.txtEditorPassword.Location = new System.Drawing.Point(76, 131);
            this.txtEditorPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEditorPassword.Name = "txtEditorPassword";
            this.txtEditorPassword.Size = new System.Drawing.Size(344, 23);
            this.txtEditorPassword.TabIndex = 1;
            // 
            // txtEditorUserName
            // 
            this.txtEditorUserName.Location = new System.Drawing.Point(76, 73);
            this.txtEditorUserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEditorUserName.Name = "txtEditorUserName";
            this.txtEditorUserName.Size = new System.Drawing.Size(344, 23);
            this.txtEditorUserName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(76, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(76, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "User Name:";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 256);
            this.Controls.Add(this.btnEditorGiris);
            this.Controls.Add(this.txtEditorPassword);
            this.Controls.Add(this.txtEditorUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form6";
            this.Text = "Editor SignIn Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEditorGiris;
        private TextBox txtEditorPassword;
        private TextBox txtEditorUserName;
        private Label label3;
        private Label label2;
    }
}