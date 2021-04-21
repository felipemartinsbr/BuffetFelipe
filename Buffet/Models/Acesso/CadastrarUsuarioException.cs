using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Buffet.Models.Acesso
{
    public class CadastrarUsuarioException : Exception

    {
    public IEnumerable<IdentityError> Erros { get; set; }

    public CadastrarUsuarioException(IEnumerable<IdentityError> erros)
    {
        Erros = erros;
    }
    }
}