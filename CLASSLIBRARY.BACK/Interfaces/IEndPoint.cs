using CLASSLIBRARY.BACK.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSLIBRARY.BACK.Interfaces
{
    public interface IEndPoint
    {
        InvocadorDto buscarPuuidInvocador(string nomeInvocador);
    }
}
