namespace Student_Management
{
    partial class CreateClassForm
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
            this.lblClassName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCannel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(12, 61);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(60, 13);
            this.lblClassName.TabIndex = 0;
            this.lblClassName.Text = "ClassName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(99, 58);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(100, 20);
            this.txtClassName.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(99, 115);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(27, 160);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCannel
            // 
            this.btnCannel.Location = new System.Drawing.Point(144, 160);
            this.btnCannel.Name = "btnCannel";
            this.btnCannel.Size = new System.Drawing.Size(75, 23);
            this.btnCannel.TabIndex = 5;
            this.btnCannel.Text = "Cannel";
            this.btnCannel.UseVisualStyleBackColor = true;
            // 
            // CreateClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCannel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblClassName);
            this.Name = "CreateClassForm";
            this.Text = "CreateClassForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCannel;
    }
}