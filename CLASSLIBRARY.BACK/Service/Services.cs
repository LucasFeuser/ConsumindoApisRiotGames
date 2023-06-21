using CLASSLIBRARY.BACK.Dto;
using CLASSLIBRARY.BACK.Endpoint;
using CLASSLIBRARY.BACK.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CLASSLIBRARY.BACK.Service
{
    public class Services : IEndPoint
    {
        private readonly IEndPointClient _iEndPointClient;

        public Services(IEndPointClient iEndPointClient)
        {
            _iEndPointClient = iEndPointClient;
        }

        public void MyMethod()
        {

            throw new NotImplementedException();
        }

        public string buscarPuuidInvocador(string nomeInvocador)
        {
            var endpoint = $"https://br1.api.riotgames.com/lol/summoner/v4/summoners/by-name/{nomeInvocador}";
            var json = _iEndPointClient.BuscarPuuidAsync(endpoint).Result;

            var dados = JsonConvert.DeserializeObject<InvocadorDto>(json);

            return dados.puuid;
        }
    }
}
