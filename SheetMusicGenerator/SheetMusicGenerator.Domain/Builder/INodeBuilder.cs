namespace SheetMusicGenerator.Domain.Builder
{
    public interface INodeBuilder
    {
        INodeBuilder AddNode(string node);
        IBarBuilder EndBar();
    }
}