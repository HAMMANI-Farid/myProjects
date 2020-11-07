#include<stdio.h>
#include<stdlib.h>
#include<string.h>
#include<time.h>

int main()
{
	char Pays[15][15]={"Senegal","France","Italie","Allemagne","Maroc","Monaco","Gabon","Nigeria","Liberia","Perou","Philippines","Pays-Bas","Cuba","Danemark","Argentine"};
	char Caps[15][15]={"Dakar","Paris","Rome","Berlin","Rabat","Monaco","Libreville","Lagos","Monrovia","Lima","Manille","Amsterdam","La Havane","Copenhague","Buenos Aires"};
	char R[15],C[4];
	int E,A,score;
	do{
		char F[15][1]={"N","N","N","N","N","N","N","N","N","N","N","N","N","N","N"};
		score=0;
		E=0;
		do{
			do{
				srand(time(NULL));
				A=rand()%14;
			} while (strcmp(F[A],"O")==0);
			strcpy(F[A],"O");
			printf("Quel est la capitale de %s:\t",Pays[A]);
			gets(R);
			E++;
			if(strcmp(Caps[A],R)==0)
			{
				printf("\t\tCorrect\n");
				printf("\t\t*******\n");
				score++;
			}
			else
			{
				printf("\t\tIncorrect le bonne reponse est %s\n",Caps[A]);
				printf("\t\t*********************************************\n");
			}
			} while(E<7);
			printf("Votre score est %d/7\n",score);
			printf("********************\n");
			do
			{
				printf("\t\tVoulez vous recommancer? O/N\t");
				gets(C);
			} while (C[0]!='O' && C[0]!='o' && C[0]!='N' && C[0]!='n');
	} while(C[0]!='N' && C[0]!='n');
	system("Pause");
}
