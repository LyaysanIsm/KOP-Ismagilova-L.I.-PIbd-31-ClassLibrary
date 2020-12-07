namespace OpenModelsLibrary.Interfaces
{
    public interface IVisitable
    {
        void Accept(IVisitor visitor);
    }
}
