#include<stdio.h>
#include<stdlib.h>
#include<string.h>
#include<time.h>
int main()
{
    int N,i=0,j=0;
    typedef struct
    {
        char nom[20];
        char prenom[20];
        int age;
        float moyenne;
    }etude;
    etude *e;
    printf("Donnez nombre d'etudients: ");scanf("%d",&N);
    e = malloc(N*sizeof(etude));
    do
    {
        fflush(stdin);
        printf("------------etudient(e) %d------------\n",i+1);
        printf("Donnez nom d'etudient(e): ");scanf("%s",&e[i].nom);
        printf("Donnez prenom d'etudient(e): ");scanf("%s",&e[i].prenom);
        printf("Donnez l'age d'etudient(e): ");scanf("%d",&e[i].age);
        printf("Donnez moyenne d'etudient(e): ");scanf("%f",&e[i].moyenne);
        i++;
    } while (!(i==N));

    do
    {
        printf("------------etudient(e) %d------------\n",j+1);
        printf("Nom d'etudient(e): %s\n",e[j].nom);
        printf("Prenom d'etudient(e): %s\n",e[j].prenom);
        printf("Age d'etudient(e): %d\n",e[j].age);
        printf("Moyenne d'etudient(e): %.2f\n",e[j].moyenne);
        j++;
    } while (!(j==i));
    free(e);
}
