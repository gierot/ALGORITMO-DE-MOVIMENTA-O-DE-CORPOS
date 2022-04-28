using System;
using System.IO;
using System.Text;
namespace aula01
{
    class Universo 
    {
        private double forca;
        private double gravidade;
        private double aceleracaox;
        private double aceleracaoy;
        public void calculo(CorpoCeleste[] corpos)
        {
            double distanciax = Math.Pow((corpos[0].Px - corpos[1].Px), 2);
            double distanciay = Math.Pow((corpos[0].Py - corpos[1].Py), 2);
            double distancia = Math.Sqrt(distanciax + distanciay);
            gravidade = Math.Pow(6.674184 * 10, -11);
            forca = ((gravidade * (corpos[0].Mas * corpos[1].Mas))/(distancia * distancia));
            corpos[1].Forcax += forca * ((corpos[1].Px - corpos[0].Px)/distancia);
            corpos[0].Forcax += forca * ((corpos[1].Px - corpos[0].Px)/distancia);
            corpos[1].Forcay += forca * ((corpos[1].Py - corpos[0].Py)/distancia);
            corpos[0].Forcay += forca * ((corpos[1].Py - corpos[0].Py)/distancia);
        }
        public void acelera(CorpoCeleste corpos)
        {
            aceleracaox = corpos.Forcax/corpos.Mas;
            aceleracaoy = corpos.Forcay/corpos.Mas;
            corpos.Vy = corpos.Vy + aceleracaoy * 100;
            corpos.Vx = corpos.Vx + aceleracaox * 100;
        }
        public void deslocamento(CorpoCeleste corpo)
        {
            long tempo = long.Parse(corpo.Lin[2]);
            corpo.Px = (corpo.Vx * tempo + (corpo.Vx / 2) + aceleracaox);
            corpo.Py = (corpo.Vy * tempo + (corpo.Vy / 2) + aceleracaoy);   
        }
        public void colisao(CorpoCeleste[] corpo)
        {
            double varianciam = corpo[0].Px - corpo[1].Px;
            double varianciap = corpo[0].Py - corpo[1].Py;
            if ( varianciam < 1 && varianciam > 0 && varianciap < 1 && varianciap > 0)
            {
                for (int i = 0; i < 2; i++)
                {
                    corpo[i].Mas = 0;
                    corpo[i].Px = 0;
                    corpo[i].Py = 0;
                    corpo[i].Forcax = 0;
                    corpo[i].Forcay = 0;
                    corpo[i].Vx = 0;
                    corpo[i].Vy = 0;
                    corpo[i].Kirin = 0;
                }
            }
        }
    }    
}