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
    public class ProcessoService : IProcesso
    {
        public ProcessoRepository repository = new ProcessoRepository();
        public ContatoService contato = new ContatoService();
        public ProcessoDto converterModeloEmDto(Processo entidade)
        {
            return new ProcessoDto
            {
                Id = entidade.Id,
                UsuarioCadastro = entidade.UsuarioCadastro,
                DataCadastro = entidade.DataCadastro,
                ContatoCliente = contato.converterModeloEmDto(entidade.ContatoCliente),
                Descricao = entidade.Descricao,
                NumeroProcesso = entidade.NumeroProcesso,
                Tipo = entidade.Tipo,
            };
        }
        public Processo converterDtoEmModelo(ProcessoDto entidadeDto)
        {
            return new Processo
            {
                Id = entidadeDto.Id,
                UsuarioCadastro = entidadeDto.UsuarioCadastro,
                DataCadastro = entidadeDto.DataCadastro,
                ContatoCliente = contato.converterDtoEmModelo(entidadeDto.ContatoCliente),
                Descricao = entidadeDto.Descricao,
                NumeroProcesso = entidadeDto.NumeroProcesso,
                Tipo = entidadeDto.Tipo,
            };
        }
        public ProcessoDto Adicionar(ProcessoDto entidade)
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

        public ProcessoDto Editar(ProcessoDto entidade, int Id)
        {
            try
            {
                return this.converterModeloEmDto(repository.Editar(this.converterDtoEmModelo(entidade), Id));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro {this.GetType().Name}: {e.Message}");
                throw;
            };
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

        public List<ProcessoDto> Listar()
        {
            try
            {
                var lista = new List<ProcessoDto>();
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
