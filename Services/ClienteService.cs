using System;
using System.Collections.Generic;
using app02.Data;
using System.Threading.Tasks;
using app02.Models.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace app02.Services
{
    public class ClienteService
    {
        private readonly app02Context _Context;

        public ClienteService(app02Context context)
        {
            _Context = context;
        }
        public async Task<List<Cliente>> FindAllAsync()
        {
            return await _Context.Cliente.ToListAsync();
        }
        public async Task InsertAsync(Cliente cliente)
        {
            _Context.Cliente.Add(cliente);
            await _Context.SaveChangesAsync();

        }
        public async Task<Cliente> FindbyIdAsync(int id)
        {
            return await _Context.Cliente.Include(x => x.Id).FirstOrDefaultAsync(obj => obj.Id == id);
        }
        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _Context.Cliente.FindAsync(id);
                _Context.Cliente.Remove(obj);
                await _Context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task AtualizarAsync(Cliente obj)
        {
            bool HasAny = await _Context.Cliente.AnyAsync(x => x.Id == obj.Id);
            if (!HasAny)
            {
                throw new Exception("Id Não Encontrado");

            }

            try
            {
                _Context.Cliente.Update(obj);
                await _Context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new Exception(e.Message);
            }

        }
        public async Task AddTitulosAsync(int id, Titulo titulo)
        {
            var objeto = await _Context.Cliente.FirstOrDefaultAsync(obj => obj.Id == id);

            if (objeto == null || objeto.Id != id)
            {
                throw new Exception("Cliente Não Encontrado");
            }

            objeto.Titulos.Add(titulo);

            try
            {
                _Context.Cliente.Update(objeto);
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task RemTitulosAsync(int id, Titulo titulo)
        {
            var objeto = await _Context.Cliente.FirstOrDefaultAsync(obj => obj.Id == id);

            if (objeto == null || objeto.Id != id)
            {
                throw new Exception("Cliente Não Encontrado");
            }

            objeto.Titulos.Remove(titulo);

            try
            {
                _Context.Cliente.Update(objeto);
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new Exception(e.Message);
            }

        }
        public async Task AtualizarClienteAsync(int id)
        {
            var obj = await _Context.Cliente.FirstOrDefaultAsync(x => x.Id == id);

            if (obj == null || obj.Id != id)
            {
                throw new Exception("Cliente Não Encontrado"); 
            }

            try
            {
                _Context.Cliente.Update(obj);
                await _Context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}






