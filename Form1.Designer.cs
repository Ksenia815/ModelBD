
namespace ModelBD
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Addbd = new System.Windows.Forms.Button();
            this.deletebd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(601, 361);
            this.dataGridView1.TabIndex = 0;
            // 
            // Addbd
            // 
            this.Addbd.Location = new System.Drawing.Point(12, 378);
            this.Addbd.Name = "Addbd";
            this.Addbd.Size = new System.Drawing.Size(172, 58);
            this.Addbd.TabIndex = 1;
            this.Addbd.Text = "Добавить";
            this.Addbd.UseVisualStyleBackColor = true;
            this.Addbd.Click += new System.EventHandler(this.Addbd_Click);
            // 
            // deletebd
            // 
            this.deletebd.Location = new System.Drawing.Point(190, 378);
            this.deletebd.Name = "deletebd";
            this.deletebd.Size = new System.Drawing.Size(178, 58);
            this.deletebd.TabIndex = 2;
            this.deletebd.Text = "Удалить";
            this.deletebd.UseVisualStyleBackColor = true;
            this.deletebd.Click += new System.EventHandler(this.deletebd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deletebd);
            this.Controls.Add(this.Addbd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Addbd;
        private System.Windows.Forms.Button deletebd;
        private System.Windows.Forms.Button button1;
    }
}

