#include<stdio.h>
#include<stdlib.h>
#include<string.h>
#include<myconio.h>
int menu()
{
	int choix;
	puts("--------Menu Principal--------");
	puts("1.Nouveau salarie");
	puts("2.Liste des salarié");
	puts("3.Rechrcher un salarié");
	puts("4.Moyenne des salaires");
	puts("5.Salaire le plus élevé");
	puts("6.Modifier un salarié");
	puts("7.Supprimer un salarié");
	puts("8.Quitter");
	do
	{
		fflush(stdin);
		printf("Donnez votre choix\t");
		scanf("%d",&choix);
	}while(!(choix>=1 && choix<=8));
	return choix;
}
char Nouveau()
{
	char Nom[50],Prenom[50],Exit;
	int Salaire;
	FILE *fichier;
	fichier = fopen("salarie.txt","a");
	do
	{
		printf("Donnez Nom, Prenom et salaire\t");
		scanf("%s%s%d",Nom,Prenom,&Salaire);
		fprintf(fichier,"%s ",Nom);
		fprintf(fichier,"%s ",Prenom);
		fprintf(fichier,"%d\n",Salaire);
		do
		{
			fflush(stdin);
			printf("Exit O/N?\t");
			scanf("%c",&Exit);
		}while(!(Exit=='O' || Exit=='o' || Exit=='N' || Exit=='n'));
	}while(!(Exit=='O' || Exit=='o'));
	fclose(fichier);
	return Exit;
}
void Liste()
{
	char Nom[50][50],Prenom[50][50],Exit;
	int Salaire[50],i=0,j=0;
	FILE *fichier;
	fichier = fopen("salarie.txt","r");
	printf("------------Liste des salarie------------\n\n");
	while(!feof(fichier))
	{
		fscanf(fichier,"%s%s%d",Nom[i],Prenom[i],&Salaire[i]);
		i++;
	}
	do
	{
		printf("%s %s %d\n",Nom[j],Prenom[j],Salaire[j]);
		printf("-----------------------------------------\n");
		j++;
	}while(!(j==i-1));
	printf("Clicker sur Entrer!\n");
	fclose(fichier);
}
char Rechercher()
{
	char Nom[50][50],Prenom[50][50],N[50],P[50],Exit;
	int Salaire[50],i=0;
	FILE *fichier;
	do
	{
		fichier = fopen("salarie.txt","r");
		printf("Donnez nom et prenom de salarie\t");
		scanf("%s%s",N,P);
		while(!feof(fichier))
		{
			fscanf(fichier,"%s%s%d",Nom[i],Prenom[i],&Salaire[i]);
			if(strcmp(Nom[i],N)==0 && strcmp(Prenom[i],P)==0)
			{
				printf("\n%s %s %d\n",Nom[i],Prenom[i],Salaire[i]);
				printf("-----------------------------------------\n");
			}
			i++;
		}
		do
		{
			fflush(stdin);
			printf("Exit O/N?\t");
			scanf("%c",&Exit);
		}while(!(Exit=='O' || Exit=='o' || Exit=='N' || Exit=='n'));
	}while(!(Exit=='O' || Exit=='o'));
	fclose(fichier);
	return Exit;
}
void Moyenne()
{
	char Nom[50],Prenom[50],Exit;
	int Salaire[50],i=0,Moy=0;
	FILE *fichier;
	fichier = fopen("salarie.txt","r");
	while(!feof(fichier))
	{
		fscanf(fichier,"%s%s%d",Nom,Prenom,&Salaire[i]);
		Moy+=Salaire[i];
		i++;
	}
	printf("\nMoyanne generale est %d\n\n",Moy);printf("Clicker sur Entrer!\n");
	fclose(fichier);
}
void Maxi()
{
	char Nom[50],Prenom[50],Exit;
	int Salaire[50],i=0,Max=0;
	FILE *fichier;
	fichier = fopen("salarie.txt","r");
	while(!feof(fichier))
	{
		fscanf(fichier,"%s%s%d",Nom,Prenom,&Salaire[i]);
		if(Salaire[i]>Max)
		Max=Salaire[i];
		i++;
	}
	printf("\nSalaire maximum est %d\n\n",Max);printf("Clicker sur Entrer!\n");
	fclose(fichier);
}
char Modifier()
{
	char Nom[50][50],Prenom[50][50],N[50],P[50],Exit;
	int Salaire[50],S,i=0,j=0,Max=0;
	FILE *fichier;
	do
	{
		fichier = fopen("salarie.txt","r");
		printf("Donnez Nom et Prenom\t");
		scanf("%s%s",N,P);
		while(!feof(fichier))
		{
			fscanf(fichier,"%s%s%d",Nom[i],Prenom[i],&Salaire[i]);
			if(strcmp(Nom[i],N)==0 && strcmp(Prenom[i],P)==0)
			{
				printf("Salaire actuelle est %d\nDonnez nouveau salaire\t",Salaire[i]);
				scanf("%d",&S);
				Salaire[i]=S;
			}
			i++;
		}
		fclose(fichier);
		fichier = fopen("salarie.txt","w");
		do
		{
			fprintf(fichier,"%s %s %d\n",Nom[j],Prenom[j],Salaire[j]);
			j++;
		}while(!(j==i-1));
		do
		{
			fflush(stdin);
			printf("Exit O/N?\t");
			scanf("%c",&Exit);
		}while(!(Exit=='O' || Exit=='o' || Exit=='N' || Exit=='n'));
	}while(!(Exit=='O' || Exit=='o'));
	fclose(fichier);
	return Exit;
	puts("Modification est succes!");
	
}
char Supprimer()
{
	char Nom[50][50],Prenom[50][50],N[50],P[50],Exit;
	int Salaire[50],S,i=0,j=0,Max=0;
	FILE *fichier;
	do
	{
		fichier = fopen("salarie.txt","r");
		while(!feof(fichier))
		{
			fscanf(fichier,"%s%s%d",Nom[i],Prenom[i],&Salaire[i]);
			i++;
		}
		fclose(fichier);
		printf("Donnez Nom et Prenom\t");
		scanf("%s%s",N,P);
		fichier = fopen("salarie.txt","w");
		do
		{
			int s1=strcmp(Nom[j],N);
			int s2=strcmp(Prenom[j],P);
			if(s2==0 && s1==0)
			{
				goto S;
			}
		 	fprintf(fichier,"%s %s %d\n",Nom[j],Prenom[j],Salaire[j]);
			S:j++;
		}while(!(j==i-1));
		do
		{
			fflush(stdin);
			printf("Exit O/N?\t");
			scanf("%c",&Exit);
		}while(!(Exit=='O' || Exit=='o' || Exit=='N' || Exit=='n'));
	}while(!(Exit=='O' || Exit=='o'));
	fclose(fichier);
	return Exit;
	puts("Supprimer est succes!");
}
int main()
{
	textbackground(WHITE);
	textcolor(BLACK);
	clrscr();
	M:switch (menu())
	{
		case 1: {if(Nouveau()=='O'||'o')
		goto M;
			break;
		}
		case 2: {Liste();getch();printf("\n");goto M;
			break;
		}
		case 3: {if(Rechercher()=='O'||'o')
		goto M;
			break;
		}
		case 4: {Moyenne(),getch();printf("\n");goto M;
			break;
		}
		case 5: {Maxi();getch();printf("\n");goto M;
			break;
		}
		case 6: {;if(Modifier()=='O'||'o')
		goto M;
			break;
		}
		case 7: {;if(Supprimer()=='O'||'o')
		goto M;
			break;
		}
		case 8: {puts("Merci pour votre utilisation de programme");
			break;
		}
	}
}

