using System.Collections.Generic;

namespace DIO.Series.Intefaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T entidade);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}