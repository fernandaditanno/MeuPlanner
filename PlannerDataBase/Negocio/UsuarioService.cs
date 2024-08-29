using PlannerDataBase.Authentication;
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
    public class UsuarioService : IUsuario
    {
        public UsuarioRepository GetRepository()
        { 
            return new UsuarioRepository();
        }
        public UsuarioDto converterModeloEmDto(Usuario entidade)
        {
            return new UsuarioDto
            {
                Id = entidade.Id,
                UsuarioCadastro = entidade.UsuarioCadastro,
                DataCadastro = entidade.DataCadastro,
                Nome = entidade.Nome,
                Senha = entidade.Senha,
                Sobrenome = entidade.Sobrenome,
                Cpf = entidade.Cpf,
                Email = entidade.Email,
                Login = entidade.Login,
                Telefone = entidade.Telefone,
            };
        }
        public Usuario converterDtoEmModelo(UsuarioDto entidadeDto)
        {
            return new Usuario
            {
                Id = entidadeDto.Id,
                UsuarioCadastro = entidadeDto.UsuarioCadastro,
                DataCadastro = entidadeDto.DataCadastro,
                Nome = entidadeDto.Nome,
                Senha = entidadeDto.Senha,
                Sobrenome = entidadeDto.Sobrenome,
                Cpf = entidadeDto.Cpf,
                Email = entidadeDto.Email,
                Login = entidadeDto.Login,
                Telefone = entidadeDto.Telefone,
            };
        }
        public UsuarioDto Adicionar(UsuarioDto entidade)
        {
            try
            {
                return converterModeloEmDto(GetRepository().Adicionar(converterDtoEmModelo(entidade)));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro {this.GetType().Name}: {e.Message}");
                throw;
            }
        }

        public UsuarioDto Editar(UsuarioDto entidade, int Id)
        {
            try
            {
                return converterModeloEmDto(GetRepository().Editar(converterDtoEmModelo(entidade), Id));
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
                GetRepository().Excluir(Id);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro {this.GetType().Name}: {e.Message}");
                throw;
            }
        }

        public List<UsuarioDto> Listar()
        {
            /**/
            var lista = new List<UsuarioDto>();
            var item = GetRepository().Listar();
            if (item?.Count() > 0)
            {
                foreach (var objeto in item)
                {
                    lista.Add(this.converterModeloEmDto(objeto));
                }
            }
            else
            {
                return new List<UsuarioDto>();
            }
            return lista;
            
        }
    }
}
