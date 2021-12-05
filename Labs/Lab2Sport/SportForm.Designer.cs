
namespace Lab2Sport
{
    partial class SportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SportForm));
            this.comboBoxSection = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.comboBoxSurname = new System.Windows.Forms.ComboBox();
            this.comboBoxSchedule = new System.Windows.Forms.ComboBox();
            this.comboBoxConpetition = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxSection = new System.Windows.Forms.CheckBox();
            this.checkBoxStatus = new System.Windows.Forms.CheckBox();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.checkBoxSurname = new System.Windows.Forms.CheckBox();
            this.checkBoxSchedule = new System.Windows.Forms.CheckBox();
            this.checkBoxCompetition = new System.Windows.Forms.CheckBox();
            this.radioButtonDOM = new System.Windows.Forms.RadioButton();
            this.radioButtonSAX = new System.Windows.Forms.RadioButton();
            this.radioButtonLINQ = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonTransform = new System.Windows.Forms.Button();
            this.buttonOpenHTML = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.сохранитькакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSection
            // 
            this.comboBoxSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSection.FormattingEnabled = true;
            this.comboBoxSection.Location = new System.Drawing.Point(200, 72);
            this.comboBoxSection.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSection.Name = "comboBoxSection";
            this.comboBoxSection.Size = new System.Drawing.Size(147, 24);
            this.comboBoxSection.TabIndex = 0;
            this.comboBoxSection.SelectedIndexChanged += new System.EventHandler(this.comboBoxName_SelectedIndexChanged_1);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(200, 105);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(147, 24);
            this.comboBoxStatus.TabIndex = 1;
            // 
            // comboBoxName
            // 
            this.comboBoxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(200, 142);
            this.comboBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(147, 24);
            this.comboBoxName.TabIndex = 2;
            // 
            // comboBoxSurname
            // 
            this.comboBoxSurname.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxSurname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSurname.FormattingEnabled = true;
            this.comboBoxSurname.Location = new System.Drawing.Point(200, 179);
            this.comboBoxSurname.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSurname.Name = "comboBoxSurname";
            this.comboBoxSurname.Size = new System.Drawing.Size(147, 24);
            this.comboBoxSurname.TabIndex = 3;
            // 
            // comboBoxSchedule
            // 
            this.comboBoxSchedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSchedule.FormattingEnabled = true;
            this.comboBoxSchedule.Location = new System.Drawing.Point(200, 214);
            this.comboBoxSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSchedule.Name = "comboBoxSchedule";
            this.comboBoxSchedule.Size = new System.Drawing.Size(147, 24);
            this.comboBoxSchedule.TabIndex = 4;
            // 
            // comboBoxConpetition
            // 
            this.comboBoxConpetition.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBoxConpetition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConpetition.FormattingEnabled = true;
            this.comboBoxConpetition.Location = new System.Drawing.Point(200, 250);
            this.comboBoxConpetition.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxConpetition.Name = "comboBoxConpetition";
            this.comboBoxConpetition.Size = new System.Drawing.Size(147, 24);
            this.comboBoxConpetition.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 6;
            // 
            // checkBoxSection
            // 
            this.checkBoxSection.AutoSize = true;
            this.checkBoxSection.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBoxSection.Location = new System.Drawing.Point(85, 72);
            this.checkBoxSection.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxSection.Name = "checkBoxSection";
            this.checkBoxSection.Size = new System.Drawing.Size(77, 21);
            this.checkBoxSection.TabIndex = 12;
            this.checkBoxSection.Text = "Section";
            this.checkBoxSection.UseVisualStyleBackColor = false;
            this.checkBoxSection.CheckedChanged += new System.EventHandler(this.checkBoxName_CheckedChanged);
            // 
            // checkBoxStatus
            // 
            this.checkBoxStatus.AutoSize = true;
            this.checkBoxStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBoxStatus.Location = new System.Drawing.Point(85, 108);
            this.checkBoxStatus.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.Size = new System.Drawing.Size(70, 21);
            this.checkBoxStatus.TabIndex = 13;
            this.checkBoxStatus.Text = "Status";
            this.checkBoxStatus.UseVisualStyleBackColor = false;
            this.checkBoxStatus.CheckedChanged += new System.EventHandler(this.checkBoxGenre_CheckedChanged);
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBoxName.Location = new System.Drawing.Point(85, 145);
            this.checkBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(67, 21);
            this.checkBoxName.TabIndex = 14;
            this.checkBoxName.Text = "Name";
            this.checkBoxName.UseVisualStyleBackColor = false;
            this.checkBoxName.CheckedChanged += new System.EventHandler(this.checkBoxYear_CheckedChanged);
            // 
            // checkBoxSurname
            // 
            this.checkBoxSurname.AutoSize = true;
            this.checkBoxSurname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBoxSurname.Location = new System.Drawing.Point(85, 182);
            this.checkBoxSurname.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxSurname.Name = "checkBoxSurname";
            this.checkBoxSurname.Size = new System.Drawing.Size(87, 21);
            this.checkBoxSurname.TabIndex = 15;
            this.checkBoxSurname.Text = "Surname";
            this.checkBoxSurname.UseVisualStyleBackColor = false;
            this.checkBoxSurname.CheckedChanged += new System.EventHandler(this.checkBoxDirector_CheckedChanged);
            // 
            // checkBoxSchedule
            // 
            this.checkBoxSchedule.AutoSize = true;
            this.checkBoxSchedule.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBoxSchedule.Location = new System.Drawing.Point(85, 216);
            this.checkBoxSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxSchedule.Name = "checkBoxSchedule";
            this.checkBoxSchedule.Size = new System.Drawing.Size(89, 21);
            this.checkBoxSchedule.TabIndex = 16;
            this.checkBoxSchedule.Text = "Schedule";
            this.checkBoxSchedule.UseVisualStyleBackColor = false;
            this.checkBoxSchedule.CheckedChanged += new System.EventHandler(this.checkBoxCountry_CheckedChanged);
            // 
            // checkBoxCompetition
            // 
            this.checkBoxCompetition.AutoSize = true;
            this.checkBoxCompetition.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBoxCompetition.Location = new System.Drawing.Point(85, 252);
            this.checkBoxCompetition.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCompetition.Name = "checkBoxCompetition";
            this.checkBoxCompetition.Size = new System.Drawing.Size(104, 21);
            this.checkBoxCompetition.TabIndex = 17;
            this.checkBoxCompetition.Text = "Competition";
            this.checkBoxCompetition.UseVisualStyleBackColor = false;
            this.checkBoxCompetition.CheckedChanged += new System.EventHandler(this.checkBoxLanguage_CheckedChanged);
            // 
            // radioButtonDOM
            // 
            this.radioButtonDOM.AutoSize = true;
            this.radioButtonDOM.Location = new System.Drawing.Point(85, 324);
            this.radioButtonDOM.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDOM.Name = "radioButtonDOM";
            this.radioButtonDOM.Size = new System.Drawing.Size(61, 21);
            this.radioButtonDOM.TabIndex = 18;
            this.radioButtonDOM.TabStop = true;
            this.radioButtonDOM.Text = "DOM";
            this.radioButtonDOM.UseVisualStyleBackColor = true;
            // 
            // radioButtonSAX
            // 
            this.radioButtonSAX.AutoSize = true;
            this.radioButtonSAX.Location = new System.Drawing.Point(85, 364);
            this.radioButtonSAX.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonSAX.Name = "radioButtonSAX";
            this.radioButtonSAX.Size = new System.Drawing.Size(56, 21);
            this.radioButtonSAX.TabIndex = 19;
            this.radioButtonSAX.TabStop = true;
            this.radioButtonSAX.Text = "SAX";
            this.radioButtonSAX.UseVisualStyleBackColor = true;
            // 
            // radioButtonLINQ
            // 
            this.radioButtonLINQ.AutoSize = true;
            this.radioButtonLINQ.Location = new System.Drawing.Point(85, 401);
            this.radioButtonLINQ.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonLINQ.Name = "radioButtonLINQ";
            this.radioButtonLINQ.Size = new System.Drawing.Size(61, 21);
            this.radioButtonLINQ.TabIndex = 20;
            this.radioButtonLINQ.TabStop = true;
            this.radioButtonLINQ.Text = "LINQ";
            this.radioButtonLINQ.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.Location = new System.Drawing.Point(450, 59);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(573, 449);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(219, 295);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(155, 55);
            this.buttonSearch.TabIndex = 22;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonTransform
            // 
            this.buttonTransform.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTransform.Location = new System.Drawing.Point(235, 364);
            this.buttonTransform.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTransform.Name = "buttonTransform";
            this.buttonTransform.Size = new System.Drawing.Size(122, 39);
            this.buttonTransform.TabIndex = 23;
            this.buttonTransform.Text = "Transform";
            this.buttonTransform.UseVisualStyleBackColor = false;
            this.buttonTransform.Click += new System.EventHandler(this.buttonTransform_Click);
            // 
            // buttonOpenHTML
            // 
            this.buttonOpenHTML.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonOpenHTML.Location = new System.Drawing.Point(235, 414);
            this.buttonOpenHTML.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenHTML.Name = "buttonOpenHTML";
            this.buttonOpenHTML.Size = new System.Drawing.Size(122, 43);
            this.buttonOpenHTML.TabIndex = 24;
            this.buttonOpenHTML.Text = "Open HTML";
            this.buttonOpenHTML.UseVisualStyleBackColor = false;
            this.buttonOpenHTML.Click += new System.EventHandler(this.buttonOpenHTML_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonClear.Location = new System.Drawing.Point(62, 442);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(110, 45);
            this.buttonClear.TabIndex = 25;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1087, 26);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.toolStripSeparator,
            this.сохранитькакToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripMenuItem.Image")));
            this.открытьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.открытьToolStripMenuItem.Text = "&Открыть";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(200, 6);
            // 
            // сохранитькакToolStripMenuItem
            // 
            this.сохранитькакToolStripMenuItem.Name = "сохранитькакToolStripMenuItem";
            this.сохранитькакToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.сохранитькакToolStripMenuItem.Text = "Сохранить &как";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(200, 6);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.справкаToolStripMenuItem.Text = "Help";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(71, 6);
            // 
            // SportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 581);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonOpenHTML);
            this.Controls.Add(this.buttonTransform);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.radioButtonLINQ);
            this.Controls.Add(this.radioButtonSAX);
            this.Controls.Add(this.radioButtonDOM);
            this.Controls.Add(this.checkBoxCompetition);
            this.Controls.Add(this.checkBoxSchedule);
            this.Controls.Add(this.checkBoxSurname);
            this.Controls.Add(this.checkBoxName);
            this.Controls.Add(this.checkBoxStatus);
            this.Controls.Add(this.checkBoxSection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxConpetition);
            this.Controls.Add(this.comboBoxSchedule);
            this.Controls.Add(this.comboBoxSurname);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.comboBoxSection);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SportForm";
            this.Text = "Sport";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FilmsForm_FormClosing);
            this.Load += new System.EventHandler(this.Sport_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSection;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.ComboBox comboBoxSurname;
        private System.Windows.Forms.ComboBox comboBoxSchedule;
        private System.Windows.Forms.ComboBox comboBoxConpetition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxSection;
        private System.Windows.Forms.CheckBox checkBoxStatus;
        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.CheckBox checkBoxSurname;
        private System.Windows.Forms.CheckBox checkBoxSchedule;
        private System.Windows.Forms.CheckBox checkBoxCompetition;
        private System.Windows.Forms.RadioButton radioButtonDOM;
        private System.Windows.Forms.RadioButton radioButtonSAX;
        private System.Windows.Forms.RadioButton radioButtonLINQ;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonTransform;
        private System.Windows.Forms.Button buttonOpenHTML;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem сохранитькакToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}

