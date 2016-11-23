using JetBrains.Annotations;

// ReSharper disable once CheckNamespace
namespace Xunit
{
    [PublicAPI]
#if XUNIT_VISIBILITY_INTERNAL
    internal
#else
    public
#endif
    partial class Assert
    {
        // note(cosborn) This exists only to have a neutral class on which to put the attribute.
    }
}