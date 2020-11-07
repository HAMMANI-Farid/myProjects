package ma.projet.classes;

import java.util.ArrayList;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Filiere[] filieres = new Filiere[4];
        filieres[0] = new Filiere("TSDI", "Développement informatique");
        filieres[1] = new Filiere("TSRI", "Réseaux informatique" );
        filieres[2] = new Filiere("TGI", "Gstion informatisée");
        filieres[3] = new Filiere("TAC", "Zssistant comptable");
        System.out.println("la liste des filieres de notre école : ");
        for (Filiere f: filieres) {
            System.out.println(f);
        }
        Scanner scanner = new Scanner(System.in);
        ArrayList<Etudient> etudients = new ArrayList<Etudient>();
        int i = 1, fil; String nom, prenom, dateNaissance, rep;
        do {
            System.out.println("----------Saisie des infos de l'étudient " + (i++) + "----------\n Nom : "); nom = scanner.nextLine();
            System.out.println("Prénom : "); prenom = scanner.nextLine();
            System.out.println("Date naissance : "); dateNaissance = scanner.nextLine();
            do {
                System.out.println("Choisissez une filière"); fil = scanner.nextInt();
            }while (!(fil > 0 && fil <= filieres.length));
            scanner.nextLine();
            etudients.add(new Etudient(nom, prenom, dateNaissance, filieres[fil - 1]));
            do {
                System.out.println("Voulez-vous continuez?");
                rep = scanner.nextLine();
                rep = rep.toUpperCase();
            }while (!(rep.equals("O") || rep.equals("N")));
        }while (!(rep.equals("N")));
        scanner.close();
        for (Filiere f: filieres){
            System.out.println(f);
            for (Etudient e: etudients){
                if (e.getFiliere() == f){
                    System.out.println(e);
                }
            }
        }
    }
}
