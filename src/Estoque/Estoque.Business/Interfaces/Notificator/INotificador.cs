using Estoque.Business.Notificacoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque.Business.Intefaces.Notificator
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}