class GestionEmployes{
    List<Employee> employees = new List<Employee>();
    public void AjouterEmploye(Employee e){
        if (employees.Any(emp => emp.Nom == e.Nom && emp.Date == e.Date)) {
            throw new ArgumentException("Employee already exists.");
        }
        employees.Add(e);
    }
    public void SupprimerEmploye(Employee e){
        var employeeToRemove = employees.FirstOrDefault(emp => emp.Nom == e.Nom && emp.Date == e.Date);
        if (employeeToRemove != null) {
            employees.Remove(employeeToRemove);
        } else {
            throw new ArgumentException("Employee does not exist.");
        }
    }
   public double SalaireTotal(){
       double total = 0; 
       foreach(Employee e in employees){
           total += e.Salaire;
       }
       return total;
    }
    public double SalaireMoyen(){
        if (employees.Count == 0) {
            return 0;
        }
        return SalaireTotal() / employees.Count;
    }
    
    public void AfficherEmployes(){
        foreach(Employee e in employees){
            Console.WriteLine("Nome:"+e.Nom+" Salaire:"+e.Salaire+" Poste:"+e.Poste+" Date:"+e.Date);
        }
    }
    
   
}