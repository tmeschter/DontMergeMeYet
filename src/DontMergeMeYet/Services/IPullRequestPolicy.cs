﻿using Octokit;

namespace DontMergeMeYet.Services
{
    public interface IPullRequestPolicy
    {
        (CommitState state, string description) GetStatus(PullRequestContext context);
    }
}
