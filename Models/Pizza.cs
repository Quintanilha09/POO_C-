namespace Pizzaria.Models;


    public class Pizza {

        private string nome;
        private string[] ingredientes = new string[50];
        private float preco;
       
        public void MostrarPizza() {
            return "Nome: " + this.nome  + "Sabor: "  + this.sabor + "Preço: " + this.preco;
        }
           
    }


