using System.ComponentModel;



namespace Andeart.JsonButlerIde.Dialogs
{
    partial class GenerateTypeWindow
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
            this.labelNamespace = new System.Windows.Forms.Label();
            this.textNamespace = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNamespace
            // 
            this.labelNamespace.AutoSize = true;
            this.labelNamespace.Location = new System.Drawing.Point(24, 24);
            this.labelNamespace.Name = "labelNamespace";
            this.labelNamespace.Size = new System.Drawing.Size(67, 13);
            this.labelNamespace.TabIndex = 0;
            this.labelNamespace.Text = "Namespace:";
            // 
            // textNamespace
            // 
            this.textNamespace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNamespace.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textNamespace.Location = new System.Drawing.Point(96, 21);
            this.textNamespace.Name = "textNamespace";
            this.textNamespace.Size = new System.Drawing.Size(320, 20);
            this.textNamespace.TabIndex = 1;
            this.textNamespace.Text = "JsonButler.Payloads";
            this.textNamespace.GotFocus += new System.EventHandler(this.TextNamespace_GotFocus);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(336, 101);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(80, 24);
            this.buttonGenerate.TabIndex = 4;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(24, 64);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name:";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textName.Location = new System.Drawing.Point(96, 61);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(320, 20);
            this.textName.TabIndex = 3;
            this.textName.Text = "MyPayload";
            this.textName.GotFocus += new System.EventHandler(this.TextName_GotFocus);
            // 
            // GenerateTypeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(464, 141);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textNamespace);
            this.Controls.Add(this.labelNamespace);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenerateTypeWindow";
            this.Text = "JsonButler - Generate Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNamespace;
        private System.Windows.Forms.TextBox textNamespace;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textName;
    }
}