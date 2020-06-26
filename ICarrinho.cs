namespace Interfaces
{
    public interface ICarrinho
    {
         //CRUD
         //Create
         //Read
         //Update
         //Delete

         void Add(Produto produto);
         void Remove(Produto produto);
         void Read();
         void Update(int _codigo, Produto produto);
    }
}