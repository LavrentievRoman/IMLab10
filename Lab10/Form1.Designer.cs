namespace Lab10
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
            this.label1 = new System.Windows.Forms.Label();
            this.lamb1Num = new System.Windows.Forms.NumericUpDown();
            this.lamb2Num = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lamb1Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lamb2Num)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Среднее количестов забитых мячей 1 команды";
            // 
            // lamb1Num
            // 
            this.lamb1Num.DecimalPlaces = 1;
            this.lamb1Num.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.lamb1Num.Location = new System.Drawing.Point(82, 44);
            this.lamb1Num.Name = "lamb1Num";
            this.lamb1Num.Size = new System.Drawing.Size(120, 20);
            this.lamb1Num.TabIndex = 1;
            this.lamb1Num.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // lamb2Num
            // 
            this.lamb2Num.DecimalPlaces = 1;
            this.lamb2Num.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.lamb2Num.Location = new System.Drawing.Point(82, 103);
            this.lamb2Num.Name = "lamb2Num";
            this.lamb2Num.Size = new System.Drawing.Size(120, 20);
            this.lamb2Num.TabIndex = 3;
            this.lamb2Num.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Среднее количестов забитых мячей 2 команды";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(40, 135);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(219, 18);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "Победила первая команда";
            this.resultLabel.Visible = false;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(156, 168);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 26);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Начать";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 215);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.lamb2Num);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lamb1Num);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.lamb1Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lamb2Num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown lamb1Num;
        private System.Windows.Forms.NumericUpDown lamb2Num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button startButton;
    }
}

