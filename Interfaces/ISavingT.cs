﻿using Penguin.Messaging.Abstractions.Interfaces;

namespace Penguin.Messaging.Persistence.Interfaces
{
    /// <summary>
    /// A pre-save message.
    /// </summary>
    /// <typeparam name="T">The type of the object being saved</typeparam>
    public interface ISaving<out T> : IMessage<T>
    {
    }
}