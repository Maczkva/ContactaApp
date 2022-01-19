namespace ContactsAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.findLabel = new System.Windows.Forms.Label();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.birthDayLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.idVkLabel = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.idVkTextBox = new System.Windows.Forms.TextBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birthDateBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editContactToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelBirthDayInfo = new System.Windows.Forms.Label();
            this.birthContactsLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // findLabel
            // 
            this.findLabel.AutoSize = true;
            this.findLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findLabel.Location = new System.Drawing.Point(11, 32);
            this.findLabel.Margin = new System.Windows.Forms.Padding(5);
            this.findLabel.Name = "findLabel";
            this.findLabel.Size = new System.Drawing.Size(30, 13);
            this.findLabel.TabIndex = 0;
            this.findLabel.Text = "Find:";
            // 
            // findTextBox
            // 
            this.findTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findTextBox.Location = new System.Drawing.Point(51, 29);
            this.findTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(309, 20);
            this.findTextBox.TabIndex = 1;
            this.findTextBox.TextChanged += new System.EventHandler(this.FindTextBoxText_Changed);
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameLabel.Location = new System.Drawing.Point(401, 32);
            this.surnameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(52, 13);
            this.surnameLabel.TabIndex = 3;
            this.surnameLabel.Text = "Surname:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(415, 62);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name:";
            // 
            // birthDayLabel
            // 
            this.birthDayLabel.AutoSize = true;
            this.birthDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDayLabel.Location = new System.Drawing.Point(405, 92);
            this.birthDayLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.birthDayLabel.Name = "birthDayLabel";
            this.birthDayLabel.Size = new System.Drawing.Size(48, 13);
            this.birthDayLabel.TabIndex = 5;
            this.birthDayLabel.Text = "Birthday:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLabel.Location = new System.Drawing.Point(412, 122);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(41, 13);
            this.phoneLabel.TabIndex = 6;
            this.phoneLabel.Text = "Phone:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.Location = new System.Drawing.Point(415, 152);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(38, 13);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "E-mail:";
            // 
            // idVkLabel
            // 
            this.idVkLabel.AutoSize = true;
            this.idVkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idVkLabel.Location = new System.Drawing.Point(408, 181);
            this.idVkLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.idVkLabel.Name = "idVkLabel";
            this.idVkLabel.Size = new System.Drawing.Size(45, 13);
            this.idVkLabel.TabIndex = 8;
            this.idVkLabel.Text = "vk.com:";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.surnameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.surnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameTextBox.Location = new System.Drawing.Point(463, 29);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.ReadOnly = true;
            this.surnameTextBox.Size = new System.Drawing.Size(306, 20);
            this.surnameTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(463, 58);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(306, 20);
            this.nameTextBox.TabIndex = 7;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTextBox.Location = new System.Drawing.Point(463, 118);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.ReadOnly = true;
            this.phoneTextBox.Size = new System.Drawing.Size(306, 20);
            this.phoneTextBox.TabIndex = 9;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.Location = new System.Drawing.Point(463, 149);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(306, 20);
            this.emailTextBox.TabIndex = 10;
            // 
            // idVkTextBox
            // 
            this.idVkTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idVkTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.idVkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idVkTextBox.Location = new System.Drawing.Point(463, 178);
            this.idVkTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.idVkTextBox.Name = "idVkTextBox";
            this.idVkTextBox.ReadOnly = true;
            this.idVkTextBox.Size = new System.Drawing.Size(306, 20);
            this.idVkTextBox.TabIndex = 11;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 18);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenu_ItemClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editContactToolStripMenuItem,
            this.removeContactToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 18);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.addToolStripMenuItem.Text = "Add Contact";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenu_ItemClick);
            // 
            // editContactToolStripMenuItem
            // 
            this.editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
            this.editContactToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editContactToolStripMenuItem.Text = "Edit Contact";
            this.editContactToolStripMenuItem.Click += new System.EventHandler(this.EditContactToolStripMenu_ItemClick);
            // 
            // removeContactToolStripMenuItem
            // 
            this.removeContactToolStripMenuItem.Name = "removeContactToolStripMenuItem";
            this.removeContactToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.removeContactToolStripMenuItem.Text = "Remove Contact";
            this.removeContactToolStripMenuItem.Click += new System.EventHandler(this.RemoveContactToolStripMenu_ItemClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(41, 18);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenu_ItemClick);
            // 
            // birthDateBox
            // 
            this.birthDateBox.BackColor = System.Drawing.SystemColors.Window;
            this.birthDateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDateBox.Location = new System.Drawing.Point(463, 89);
            this.birthDateBox.Margin = new System.Windows.Forms.Padding(5);
            this.birthDateBox.Name = "birthDateBox";
            this.birthDateBox.ReadOnly = true;
            this.birthDateBox.Size = new System.Drawing.Size(67, 20);
            this.birthDateBox.TabIndex = 8;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteButton.BackColor = System.Drawing.SystemColors.Window;
            this.deleteButton.BackgroundImage = global::ContactsAppUI.Properties.Resources.DeleteButtonIcon30x30;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(94, 424);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(30, 30);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editButton.BackColor = System.Drawing.SystemColors.Window;
            this.editButton.BackgroundImage = global::ContactsAppUI.Properties.Resources.EditButtonIcon30x30;
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editButton.Location = new System.Drawing.Point(54, 424);
            this.editButton.Margin = new System.Windows.Forms.Padding(5);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(30, 30);
            this.editButton.TabIndex = 4;
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.BackColor = System.Drawing.SystemColors.Window;
            this.addButton.BackgroundImage = global::ContactsAppUI.Properties.Resources.AddButtonIcon30x30;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(14, 424);
            this.addButton.Margin = new System.Windows.Forms.Padding(5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(30, 30);
            this.addButton.TabIndex = 3;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ContactsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.Location = new System.Drawing.Point(14, 59);
            this.ContactsListBox.Margin = new System.Windows.Forms.Padding(5);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.Size = new System.Drawing.Size(346, 355);
            this.ContactsListBox.TabIndex = 2;
            this.ContactsListBox.SelectedIndexChanged += new System.EventHandler(this.ContactsListBoxSelected_IndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.aboutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // ExitToolStripMenuItem1
            // 
            this.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1";
            this.ExitToolStripMenuItem1.Size = new System.Drawing.Size(92, 22);
            this.ExitToolStripMenuItem1.Text = "Exit";
            this.ExitToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenu_ItemClick);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.editContactToolStripMenuItem1,
            this.deleteContactToolStripMenuItem});
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.addToolStripMenuItem1.Text = "Add Contact";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.AddToolStripMenu_ItemClick);
            // 
            // editContactToolStripMenuItem1
            // 
            this.editContactToolStripMenuItem1.Name = "editContactToolStripMenuItem1";
            this.editContactToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.editContactToolStripMenuItem1.Text = "Edit Contact";
            this.editContactToolStripMenuItem1.Click += new System.EventHandler(this.EditContactToolStripMenu_ItemClick);
            // 
            // deleteContactToolStripMenuItem
            // 
            this.deleteContactToolStripMenuItem.Name = "deleteContactToolStripMenuItem";
            this.deleteContactToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.deleteContactToolStripMenuItem.Text = "Delete Contact";
            this.deleteContactToolStripMenuItem.Click += new System.EventHandler(this.RemoveContactToolStripMenu_ItemClick);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem2});
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(40, 20);
            this.aboutToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem2
            // 
            this.aboutToolStripMenuItem2.Name = "aboutToolStripMenuItem2";
            this.aboutToolStripMenuItem2.Size = new System.Drawing.Size(103, 22);
            this.aboutToolStripMenuItem2.Text = "About";
            this.aboutToolStripMenuItem2.Click += new System.EventHandler(this.AboutToolStripMenu_ItemClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.labelBirthDayInfo);
            this.panel1.Controls.Add(this.birthContactsLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(370, 347);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 114);
            this.panel1.TabIndex = 24;
            // 
            // labelBirthDayInfo
            // 
            this.labelBirthDayInfo.AutoSize = true;
            this.labelBirthDayInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelBirthDayInfo.Location = new System.Drawing.Point(105, 27);
            this.labelBirthDayInfo.Margin = new System.Windows.Forms.Padding(3);
            this.labelBirthDayInfo.Name = "labelBirthDayInfo";
            this.labelBirthDayInfo.Size = new System.Drawing.Size(184, 13);
            this.labelBirthDayInfo.TabIndex = 27;
            this.labelBirthDayInfo.Text = "Today is the birthday of these people:";
            // 
            // birthContactsLabel
            // 
            this.birthContactsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.birthContactsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.birthContactsLabel.Location = new System.Drawing.Point(105, 46);
            this.birthContactsLabel.Margin = new System.Windows.Forms.Padding(3);
            this.birthContactsLabel.Name = "birthContactsLabel";
            this.birthContactsLabel.Size = new System.Drawing.Size(297, 56);
            this.birthContactsLabel.TabIndex = 26;
            this.birthContactsLabel.Text = "No one";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ContactsAppUI.Properties.Resources.BirthPic;
            this.pictureBox1.Location = new System.Drawing.Point(7, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.birthDateBox);
            this.Controls.Add(this.ContactsListBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.idVkTextBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.idVkLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.birthDayLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.findTextBox);
            this.Controls.Add(this.findLabel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactsApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_Closed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label findLabel;
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label birthDayLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label idVkLabel;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox idVkTextBox;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox birthDateBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editContactToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelBirthDayInfo;
        private System.Windows.Forms.Label birthContactsLabel;
    }
}

