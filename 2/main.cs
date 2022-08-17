using System;

class Aula2{

  public struct Aluno {
    public string m;//matricula
    public int p;//periodo
  
  }

  public struct Disciplina{
  
    public string n;//nome
    public int s;//semestre
    
  }
  public static bool Matricular(Aluno aluno,
                               Disciplina disciplina){

    return aluno.p == disciplina.s;
    
  }
  public static void Imprimir(Aluno aluno,
                              Disciplina disciplina){
       if(Matricular(aluno, disciplina)){
      Console.WriteLine(aluno.m);
    }
    
  } 
  public static void Main (string[]args){
   Aluno aluno1 = new Aluno{
    m = "2022",
    p = 1
   };
    
   Aluno aluno2 = new Aluno{
    m = "2022",
    p = 3
   }; 
     
  Disciplina disciplina = new Disciplina{
    n = "022022",
    s = 3
    
  };
  Imprimir(aluno1, disciplina);
  Imprimir(aluno2, disciplina);
  }
  
}