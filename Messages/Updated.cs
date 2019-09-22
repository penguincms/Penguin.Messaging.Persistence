using System.Collections.Generic;

namespace Penguin.Messaging.Persistence.Messages
{
    /// <summary>
    /// A post-save update message. Inherits from saved
    /// </summary>
    /// <typeparam name="T">The type of the object being udpated</typeparam>
    public class Updated<T> : Saved<T>, IUpdated
    {
        #region Constructors

        /// <summary>
        /// A Dictionary containing the changed property name / values for the new version of the entity
        /// </summary>
        public Dictionary<string, object> NewValues { get; } = new Dictionary<string, object>();

        /// <summary>
        /// A Dictionary containing the changed property / values as they were on the old version of the entity
        /// </summary>
        public Dictionary<string, object> OldValues { get; } = new Dictionary<string, object>();

        /// <summary>
        /// Creates a new instance of the message with the object being referenced attached
        /// </summary>
        /// <param name="target">The object being referenced</param>
        public Updated(T target) : base(target)
        {
        }

        #endregion Constructors
    }

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