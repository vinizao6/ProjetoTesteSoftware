using Microsoft.Toolkit.Diagnostics;

namespace ProjetoTeste.sln.Domain.Conta;


public partial class Contas{
    public Contas (string nomeusuario, string senha, string email){
        Guard.IsNotNullOrWhiteSpace(nomeusuario,nameof(nomeusuario));
        Guard.IsNotNullOrWhiteSpace(senha,nameof(senha));
        Guard.IsNotNullOrWhiteSpace(email,nameof(email));


        Nomeusuario = nomeusuario;
        Senha = senha;
        Email = email;
    }
    public Contas(){
//entity framework
    }
    public int Id {get; private set;}
    public string Nomeusuario {get; private set;}
    public string Senha {get; private set;}
    public string Email {get; private set;}    
}


