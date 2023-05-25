
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
            this.panelPB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Запустить камеру";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 23);
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
            this.panelPB.Controls.Add(this.pictureBox);
            this.panelPB.Location = new System.Drawing.Point(178, 5);
            this.panelPB.Name = "panelPB";
            this.panelPB.Size = new System.Drawing.Size(843, 627);
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
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Размер пикселя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Размер осн. делений";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ед. отображения";
            // 
            // textBox_pixelSize
            // 
            this.textBox_pixelSize.Location = new System.Drawing.Point(100, 86);
            this.textBox_pixelSize.Name = "textBox_pixelSize";
            this.textBox_pixelSize.Size = new System.Drawing.Size(74, 20);
            this.textBox_pixelSize.TabIndex = 8;
            this.textBox_pixelSize.Text = "0,0088";
            this.textBox_pixelSize.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox_pixelSize_PreviewKeyDown);
            // 
            // textBox_sizeOsnDel
            // 
            this.textBox_sizeOsnDel.Location = new System.Drawing.Point(124, 112);
            this.textBox_sizeOsnDel.Name = "textBox_sizeOsnDel";
            this.textBox_sizeOsnDel.Size = new System.Drawing.Size(50, 20);
            this.textBox_sizeOsnDel.TabIndex = 9;
            this.textBox_sizeOsnDel.Text = "15";
            this.textBox_sizeOsnDel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox_sizeOsnDel_PreviewKeyDown);
            // 
            // comboBox_valueView
            // 
            this.comboBox_valueView.FormattingEnabled = true;
            this.comboBox_valueView.Items.AddRange(new object[] {
            "См",
            "Мм"});
            this.comboBox_valueView.Location = new System.Drawing.Point(100, 141);
            this.comboBox_valueView.Name = "comboBox_valueView";
            this.comboBox_valueView.Size = new System.Drawing.Size(74, 21);
            this.comboBox_valueView.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 644);
            this.Controls.Add(this.comboBox_valueView);
            this.Controls.Add(this.textBox_sizeOsnDel);
            this.Controls.Add(this.textBox_pixelSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelPB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

