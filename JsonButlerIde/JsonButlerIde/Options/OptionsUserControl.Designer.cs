namespace Andeart.JsonButlerIde.Options
{
    partial class OptionsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBoxSerialization = new System.Windows.Forms.GroupBox();
            this.CheckBoxConfirmationAlerts = new System.Windows.Forms.CheckBox();
            this.LabelShowConfirmation = new System.Windows.Forms.Label();
            this.ComboBoxPropertySerialization = new System.Windows.Forms.ComboBox();
            this.LabelPropertySerializationType = new System.Windows.Forms.Label();
            this.RootTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.GroupBoxSerialization.SuspendLayout();
            this.RootTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxSerialization
            // 
            this.GroupBoxSerialization.Controls.Add(this.CheckBoxConfirmationAlerts);
            this.GroupBoxSerialization.Controls.Add(this.LabelShowConfirmation);
            this.GroupBoxSerialization.Controls.Add(this.ComboBoxPropertySerialization);
            this.GroupBoxSerialization.Controls.Add(this.LabelPropertySerializationType);
            this.GroupBoxSerialization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxSerialization.Location = new System.Drawing.Point(3, 3);
            this.GroupBoxSerialization.Name = "GroupBoxSerialization";
            this.GroupBoxSerialization.Size = new System.Drawing.Size(476, 255);
            this.GroupBoxSerialization.TabIndex = 0;
            this.GroupBoxSerialization.TabStop = false;
            this.GroupBoxSerialization.Text = "Serialization";
            // 
            // CheckBoxConfirmationAlerts
            // 
            this.CheckBoxConfirmationAlerts.AutoSize = true;
            this.CheckBoxConfirmationAlerts.Checked = true;
            this.CheckBoxConfirmationAlerts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxConfirmationAlerts.Location = new System.Drawing.Point(147, 49);
            this.CheckBoxConfirmationAlerts.Name = "CheckBoxConfirmationAlerts";
            this.CheckBoxConfirmationAlerts.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxConfirmationAlerts.TabIndex = 3;
            this.CheckBoxConfirmationAlerts.UseVisualStyleBackColor = true;
            this.CheckBoxConfirmationAlerts.CheckedChanged += new System.EventHandler(this.CheckBoxConfirmationAlerts_CheckedChanged);
            // 
            // LabelShowConfirmation
            // 
            this.LabelShowConfirmation.AutoSize = true;
            this.LabelShowConfirmation.Location = new System.Drawing.Point(6, 49);
            this.LabelShowConfirmation.Name = "LabelShowConfirmation";
            this.LabelShowConfirmation.Size = new System.Drawing.Size(127, 13);
            this.LabelShowConfirmation.TabIndex = 2;
            this.LabelShowConfirmation.Text = "Show Confirmation Alerts:";
            // 
            // ComboBoxPropertySerialization
            // 
            this.ComboBoxPropertySerialization.DisplayMember = "test";
            this.ComboBoxPropertySerialization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPropertySerialization.FormattingEnabled = true;
            this.ComboBoxPropertySerialization.Items.AddRange(new object[] {
            "camelCase",
            "lower_snake_case",
            "PascalCase",
            "_underscoreCamelCase"});
            this.ComboBoxPropertySerialization.Location = new System.Drawing.Point(147, 19);
            this.ComboBoxPropertySerialization.Name = "ComboBoxPropertySerialization";
            this.ComboBoxPropertySerialization.Size = new System.Drawing.Size(160, 21);
            this.ComboBoxPropertySerialization.TabIndex = 1;
            this.ComboBoxPropertySerialization.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPropertySerialization_SelectedIndexChanged);
            // 
            // LabelPropertySerializationType
            // 
            this.LabelPropertySerializationType.AutoSize = true;
            this.LabelPropertySerializationType.Location = new System.Drawing.Point(6, 22);
            this.LabelPropertySerializationType.Name = "LabelPropertySerializationType";
            this.LabelPropertySerializationType.Size = new System.Drawing.Size(135, 13);
            this.LabelPropertySerializationType.TabIndex = 0;
            this.LabelPropertySerializationType.Text = "Property Serialization Case:";
            // 
            // RootTableLayout
            // 
            this.RootTableLayout.ColumnCount = 1;
            this.RootTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RootTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RootTableLayout.Controls.Add(this.GroupBoxSerialization, 0, 0);
            this.RootTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RootTableLayout.Location = new System.Drawing.Point(0, 0);
            this.RootTableLayout.Name = "RootTableLayout";
            this.RootTableLayout.RowCount = 1;
            this.RootTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.81871F));
            this.RootTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.18129F));
            this.RootTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.RootTableLayout.Size = new System.Drawing.Size(482, 261);
            this.RootTableLayout.TabIndex = 1;
            // 
            // OptionsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.RootTableLayout);
            this.Name = "OptionsUserControl";
            this.Size = new System.Drawing.Size(482, 261);
            this.GroupBoxSerialization.ResumeLayout(false);
            this.GroupBoxSerialization.PerformLayout();
            this.RootTableLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxSerialization;
        private System.Windows.Forms.TableLayoutPanel RootTableLayout;
        private System.Windows.Forms.CheckBox CheckBoxConfirmationAlerts;
        private System.Windows.Forms.Label LabelShowConfirmation;
        private System.Windows.Forms.ComboBox ComboBoxPropertySerialization;
        private System.Windows.Forms.Label LabelPropertySerializationType;
    }
}
