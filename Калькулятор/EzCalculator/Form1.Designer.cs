
namespace EzCalculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sumCredit = new System.Windows.Forms.TextBox();
            this.percent = new System.Windows.Forms.TextBox();
            this.numberOfYears = new System.Windows.Forms.TextBox();
            this.numberOfMonth = new System.Windows.Forms.TextBox();
            this.monthlyFee = new System.Windows.Forms.TextBox();
            this.totalPayment = new System.Windows.Forms.TextBox();
            this.loanOverpayment = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Procents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NeedToPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сумма кредита";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Процентная ставка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Срок (в годах)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(11, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Срок в месяцах";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(11, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Выплата в месяц";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(11, 431);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Сумма переплаты";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(11, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Общая сумма выплат ";
            // 
            // sumCredit
            // 
            this.sumCredit.Location = new System.Drawing.Point(12, 37);
            this.sumCredit.Name = "sumCredit";
            this.sumCredit.Size = new System.Drawing.Size(173, 20);
            this.sumCredit.TabIndex = 2;
            // 
            // percent
            // 
            this.percent.Location = new System.Drawing.Point(12, 87);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(173, 20);
            this.percent.TabIndex = 3;
            // 
            // numberOfYears
            // 
            this.numberOfYears.Location = new System.Drawing.Point(12, 137);
            this.numberOfYears.Name = "numberOfYears";
            this.numberOfYears.Size = new System.Drawing.Size(173, 20);
            this.numberOfYears.TabIndex = 4;
            // 
            // numberOfMonth
            // 
            this.numberOfMonth.BackColor = System.Drawing.SystemColors.Control;
            this.numberOfMonth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numberOfMonth.Location = new System.Drawing.Point(11, 324);
            this.numberOfMonth.Name = "numberOfMonth";
            this.numberOfMonth.ReadOnly = true;
            this.numberOfMonth.Size = new System.Drawing.Size(173, 20);
            this.numberOfMonth.TabIndex = 4;
            // 
            // monthlyFee
            // 
            this.monthlyFee.ForeColor = System.Drawing.SystemColors.WindowText;
            this.monthlyFee.Location = new System.Drawing.Point(11, 366);
            this.monthlyFee.Name = "monthlyFee";
            this.monthlyFee.ReadOnly = true;
            this.monthlyFee.Size = new System.Drawing.Size(173, 20);
            this.monthlyFee.TabIndex = 4;
            // 
            // totalPayment
            // 
            this.totalPayment.Location = new System.Drawing.Point(11, 408);
            this.totalPayment.Name = "totalPayment";
            this.totalPayment.ReadOnly = true;
            this.totalPayment.Size = new System.Drawing.Size(173, 20);
            this.totalPayment.TabIndex = 4;
            // 
            // loanOverpayment
            // 
            this.loanOverpayment.ForeColor = System.Drawing.SystemColors.WindowText;
            this.loanOverpayment.Location = new System.Drawing.Point(11, 450);
            this.loanOverpayment.Name = "loanOverpayment";
            this.loanOverpayment.ReadOnly = true;
            this.loanOverpayment.Size = new System.Drawing.Size(173, 20);
            this.loanOverpayment.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(11, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Period,
            this.Payment,
            this.Procents,
            this.AllPayment,
            this.NeedToPay});
            this.dataGridView1.Location = new System.Drawing.Point(219, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(459, 466);
            this.dataGridView1.TabIndex = 6;
            // 
            // Period
            // 
            this.Period.HeaderText = "Период";
            this.Period.Name = "Period";
            this.Period.ReadOnly = true;
            // 
            // Payment
            // 
            this.Payment.HeaderText = "Выплата кредита";
            this.Payment.Name = "Payment";
            this.Payment.ReadOnly = true;
            // 
            // Procents
            // 
            this.Procents.HeaderText = "Выплата процентов";
            this.Procents.Name = "Procents";
            this.Procents.ReadOnly = true;
            // 
            // AllPayment
            // 
            this.AllPayment.HeaderText = "Общая выплата";
            this.AllPayment.Name = "AllPayment";
            this.AllPayment.ReadOnly = true;
            // 
            // NeedToPay
            // 
            this.NeedToPay.HeaderText = "Осталось выплатить";
            this.NeedToPay.Name = "NeedToPay";
            this.NeedToPay.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(216, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Расчет выплат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 524);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loanOverpayment);
            this.Controls.Add(this.totalPayment);
            this.Controls.Add(this.monthlyFee);
            this.Controls.Add(this.numberOfMonth);
            this.Controls.Add(this.numberOfYears);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.sumCredit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Простой кредитный калькулятор";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox sumCredit;
        private System.Windows.Forms.TextBox percent;
        private System.Windows.Forms.TextBox numberOfYears;
        private System.Windows.Forms.TextBox numberOfMonth;
        private System.Windows.Forms.TextBox monthlyFee;
        private System.Windows.Forms.TextBox totalPayment;
        private System.Windows.Forms.TextBox loanOverpayment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Period;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Procents;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn NeedToPay;
        private System.Windows.Forms.Label label1;
    }
}

