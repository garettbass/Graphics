namespace UnityEditor.ShaderGraph
{
    enum PreviewMode
    {
        Default,        // default behavior is 2D, unless a connected input node is 3D, in which case it is 3D
        Preview2D,
        Preview3D
    }
}
