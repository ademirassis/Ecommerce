using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    interface IRepository<T>
    {
        bool Cadastrar(T objeto);
        //bool CadastrarProduto(Produto p); // --> nome do método implementado na classe DAO // interfaces genéricas

        List<T> ListarTodos();

        T BuscarPorId(int? id);

    }
}
