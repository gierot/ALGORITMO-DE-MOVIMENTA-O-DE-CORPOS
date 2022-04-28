using System;
using System.IO;
using System.Text;
namespace aula01
{
    class Program
    {
        static void Main(string[] args)
        {   
            Universo planeta = new Universo();
            StreamReader se = new StreamReader("teste.txt");
            CorpoCeleste[] corpos = new CorpoCeleste[2];
            string[] cabecalho = (se.ReadLine()).Split(";");
            string[] parametros;
            int contador = 0;
            while(!se.EndOfStream)
            {
                string linha = se.ReadLine();
                parametros = linha.Split(";");
                corpos[contador] = new CorpoCeleste(parametros);
                contador++;
            }
            se.Close();
            StreamWriter bolado = new StreamWriter("novo.txt");
            for (int i = 0; i < int.Parse(cabecalho[1]); i++)
            {
                for (int j = 0; j < corpos.Length; j++)
                {
                    planeta.calculo(corpos);
                    planeta.acelera(corpos[j]);
                    planeta.deslocamento(corpos[j]);
                    planeta.colisao(corpos);
                    bolado.WriteLine("Planeta {0}", corpos[j].name);
                    bolado.WriteLine("Planeta massa : {0} ",corpos[j].Mas);
                    bolado.WriteLine("Planeta posição x : {0}  ",corpos[j].Px);
                    bolado.WriteLine("Planeta posição y : {0}  ",corpos[j].Py);
                    bolado.WriteLine("Planeta velocidade x : {0} ",corpos[j].Vx);
                    bolado.WriteLine("Planeta velocidade y : {0} ",corpos[j].Vy);
                    bolado.WriteLine("Planeta Força x : {0} ",corpos[j].Forcax);
                    bolado.WriteLine("Planeta Foça y : {0} ",corpos[j].Forcay);
                    bolado.WriteLine("Planeta raio : {0} ",corpos[j].Kirin);
                    bolado.WriteLine("");
                }
            }
            bolado.Close();
        }
    }
}