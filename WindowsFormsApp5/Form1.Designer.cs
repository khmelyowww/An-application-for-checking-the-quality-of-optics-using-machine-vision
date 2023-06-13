
namespace WindowsFormsApp5
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelPB = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_pixelSize = new System.Windows.Forms.TextBox();
            this.textBox_sizeOsnDel = new System.Windows.Forms.TextBox();
            this.comboBox_valueView = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_theme = new System.Windows.Forms.ComboBox();
            this.buttonSFD = new System.Windows.Forms.Button();
            this.checkBox_blockDetected = new System.Windows.Forms.CheckBox();
            this.panelPB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Запустить камеру";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 25);
            this.button2.TabIndex = 3;
            this.button2.Text = "Загрузить изображение";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonUpld_Click);
            // 
            // panelPB
            // 
            this.panelPB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPB.BackColor = System.Drawing.Color.LightGray;
            this.panelPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPB.Controls.Add(this.pictureBox);
            this.panelPB.Location = new System.Drawing.Point(178, 5);
            this.panelPB.Name = "panelPB";
            this.panelPB.Size = new System.Drawing.Size(846, 627);
            this.panelPB.TabIndex = 4;
            this.panelPB.Resize += new System.EventHandler(this.panelPB_Resize);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(8, 8);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(825, 610);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            this.pictureBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pictureBox_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Размер пикселя:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Размер осн. делений:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ед. отображения:";
            // 
            // textBox_pixelSize
            // 
            this.textBox_pixelSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_pixelSize.Location = new System.Drawing.Point(12, 417);
            this.textBox_pixelSize.Name = "textBox_pixelSize";
            this.textBox_pixelSize.Size = new System.Drawing.Size(160, 20);
            this.textBox_pixelSize.TabIndex = 8;
            this.textBox_pixelSize.Text = "0,0088";
            this.textBox_pixelSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_pixelSize.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox_pixelSize_PreviewKeyDown);
            // 
            // textBox_sizeOsnDel
            // 
            this.textBox_sizeOsnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_sizeOsnDel.Location = new System.Drawing.Point(12, 482);
            this.textBox_sizeOsnDel.Name = "textBox_sizeOsnDel";
            this.textBox_sizeOsnDel.Size = new System.Drawing.Size(160, 20);
            this.textBox_sizeOsnDel.TabIndex = 9;
            this.textBox_sizeOsnDel.Text = "15";
            this.textBox_sizeOsnDel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_sizeOsnDel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox_sizeOsnDel_PreviewKeyDown);
            // 
            // comboBox_valueView
            // 
            this.comboBox_valueView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox_valueView.FormattingEnabled = true;
            this.comboBox_valueView.Items.AddRange(new object[] {
            "Мм",
            "См"});
            this.comboBox_valueView.Location = new System.Drawing.Point(12, 548);
            this.comboBox_valueView.Name = "comboBox_valueView";
            this.comboBox_valueView.Size = new System.Drawing.Size(160, 21);
            this.comboBox_valueView.TabIndex = 11;
            this.comboBox_valueView.SelectedIndexChanged += new System.EventHandler(this.comboBox_valueView_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 591);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Сменить тему:";
            // 
            // comboBox_theme
            // 
            this.comboBox_theme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox_theme.FormattingEnabled = true;
            this.comboBox_theme.Items.AddRange(new object[] {
            "Светлая",
            "Тёмная"});
            this.comboBox_theme.Location = new System.Drawing.Point(12, 610);
            this.comboBox_theme.Name = "comboBox_theme";
            this.comboBox_theme.Size = new System.Drawing.Size(160, 21);
            this.comboBox_theme.TabIndex = 13;
            this.comboBox_theme.SelectedIndexChanged += new System.EventHandler(this.comboBox_theme_SelectedIndexChanged);
            // 
            // buttonSFD
            // 
            this.buttonSFD.Location = new System.Drawing.Point(4, 67);
            this.buttonSFD.Name = "buttonSFD";
            this.buttonSFD.Size = new System.Drawing.Size(168, 25);
            this.buttonSFD.TabIndex = 14;
            this.buttonSFD.Text = "Сохранить изображение";
            this.buttonSFD.UseVisualStyleBackColor = true;
            this.buttonSFD.Click += new System.EventHandler(this.buttonSFD_Click);
            // 
            // checkBox_blockDetected
            // 
            this.checkBox_blockDetected.AutoSize = true;
            this.checkBox_blockDetected.Location = new System.Drawing.Point(4, 98);
            this.checkBox_blockDetected.Name = "checkBox_blockDetected";
            this.checkBox_blockDetected.Size = new System.Drawing.Size(147, 17);
            this.checkBox_blockDetected.TabIndex = 15;
            this.checkBox_blockDetected.Text = "Обнаружение дефектов";
            this.checkBox_blockDetected.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1036, 644);
            this.Controls.Add(this.checkBox_blockDetected);
            this.Controls.Add(this.buttonSFD);
            this.Controls.Add(this.comboBox_theme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_valueView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_sizeOsnDel);
            this.Controls.Add(this.textBox_pixelSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelPB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "НПЗ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelPB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelPB;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_pixelSize;
        private System.Windows.Forms.TextBox textBox_sizeOsnDel;
        private System.Windows.Forms.ComboBox comboBox_valueView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_theme;
        private System.Windows.Forms.Button buttonSFD;
        private System.Windows.Forms.CheckBox checkBox_blockDetected;
    }
}

