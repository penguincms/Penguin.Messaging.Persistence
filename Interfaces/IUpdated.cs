using System.Collections.Generic;

namespace Penguin.Messaging.Persistence.Interfaces
{
    /// <summary>
    /// Interface used to access the updated values for the object referenced in the message
    /// </summary>
    public interface IUpdated
    {
        /// <summary>
        /// A Dictionary containing the changed property name / values for the new version of the entity
        /// </summary>
        Dictionary<string, object> NewValues { get; }

        /// <summary>
        /// A Dictionary containing the changed property / values as they were on the old version of the entity
        /// </summary>
        Dictionary<string, object> OldValues { get; }
    }
}