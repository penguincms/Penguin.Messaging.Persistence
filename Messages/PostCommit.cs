using Penguin.Messaging.Abstractions.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Penguin.Messaging.Persistence.Messages
{
    /// <summary>
    /// Fires after a persistence commit has completed
    /// </summary>
    public class PostCommit : Message
    {
    }
}
