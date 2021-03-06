﻿using System.Threading.Tasks;

namespace DontMergeMeYet.Services
{
    public interface IPullRequestInfoProvider
    {
        Task<PullRequestInfo> GetPullRequestInfoAsync(PullRequestContext context);
    }
}
