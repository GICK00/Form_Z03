
namespace Form_Z03
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxExample = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonExample = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Методы ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите число, если оно будет четное то уменьшется в \r\nдва раза, если же оно не ч" +
    "етное то заменится на 0.";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(15, 79);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(59, 20);
            this.textBoxN.TabIndex = 2;
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult.Location = new System.Drawing.Point(12, 135);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(288, 51);
            this.textBoxResult.TabIndex = 3;
            // 
            // textBoxExample
            // 
            this.textBoxExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxExample.Location = new System.Drawing.Point(309, 57);
            this.textBoxExample.Multiline = true;
            this.textBoxExample.Name = "textBoxExample";
            this.textBoxExample.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxExample.Size = new System.Drawing.Size(163, 209);
            this.textBoxExample.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пример работы \r\nметода в цикле";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Утин Д. С.";
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(95, 77);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(75, 23);
            this.buttonResult.TabIndex = 7;
            this.buttonResult.Text = "Ответ";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonExample
            // 
            this.buttonExample.Location = new System.Drawing.Point(189, 77);
            this.buttonExample.Name = "buttonExample";
            this.buttonExample.Size = new System.Drawing.Size(75, 23);
            this.buttonExample.TabIndex = 8;
            this.buttonExample.Text = "Пример";
            this.buttonExample.UseVisualStyleBackColor = true;
            this.buttonExample.Click += new System.EventHandler(this.buttonExample_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(189, 106);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Очистить ";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(484, 275);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonExample);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxExample);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form Z03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxExample;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonExample;
        private System.Windows.Forms.Button buttonClear;
    }
}

