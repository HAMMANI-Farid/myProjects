#include<stdio.h>
#include<stdlib.h>
#include<string.h>
typedef struct 
{
    char NomVille[30];
    int Nbhabitant;
    int precipitation[12];
    int temperature[12];
}gestion;
void saisie_ville();
void affichage_ville();
float moyenne_precipitation();
float moyenne_temperature();
int main()
{
    int NbVille;
    gestion *Ville;
    printf("Combien de ville vous saisir: ");scanf("%d",&NbVille);
    Ville=malloc(NbVille*sizeof(gestion));
    saisie_ville(Ville,NbVille);
    affichage_ville(Ville,NbVille);
    printf("Merci pour votre temps.\n");
    free(Ville);
}
void saisie_ville(gestion* V,int n)
{
    int i,j;
    for ( i = 0; i < n; i++)
    {
        printf("Donnez nom de la ville: ");fflush(stdin);gets(&V[i].NomVille);
        printf("Donnez nombre d'habitants: ");scanf("%d",&V[i].Nbhabitant);
        printf("-------- Saisie des precipitations --------\n");
        for ( j = 0; j < 12; j++)
        {
            printf("Precipitation mois %2d: ",j+1);scanf("%d",&V[i].precipitation[j]);
        }
        printf("--------- Saisie des temperature ----------\n");
        for ( j = 0; j < 12; j++)
        {
            printf("Temperature mois %2d: ",j+1);scanf("%d",&V[i].temperature[j]);
        }
        printf("-------------------------------------------\n");
    }
    
}
void affichage_ville(gestion* V,int n)
{
    int i;float P,T;
    for ( i = 0; i < n; i++)
    {
        P=moyenne_precipitation(V[i]);
        T=moyenne_temperature(V[i]);
        printf("---------------- Ville %d -----------------\n",i+1);
        printf("Nom ville: %s\nNombre d'habitants: %d\nPrecipitation moyenne: %.2f\nTemperature moyenne: %.2f\n",V[i].NomVille,V[i].Nbhabitant,P,T);
    }
    printf("-------------------------------------------\n");
}
float moyenne_precipitation(gestion* V)
{
    int i;float moyenne=0;
    for ( i = 0; i < 12; i++)
    {
        moyenne+=V->precipitation[i];
    }
    return moyenne/12;
}
float moyenne_temperature(gestion* V)
{
    int i;float moyenne=0;
    for ( i = 0; i < 12; i++)
    {
        moyenne+=V->temperature[i];
    }
    return moyenne/12;
}