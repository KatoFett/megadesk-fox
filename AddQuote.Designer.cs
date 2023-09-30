namespace MegaDesk_Fox
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nmDrawers = new System.Windows.Forms.NumericUpDown();
            this.lblDrawers = new System.Windows.Forms.Label();
            this.cbMaterial = new System.Windows.Forms.ComboBox();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nmDepth = new System.Windows.Forms.NumericUpDown();
            this.lblDepth = new System.Windows.Forms.Label();
            this.nmWidth = new System.Windows.Forms.NumericUpDown();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.cbProductionDays = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDrawers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(167, 231);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(12, 15);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(51, 13);
            this.lblCustomer.TabIndex = 1;
            this.lblCustomer.Text = "Customer";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(69, 12);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(155, 20);
            this.txtCustomer.TabIndex = 1;
            this.txtCustomer.TextChanged += new System.EventHandler(this.txtCustomer_TextChanged);
            this.txtCustomer.Validating += new System.ComponentModel.CancelEventHandler(this.txtCustomer_Validating);
            this.txtCustomer.Validated += new System.EventHandler(this.Control_Validated);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nmDrawers);
            this.groupBox1.Controls.Add(this.lblDrawers);
            this.groupBox1.Controls.Add(this.cbMaterial);
            this.groupBox1.Controls.Add(this.lblMaterial);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nmDepth);
            this.groupBox1.Controls.Add(this.lblDepth);
            this.groupBox1.Controls.Add(this.nmWidth);
            this.groupBox1.Controls.Add(this.lblWidth);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 148);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desk";
            // 
            // nmDrawers
            // 
            this.nmDrawers.Location = new System.Drawing.Point(57, 85);
            this.nmDrawers.Name = "nmDrawers";
            this.nmDrawers.Size = new System.Drawing.Size(143, 20);
            this.nmDrawers.TabIndex = 5;
            // 
            // lblDrawers
            // 
            this.lblDrawers.AutoSize = true;
            this.lblDrawers.Location = new System.Drawing.Point(6, 87);
            this.lblDrawers.Name = "lblDrawers";
            this.lblDrawers.Size = new System.Drawing.Size(46, 13);
            this.lblDrawers.TabIndex = 8;
            this.lblDrawers.Text = "Drawers";
            // 
            // cbMaterial
            // 
            this.cbMaterial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbMaterial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Location = new System.Drawing.Point(57, 111);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(143, 21);
            this.cbMaterial.TabIndex = 6;
            this.cbMaterial.SelectedIndexChanged += new System.EventHandler(this.cbMaterial_SelectedIndexChanged);
            this.cbMaterial.Validating += new System.ComponentModel.CancelEventHandler(this.cbMaterial_Validating);
            this.cbMaterial.Validated += new System.EventHandler(this.Control_Validated);
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(6, 114);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(44, 13);
            this.lblMaterial.TabIndex = 6;
            this.lblMaterial.Text = "Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "inches";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "inches";
            // 
            // nmDepth
            // 
            this.nmDepth.Location = new System.Drawing.Point(57, 59);
            this.nmDepth.Name = "nmDepth";
            this.nmDepth.Size = new System.Drawing.Size(99, 20);
            this.nmDepth.TabIndex = 4;
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.Location = new System.Drawing.Point(6, 61);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(36, 13);
            this.lblDepth.TabIndex = 2;
            this.lblDepth.Text = "Depth";
            // 
            // nmWidth
            // 
            this.nmWidth.BackColor = System.Drawing.SystemColors.Window;
            this.nmWidth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nmWidth.Location = new System.Drawing.Point(57, 33);
            this.nmWidth.Name = "nmWidth";
            this.nmWidth.Size = new System.Drawing.Size(99, 20);
            this.nmWidth.TabIndex = 3;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(6, 35);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 0;
            this.lblWidth.Text = "Width";
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Location = new System.Drawing.Point(18, 45);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(45, 13);
            this.lblDelivery.TabIndex = 4;
            this.lblDelivery.Text = "Delivery";
            // 
            // cbProductionDays
            // 
            this.cbProductionDays.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbProductionDays.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProductionDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductionDays.FormattingEnabled = true;
            this.cbProductionDays.Location = new System.Drawing.Point(69, 42);
            this.cbProductionDays.Name = "cbProductionDays";
            this.cbProductionDays.Size = new System.Drawing.Size(155, 21);
            this.cbProductionDays.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(87, 231);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddQuote
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(254, 266);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbProductionDays);
            this.Controls.Add(this.lblDelivery);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddQuote";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Quote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDrawers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nmDepth;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.NumericUpDown nmWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.ComboBox cbProductionDays;
        private System.Windows.Forms.NumericUpDown nmDrawers;
        private System.Windows.Forms.Label lblDrawers;
        private System.Windows.Forms.ComboBox cbMaterial;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}