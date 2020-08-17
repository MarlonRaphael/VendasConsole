using System;
using System.Collections.Generic;
using System.Text;

namespace VendasConsole
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime CriadoEm { get; set; }

        public virtual List<Cliente> Clientes { get; set; }

        public Cliente(string Nome, string Cpf)
        {
            this.setNome(Nome);
            this.setCpf(Cpf);
            this.setCriadoEm();
        }

        public string getNome()
        {
            return this.Nome;
        }

        public void setNome(string Nome)
        {
            this.Nome = Nome;
        }

        public string getCpf()
        {
            return this.Cpf;
        }

        public void setCpf(string Cpf)
        {
            this.Cpf = Cpf;
        }

        public DateTime getCriadoEm()
        {
            return this.CriadoEm;
        }

        public void setCriadoEm()
        {
            this.CriadoEm = DateTime.Now;
        }

        public void addCliente(Cliente cliente)
        {
            this.Clientes.Add(cliente);
        }

        public bool validaCpf(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
            {
                return false;
            }
            switch (cpf)
            {
                case "11111111111":
                    return false;
                case "22222222222":
                    return false;
                case "33333333333":
                    return false;
                case "44444444444":
                    return false;
                case "55555555555":
                    return false;
                case "66666666666":
                    return false;
                case "77777777777":
                    return false;
                case "88888888888":
                    return false;
                case "99999999999":
                    return false;
                case "00000000000":
                    return false;
            }

            int peso = 10;
            int soma = 0;
            int resto;
            int digito1, digito2;

            for (int i = 0; i < 9; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * peso;
                peso--;
            }

            resto = soma % 11;

            if (resto < 2)
            {
                digito1 = 0;
            }
            else
            {
                digito1 = 11 - resto;
            }

            peso = 11;
            soma = 0;

            for (int i = 0; i < 10; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * peso;
                peso--;
            }

            resto = soma % 11;

            if (resto < 2)
            {
                digito2 = 0;
            }
            else
            {
                digito2 = 11 - resto;
            }

            if (digito1 == Convert.ToInt32(cpf[9].ToString())
                && digito2 == Convert.ToInt32(cpf[10].ToString()))
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"NOME: {Nome} | CPF: {Cpf} | Criado em: {CriadoEm}";
        }

    }
}
