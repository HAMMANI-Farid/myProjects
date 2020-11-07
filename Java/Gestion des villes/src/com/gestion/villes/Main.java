package com.gestion.villes;

import java.util.ArrayList;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        ArrayList<Ville> villes = new ArrayList<Ville>();
        Scanner scanner = new Scanner(System.in); int nbr = 1, nomber = 0; int[] P = new int[12], T = new int[12]; String name = "", rep = "";
        do {
            System.out.println("--------Saisie des infos de la ville : " + nbr++ + "--------\n" +
                    "Donnez nom de ville : "); name = scanner.nextLine();
            System.out.println("Donnez nombre d'habitants : "); nomber = scanner.nextInt();
            for (int i = 0; i < 12; i++) {
                System.out.println("Donnez précipitation de mois " + (i+1));
                P[i] = scanner.nextInt();
            }
            for (int i = 0; i < 12; i++) {
                System.out.println("Donnez température de mois " + (i+1));
                T[i] = scanner.nextInt();
            }
            villes.add(new Ville(name,nomber,P,T));
            scanner.nextLine();
            do {
                System.out.println("Voulez-vous continuez?");
                rep = scanner.nextLine(); rep = rep.toUpperCase();
            }while (!(rep.equals("O") || rep.equals("N")));
        }while (!(rep.equals("N")));
        scanner.close();
        for (Ville V: villes){
            System.out.println(V);
        }
    }
}
