using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
       
        GestionEmployes gestionEmployes = new GestionEmployes();

        
        try
        {
            gestionEmployes.AjouterEmploye(new Employee { Nom = "Alice", Salaire = 4500, Poste = "Développeur", Date = "2020-05-10" });
            gestionEmployes.AjouterEmploye(new Employee { Nom = "Bob", Salaire = 5000, Poste = "Manager", Date = "2018-07-25" });
            gestionEmployes.AjouterEmploye(new Employee { Nom = "Charlie", Salaire = 4000, Poste = "Technicien", Date = "2021-03-15" });
        }
        catch (ArgumentException e)
        {
            Console.WriteLine("❌ Erreur : " + e.Message);
        }

       
        Directeur directeur = Directeur.GetInstance();
        directeur.SetGestionEmployes(gestionEmployes);

        
        Console.WriteLine("\n📌 Liste des employés:");
        directeur.AfficherEmployes();

        Console.WriteLine($"\n💰 Salaire total de l'entreprise: {directeur.GetSalaireTotal():C}");
        Console.WriteLine($"📊 Salaire moyen des employés: {directeur.GetSalaireMoyen():C}");

       
        try
        {
            gestionEmployes.SupprimerEmploye(new Employee { Nom = "Alice", Date = "2020-05-10" });
            Console.WriteLine("\n✅ Alice a été supprimée avec succès.");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine("❌ Erreur : " + e.Message);
        }

        
        Console.WriteLine("\n📌 Liste des employés après suppression:");
        directeur.AfficherEmployes();

        Console.WriteLine($"\n💰 Salaire total après suppression: {directeur.GetSalaireTotal():C}");
        Console.WriteLine($"📊 Salaire moyen après suppression: {directeur.GetSalaireMoyen():C}");
    }
}
