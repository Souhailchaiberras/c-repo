using System.ComponentModel.DataAnnotations.Schema;

class Employee
{
   private string nom;
   private double salaire;
   private string poste;
   private string date;

    public string Nom { get => nom; set => nom = value; }
    public double Salaire { get => salaire; set => salaire = value; }
    public string Poste { get => poste; set => poste = value; }
    public string Date { get => date; set => date = value; }
}
