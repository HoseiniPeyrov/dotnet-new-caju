﻿namespace CleanBasicProject.Domain
{
    public interface IAggregateRoot : IEntity
    {
        int Version { get; }
    }
}