using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAvaliativa
{
    class Cliente
    {
        // Atributos da Classe

        private int saldo;
        private int conta;
        private int totalCobrancas;
        private int totalCredito;
        private int limiteCredito;

        // Construtor

        public Cliente()
        {
            saldo = 0;
            conta = 0;
            totalCobrancas = 0;
            totalCredito = 0;
            limiteCredito = 0;
        }
        
        // Assinatura da Classe

        public Cliente(int saldo, int conta, int totalCobrancas, int totalCredito, int limiteCredito)
        {
            this.saldo = saldo;
            this.conta = conta;
            this.totalCobrancas = totalCobrancas;
            this.totalCredito = totalCredito;
            this.limiteCredito = limiteCredito;
        }

        // Método CalcularNovoSaldo

        public int CalcularNovoSaldo()
        {
            return this.saldo + this.totalCobrancas - this.totalCredito;
        }

        // Método de Atualização do saldo

        public void AtualizarSaldo()
        {
            this.saldo = CalcularNovoSaldo();
        }

        // Método Verificação se Ultrapassou o limite

        public bool UltrapassouLimite()
        {
            return this.saldo > this.limiteCredito;
        }

    }
}
