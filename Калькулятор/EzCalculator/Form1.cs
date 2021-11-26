using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                #region Variables
                double SumCredit = Convert.ToDouble(sumCredit.Text);
                double Percent = Convert.ToDouble(percent.Text);
                double NumberOfYears = Convert.ToDouble(numberOfYears.Text);
                #endregion

                double NumberOfMonth = (NumberOfYears * 12);
                double MonthlyFee = -1 * SumCredit * Percent / 100 / 12 * Math.Pow(1 + Percent / 100 / 12, NumberOfMonth) / (Math.Pow(1 + Percent / 100 / 12, NumberOfMonth) - 1);
                double TotalPayment = MonthlyFee * NumberOfMonth;
                double LoanOverpayment = TotalPayment + SumCredit;
                double LoanBalance = SumCredit;


                numberOfMonth.Text = "" + Math.Round(NumberOfMonth, 2);
                monthlyFee.Text = "" + Math.Round(MonthlyFee, 2) + " руб.";
                totalPayment.Text = "" + Math.Round(TotalPayment, 2) + " руб.";
                loanOverpayment.Text = "" + Math.Round(LoanOverpayment, 2) + " руб.";



                for (int MonthOfPayment = 1; MonthOfPayment <= NumberOfMonth; MonthOfPayment++)
                {
                    double LoanRepayment = MonthlyFee * Math.Pow(1 + Percent / 100 / 12, MonthOfPayment - NumberOfMonth - 1);
                    double InterestPayment = MonthlyFee * (1 - Math.Pow(1 + Percent / 100 / 12, MonthOfPayment - NumberOfMonth - 1));
                    LoanBalance += LoanRepayment;

                    #region Заполнение таблицы
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[MonthOfPayment - 1].Cells[0].Value = MonthOfPayment;
                    dataGridView1.Rows[MonthOfPayment - 1].Cells[1].Value = Math.Round(LoanRepayment, 2);
                    dataGridView1.Rows[MonthOfPayment - 1].Cells[2].Value = Math.Round(InterestPayment, 2);
                    dataGridView1.Rows[MonthOfPayment - 1].Cells[3].Value = Math.Round(LoanRepayment + InterestPayment, 2);
                    dataGridView1.Rows[MonthOfPayment - 1].Cells[4].Value = Math.Round(LoanBalance, 2);
                    #endregion
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                monthlyFee.BackColor = Color.Coral;
                totalPayment.BackColor = Color.Coral;
                loanOverpayment.BackColor = Color.Coral;
            }
        }
    }
}
