﻿using System;
using System.Data.Entity;
using System.Threading.Tasks;
using DevIO.Business.Models.Fornecedores;

namespace DevIO.Infra.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public async Task<Fornecedor> ObterFornecedorEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(f => f.Endereco)
                .FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(f => f.Endereco)
                .Include(f=>f.Produtos)
                .FirstOrDefaultAsync(f => f.Id == id);
        }
    }
}