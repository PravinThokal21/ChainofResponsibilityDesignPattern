using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibilityDesignPattern
{
    abstract class Approver
    {
        public EventHandler<LoanEventArgs> Loan;

        public abstract void LoanHandler(object sender, LoanEventArgs e);

        public Approver()
        {
            Loan += LoanHandler;
        }

        public virtual void OnLoan(LoanEventArgs e)
        {
            if (Loan != null)
            {
                Loan(this, e);
            }
        }

        // Sets or gets the next approver
        public Approver Successor { get; set; }

        public void ProcessRequest(Loan loan)
        {
            OnLoan(new LoanEventArgs { Loan = loan });
        }

    }
}
