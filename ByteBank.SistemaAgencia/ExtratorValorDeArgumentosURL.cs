﻿using System;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        private readonly string _argumentos;
        public string URL { get; }

        public ExtratorValorDeArgumentosURL(string url)
        {
           if(string.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento url não pode ser nulo ou vazio", nameof(url));
            }
                       

            int indiceInterrogacao = URL.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);

            URL = url;
        }

        // moedaOrigem=real&moedaDestino=dolar
        public string GetValor(string nomeParametro)
        {
            return "";
           // int indiceParametro = _argumentos.IndexOf
        }
    }
}
