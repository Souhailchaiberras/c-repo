class Directeur
{
    private static Directeur instance;
    private GestionEmployes gestionEmployes;

    private Directeur()
    {
        gestionEmployes = new GestionEmployes();
    }

    public static Directeur GetInstance()
    {
        if (instance == null)
        {
            instance = new Directeur();
        }
        return instance;
    }

    public void SetGestionEmployes(GestionEmployes gestion)
    {
        gestionEmployes = gestion;
    }

    public double GetSalaireTotal()
    {
        return gestionEmployes.SalaireTotal();
    }

    public double GetSalaireMoyen()
    {
        return gestionEmployes.SalaireMoyen();
    }

    public void AfficherEmployes()
    {
        gestionEmployes.AfficherEmployes();
    }
}
