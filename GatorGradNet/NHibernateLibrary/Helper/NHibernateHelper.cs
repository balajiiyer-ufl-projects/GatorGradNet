using NHibernate;
using NHibernate.Cfg;
using NHibernate.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Helper
{

    /// <summary>
    /// Here basic NHibernate manipulation methods are implemented.
    /// </summary>
    public class NHibernateHelper
    {
        private static ISessionFactory sessionFactory = null;

        /// <summary>
        /// In case there is an already instantiated NHibernate ISessionFactory,
        /// retrieve it, otherwise instantiate it.
        /// </summary>
        public static ISessionFactory SessionFactory
        {
            get
            {
                if (sessionFactory == null)
                {
                    Configuration configuration = new Configuration();
                    configuration.Configure();

                    // build a Session Factory
                    sessionFactory = configuration.BuildSessionFactory();
                }
                return sessionFactory;
            }
        }

        /// <summary>
        /// Open an ISession based on the built SessionFactory.
        /// </summary>
        /// <returns>Opened ISession.</returns>
        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();

        }
        /// <summary>
        /// Create an ISession and bind it to the current tNHibernate Context.
        /// </summary>
        public static void CreateSession()
        {
            CurrentSessionContext.Bind(OpenSession());
        }

        /// <summary>
        /// Close an ISession and unbind it from the current
        /// NHibernate Context.
        /// </summary>
        public static void CloseSession()
        {
            if (CurrentSessionContext.HasBind(SessionFactory))
            {
                CurrentSessionContext.Unbind(SessionFactory).Dispose();
            }
        }

        /// <summary>
        /// Retrieve the current binded NHibernate ISession, in case there
        /// is any. Otherwise, open a new ISession.
        /// </summary>
        /// <returns>The current binded NHibernate ISession.</returns>
        public static ISession GetCurrentSession()
        {
            if (!CurrentSessionContext.HasBind(SessionFactory))
            {
                CurrentSessionContext.Bind(SessionFactory.OpenSession());
            }
            return SessionFactory.GetCurrentSession();
        }
    }
}

