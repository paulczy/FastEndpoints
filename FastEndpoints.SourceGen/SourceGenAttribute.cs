using System;

namespace FastEndpoints.SourceGen
{
    /// <summary>
    /// use this attribute to mark request/response dto classes that should be 'source generated' to avoid the use of reflection when serializing and deserializing to json.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class SourceGenAttribute : Attribute { }
}
