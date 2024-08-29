using PlannerTransmission.DTOs;
using PlannerTransmission.Interfaces;
using PlannerDataBase.Repositories;
using System;
using System.Collections.Generic;
using PlannerDataBase.Entities;

namespace PlannerDataBase.Negocio
{
    public class ColaboradorService : IColaborador
    {
        public ContatoService contato = new ContatoService();
        public ColaboradorRepository repository = new ColaboradorRepository();
        public ColaboradorDto converterModeloEmDto(Colaborador entidade)
        {
            return new ColaboradorDto
            {
                ContatoCliente = contato.converterModeloEmDto(entidade.ContatoCliente),
                ContatoColaborador = contato.converterModeloEmDto(entidade.ContatoColaborador)
            };
        }
        public Colaborador converterDtoEmModelo(ColaboradorDto entidadeDto)
        {
            return new Colaborador
            {
                ContatoCliente = contato.converterDtoEmModelo(entidadeDto.ContatoCliente),
                ContatoColaborador = contato.converterDtoEmModelo(entidadeDto.ContatoColaborador)
            };
        }
        public ColaboradorDto Adicionar(ColaboradorDto entidade)
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

        public ColaboradorDto Editar(ColaboradorDto entidade, int Id)
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

        public List<ColaboradorDto> Listar()
        {
            try
            {
                var lista = new List<ColaboradorDto>();
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
