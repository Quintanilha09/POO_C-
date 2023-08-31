namespace Pizzaria.Models;


    public class Pizza {

        public string nome;
        public string[] ingredientes = new string[50];
        public float preco;
       
        public String MostrarPizza() {
            string ingredientesTexto = string.Join(", ", ingredientes);
            return $"Nome: {nome}\nIngredientes: {ingredientesTexto}\nPreço: {preco:C2}";
        }
           
    }


