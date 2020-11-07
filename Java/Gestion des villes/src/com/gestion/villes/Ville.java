package com.gestion.villes;

public class Ville {
    private String Nom_Ville;
    private int Nombre_habitants;
    private int[] Precipitation_Mensuel = new int[12];
    private int[] Temperature_Mensuel = new int[12];

    public Ville(){
    }

    public Ville(String Nom_Ville, int Nombre_habitants, int[] Precipitation_Mensuel, int[] Temperature_Mensuel){
        this.Nom_Ville = Nom_Ville;
        this.Nombre_habitants = Nombre_habitants;
        this.Precipitation_Mensuel = Precipitation_Mensuel;
        this.Temperature_Mensuel = Temperature_Mensuel;
    }

    public String getNom_Ville() {
        return Nom_Ville;
    }

    public void setNom_Ville(String nom_Ville) {
        Nom_Ville = nom_Ville;
    }

    public int getNombre_habitants() {
        return Nombre_habitants;
    }

    public void setNombre_habitants(int nombre_habitants) {
        Nombre_habitants = nombre_habitants;
    }

    public int[] getPrecipitation_Mensuel() {
        return Precipitation_Mensuel;
    }

    public void setPrecipitation_Mensuel(int[] precipitation_Mensuel) {
        this.Precipitation_Mensuel = precipitation_Mensuel;
    }

    public int[] getTemperature_Mensuel() {
        return Temperature_Mensuel;
    }

    public void setTemperature_Mensuel(int[] temperature_Mensuel) {
        Temperature_Mensuel = temperature_Mensuel;
    }

    private float moyenneP = 0;
    private float moyenneT = 0;

    private int maxiP = 0;
    private int maxiT = 0;

    public float moyennePrecipitation(){
        for (int P: Precipitation_Mensuel){
            moyenneP += P;
        }
        return moyenneP/12;
    }

    public float moyenneTemperature(){
        for (int T: Temperature_Mensuel) {
            moyenneT += T;
        }
        return moyenneT/12;
    }

    public int maxPrecipitation(){
        for (int P: Precipitation_Mensuel) {
            if (P > maxiP){
                maxiP = P;
            }
        }
        return maxiP;
    }

    public int maxTemperature(){
        for (int T: Temperature_Mensuel){
            if (T > maxiT){
                maxiT = T;
            }
        }
        return maxiT;
    }

    @Override
    public String toString() {
        return "Ville [ Nom ville : " + Nom_Ville + ", Nombre habitants : " + Nombre_habitants + ", Précipitation moyenne : " + moyennePrecipitation() +
                ", Température moyenne : " + moyenneTemperature() + ", Précipitation maximum : " + maxPrecipitation() + ", Température maximum : " +
                maxTemperature() + "]";
    }
}
