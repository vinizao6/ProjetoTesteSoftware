using Microsoft.Toolkit.Diagnostics;


namespace ProjetoTeste.Domain.Conta;


public partial class Contas{
    public Contas (string nomeusuario, string senha, string email){
        Guard.IsNotNullOrWhiteSpace(nomeusuario,nameof(nomeusuario));
        Guard.IsNotNullOrWhiteSpace(senha,nameof(senha));
        Guard.IsNotNullOrWhiteSpace(email,nameof(email));


          Nomeusuario = string.Empty;
          Senha = string.Empty;
          Email = string.Empty;
    }
    public Contas(){
//entity framework
    }
    public int Id{get; private set;}
    public string? Nomeusuario { get; private set; }
    public string? Senha { get; private set; }
     public string? Email { get; private set; }
}


