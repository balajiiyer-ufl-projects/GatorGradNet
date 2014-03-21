using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary
{
    public class Customer
    {
         private int CUSTOMER_ID;
        private string CUST_FIRST_NAME;
        private string CUST_LAST_NAME;
        private double CREDIT_LIMIT;
        private string CUST_EMAIL;
        private DateTime DATE_OF_BIRTH;

        public virtual int Customer_Id
        {
            get { return CUSTOMER_ID; }
            set { CUSTOMER_ID = value; }
        }

        public virtual string Cust_First_Name
        {
            get { return CUST_FIRST_NAME; }
            set { CUST_FIRST_NAME = value; }
        }

        public virtual string Cust_Last_Name
        {
            get { return CUST_LAST_NAME; }
            set { CUST_LAST_NAME = value; }
        }

        public virtual double Credit_Limit
        {
            get { return CREDIT_LIMIT; }
            set { CREDIT_LIMIT = value; }
        }

        public virtual string Cust_Email
        {
            get { return CUST_EMAIL; }
            set { CUST_EMAIL = value; }
        }

        public virtual DateTime Date_of_Birth
        {
            get { return DATE_OF_BIRTH; }
            set { DATE_OF_BIRTH = value; }
        }
    }
    
}
