package ma.projet.classes;

public class Etudient {
    private int id;
    private String nom;
    private String Prenom;
    private String DateNaissance;
    private Filiere filiere;
    private static int vId = 0;

    public Etudient() {
        this.id = ++vId;
    }

    public Etudient(String nom, String prenom, String DateNaissance, Filiere filiere){
        this.id = ++vId;
        this.nom = nom;
        this.Prenom = prenom;
        this.DateNaissance = DateNaissance;
        this.filiere = filiere;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getNom() {
        return nom;
    }

    public void setNom(String nom) {
        this.nom = nom;
    }

    public String getPrenom() {
        return Prenom;
    }

    public void setPrenom(String prenom) {
        Prenom = prenom;
    }

    public String getDateNaissance() {
        return DateNaissance;
    }

    public void setDateNaissance(String dateNaissance) {
        DateNaissance = dateNaissance;
    }

    public Filiere getFiliere(){
        return filiere;
    }

    public void setFiliere(Filiere filiere){
        this.filiere = filiere;
    }

    @Override
    public String toString() {
        return "\tJe suis l'étudient " + nom + " " + Prenom + " ma date de naissance est : " + DateNaissance;
    }
}
