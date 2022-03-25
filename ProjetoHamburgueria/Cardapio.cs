using System.Collections.Generic;
class cardapio{

  public List<Comida> comidas = new List<Comida>();
  public List<Bebida> bebidas =  new List<Bebida>();

  public void addBebida(Bebida bebida){
    bebidas.Add(bebida);
        }
  public void addComida(Comida comida){
    comidas.Add(comida);
  }
  public List <Comida> getComidas(){
    return comidas;
  }
  public List <Bebida> getBebidas(){
    return bebidas;
  }
  public void removecomida(int id){
    comidas.RemoveAt(id-1);
  }
  public void removebebida(int id){
    bebidas.RemoveAt(id-1);
  }
  public void editarcomida(int id, string nome){
    for (int c = 0; c < comidas.Count ; c++)
      {
        if (comidas[c].id == id)comidas[c].nome = nome; 

      }
  }
  public void editarbebida(int id, string nome){
    for (int c = 0; c < comidas.Count ; c++)
      {
        if (bebidas[c].id == id)bebidas[c].nome = nome; 
      
      } 
  }
  
}