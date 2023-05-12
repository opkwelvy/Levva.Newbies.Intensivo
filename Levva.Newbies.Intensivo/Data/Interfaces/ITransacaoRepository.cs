﻿using Levva.Newbies.Intensivo.Domain.Models;

namespace Levva.Newbies.Intensivo.Data.Interfaces
{
    public interface ITransacaoRepository
    {
        void Create(Transacao transacao);
        Transacao Get(int id);
        List<Transacao> GetAll();   
        void Update(Transacao transacao);
        void Delete(int id);
    }   
}
