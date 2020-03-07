using Penguin.Messaging.Persistence.Interfaces;
using System.Collections.Generic;

namespace Penguin.Messaging.Persistence.Messages
{
    /// <summary>
    /// A post-save update message. Inherits from saved
    /// </summary>
    /// <typeparam name="T">The type of the object being udpated</typeparam>
    public class Updated<T> : Saved<T>, IUpdated<T>
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
        /// <param name="newValues">The changed property new values</param>
        /// <param name="oldValues">The changed property old values</param>
        public Updated(T target, Dictionary<string, object> newValues = null, Dictionary<string, object> oldValues = null) : base(target)
        {
            if (newValues != null)
            {
                foreach (KeyValuePair<string, object> newValue in newValues)
                {
                    this.NewValues.Add(newValue.Key, newValue.Value);
                }
            }

            if (oldValues != null)
            {
                foreach (KeyValuePair<string, object> oldValue in oldValues)
                {
                    this.OldValues.Add(oldValue.Key, oldValue.Value);
                }
            }
        }

        /// <summary>
        /// Creates a new instance of the message with the object being referenced attached
        /// </summary>
        /// <param name="target">The object being referenced</param>
        /// <param name="updateData">An interface containing the values changed as part of this update</param>
        public Updated(T target, IUpdated updateData) : this(target, updateData?.NewValues, updateData?.OldValues) { }

        #endregion Constructors
    }
}