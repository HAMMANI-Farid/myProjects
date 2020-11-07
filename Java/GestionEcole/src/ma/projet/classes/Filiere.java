package ma.projet.classes;

public class Filiere {
    private int Id;
    private String code;
    private String libelle;
    private static int vId = 0;

    public Filiere() {
        this.Id = ++vId;
    }

    public Filiere(String code, String libelle){
        this.Id = ++vId;
        this.code = code;
        this.libelle = libelle;
    }

    public int getId() {
        return Id;
    }

    public void setId(int id) {
        Id = id;
    }

    public String getCode() {
        return code;
    }

    public void setCode(String code) {
        this.code = code;
    }

    public String getLibelle() {
        return libelle;
    }

    public void setLibelle(String libelle) {
        this.libelle = libelle;
    }

    @Override
    public String toString() {
        return "Code Filiere : " + Id + " Filière : " + libelle;
    }
}
