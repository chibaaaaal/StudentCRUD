namespace StudentCRUD
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
            this.gcStudents = new DevExpress.XtraGrid.GridControl();
            this.gvStudents = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtbxFirstName = new DevExpress.XtraEditors.TextEdit();
            this.txtbxMiddleName = new DevExpress.XtraEditors.TextEdit();
            this.txtbxLastName = new DevExpress.XtraEditors.TextEdit();
            this.txtbxNameExtension = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dteditBirthDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.cbGender = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbxFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbxMiddleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbxLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbxNameExtension.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteditBirthDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteditBirthDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGender.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcStudents
            // 
            this.gcStudents.Location = new System.Drawing.Point(12, 12);
            this.gcStudents.MainView = this.gvStudents;
            this.gcStudents.Name = "gcStudents";
            this.gcStudents.Size = new System.Drawing.Size(524, 248);
            this.gcStudents.TabIndex = 0;
            this.gcStudents.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStudents});
            // 
            // gvStudents
            // 
            this.gvStudents.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gvStudents.GridControl = this.gcStudents;
            this.gvStudents.Name = "gvStudents";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "First Name";
            this.gridColumn1.FieldName = "FirstName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Middle Name";
            this.gridColumn2.FieldName = "MiddleName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Last Name";
            this.gridColumn3.FieldName = "LastName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Name Extension";
            this.gridColumn4.FieldName = "NameExtension";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Gender";
            this.gridColumn5.FieldName = "Gender";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Birth Date";
            this.gridColumn6.FieldName = "BirthDate";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // txtbxFirstName
            // 
            this.txtbxFirstName.Location = new System.Drawing.Point(12, 288);
            this.txtbxFirstName.Name = "txtbxFirstName";
            this.txtbxFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtbxFirstName.TabIndex = 1;
            // 
            // txtbxMiddleName
            // 
            this.txtbxMiddleName.Location = new System.Drawing.Point(118, 288);
            this.txtbxMiddleName.Name = "txtbxMiddleName";
            this.txtbxMiddleName.Size = new System.Drawing.Size(100, 20);
            this.txtbxMiddleName.TabIndex = 2;
            // 
            // txtbxLastName
            // 
            this.txtbxLastName.Location = new System.Drawing.Point(224, 288);
            this.txtbxLastName.Name = "txtbxLastName";
            this.txtbxLastName.Size = new System.Drawing.Size(100, 20);
            this.txtbxLastName.TabIndex = 3;
            // 
            // txtbxNameExtension
            // 
            this.txtbxNameExtension.Location = new System.Drawing.Point(330, 288);
            this.txtbxNameExtension.Name = "txtbxNameExtension";
            this.txtbxNameExtension.Size = new System.Drawing.Size(100, 20);
            this.txtbxNameExtension.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 269);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "First Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(118, 269);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Middle Name";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(224, 269);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Last Name";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(330, 269);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(77, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Name Extension";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(436, 269);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(35, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Gender";
            // 
            // dteditBirthDate
            // 
            this.dteditBirthDate.EditValue = null;
            this.dteditBirthDate.Location = new System.Drawing.Point(12, 333);
            this.dteditBirthDate.Name = "dteditBirthDate";
            this.dteditBirthDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteditBirthDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteditBirthDate.Size = new System.Drawing.Size(100, 20);
            this.dteditBirthDate.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 314);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 13);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Birth Date";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(118, 331);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(224, 331);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(330, 330);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 23);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(436, 330);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 23);
            this.btnLoad.TabIndex = 16;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cbGender
            // 
            this.cbGender.Location = new System.Drawing.Point(436, 288);
            this.cbGender.Name = "cbGender";
            this.cbGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGender.Properties.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Size = new System.Drawing.Size(100, 20);
            this.cbGender.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 441);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.dteditBirthDate);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtbxNameExtension);
            this.Controls.Add(this.txtbxLastName);
            this.Controls.Add(this.txtbxMiddleName);
            this.Controls.Add(this.txtbxFirstName);
            this.Controls.Add(this.gcStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gcStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbxFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbxMiddleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbxLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbxNameExtension.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteditBirthDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteditBirthDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGender.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcStudents;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStudents;
        private DevExpress.XtraEditors.TextEdit txtbxFirstName;
        private DevExpress.XtraEditors.TextEdit txtbxMiddleName;
        private DevExpress.XtraEditors.TextEdit txtbxLastName;
        private DevExpress.XtraEditors.TextEdit txtbxNameExtension;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit dteditBirthDate;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.ComboBoxEdit cbGender;
    }
}

