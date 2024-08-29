using Caliburn.Micro;
using PlannerInterface.Models;
using PlannerInterface.Views;
using PlannerTransmission.DTOs;
using PlannerNegocio.Negocio;
using PlannerTransmission.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerInterface.ViewModels
{
    public class HomeViewModel : Conductor<HomeView>
    {
        public Usuario servico =  new Usuario();
        public bool isHome { get; set; }
        public HomeViewModel()
        { 
            DisplayName = "Meu Planner";
            isHome= true;
            //ContentViewModel = new HomeViewModel();
        }
        private Screen _contentViewModel;
        public Screen ContentViewModel
        {
            get => _contentViewModel;
            set
            {
                _contentViewModel = value;
                NotifyOfPropertyChange(() => ContentViewModel);
            }
        }
        public void voltar()
        {
            // Exemplo de troca de conteúdo dinamicamente
            ContentViewModel = null;
            ContentViewModel = new HomeViewModel();
            isHome = true;
        }
        public void ChangeContent()
        {
            // Exemplo de troca de conteúdo dinamicamente
            ContentViewModel = null;
            ContentViewModel = new UsuarioViewModel();
            isHome = false;
        }
        public void CriarNovoUsuario()
        {
            servico.Listar();
            //model.addico(usuario);
        }
    }
}
