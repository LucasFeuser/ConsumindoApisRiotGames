using CLASSLIBRARY.BACK.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ASPNET.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEndPoint _endPoint;

        public HomeController(IEndPoint endPoint)
        {
            _endPoint = endPoint;
        }

        public void BuscarDados(string nomeInvocador)
        {
            try
            {
                _endPoint.buscarPuuidInvocador(nomeInvocador);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro na busca do invocador. Erro:{e.InnerException.Message}");
            }


        }
    }
}
