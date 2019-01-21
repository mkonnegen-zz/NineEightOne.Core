using System;

namespace NineEightOne.Core
{
    public static class Guard
    {
        /// <summary>
        /// Checks if the given instance is <c>null</c> and throws if it is.
        /// </summary>
        /// <param name="instance">An instance to check for <c>null</c>.</param>
        /// <param name="parameterName">The name of the instance parameter.</param>
        /// <exception cref="ArgumentNullException">
        ///     If the given <paramref name="instance"/> is <c>null</c>.
        /// </exception>
        public static void CheckNotNoull(object instance, string parameterName)
        {
            if (instance == null)
                throw new ArgumentNullException(parameterName);
        }

        /// <summary>
        /// Checks if the given instance is <c>null</c> and throws if it is.
        /// </summary>
        /// <param name="instance">An instance to check for <c>null</c>.</param>
        /// <param name="parameterName">The name of the instance parameter.</param>
        /// <param name="message">A customized exception message.</param>
        /// <exception cref="ArgumentNullException">
        ///     If the given <paramref name="instance"/> is <c>null</c>.
        /// </exception>
        public static void CheckNotNoull(object instance, string name, string message)
        {
            if (instance == null)
                throw new ArgumentNullException(name, message);
        }

        /// <summary>
        /// Checks if the given instance is <c>null</c> or the empty string.
        /// </summary>
        /// <param name="instance">An instance to check for <c>null</c>.</param>
        /// <param name="parameterName">The name of the instance parameter.</param>
        /// <seealso cref="CheckNotNullOrEmpty(string, string, string)"/>
        public static void CheckNotNullOrEmpty(string instance, string parameterName)
        {
            CheckNotNullOrEmpty(instance, parameterName, "Parameter may not be null or the empty string.");
        }

        /// <summary>
        /// Checks if the given instance is <c>null</c> or the empty string.
        /// </summary>
        /// <param name="instance">An instance to check for <c>null</c>.</param>
        /// <param name="parameterName">The name of the instance parameter.</param>
        /// <param name="message">A customized exception message.</param>
        /// <exception cref="ArgumentNullException">
        ///     If the given <paramref name="instance"/> is <c>null</c>.
        /// </exception>
        /// <exception cref="ArgumentException">
        ///     If the given <paramref name="instance"/> is the empty string.
        /// </exception>
        public static void CheckNotNullOrEmpty(string instance, string parameterName, string message)
        {
            if (instance == null)
                throw new ArgumentNullException(parameterName, message);

            if (String.IsNullOrEmpty(instance))
                throw new ArgumentException(message, parameterName);
        }
    }
}