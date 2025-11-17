using System.Dynamic;

namespace DesafioPOO.Models
{

   

    public abstract class Smartphone
    {
         private string numero;
         private string modelo;

         private string imei;

         private int memoria;

        public string Numero { 
            
            get{return numero;} 
            set{numero = value;}
            
             }
        public string Modelo
        {
            get{return modelo;}
            set{modelo=value;}
            
            
        } 
        public string IMEI
        {
            get
            {return imei;}
            set
            {imei=value;}
        }   

        public int Memoria
        {
            get
            {return memoria;}
            set
            {
                memoria = value;
            }
        } 
           
        


        public Smartphone(string numero,string modelo,string imei,int memoria)
        {
            Numero = numero;
            this.numero = numero;
            Modelo = modelo;
            this.modelo = modelo;
            IMEI = imei;
            this.imei = imei;
            Memoria = memoria;
            this.memoria = memoria;

        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}