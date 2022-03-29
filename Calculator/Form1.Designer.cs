
namespace Calculator
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
            this.FirstNumTxtBox = new System.Windows.Forms.TextBox();
            this.ResultTxtBox = new System.Windows.Forms.TextBox();
            this.SumBtn = new System.Windows.Forms.Button();
            this.SubBtn = new System.Windows.Forms.Button();
            this.MultiplyBtn = new System.Windows.Forms.Button();
            this.DivBtn = new System.Windows.Forms.Button();
            this.ExtendedBtn = new System.Windows.Forms.Button();
            this.SinBtn = new System.Windows.Forms.Button();
            this.CosBtn = new System.Windows.Forms.Button();
            this.TanBtn = new System.Windows.Forms.Button();
            this.CtgBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNumTxtBox
            // 
            this.FirstNumTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNumTxtBox.Location = new System.Drawing.Point(12, 41);
            this.FirstNumTxtBox.Multiline = true;
            this.FirstNumTxtBox.Name = "FirstNumTxtBox";
            this.FirstNumTxtBox.Size = new System.Drawing.Size(77, 28);
            this.FirstNumTxtBox.TabIndex = 0;
            this.FirstNumTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FirstNumTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstNumTxtBox_KeyPress);
            // 
            // ResultTxtBox
            // 
            this.ResultTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultTxtBox.Location = new System.Drawing.Point(109, 41);
            this.ResultTxtBox.Multiline = true;
            this.ResultTxtBox.Name = "ResultTxtBox";
            this.ResultTxtBox.ReadOnly = true;
            this.ResultTxtBox.Size = new System.Drawing.Size(111, 28);
            this.ResultTxtBox.TabIndex = 1;
            this.ResultTxtBox.Text = "0";
            this.ResultTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SumBtn
            // 
            this.SumBtn.Location = new System.Drawing.Point(14, 102);
            this.SumBtn.Name = "SumBtn";
            this.SumBtn.Size = new System.Drawing.Size(75, 23);
            this.SumBtn.TabIndex = 2;
            this.SumBtn.Text = "Сложить";
            this.SumBtn.UseVisualStyleBackColor = true;
            this.SumBtn.Click += new System.EventHandler(this.SumBtn_Click);
            // 
            // SubBtn
            // 
            this.SubBtn.Location = new System.Drawing.Point(14, 131);
            this.SubBtn.Name = "SubBtn";
            this.SubBtn.Size = new System.Drawing.Size(75, 23);
            this.SubBtn.TabIndex = 3;
            this.SubBtn.Text = "Вычесть";
            this.SubBtn.UseVisualStyleBackColor = true;
            this.SubBtn.Click += new System.EventHandler(this.SubBtn_Click);
            // 
            // MultiplyBtn
            // 
            this.MultiplyBtn.Location = new System.Drawing.Point(95, 102);
            this.MultiplyBtn.Name = "MultiplyBtn";
            this.MultiplyBtn.Size = new System.Drawing.Size(75, 23);
            this.MultiplyBtn.TabIndex = 4;
            this.MultiplyBtn.Text = "Умножить";
            this.MultiplyBtn.UseVisualStyleBackColor = true;
            this.MultiplyBtn.Click += new System.EventHandler(this.MultiplyBtn_Click);
            // 
            // DivBtn
            // 
            this.DivBtn.Location = new System.Drawing.Point(95, 131);
            this.DivBtn.Name = "DivBtn";
            this.DivBtn.Size = new System.Drawing.Size(75, 23);
            this.DivBtn.TabIndex = 5;
            this.DivBtn.Text = "Делить";
            this.DivBtn.UseVisualStyleBackColor = true;
            this.DivBtn.Click += new System.EventHandler(this.DivBtn_Click);
            // 
            // ExtendedBtn
            // 
            this.ExtendedBtn.Location = new System.Drawing.Point(242, 41);
            this.ExtendedBtn.Name = "ExtendedBtn";
            this.ExtendedBtn.Size = new System.Drawing.Size(156, 28);
            this.ExtendedBtn.TabIndex = 6;
            this.ExtendedBtn.Text = "Расширенный режим";
            this.ExtendedBtn.UseVisualStyleBackColor = true;
            this.ExtendedBtn.Click += new System.EventHandler(this.ExtendedBtn_Click);
            // 
            // SinBtn
            // 
            this.SinBtn.Location = new System.Drawing.Point(242, 102);
            this.SinBtn.Name = "SinBtn";
            this.SinBtn.Size = new System.Drawing.Size(75, 23);
            this.SinBtn.TabIndex = 7;
            this.SinBtn.Text = "Sin";
            this.SinBtn.UseVisualStyleBackColor = true;
            this.SinBtn.Visible = false;
            this.SinBtn.Click += new System.EventHandler(this.SinBtn_Click);
            // 
            // CosBtn
            // 
            this.CosBtn.Location = new System.Drawing.Point(323, 102);
            this.CosBtn.Name = "CosBtn";
            this.CosBtn.Size = new System.Drawing.Size(75, 23);
            this.CosBtn.TabIndex = 8;
            this.CosBtn.Text = "Cos";
            this.CosBtn.UseVisualStyleBackColor = true;
            this.CosBtn.Visible = false;
            // 
            // TanBtn
            // 
            this.TanBtn.Location = new System.Drawing.Point(242, 131);
            this.TanBtn.Name = "TanBtn";
            this.TanBtn.Size = new System.Drawing.Size(75, 23);
            this.TanBtn.TabIndex = 9;
            this.TanBtn.Text = "Tan";
            this.TanBtn.UseVisualStyleBackColor = true;
            this.TanBtn.Visible = false;
            // 
            // CtgBtn
            // 
            this.CtgBtn.Location = new System.Drawing.Point(323, 131);
            this.CtgBtn.Name = "CtgBtn";
            this.CtgBtn.Size = new System.Drawing.Size(75, 23);
            this.CtgBtn.TabIndex = 10;
            this.CtgBtn.Text = "Ctg";
            this.CtgBtn.UseVisualStyleBackColor = true;
            this.CtgBtn.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 184);
            this.Controls.Add(this.CtgBtn);
            this.Controls.Add(this.TanBtn);
            this.Controls.Add(this.CosBtn);
            this.Controls.Add(this.SinBtn);
            this.Controls.Add(this.ExtendedBtn);
            this.Controls.Add(this.DivBtn);
            this.Controls.Add(this.MultiplyBtn);
            this.Controls.Add(this.SubBtn);
            this.Controls.Add(this.SumBtn);
            this.Controls.Add(this.ResultTxtBox);
            this.Controls.Add(this.FirstNumTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNumTxtBox;
        private System.Windows.Forms.TextBox ResultTxtBox;
        private System.Windows.Forms.Button SumBtn;
        private System.Windows.Forms.Button SubBtn;
        private System.Windows.Forms.Button MultiplyBtn;
        private System.Windows.Forms.Button DivBtn;
        private System.Windows.Forms.Button ExtendedBtn;
        private System.Windows.Forms.Button SinBtn;
        private System.Windows.Forms.Button CosBtn;
        private System.Windows.Forms.Button TanBtn;
        private System.Windows.Forms.Button CtgBtn;
    }
}

