
namespace Workers
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
            this.ageChoicer = new System.Windows.Forms.NumericUpDown();
            this.info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ageChoicer)).BeginInit();
            this.SuspendLayout();
            // 
            // ageChoicer
            // 
            this.ageChoicer.Location = new System.Drawing.Point(12, 12);
            this.ageChoicer.Name = "ageChoicer";
            this.ageChoicer.Size = new System.Drawing.Size(120, 20);
            this.ageChoicer.TabIndex = 0;
            this.ageChoicer.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.ageChoicer.ValueChanged += new System.EventHandler(this.ageChoicer_ValueChanged);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info.Location = new System.Drawing.Point(12, 52);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(111, 25);
            this.info.TabIndex = 1;
            this.info.Text = "Работники";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.info);
            this.Controls.Add(this.ageChoicer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ageChoicer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ageChoicer;
        private System.Windows.Forms.Label info;
    }
}

