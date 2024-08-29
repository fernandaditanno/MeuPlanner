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

    public class PermissaoService : IPermissao
    {
        public PermissaoRepository repository =  new PermissaoRepository();
        public PermissaoDto converterModeloEmDto(Permissao entidade)
        {
            return new PermissaoDto
            {
                Id = entidade.Id,
                UsuarioCadastro = entidade.UsuarioCadastro,
                DataCadastro = entidade.DataCadastro,
                NomeDaTela = entidade.NomeDaTela,
                Privado = entidade.Privado,
                Senha = entidade.Senha,
            };
        }
        public Permissao converterDtoEmModelo(PermissaoDto entidadeDto)
        {
            return new Permissao
            {
                Id = entidadeDto.Id,
                UsuarioCadastro = entidadeDto.UsuarioCadastro,
                DataCadastro = entidadeDto.DataCadastro,
                NomeDaTela = entidadeDto.NomeDaTela,
                Privado = entidadeDto.Privado,
                Senha = entidadeDto.Senha,
            };
        }
        public PermissaoDto Adicionar(PermissaoDto entidade)
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

        public PermissaoDto Editar(PermissaoDto entidade, int Id)
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

        public List<PermissaoDto> Listar()
        {
            try
            {
                var lista = new List<PermissaoDto>();
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
