
namespace GuessNumber
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
            this.btnGame = new System.Windows.Forms.Button();
            this.txtBxAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGame
            // 
            this.btnGame.Location = new System.Drawing.Point(12, 29);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(75, 23);
            this.btnGame.TabIndex = 0;
            this.btnGame.Text = "Играть";
            this.btnGame.UseVisualStyleBackColor = true;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // txtBxAnswer
            // 
            this.txtBxAnswer.Location = new System.Drawing.Point(12, 58);
            this.txtBxAnswer.Name = "txtBxAnswer";
            this.txtBxAnswer.Size = new System.Drawing.Size(100, 20);
            this.txtBxAnswer.TabIndex = 1;
            this.txtBxAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxAnswer_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Нажмите кнопку \"Играть\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 98);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxAnswer);
            this.Controls.Add(this.btnGame);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Угадай число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.TextBox txtBxAnswer;
        private System.Windows.Forms.Label label1;
    }
}

