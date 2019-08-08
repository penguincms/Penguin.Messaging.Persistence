namespace Penguin.Messaging.Persistence.Messages
{
    /// <summary>
    /// A post-save update message. Inherits from saved
    /// </summary>
    /// <typeparam name="T">The type of the object being udpated</typeparam>
    public class Updated<T> : Saved<T>
    {
        #region Constructors

        /// <summary>
        /// Creates a new instance of the message with the object being referenced attached
        /// </summary>
        /// <param name="target">The object being referenced</param>
        public Updated(T target) : base(target)
        {
        }

        #endregion Constructors
    }
}