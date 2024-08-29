using PlannerDataBase.Entities;
using PlannerDataBase.Repositories;
using PlannerTransmission.DTOs;
using PlannerTransmission.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerDataBase.Negocio
{
    public class ContatoService : IContato
    {
        public ContatoRepository repository = new ContatoRepository();
        public ContatoDto converterModeloEmDto(Contato entidade)
        {
            return new ContatoDto
            {
                Id = entidade.Id,
                UsuarioCadastro = entidade.UsuarioCadastro,
                DataCadastro = entidade.DataCadastro,
                Nome = entidade.Nome,
                Sobrenome = entidade.Sobrenome,
                Cpf = entidade.Cpf,
                Telefone = entidade.Telefone,
                Email = entidade.Email,
                Endereco = entidade.Endereco,
                DataNascimento  = entidade.DataNascimento,
                Descricao = entidade.Descricao,
            };
        }
        public Contato converterDtoEmModelo(ContatoDto entidadeDto)
        {
            return new Contato
            {
                Id = entidadeDto.Id,
                UsuarioCadastro = entidadeDto.UsuarioCadastro,
                DataCadastro = entidadeDto.DataCadastro,
                Nome = entidadeDto.Nome,
                Sobrenome = entidadeDto.Sobrenome,
                Cpf = entidadeDto.Cpf,
                Telefone = entidadeDto.Telefone,
                Email = entidadeDto.Email,
                Endereco = entidadeDto.Endereco,
                DataNascimento = entidadeDto.DataNascimento,
                Descricao = entidadeDto.Descricao,
            };
        }
        public ContatoDto Adicionar(ContatoDto entidade)
        {
            try
            {
                return this.converterModeloEmDto(repository.Adicionar(this.converterDtoEmModelo(entidade)));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro {this.GetType().Name}: {e.Message}");
                throw;
            }
        }

        public ContatoDto Editar(ContatoDto entidade, int Id)
        {
            try
            {
                return this.converterModeloEmDto(repository.Editar(this.converterDtoEmModelo(entidade), Id));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro {this.GetType().Name}: {e.Message}");
                throw;
            }
        }

        public void Excluir(int Id)
        {
            try
            {
                repository.Excluir(Id);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro {this.GetType().Name}: {e.Message}");
                throw;
            }
        }

        public List<ContatoDto> Listar()
        {
            try
            {
                var lista = new List<ContatoDto>();
                foreach (var item in repository.Listar())
                {
                    lista.Add(this.converterModeloEmDto(item));
                }
                return lista;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro {this.GetType().Name}: {e.Message}");
                throw;
            }
        }
    }
}
