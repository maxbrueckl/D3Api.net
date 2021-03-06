﻿using System;

namespace D3ApiDotNet.DataAccess.Repositories
{
    public class RepositoryEntityNotFoundException : Exception
    {
        public RepositoryEntityNotFoundException()
        {
            
        }

        public RepositoryEntityNotFoundException(string message) 
            : base(message)
        {
            
        }

        public RepositoryEntityNotFoundException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
}