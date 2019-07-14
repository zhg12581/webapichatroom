using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webapichatroom.Models;
using webapichatroom.Repositories;

namespace webapichatroom.DAL
{
    public class UnitOfWork : IDisposable
    {
        private AccountContext context = new AccountContext();

        private GenericRepository<AllUser> allUserRepository;
        private GenericRepository<ChatMessages> chatMessagesRepository;
        private GenericRepository<GroupInformation> groupInformationRepository;
        private GenericRepository<GroupMembers> groupMembersRepository;

        public GenericRepository<AllUser> AllUserRepository
        {
            get
            {
                if (this.allUserRepository == null)
                {
                    this.allUserRepository = new GenericRepository<AllUser>(context);
                }
                return allUserRepository;
            }
        }

        public GenericRepository<ChatMessages> ChatMessagesRepository
        {
            get
            {
                if (this.chatMessagesRepository == null)
                {
                    this.chatMessagesRepository = new GenericRepository<ChatMessages>(context);
                }
                return chatMessagesRepository;
            }
        }

        public GenericRepository<GroupInformation> GroupInformationRepository
        {
            get
            {
                if (this.groupInformationRepository == null)
                {
                    this.groupInformationRepository = new GenericRepository<GroupInformation>(context);
                }
                return groupInformationRepository;
            }
        }

        public GenericRepository<GroupMembers> GroupMembersRepository
        {
            get
            {
                if (this.groupMembersRepository == null)
                {
                    this.groupMembersRepository = new GenericRepository<GroupMembers>(context);
                }
                return groupMembersRepository;
            }
        }



        #region Save & Dispose
        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;


        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}