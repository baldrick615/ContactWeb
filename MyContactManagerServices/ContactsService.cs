﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactWebModels;

namespace MyContactManagerServices
{
    public class ContactsService :IContactsService
    {
        public async Task<IList<Contact>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Contact?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> AddOrUpdateAsync(Contact state)
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteAsync(Contact state)
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExistsAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}