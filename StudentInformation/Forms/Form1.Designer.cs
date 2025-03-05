namespace StudentInformation
{
    partial class Form1
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
            this.teFirstName = new DevExpress.XtraEditors.TextEdit();
            this.teAddress = new DevExpress.XtraEditors.TextEdit();
            this.teLastName = new DevExpress.XtraEditors.TextEdit();
            this.teMiddleName = new DevExpress.XtraEditors.TextEdit();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.teContactNumber = new DevExpress.XtraEditors.LabelControl();
            this.teEmail = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.gcStudents = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Adrress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContactNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpadate = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMiddleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // teFirstName
            // 
            this.teFirstName.Location = new System.Drawing.Point(65, 69);
            this.teFirstName.Name = "teFirstName";
            this.teFirstName.Properties.AutoHeight = false;
            this.teFirstName.Size = new System.Drawing.Size(245, 36);
            this.teFirstName.TabIndex = 0;
            // 
            // teAddress
            // 
            this.teAddress.Location = new System.Drawing.Point(65, 348);
            this.teAddress.Name = "teAddress";
            this.teAddress.Properties.AutoHeight = false;
            this.teAddress.Size = new System.Drawing.Size(245, 36);
            this.teAddress.TabIndex = 1;
            // 
            // teLastName
            // 
            this.teLastName.Location = new System.Drawing.Point(65, 251);
            this.teLastName.Name = "teLastName";
            this.teLastName.Properties.AutoHeight = false;
            this.teLastName.Size = new System.Drawing.Size(245, 36);
            this.teLastName.TabIndex = 2;
            // 
            // teMiddleName
            // 
            this.teMiddleName.Location = new System.Drawing.Point(65, 159);
            this.teMiddleName.Name = "teMiddleName";
            this.teMiddleName.Properties.AutoHeight = false;
            this.teMiddleName.Size = new System.Drawing.Size(245, 36);
            this.teMiddleName.TabIndex = 3;
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(65, 541);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Properties.AutoHeight = false;
            this.textEdit5.Size = new System.Drawing.Size(245, 36);
            this.textEdit5.TabIndex = 4;
            // 
            // textEdit6
            // 
            this.textEdit6.Location = new System.Drawing.Point(65, 445);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Properties.AutoHeight = false;
            this.textEdit6.Size = new System.Drawing.Size(245, 36);
            this.textEdit6.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(66, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 20);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "FirstName:";
            // 
            // teContactNumber
            // 
            this.teContactNumber.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teContactNumber.Appearance.ForeColor = System.Drawing.Color.Black;
            this.teContactNumber.Appearance.Options.UseFont = true;
            this.teContactNumber.Appearance.Options.UseForeColor = true;
            this.teContactNumber.Location = new System.Drawing.Point(65, 519);
            this.teContactNumber.Name = "teContactNumber";
            this.teContactNumber.Size = new System.Drawing.Size(120, 20);
            this.teContactNumber.TabIndex = 8;
            this.teContactNumber.Text = "Contact Number:";
            // 
            // teEmail
            // 
            this.teEmail.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teEmail.Appearance.ForeColor = System.Drawing.Color.Black;
            this.teEmail.Appearance.Options.UseFont = true;
            this.teEmail.Appearance.Options.UseForeColor = true;
            this.teEmail.Location = new System.Drawing.Point(66, 422);
            this.teEmail.Name = "teEmail";
            this.teEmail.Size = new System.Drawing.Size(42, 20);
            this.teEmail.TabIndex = 9;
            this.teEmail.Text = "Email:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(66, 327);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(61, 20);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Address:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(66, 228);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(75, 20);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "LastName:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(65, 136);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(94, 20);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "MiddleName:";
            // 
            // gcStudents
            // 
            this.gcStudents.Location = new System.Drawing.Point(366, 48);
            this.gcStudents.MainView = this.gridView1;
            this.gcStudents.Name = "gcStudents";
            this.gcStudents.Size = new System.Drawing.Size(1048, 529);
            this.gcStudents.TabIndex = 13;
            this.gcStudents.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.Adrress,
            this.Email,
            this.ContactNumber});
            this.gridView1.GridControl = this.gcStudents;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 914;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // FirstName
            // 
            this.FirstName.Caption = "FirstName";
            this.FirstName.FieldName = "FirstName";
            this.FirstName.MinWidth = 29;
            this.FirstName.Name = "FirstName";
            this.FirstName.Visible = true;
            this.FirstName.VisibleIndex = 0;
            this.FirstName.Width = 107;
            // 
            // MiddleName
            // 
            this.MiddleName.Caption = "MiddleName";
            this.MiddleName.FieldName = "MiddleName";
            this.MiddleName.MinWidth = 29;
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Visible = true;
            this.MiddleName.VisibleIndex = 1;
            this.MiddleName.Width = 107;
            // 
            // LastName
            // 
            this.LastName.Caption = "LastName";
            this.LastName.FieldName = "LastName";
            this.LastName.MinWidth = 29;
            this.LastName.Name = "LastName";
            this.LastName.Visible = true;
            this.LastName.VisibleIndex = 2;
            this.LastName.Width = 107;
            // 
            // Adrress
            // 
            this.Adrress.Caption = "Adrress";
            this.Adrress.FieldName = "Adrress";
            this.Adrress.MinWidth = 29;
            this.Adrress.Name = "Adrress";
            this.Adrress.Visible = true;
            this.Adrress.VisibleIndex = 3;
            this.Adrress.Width = 107;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "Email";
            this.Email.MinWidth = 29;
            this.Email.Name = "Email";
            this.Email.Visible = true;
            this.Email.VisibleIndex = 4;
            this.Email.Width = 107;
            // 
            // ContactNumber
            // 
            this.ContactNumber.Caption = "Contact Number";
            this.ContactNumber.FieldName = "ContactNumber";
            this.ContactNumber.MinWidth = 29;
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.Visible = true;
            this.ContactNumber.VisibleIndex = 5;
            this.ContactNumber.Width = 107;
            // 
            // btnLoad
            // 
            this.btnLoad.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Appearance.Options.UseFont = true;
            this.btnLoad.Location = new System.Drawing.Point(890, 610);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(107, 29);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "LOAD";
            // 
            // btnUpadate
            // 
            this.btnUpadate.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpadate.Appearance.Options.UseFont = true;
            this.btnUpadate.Location = new System.Drawing.Point(1170, 610);
            this.btnUpadate.Name = "btnUpadate";
            this.btnUpadate.Size = new System.Drawing.Size(107, 29);
            this.btnUpadate.TabIndex = 15;
            this.btnUpadate.Text = "UPDATE";
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Location = new System.Drawing.Point(1030, 610);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 29);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Location = new System.Drawing.Point(1306, 610);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 29);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "DELETE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1449, 662);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpadate);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.gcStudents);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.teEmail);
            this.Controls.Add(this.teContactNumber);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEdit6);
            this.Controls.Add(this.textEdit5);
            this.Controls.Add(this.teMiddleName);
            this.Controls.Add(this.teLastName);
            this.Controls.Add(this.teAddress);
            this.Controls.Add(this.teFirstName);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMiddleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit teFirstName;
        private DevExpress.XtraEditors.TextEdit teAddress;
        private DevExpress.XtraEditors.TextEdit teLastName;
        private DevExpress.XtraEditors.TextEdit teMiddleName;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl teContactNumber;
        private DevExpress.XtraEditors.LabelControl teEmail;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.GridControl gcStudents;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn FirstName;
        private DevExpress.XtraGrid.Columns.GridColumn MiddleName;
        private DevExpress.XtraGrid.Columns.GridColumn LastName;
        private DevExpress.XtraGrid.Columns.GridColumn Adrress;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn ContactNumber;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraEditors.SimpleButton btnUpadate;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
    }
}

