namespace PAS.Models
{
    public class Cour
    {
        internal object Etudiants;

        public int CourId { get; set; }
        public string NomCours { get; set; }
        public string? Description { get; set; }
        public int ClasseId { get; set; }
        public Classe Classe { get; set; }
        public int ProfesseurId { get; set; }
        public ICollection<Professeur> Professeurs { get; set; }
        public ICollection<CourEtudiant> CourEtudiants { get; set; }

        //public Professeur Professeur { get; set; }
    }
}
