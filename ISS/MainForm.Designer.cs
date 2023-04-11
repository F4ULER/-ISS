
namespace ISS
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureSearch = new System.Windows.Forms.PictureBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.mainTable = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxEndDate = new System.Windows.Forms.TextBox();
            this.textBoxStartDate = new System.Windows.Forms.TextBox();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.textBoxOwner = new System.Windows.Forms.TextBox();
            this.labelAdd = new System.Windows.Forms.Label();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.pictureBoxDel = new System.Windows.Forms.PictureBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelCheckDel = new System.Windows.Forms.Label();
            this.tableDelete = new System.Windows.Forms.DataGridView();
            this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
            this.textBoxDelete = new System.Windows.Forms.TextBox();
            this.labelDelEnter = new System.Windows.Forms.Label();
            this.labelDelete = new System.Windows.Forms.Label();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.buttonSaveEdit = new System.Windows.Forms.Button();
            this.textBoxEndDateEdit = new System.Windows.Forms.TextBox();
            this.textBoxStartDateEdit = new System.Windows.Forms.TextBox();
            this.textBoxBrandEdit = new System.Windows.Forms.TextBox();
            this.textBoxOwnerEdit = new System.Windows.Forms.TextBox();
            this.textBoxNumEdit = new System.Windows.Forms.TextBox();
            this.pictureBoxEditNote = new System.Windows.Forms.PictureBox();
            this.textBoxEdit = new System.Windows.Forms.TextBox();
            this.labelEditEnter = new System.Windows.Forms.Label();
            this.labelEditNote = new System.Windows.Forms.Label();
            this.pictureBoxEdit = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackAdd = new System.Windows.Forms.PictureBox();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelWelc = new System.Windows.Forms.Label();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.tabDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
            this.tabEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureSearch
            // 
            this.pictureSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureSearch.Image = ((System.Drawing.Image)(resources.GetObject("pictureSearch.Image")));
            this.pictureSearch.Location = new System.Drawing.Point(790, 44);
            this.pictureSearch.Name = "pictureSearch";
            this.pictureSearch.Size = new System.Drawing.Size(40, 40);
            this.pictureSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSearch.TabIndex = 3;
            this.pictureSearch.TabStop = false;
            this.pictureSearch.Click += new System.EventHandler(this.pictureSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearch.Location = new System.Drawing.Point(281, 44);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(503, 40);
            this.textBoxSearch.TabIndex = 4;
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // mainTable
            // 
            this.mainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainTable.Location = new System.Drawing.Point(197, 110);
            this.mainTable.Name = "mainTable";
            this.mainTable.RowHeadersWidth = 51;
            this.mainTable.RowTemplate.Height = 29;
            this.mainTable.Size = new System.Drawing.Size(801, 554);
            this.mainTable.TabIndex = 5;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabAdd);
            this.tabControl.Controls.Add(this.tabDelete);
            this.tabControl.Controls.Add(this.tabEdit);
            this.tabControl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl.Location = new System.Drawing.Point(166, 110);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(816, 517);
            this.tabControl.TabIndex = 6;
            this.tabControl.Visible = false;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabAdd
            // 
            this.tabAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(193)))), ((int)(((byte)(196)))));
            this.tabAdd.Controls.Add(this.buttonAdd);
            this.tabAdd.Controls.Add(this.textBoxEndDate);
            this.tabAdd.Controls.Add(this.textBoxStartDate);
            this.tabAdd.Controls.Add(this.textBoxBrand);
            this.tabAdd.Controls.Add(this.textBoxOwner);
            this.tabAdd.Controls.Add(this.labelAdd);
            this.tabAdd.Controls.Add(this.textBoxNum);
            this.tabAdd.Location = new System.Drawing.Point(4, 32);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(808, 481);
            this.tabAdd.TabIndex = 0;
            this.tabAdd.Text = "Добавить";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(320, 389);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(133, 48);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Сохранить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxEndDate
            // 
            this.textBoxEndDate.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEndDate.Location = new System.Drawing.Point(166, 308);
            this.textBoxEndDate.Multiline = true;
            this.textBoxEndDate.Name = "textBoxEndDate";
            this.textBoxEndDate.Size = new System.Drawing.Size(420, 39);
            this.textBoxEndDate.TabIndex = 8;
            this.textBoxEndDate.Enter += new System.EventHandler(this.textBoxEndDate_Enter);
            this.textBoxEndDate.Leave += new System.EventHandler(this.textBoxEndDate_Leave);
            // 
            // textBoxStartDate
            // 
            this.textBoxStartDate.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxStartDate.Location = new System.Drawing.Point(166, 248);
            this.textBoxStartDate.Multiline = true;
            this.textBoxStartDate.Name = "textBoxStartDate";
            this.textBoxStartDate.Size = new System.Drawing.Size(420, 39);
            this.textBoxStartDate.TabIndex = 7;
            this.textBoxStartDate.Enter += new System.EventHandler(this.textBoxStartDate_Enter);
            this.textBoxStartDate.Leave += new System.EventHandler(this.textBoxStartDate_Leave);
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBrand.Location = new System.Drawing.Point(166, 188);
            this.textBoxBrand.Multiline = true;
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(420, 39);
            this.textBoxBrand.TabIndex = 6;
            this.textBoxBrand.Enter += new System.EventHandler(this.textBoxBrand_Enter);
            this.textBoxBrand.Leave += new System.EventHandler(this.textBoxBrand_Leave);
            // 
            // textBoxOwner
            // 
            this.textBoxOwner.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxOwner.Location = new System.Drawing.Point(166, 128);
            this.textBoxOwner.Multiline = true;
            this.textBoxOwner.Name = "textBoxOwner";
            this.textBoxOwner.Size = new System.Drawing.Size(420, 39);
            this.textBoxOwner.TabIndex = 5;
            this.textBoxOwner.Enter += new System.EventHandler(this.textBoxOwner_Enter);
            this.textBoxOwner.Leave += new System.EventHandler(this.textBoxOwner_Leave);
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAdd.Location = new System.Drawing.Point(185, 0);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(424, 46);
            this.labelAdd.TabIndex = 4;
            this.labelAdd.Text = "Добавление записи о судне";
            // 
            // textBoxNum
            // 
            this.textBoxNum.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNum.Location = new System.Drawing.Point(166, 68);
            this.textBoxNum.Multiline = true;
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(420, 39);
            this.textBoxNum.TabIndex = 3;
            this.textBoxNum.Enter += new System.EventHandler(this.textBoxNum_Enter);
            this.textBoxNum.Leave += new System.EventHandler(this.textBoxNum_Leave);
            // 
            // tabDelete
            // 
            this.tabDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(193)))), ((int)(((byte)(196)))));
            this.tabDelete.Controls.Add(this.pictureBoxDel);
            this.tabDelete.Controls.Add(this.buttonDelete);
            this.tabDelete.Controls.Add(this.labelCheckDel);
            this.tabDelete.Controls.Add(this.tableDelete);
            this.tabDelete.Controls.Add(this.pictureBoxDelete);
            this.tabDelete.Controls.Add(this.textBoxDelete);
            this.tabDelete.Controls.Add(this.labelDelEnter);
            this.tabDelete.Controls.Add(this.labelDelete);
            this.tabDelete.Location = new System.Drawing.Point(4, 32);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabDelete.Size = new System.Drawing.Size(808, 481);
            this.tabDelete.TabIndex = 1;
            this.tabDelete.Text = "Удалить";
            // 
            // pictureBoxDel
            // 
            this.pictureBoxDel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBoxDel.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDel.Image")));
            this.pictureBoxDel.Location = new System.Drawing.Point(446, 393);
            this.pictureBoxDel.Name = "pictureBoxDel";
            this.pictureBoxDel.Size = new System.Drawing.Size(58, 54);
            this.pictureBoxDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDel.TabIndex = 13;
            this.pictureBoxDel.TabStop = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDelete.Location = new System.Drawing.Point(308, 393);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(132, 54);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelCheckDel
            // 
            this.labelCheckDel.AutoSize = true;
            this.labelCheckDel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCheckDel.Location = new System.Drawing.Point(95, 336);
            this.labelCheckDel.Name = "labelCheckDel";
            this.labelCheckDel.Size = new System.Drawing.Size(633, 32);
            this.labelCheckDel.TabIndex = 11;
            this.labelCheckDel.Text = "Вы уверены, что хотите удалить данную запись?";
            // 
            // tableDelete
            // 
            this.tableDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDelete.Location = new System.Drawing.Point(3, 130);
            this.tableDelete.Name = "tableDelete";
            this.tableDelete.RowHeadersWidth = 51;
            this.tableDelete.RowTemplate.Height = 29;
            this.tableDelete.Size = new System.Drawing.Size(802, 111);
            this.tableDelete.TabIndex = 10;
            // 
            // pictureBoxDelete
            // 
            this.pictureBoxDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDelete.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDelete.Image")));
            this.pictureBoxDelete.Location = new System.Drawing.Point(487, 79);
            this.pictureBoxDelete.Name = "pictureBoxDelete";
            this.pictureBoxDelete.Size = new System.Drawing.Size(45, 45);
            this.pictureBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDelete.TabIndex = 8;
            this.pictureBoxDelete.TabStop = false;
            this.pictureBoxDelete.Click += new System.EventHandler(this.pictureBoxDelete_Click);
            // 
            // textBoxDelete
            // 
            this.textBoxDelete.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDelete.Location = new System.Drawing.Point(278, 84);
            this.textBoxDelete.Multiline = true;
            this.textBoxDelete.Name = "textBoxDelete";
            this.textBoxDelete.Size = new System.Drawing.Size(203, 40);
            this.textBoxDelete.TabIndex = 9;
            // 
            // labelDelEnter
            // 
            this.labelDelEnter.AutoSize = true;
            this.labelDelEnter.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDelEnter.Location = new System.Drawing.Point(186, 55);
            this.labelDelEnter.Name = "labelDelEnter";
            this.labelDelEnter.Size = new System.Drawing.Size(427, 26);
            this.labelDelEnter.TabIndex = 7;
            this.labelDelEnter.Text = "Введите идентификационный номер судна";
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDelete.Location = new System.Drawing.Point(200, 0);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(390, 46);
            this.labelDelete.TabIndex = 6;
            this.labelDelete.Text = "Удаление записи о судне";
            // 
            // tabEdit
            // 
            this.tabEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(193)))), ((int)(((byte)(196)))));
            this.tabEdit.Controls.Add(this.buttonSaveEdit);
            this.tabEdit.Controls.Add(this.textBoxEndDateEdit);
            this.tabEdit.Controls.Add(this.textBoxStartDateEdit);
            this.tabEdit.Controls.Add(this.textBoxBrandEdit);
            this.tabEdit.Controls.Add(this.textBoxOwnerEdit);
            this.tabEdit.Controls.Add(this.textBoxNumEdit);
            this.tabEdit.Controls.Add(this.pictureBoxEditNote);
            this.tabEdit.Controls.Add(this.textBoxEdit);
            this.tabEdit.Controls.Add(this.labelEditEnter);
            this.tabEdit.Controls.Add(this.labelEditNote);
            this.tabEdit.Location = new System.Drawing.Point(4, 32);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdit.Size = new System.Drawing.Size(808, 481);
            this.tabEdit.TabIndex = 2;
            this.tabEdit.Text = "Изменить";
            // 
            // buttonSaveEdit
            // 
            this.buttonSaveEdit.Location = new System.Drawing.Point(275, 430);
            this.buttonSaveEdit.Name = "buttonSaveEdit";
            this.buttonSaveEdit.Size = new System.Drawing.Size(133, 48);
            this.buttonSaveEdit.TabIndex = 19;
            this.buttonSaveEdit.Text = "Сохранить";
            this.buttonSaveEdit.UseVisualStyleBackColor = true;
            this.buttonSaveEdit.Visible = false;
            this.buttonSaveEdit.Click += new System.EventHandler(this.buttonSaveEdit_Click);
            // 
            // textBoxEndDateEdit
            // 
            this.textBoxEndDateEdit.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEndDateEdit.Location = new System.Drawing.Point(151, 372);
            this.textBoxEndDateEdit.Multiline = true;
            this.textBoxEndDateEdit.Name = "textBoxEndDateEdit";
            this.textBoxEndDateEdit.Size = new System.Drawing.Size(420, 39);
            this.textBoxEndDateEdit.TabIndex = 18;
            this.textBoxEndDateEdit.Visible = false;
            // 
            // textBoxStartDateEdit
            // 
            this.textBoxStartDateEdit.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxStartDateEdit.Location = new System.Drawing.Point(151, 312);
            this.textBoxStartDateEdit.Multiline = true;
            this.textBoxStartDateEdit.Name = "textBoxStartDateEdit";
            this.textBoxStartDateEdit.Size = new System.Drawing.Size(420, 39);
            this.textBoxStartDateEdit.TabIndex = 17;
            this.textBoxStartDateEdit.Visible = false;
            // 
            // textBoxBrandEdit
            // 
            this.textBoxBrandEdit.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBrandEdit.Location = new System.Drawing.Point(151, 252);
            this.textBoxBrandEdit.Multiline = true;
            this.textBoxBrandEdit.Name = "textBoxBrandEdit";
            this.textBoxBrandEdit.Size = new System.Drawing.Size(420, 39);
            this.textBoxBrandEdit.TabIndex = 16;
            this.textBoxBrandEdit.Visible = false;
            // 
            // textBoxOwnerEdit
            // 
            this.textBoxOwnerEdit.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxOwnerEdit.Location = new System.Drawing.Point(151, 192);
            this.textBoxOwnerEdit.Multiline = true;
            this.textBoxOwnerEdit.Name = "textBoxOwnerEdit";
            this.textBoxOwnerEdit.Size = new System.Drawing.Size(420, 39);
            this.textBoxOwnerEdit.TabIndex = 15;
            this.textBoxOwnerEdit.Visible = false;
            // 
            // textBoxNumEdit
            // 
            this.textBoxNumEdit.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNumEdit.Location = new System.Drawing.Point(151, 132);
            this.textBoxNumEdit.Multiline = true;
            this.textBoxNumEdit.Name = "textBoxNumEdit";
            this.textBoxNumEdit.Size = new System.Drawing.Size(420, 39);
            this.textBoxNumEdit.TabIndex = 14;
            this.textBoxNumEdit.Visible = false;
            // 
            // pictureBoxEditNote
            // 
            this.pictureBoxEditNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEditNote.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEditNote.Image")));
            this.pictureBoxEditNote.Location = new System.Drawing.Point(466, 79);
            this.pictureBoxEditNote.Name = "pictureBoxEditNote";
            this.pictureBoxEditNote.Size = new System.Drawing.Size(45, 45);
            this.pictureBoxEditNote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEditNote.TabIndex = 12;
            this.pictureBoxEditNote.TabStop = false;
            this.pictureBoxEditNote.Click += new System.EventHandler(this.pictureBoxEditNote_Click);
            // 
            // textBoxEdit
            // 
            this.textBoxEdit.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEdit.Location = new System.Drawing.Point(257, 84);
            this.textBoxEdit.Multiline = true;
            this.textBoxEdit.Name = "textBoxEdit";
            this.textBoxEdit.Size = new System.Drawing.Size(203, 40);
            this.textBoxEdit.TabIndex = 13;
            // 
            // labelEditEnter
            // 
            this.labelEditEnter.AutoSize = true;
            this.labelEditEnter.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEditEnter.Location = new System.Drawing.Point(165, 55);
            this.labelEditEnter.Name = "labelEditEnter";
            this.labelEditEnter.Size = new System.Drawing.Size(427, 26);
            this.labelEditEnter.TabIndex = 11;
            this.labelEditEnter.Text = "Введите идентификационный номер судна";
            // 
            // labelEditNote
            // 
            this.labelEditNote.AutoSize = true;
            this.labelEditNote.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEditNote.Location = new System.Drawing.Point(161, -49);
            this.labelEditNote.Name = "labelEditNote";
            this.labelEditNote.Size = new System.Drawing.Size(418, 46);
            this.labelEditNote.TabIndex = 10;
            this.labelEditNote.Text = "Изменение записи о судне";
            // 
            // pictureBoxEdit
            // 
            this.pictureBoxEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEdit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEdit.Image")));
            this.pictureBoxEdit.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxEdit.Name = "pictureBoxEdit";
            this.pictureBoxEdit.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEdit.TabIndex = 7;
            this.pictureBoxEdit.TabStop = false;
            this.pictureBoxEdit.Visible = false;
            this.pictureBoxEdit.Click += new System.EventHandler(this.pictureBoxEdit_Click);
            // 
            // pictureBoxBackAdd
            // 
            this.pictureBoxBackAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBackAdd.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackAdd.Image")));
            this.pictureBoxBackAdd.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxBackAdd.Name = "pictureBoxBackAdd";
            this.pictureBoxBackAdd.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxBackAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackAdd.TabIndex = 8;
            this.pictureBoxBackAdd.TabStop = false;
            this.pictureBoxBackAdd.Visible = false;
            this.pictureBoxBackAdd.Click += new System.EventHandler(this.pictureBoxBackAdd_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWelcome.Location = new System.Drawing.Point(428, -108);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(57, 36);
            this.labelWelcome.TabIndex = 9;
            this.labelWelcome.Text = "test";
            // 
            // labelWelc
            // 
            this.labelWelc.AutoSize = true;
            this.labelWelc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelWelc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWelc.Location = new System.Drawing.Point(869, 12);
            this.labelWelc.Name = "labelWelc";
            this.labelWelc.Size = new System.Drawing.Size(45, 28);
            this.labelWelc.TabIndex = 10;
            this.labelWelc.Text = "test";
            // 
            // pictureUser
            // 
            this.pictureUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureUser.Image")));
            this.pictureUser.Location = new System.Drawing.Point(297, 90);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(500, 500);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUser.TabIndex = 11;
            this.pictureUser.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(95)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(1151, 712);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.labelWelc);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.pictureSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.mainTable);
            this.Controls.Add(this.pictureBoxBackAdd);
            this.Controls.Add(this.pictureBoxEdit);
            this.Controls.Add(this.pictureUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounting system for civil ships in private docks";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.tabDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
            this.tabEdit.ResumeLayout(false);
            this.tabEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView mainTable;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.TextBox textBoxEndDate;
        private System.Windows.Forms.TextBox textBoxStartDate;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.TextBox textBoxOwner;
        private System.Windows.Forms.Label labelDelEnter;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.DataGridView tableDelete;
        private System.Windows.Forms.PictureBox pictureBoxDelete;
        private System.Windows.Forms.TextBox textBoxDelete;
        private System.Windows.Forms.Label labelCheckDel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.PictureBox pictureBoxDel;
        private System.Windows.Forms.PictureBox pictureBoxEdit;
        private System.Windows.Forms.PictureBox pictureBoxBackAdd;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelWelc;
        private System.Windows.Forms.Button buttonSaveEdit;
        private System.Windows.Forms.TextBox textBoxEndDateEdit;
        private System.Windows.Forms.TextBox textBoxStartDateEdit;
        private System.Windows.Forms.TextBox textBoxBrandEdit;
        private System.Windows.Forms.TextBox textBoxOwnerEdit;
        private System.Windows.Forms.TextBox textBoxNumEdit;
        private System.Windows.Forms.PictureBox pictureBoxEditNote;
        private System.Windows.Forms.TextBox textBoxEdit;
        private System.Windows.Forms.Label labelEditEnter;
        private System.Windows.Forms.Label labelEditNote;
        private System.Windows.Forms.PictureBox pictureUser;
    }
}

