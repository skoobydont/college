using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan002
{
    public class Loan
    {
        private decimal mydecPrincipal = 0;
        public decimal Principal
        {
            get
            {
                return mydecPrincipal;
            }
            set
            {
                if (value >= 0)
                {
                    mydecPrincipal = value;
                }
            }
        }

        private decimal mydecMonthlyInterestRate = 0;
        public decimal APR
        {
            get
            {
                return mydecMonthlyInterestRate * 12;
            }
            set
            {
                if (value >= 0)
                {
                    if (value >= (decimal).25)
                    {
                        value = value / 100;
                    }
                    mydecMonthlyInterestRate = value / 12;
                }
            }
        }

        private int myintMonths = 1;
        public int Months
        {

            get
            {
                return myintMonths;
            }
            set
            {
                if (value > 0)
                {
                    myintMonths = value;
                }
            }
        }

        public int Years
        {
            set
            {
                if (value > 0)
                {
                    myintMonths = value * 12;
                }
            }
        }

        public decimal MonthlyPayment
        {
            get
            {
                double Bottom = Math.Pow((1 + (double)mydecMonthlyInterestRate), (double)myintMonths) - 1;

                return (mydecMonthlyInterestRate + (mydecMonthlyInterestRate / (decimal)Bottom)) * mydecPrincipal;

            }
        }

        public AmortizationSchedule Schedule
        {
            get
            {
                return new AmortizationSchedule(DateTime.Now, MonthlyPayment, myintMonths, mydecMonthlyInterestRate, mydecPrincipal);
            }
        }

    }


    public class AmortizationLine
    {
        public AmortizationLine(DateTime PaymentDate, decimal BeginningBalance, 
                                decimal Payment, decimal InterestRate)
        {
            mydtePaymentDate = PaymentDate;
            mydecInterestPayment = BeginningBalance * InterestRate;
            mydecPrincipalPayment = Payment - mydecInterestPayment;
            mydecEndingBalance = BeginningBalance - mydecPrincipalPayment;
        }

        private DateTime mydtePaymentDate = DateTime.Now;
        public DateTime Date
        {
            get
            {
                return mydtePaymentDate;
            }
        }
        private decimal mydecPrincipalPayment = 0;
        public decimal Principal
        {
            get
            {
                return mydecPrincipalPayment;
            }
        }

        private decimal mydecInterestPayment = 0;
        public decimal Interest
        {
            get
            {
                return mydecInterestPayment;
            }
        }

        private decimal mydecEndingBalance = 0;
        public decimal EndingBalance
        {
            get
            {
                return mydecEndingBalance;
            }
        }
    }

    public class AmortizationSchedule
    {
        public AmortizationSchedule(DateTime FirstPayment, decimal PaymentAmount,
                                    int NumberOfPayments, decimal InterestRate,
                                    decimal BeginningBalance)
        {
            mySchedule = new AmortizationLine[NumberOfPayments+1];
            mySchedule[0] = new AmortizationLine(FirstPayment, BeginningBalance, 0, 0);
            for(int intMonth = 1; intMonth <= NumberOfPayments; intMonth++)
            {
                mySchedule[intMonth] = new AmortizationLine(FirstPayment.AddMonths(intMonth),
                                                            mySchedule[intMonth - 1].EndingBalance, 
                                                            PaymentAmount, InterestRate);
            }
        }

        AmortizationLine[] mySchedule;
        public AmortizationLine[] Schedule
        {
            get
            {
                return mySchedule;
            }
        }
    }
}
