
namespace Recipes
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
            this.add_Dish = new System.Windows.Forms.Button();
            this.textRecept = new System.Windows.Forms.TextBox();
            this.textNameDish = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_NameProd = new System.Windows.Forms.Label();
            this.label_CountProd = new System.Windows.Forms.Label();
            this.textBox_countPRod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Dimensh = new System.Windows.Forms.TextBox();
            this.textBox_NameProd = new System.Windows.Forms.TextBox();
            this.listBox_ListDishs = new System.Windows.Forms.ListBox();
            this.btn_ShowList = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_ReceptShow = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_Dish
            // 
            this.add_Dish.Location = new System.Drawing.Point(18, 227);
            this.add_Dish.Name = "add_Dish";
            this.add_Dish.Size = new System.Drawing.Size(179, 23);
            this.add_Dish.TabIndex = 0;
            this.add_Dish.Text = "Добавить рецепт блюда";
            this.add_Dish.UseVisualStyleBackColor = true;
            this.add_Dish.Click += new System.EventHandler(this.Add_Dish_Click);
            // 
            // textRecept
            // 
            this.textRecept.Location = new System.Drawing.Point(15, 35);
            this.textRecept.Multiline = true;
            this.textRecept.Name = "textRecept";
            this.textRecept.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textRecept.Size = new System.Drawing.Size(262, 92);
            this.textRecept.TabIndex = 1;
            this.textRecept.Text = "Рецепт";
            // 
            // textNameDish
            // 
            this.textNameDish.Location = new System.Drawing.Point(75, 9);
            this.textNameDish.Name = "textNameDish";
            this.textNameDish.Size = new System.Drawing.Size(202, 20);
            this.textNameDish.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_NameProd
            // 
            this.label_NameProd.AutoSize = true;
            this.label_NameProd.Location = new System.Drawing.Point(12, 133);
            this.label_NameProd.Name = "label_NameProd";
            this.label_NameProd.Size = new System.Drawing.Size(79, 13);
            this.label_NameProd.TabIndex = 6;
            this.label_NameProd.Text = "Наз. продукта";
            // 
            // label_CountProd
            // 
            this.label_CountProd.AutoSize = true;
            this.label_CountProd.Location = new System.Drawing.Point(12, 161);
            this.label_CountProd.Name = "label_CountProd";
            this.label_CountProd.Size = new System.Drawing.Size(41, 13);
            this.label_CountProd.TabIndex = 7;
            this.label_CountProd.Text = "Кол-во";
            // 
            // textBox_countPRod
            // 
            this.textBox_countPRod.Location = new System.Drawing.Point(97, 158);
            this.textBox_countPRod.Name = "textBox_countPRod";
            this.textBox_countPRod.Size = new System.Drawing.Size(100, 20);
            this.textBox_countPRod.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Измерение";
            // 
            // textBox_Dimensh
            // 
            this.textBox_Dimensh.Location = new System.Drawing.Point(97, 187);
            this.textBox_Dimensh.Name = "textBox_Dimensh";
            this.textBox_Dimensh.Size = new System.Drawing.Size(100, 20);
            this.textBox_Dimensh.TabIndex = 10;
            // 
            // textBox_NameProd
            // 
            this.textBox_NameProd.Location = new System.Drawing.Point(97, 133);
            this.textBox_NameProd.Name = "textBox_NameProd";
            this.textBox_NameProd.Size = new System.Drawing.Size(100, 20);
            this.textBox_NameProd.TabIndex = 11;
            // 
            // listBox_ListDishs
            // 
            this.listBox_ListDishs.FormattingEnabled = true;
            this.listBox_ListDishs.Location = new System.Drawing.Point(283, 12);
            this.listBox_ListDishs.Name = "listBox_ListDishs";
            this.listBox_ListDishs.Size = new System.Drawing.Size(179, 134);
            this.listBox_ListDishs.TabIndex = 12;
            // 
            // btn_ShowList
            // 
            this.btn_ShowList.Location = new System.Drawing.Point(468, 12);
            this.btn_ShowList.Name = "btn_ShowList";
            this.btn_ShowList.Size = new System.Drawing.Size(120, 29);
            this.btn_ShowList.TabIndex = 13;
            this.btn_ShowList.Text = "Показать список";
            this.btn_ShowList.UseVisualStyleBackColor = true;
            this.btn_ShowList.Click += new System.EventHandler(this.Btn_ShowList_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Показать рецепт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Btn_ShowRecept_Click);
            // 
            // textBox_ReceptShow
            // 
            this.textBox_ReceptShow.Location = new System.Drawing.Point(283, 158);
            this.textBox_ReceptShow.Multiline = true;
            this.textBox_ReceptShow.Name = "textBox_ReceptShow";
            this.textBox_ReceptShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ReceptShow.Size = new System.Drawing.Size(305, 92);
            this.textBox_ReceptShow.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(468, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 29);
            this.button3.TabIndex = 17;
            this.button3.Text = "Очистить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(468, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 29);
            this.button2.TabIndex = 18;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Btn_Remove_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox_ReceptShow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ShowList);
            this.Controls.Add(this.listBox_ListDishs);
            this.Controls.Add(this.textBox_NameProd);
            this.Controls.Add(this.textBox_Dimensh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_countPRod);
            this.Controls.Add(this.label_CountProd);
            this.Controls.Add(this.label_NameProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNameDish);
            this.Controls.Add(this.textRecept);
            this.Controls.Add(this.add_Dish);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Recipes";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        
        private System.Windows.Forms.Button add_Dish;
        private System.Windows.Forms.TextBox textRecept;
        private System.Windows.Forms.TextBox textNameDish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_NameProd;
        private System.Windows.Forms.Label label_CountProd;
        private System.Windows.Forms.TextBox textBox_countPRod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Dimensh;
        private System.Windows.Forms.TextBox textBox_NameProd;
        private System.Windows.Forms.ListBox listBox_ListDishs;
        private System.Windows.Forms.Button btn_ShowList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_ReceptShow;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

