using Penguin.Messaging.Abstractions.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Penguin.Messaging.Persistence.Messages
{
    /// <summary>
    /// Fires on the beginning of a persistence commit
    /// </summary>
    public class PreCommit : Message
    {
    }
}
