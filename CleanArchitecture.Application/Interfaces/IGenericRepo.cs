namespace CleanArchitecture.Application.Interfaces
{
    public interface IGenericRepo<T>
    {
        Task<IEnumerable<string>> Index(IEnumerable<T> documents);
        Task<T> Get(string id);
        Task<bool> Update(T document, string id);
        Task<bool> Delete(string id);
    }
}
