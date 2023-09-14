
namespace WindowsFormsApp2
{
    partial class MDIParent1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.save2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.окнаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новоеОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каскадомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.слеваНаправоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сверхуВнизToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.упорядочитьЗначкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дополнительноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.масштабирование1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.масштабирование2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изначальныйВидToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пероToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.линияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кругToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.звездаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ластикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SizeTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.ColorLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.окнаToolStripMenuItem,
            this.дополнительноToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.рисованиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.отрытьToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.save2ToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newToolStripMenuItem.Text = "Создать";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // отрытьToolStripMenuItem
            // 
            this.отрытьToolStripMenuItem.Name = "отрытьToolStripMenuItem";
            this.отрытьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.отрытьToolStripMenuItem.Text = "Открыть";
            this.отрытьToolStripMenuItem.Click += new System.EventHandler(this.отрытьToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // save2ToolStripMenuItem
            // 
            this.save2ToolStripMenuItem.Name = "save2ToolStripMenuItem";
            this.save2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.save2ToolStripMenuItem.Text = "Сохранить как";
            this.save2ToolStripMenuItem.Click += new System.EventHandler(this.save2ToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // окнаToolStripMenuItem
            // 
            this.окнаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новоеОкноToolStripMenuItem,
            this.каскадомToolStripMenuItem,
            this.слеваНаправоToolStripMenuItem,
            this.сверхуВнизToolStripMenuItem,
            this.упорядочитьЗначкиToolStripMenuItem,
            this.закрытьВсеToolStripMenuItem});
            this.окнаToolStripMenuItem.Name = "окнаToolStripMenuItem";
            this.окнаToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.окнаToolStripMenuItem.Text = "Окна";
            // 
            // новоеОкноToolStripMenuItem
            // 
            this.новоеОкноToolStripMenuItem.Name = "новоеОкноToolStripMenuItem";
            this.новоеОкноToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.новоеОкноToolStripMenuItem.Text = "Новое окно";
            // 
            // каскадомToolStripMenuItem
            // 
            this.каскадомToolStripMenuItem.Name = "каскадомToolStripMenuItem";
            this.каскадомToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.каскадомToolStripMenuItem.Text = "Каскадом";
            this.каскадомToolStripMenuItem.Click += new System.EventHandler(this.каскадомToolStripMenuItem_Click);
            // 
            // слеваНаправоToolStripMenuItem
            // 
            this.слеваНаправоToolStripMenuItem.Name = "слеваНаправоToolStripMenuItem";
            this.слеваНаправоToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.слеваНаправоToolStripMenuItem.Text = "Слева направо";
            this.слеваНаправоToolStripMenuItem.Click += new System.EventHandler(this.слеваНаправоToolStripMenuItem_Click);
            // 
            // сверхуВнизToolStripMenuItem
            // 
            this.сверхуВнизToolStripMenuItem.Name = "сверхуВнизToolStripMenuItem";
            this.сверхуВнизToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.сверхуВнизToolStripMenuItem.Text = "Сверху вниз";
            this.сверхуВнизToolStripMenuItem.Click += new System.EventHandler(this.сверхуВнизToolStripMenuItem_Click);
            // 
            // упорядочитьЗначкиToolStripMenuItem
            // 
            this.упорядочитьЗначкиToolStripMenuItem.Name = "упорядочитьЗначкиToolStripMenuItem";
            this.упорядочитьЗначкиToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.упорядочитьЗначкиToolStripMenuItem.Text = "Упорядочить значки";
            this.упорядочитьЗначкиToolStripMenuItem.Click += new System.EventHandler(this.упорядочитьЗначкиToolStripMenuItem_Click);
            // 
            // закрытьВсеToolStripMenuItem
            // 
            this.закрытьВсеToolStripMenuItem.Name = "закрытьВсеToolStripMenuItem";
            this.закрытьВсеToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.закрытьВсеToolStripMenuItem.Text = "Закрыть все";
            this.закрытьВсеToolStripMenuItem.Click += new System.EventHandler(this.закрытьВсеToolStripMenuItem_Click);
            // 
            // дополнительноToolStripMenuItem
            // 
            this.дополнительноToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.масштабирование1ToolStripMenuItem,
            this.масштабирование2ToolStripMenuItem1,
            this.изначальныйВидToolStripMenuItem});
            this.дополнительноToolStripMenuItem.Name = "дополнительноToolStripMenuItem";
            this.дополнительноToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.дополнительноToolStripMenuItem.Text = "Дополнительно";
            // 
            // масштабирование1ToolStripMenuItem
            // 
            this.масштабирование1ToolStripMenuItem.Name = "масштабирование1ToolStripMenuItem";
            this.масштабирование1ToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.масштабирование1ToolStripMenuItem.Text = "Масштабирование +";
            this.масштабирование1ToolStripMenuItem.Click += new System.EventHandler(this.масштабирование1ToolStripMenuItem_Click);
            // 
            // масштабирование2ToolStripMenuItem1
            // 
            this.масштабирование2ToolStripMenuItem1.Name = "масштабирование2ToolStripMenuItem1";
            this.масштабирование2ToolStripMenuItem1.Size = new System.Drawing.Size(238, 26);
            this.масштабирование2ToolStripMenuItem1.Text = "Масштабирование -";
            this.масштабирование2ToolStripMenuItem1.Click += new System.EventHandler(this.масштабирование2ToolStripMenuItem1_Click);
            // 
            // изначальныйВидToolStripMenuItem
            // 
            this.изначальныйВидToolStripMenuItem.Name = "изначальныйВидToolStripMenuItem";
            this.изначальныйВидToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.изначальныйВидToolStripMenuItem.Text = "Изначальный вид";
            this.изначальныйВидToolStripMenuItem.Click += new System.EventHandler(this.изначальныйВидToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // рисованиеToolStripMenuItem
            // 
            this.рисованиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пероToolStripMenuItem,
            this.линияToolStripMenuItem,
            this.кругToolStripMenuItem,
            this.звездаToolStripMenuItem,
            this.ластикToolStripMenuItem});
            this.рисованиеToolStripMenuItem.Name = "рисованиеToolStripMenuItem";
            this.рисованиеToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.рисованиеToolStripMenuItem.Text = "Рисование";
            // 
            // пероToolStripMenuItem
            // 
            this.пероToolStripMenuItem.Name = "пероToolStripMenuItem";
            this.пероToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.пероToolStripMenuItem.Text = "Перо";
            this.пероToolStripMenuItem.Click += new System.EventHandler(this.пероToolStripMenuItem_Click);
            // 
            // линияToolStripMenuItem
            // 
            this.линияToolStripMenuItem.Name = "линияToolStripMenuItem";
            this.линияToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.линияToolStripMenuItem.Text = "Линия";
            this.линияToolStripMenuItem.Click += new System.EventHandler(this.линияToolStripMenuItem_Click);
            // 
            // кругToolStripMenuItem
            // 
            this.кругToolStripMenuItem.Name = "кругToolStripMenuItem";
            this.кругToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.кругToolStripMenuItem.Text = "Круг";
            this.кругToolStripMenuItem.Click += new System.EventHandler(this.кругToolStripMenuItem_Click);
            // 
            // звездаToolStripMenuItem
            // 
            this.звездаToolStripMenuItem.Name = "звездаToolStripMenuItem";
            this.звездаToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.звездаToolStripMenuItem.Text = "Звезда";
            this.звездаToolStripMenuItem.Click += new System.EventHandler(this.звездаToolStripMenuItem_Click);
            // 
            // ластикToolStripMenuItem
            // 
            this.ластикToolStripMenuItem.Name = "ластикToolStripMenuItem";
            this.ластикToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.ластикToolStripMenuItem.Text = "Ластик";
            this.ластикToolStripMenuItem.Click += new System.EventHandler(this.ластикToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.SizeTextBox,
            this.ColorLabel,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.Size = new System.Drawing.Size(100, 27);
            this.SizeTextBox.Text = "1";
            this.SizeTextBox.Click += new System.EventHandler(this.SizeTextBox_Click);
            // 
            // ColorLabel
            // 
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(42, 24);
            this.ColorLabel.Text = "Цвет";
            this.ColorLabel.Click += new System.EventHandler(this.ColorLabel_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIParent1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDIParent1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MDIParent1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem save2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem окнаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новоеОкноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem каскадомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem слеваНаправоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сверхуВнизToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem упорядочитьЗначкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дополнительноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem масштабирование1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem масштабирование2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem изначальныйВидToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox SizeTextBox;
        private System.Windows.Forms.ToolStripLabel ColorLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem рисованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пероToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem линияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кругToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem звездаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ластикToolStripMenuItem;
    }
}

