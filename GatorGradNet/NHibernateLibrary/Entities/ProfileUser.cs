using NHibernateLibrary.Entities;
using NHibernateLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Entities
{
    public class ProfileUser : BaseEntity<Int64>
    {
   
        public virtual String Username { get; set; }
        public virtual String Password { get; set; }
        public virtual String Email { get; set; }
        public virtual String FirstName { get; set; }
        public virtual String LastName { get; set; }
        public virtual String Branch { get; set; }
        public virtual float GPA { get; set; }
        public virtual String PrevEducation { get; set; }
        public virtual String PrevWork { get; set; }
        public virtual String PrevLocation { get; set; }
        public virtual String CurrentWork { get; set; }
        public virtual String DreamCompany { get; set; }

        public virtual String Validated { get; set; }

        //public virtual String Gender { get; set; }
        //public virtual String PhotoUrl { get; set; }
        //public virtual ISet<Address> Address { get; set; }


        //public virtual PhoneNos PhoneNo { get; set; }
       

        //public virtual PrevLocGroup PreviousLocation { get; set; }

        //public virtual PrevWorkGroup PreviousWork { get; set; }

        public virtual Iesi.Collections.Generic.ISet<Address> Addresses { get; set; }
        public virtual Iesi.Collections.Generic.ISet<PhoneNos> PhoneNumbers { get; set; }
        public virtual Iesi.Collections.Generic.ISet<PrevEduGroup> PreviousEducation { get; set; }
        public virtual Iesi.Collections.Generic.ISet<PrevLocGroup> PreviousLocation { get; set; }
        public virtual Iesi.Collections.Generic.ISet<PrevWorkGroup> PreviousWork { get; set; }
        public virtual void AddAddress(Address address)
        {
            address.UserId= this;
            Addresses.Add(address);
        }

        public virtual void AddPhoneNo(PhoneNos phoneNumber)
        {
            phoneNumber.UserId = this;
            PhoneNumbers.Add(phoneNumber);
        }


        public virtual void AddPreviousEducation(PrevEduGroup previousEducation)
        {
            previousEducation.UserId = this;
            PreviousEducation.Add(previousEducation);
        }

        public virtual void AddPreviousLocation(PrevLocGroup previousLocation)
        {
            previousLocation.UserId = this;
            PreviousLocation.Add(previousLocation);
        }

        public virtual void AddPreviousWork(PrevWorkGroup previousWork)
        {
            previousWork.UserId = this;
            PreviousWork.Add(previousWork);
        }
    }
}
