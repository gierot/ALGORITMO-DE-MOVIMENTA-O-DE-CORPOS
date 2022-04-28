using System;
using System.IO;
using System.Text;
namespace aula01
{
    class CorpoCeleste
    {
        private double massa;
        private string nome;
        private double raio;
        private double posX;
        private double posY;
        private double velX;
        private double velY;
        private double forcax;
        private double forcay;
        private string[] linha;
        private double aceleracaox;
        private double aceleracaoy;
        public CorpoCeleste(string[] parametros)
        {
            this.nome = parametros[0];
            this.massa = float.Parse(parametros[1]);
            this.raio = float.Parse(parametros[2]);
            this.posX = float.Parse(parametros[3]);
            this.posY = float.Parse(parametros[4]);
            this.velX = float.Parse(parametros[5]);
            this.velY = float.Parse(parametros[6]);
            StreamReader bol = new StreamReader("teste.txt");
            linha = (bol.ReadLine().Split(";"));
        }
        public double Mas
        {
            get
            {
                return massa;
            }
            set
            {
                massa = value;
            }
        }
        public double Kirin
        {
            get
            {
                return raio;
            }
            set
            {
                raio = value;
            }
        }
        public double Px
        {
            get
            {
                return posX;
            }
            set
            {
                posX = value;
            }
        }
        public double Py
        {
            get
            {
                return posY;
            }
            set
            {
                posY = value;
            }
        }
        public double Vx
        {
            get
            {
                return velX;
            }
            set
            {
                velX = value;
            }
        }
        public double Vy
        {
            get
            {
                return velY;
            }
            set
            {
                velY = value;
            }
        } 
        public double Forcax
        {
            get
            {
                return forcax; 
            }
            set
            { 
                forcax = value; 
            }
        }
        public double Forcay
        {
            get
            {
                return forcay; 
            }
            set
            { 
                forcay = value; 
            }
        }
        public string[] Lin
        {
            get
            {
                return linha;
            }
            set
            {
                linha = value;
            }
        }
        public string name
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }
        public double acely
        {
            get
            {
                return aceleracaoy;
            }
            set
            {
                aceleracaoy = value;
            }
        }
        public double acelx
        {
            get
            {
                return aceleracaox;
            }
            set
            {
                aceleracaox = value;
            }
        }
    }
}