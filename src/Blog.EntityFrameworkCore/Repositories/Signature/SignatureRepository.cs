using Blog.Domain.Signature.Repositories;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Blog.EntityFrameworkCore.Repositories.Signature
{
    /// <summary>
    /// SignatureRepository
    /// </summary>
    public class SignatureRepository : EfCoreRepository<BlogDbContext, Domain.Signature.Signature, Guid>, ISignatureRepository
    {
        public SignatureRepository(IDbContextProvider<BlogDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}