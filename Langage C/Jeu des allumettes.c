#include<stdio.h>
#include<stdlib.h>
#include<string.h>
#include<time.h>
#include<myconio.h>
int CHOIX(int repetition[])
{
  int A;int choix[3]={1,2,3};
  do
  {
    srand(time(NULL));A=rand()%3;
  } while (!(repetition[A]==0));
  repetition[A]=1;
  return choix[A];
}
int verifier(int choix, int pc)
{
  if (choix==pc)
  {
    return 1;
  }
  else
  {
    return 0;
  }
}
int score(int E1,int E2)
{
  if (E1>E2)
  {
    return 0;
  }
  else if (E1<E2)
  {
    return 1;
  }
  else
  {
    return 2;
  }
}
int main()
{
  char again;
  do
  {
    int repJeux[3]={0,0,0},repPc[3]={0,0,0},choix,J,P,essai=0,scoreJoueur=0,scorePc=0,A1,A2;
    printf("Bienvenue dans:\n");
    printf("Jeu des allumettes\n");
    do
    {
      J=CHOIX(repJeux);P=CHOIX(repPc);
      printf("Donnez nombre entre 1 et 3: ");scanf("%d",&choix);
      A1=verifier(choix,J);A2=verifier(P,J);
      if (A1==1 && A2==1)
      {
        printf("Egalite le nombre est: %d!\n",J);
        printf("Votre choix: %d\n",choix);scoreJoueur++;
        printf("Pc choix: %d\n",P);scorePc++;
      }
      else if (A1==1 && A2==0)
      {
        printf("Vous avez gagné et Pc perdu a tour %d!\n",essai+1);
        printf("Votre choix: %d\n",choix);scoreJoueur++;
        printf("Pc perdu choix: %d\n",P);
      }
      else if (A1==0 && A2==1)
      {
        printf("Vous avez perdu et Pc gagne a tour %d!\n",essai+1);
        printf("Votre choix: %d\n",choix);
        printf("Pc choix: %d\n",P);scorePc++;
      }
      else
      {
        printf("Vous avez perdu a tour %d!\n",essai+1);
        printf("Votre choix: %d\n",choix);
        printf("Pc choix: %d\n",P);
      }
      essai++;
    } while (!(essai==3));
    switch (score(scoreJoueur,scorePc))
    {
    case 0:
      printf("Felecitation! Vous avec gagne! votre score: %d\n",scoreJoueur);
      break;
    case 1:
      printf("Vous avez perdu! votre score: %d\n",scoreJoueur);
      break;
    case 2:
      printf("egalite! votre score: %d\n",scoreJoueur);
      break;
    }
    do
    {
      fflush(stdin);
      printf("Voulez vous recommancez? O/N: ");scanf("%c",&again);
    } while (!(again=='O' || again=='o' || again=='N' || again=='n'));
  } while (!(again=='N' || again=='n'));
  printf("Merci pour jouer ce jeu!\n");
  
  
}