
public class Produto {

    public Produto (){
        
        Id = Guid.NewGuid().ToString();
        CriadoEm = DateTime.Now;      
    }

    public string Id {get; set; }
    public string Nome {get;set; }
    public double valor {get;set; }
    public int Quantidade {get; set; }
    public DateTime CriadoEm {get; set; }
}