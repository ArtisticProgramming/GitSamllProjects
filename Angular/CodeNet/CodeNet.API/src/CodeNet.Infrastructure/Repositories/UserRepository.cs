using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CodeNet.Domain.Entities;
using CodeNet.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using CodeNet.Domain.Repositories.BaseClasses;

namespace CodeNet.Infrastructure.Repositories
{
    public class UserRepository: IUserRepository
    {
        private readonly CodeNetContext _codeNetContext ;
        public IUnitOfWork UnitOfWork => _codeNetContext;

      
    }
}