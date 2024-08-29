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
    public class EventoService : IEvento
    {
        public EventoRepository repository = new EventoRepository();
        public ContatoService contato = new ContatoService();
        public PermissaoService permissao = new PermissaoService();
        public EventoDto converterModeloEmDto(Evento entidade)
        {
            return new EventoDto
            {
                Id = entidade.Id,
                UsuarioCadastro = entidade.UsuarioCadastro,
                DataCadastro = entidade.DataCadastro,
                DescricaoEvento = entidade.DescricaoEvento,
                ContatoCliente = contato.converterModeloEmDto(entidade.ContatoCliente),
                Data = entidade.Data,
                Horario = entidade.Horario,
                PermissaoVisualizacao = permissao.converterModeloEmDto(entidade.PermissaoVisualizacao),
            };
        }
        public Evento converterDtoEmModelo(EventoDto entidadeDto)
        {
            return new Evento
            {
                Id = entidadeDto.Id,
                UsuarioCadastro = entidadeDto.UsuarioCadastro,
                DataCadastro = entidadeDto.DataCadastro,
                DescricaoEvento = entidadeDto.DescricaoEvento,
                ContatoCliente = contato.converterDtoEmModelo(entidadeDto.ContatoCliente),
                Data = entidadeDto.Data,
                Horario = entidadeDto.Horario,
                PermissaoVisualizacao = permissao.converterDtoEmModelo(entidadeDto.PermissaoVisualizacao),
            };
        }
        public EventoDto Adicionar(EventoDto entidade)
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

        public EventoDto Editar(EventoDto entidade, int Id)
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

        public List<EventoDto> Listar()
        {
            try
            {
                var lista = new List<EventoDto>();
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
