﻿namespace DBRepository
{
    public abstract class BaseRepository
    {
        protected string ConnectionString { get; }

        protected IRepositoryContextFactory ContextFactory { get; }

        protected BaseRepository(string connectionString, IRepositoryContextFactory contextFactory)
        {
            ConnectionString = connectionString;
            ContextFactory = contextFactory;
        }
    }
}
