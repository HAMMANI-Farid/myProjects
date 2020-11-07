#include<stdio.h>
#include<stdlib.h>
#include<time.h>
#include<myconio.h>
long verifier_nom(char name[])
{
	char chaine[1][50];int Num,S;long Solde;
	FILE *fichier;
	fichier = fopen("Bank1.txt","r");
	while(!feof(fichier))
	{
		fscanf(fichier,"%s",chaine[0]);
		fscanf(fichier,"%d",&Num);
		fscanf(fichier,"%lu",&Solde);
		if(strcmp(name,chaine[0])==0)
		{
			S=Solde;break;
		}
		else
			S=0;
	}
	fclose(fichier);
	return S;
}
long verifier_pass(int pass)
{
	char chaine[50];int Num,S;long Solde;
	FILE *fichier;
	fichier = fopen("Bank1.txt","r");
	while(!feof(fichier))
	{
		fscanf(fichier,"%s",chaine);
		fscanf(fichier,"%d",&Num);
		fscanf(fichier,"%lu",&Solde);
		if(Num==pass)
		{
			S=Solde;break;
		}
		else
		S=0;
		
	}
	fclose(fichier);
	return S;
}
void Menu()
{
	gotoxy(45,14);printf("1.Retrait argent");//SGBDI. SQL
	gotoxy(45,15);printf("2.Consulter solde");
	gotoxy(45,16);printf("3.Relevés");
	gotoxy(45,17);printf("4.Quitter");
	return;
}
void Retrait(char name[],int ret)
{
	char chaine[6][20],chaine2[6][20],Op[20],tim[50];
	long Num[6];
	int i=0,now,numero,numero1;
	FILE *fichier;
	fichier = fopen("Bank1.txt","r");
	if(fichier==NULL)
	{
		printf("There has been an error!");
		exit(1);
	}
	while(!feof(fichier))
	{
		fscanf(fichier,"%s",chaine[i]);
		fscanf(fichier,"%s",chaine2[i]);
		fscanf(fichier,"%lu",&Num[i]);
		i++;
	}
	fclose(fichier);
	fichier = fopen("Bank1.txt","w");
	int j=0;
	do
	{
		if(strcmp(chaine[j],name)==0)
		{
			Num[j] -= ret;
		}
		fprintf(fichier,"%s ",chaine[j]);
		fprintf(fichier,"%s ",chaine2[j]);
		fprintf(fichier,"%lu\n",Num[j]);
		j++;
	}while(!(j==(i-1)));
	fclose(fichier);
	FILE *fichier2;
	fichier2 = fopen("Operations.txt","r");
	while(!feof(fichier2))
	{
		fscanf(fichier2,"%d",&numero);
		fscanf(fichier2,"%s",Op);
		fscanf(fichier2,"%d",&numero1);
		fgets(tim,"%s",fichier2);
	}
	fclose(fichier2);
	fichier2 = fopen("Operations.txt","a");
	time(&now);
	fprintf(fichier2,"%d ",numero+1);
	fprintf(fichier2,"%s ",name);
	fprintf(fichier2,"%d ",ret);
	fprintf(fichier2,"%s",ctime(&now));
	fclose(fichier2);
}
void releves(char name[])
{
	char Nom[50][50],tim[50][50];
	int i=0,j=0,numero,ret[50];
	
	FILE *fichier3;
	fichier3 = fopen("Operations.txt","r");
	
	while(!feof(fichier3))
	{
		fscanf(fichier3,"%d",&numero);
		fscanf(fichier3,"%s",Nom[i]);
		fscanf(fichier3,"%d",&ret[i]);
		fgets(tim[i],"%s",fichier3);
		i++;
	}
	int N=1,k=11;
	do
	{
		if(strcmp(Nom[j],name)==0)
		{
			gotoxy(45,k++);printf("%d ",N++);
			printf("%s ",name);
			printf("%d ",ret[j]);
			printf("%s\n",tim[j]);
		}
		j++;
	}while(!(j==i-1));
	fclose(fichier3);
}
int back_menu()
{
	char C[1];
	do
	{
		clrscr();
		fflush(stdin);
		gotoxy(45,12);puts("Back to menu Y/N?");
		gotoxy(45,13);gets(C);
	}while(!(C[0]=='Y' || C[0]=='y' || C[0]=='N' || C[0]=='n'));
	if(C[0]=='Y' || C[0]=='y')
	return 0;
	else
	return 1;
}
int main()
{
	int pin;int essai=1,ch,Ret,C;
	char username[20];
	textcolor(BLACK);
	textbackground(WHITE);
	clrscr();
	gotoxy(50,7);puts("Welcome our client");sleep(1);
	clrscr();
	do
	{
		gotoxy(50,7);puts("Welcome our client");
		gotoxy(40,9); printf("ÚÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÂÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¿");
		gotoxy(40,10);printf("³Username:          ³                ³");
		gotoxy(40,11);printf("ÃÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ´");
		gotoxy(40,12);printf("³Pin Code:          ³                ³");
		gotoxy(40,13);printf("ÀÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÁÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÙ");
		gotoxy(61,10);gets(username);
		if(verifier_nom(username)==0)
		{
			clrscr();
			gotoxy(50,7);puts("Welcome our client");
			gotoxy(40,9); printf("ÚÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÂÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¿");
			gotoxy(40,10);printf("³Username:          ³                ³");
			gotoxy(40,11);printf("ÃÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ´");
			gotoxy(40,12);printf("³Pin Code:          ³                ³");
			gotoxy(40,13);printf("ÀÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÁÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÙ");
			textcolor(RED);gotoxy(61,10);printf("Incorrect");sleep(1);
			clrscr();
			textcolor(BLACK);
		}
	}while(!(verifier_nom(username)!=0));
	clrscr();
	do
	{
		gotoxy(50,7);puts("Welcome our client");
		gotoxy(40,9); printf("ÚÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÂÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¿");
		gotoxy(40,10);printf("³Username:          ³                ³");
		gotoxy(40,11);printf("ÃÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ´");
		gotoxy(40,12);printf("³Pin Code:          ³                ³");
		gotoxy(40,13);printf("ÀÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÁÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÙ");
		gotoxy(61,10);puts(username);
		fflush(stdin);
		gotoxy(61,12);scanf("%d",&pin);
		if(essai==3)
		{
			clrscr();
			textcolor(RED);
			gotoxy(50,7);printf("Your account is blocked!");
			textcolor(BLACK);
			goto A;
			
		}
		if(verifier_pass(pin)==0)
		{
			clrscr();
			gotoxy(50,7);puts("Welcome our client");
			gotoxy(40,9); printf("ÚÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÂÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¿");
			gotoxy(40,10);printf("³Username:          ³                ³");
			gotoxy(40,11);printf("ÃÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ´");
			gotoxy(40,12);printf("³Pin Code:          ³                ³");
			gotoxy(40,13);printf("ÀÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÁÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÙ");
			gotoxy(61,10);puts(username);
			textcolor(RED);gotoxy(61,12);printf("Incorrect");sleep(1);
			clrscr();
			textcolor(BLACK);
		}
		essai++;
	}while(!(verifier_pass(pin)!=0));
	clrscr();
	A:gotoxy(50,7);printf("Welcome %s",username);
	gotoxy(45,8);printf("Your account:%lu DH",verifier_nom(username));
	Menu();
	do
	{
		gotoxy(45,10);printf("Enter your chose:");
		gotoxy(45,11);scanf("%d",&ch);
	}while(!(ch>=1 && ch<=4));
	clrscr();
	switch(ch)
	{
		case 1:{gotoxy(45,12);puts("Combien ?");
		gotoxy(45,13);scanf("%d",&Ret);
		Retrait(username,Ret);
		C=back_menu();
		if(C==0)
		{
			clrscr();
			goto A;
		}
		else
		{
			goto E;
		}
		break;}
		case 2:{gotoxy(45,12);puts("Give me the name");char Nom[20];
		gotoxy(45,13);scanf("%s",Nom);
		gotoxy(45,14);printf("The account has: %lu",verifier_nom(Nom));
		getch();
		C=back_menu();
		if(C==0)
		{
			clrscr();
			goto A;
		}
		else
		{
			goto E;
		}
		break;}
		case 3:{releves(username);
		getch();
		C=back_menu();
		if(C==0)
		{
			clrscr();
			goto A;
		}
		else
		{
			goto E;
		}
		break;}
		case 4:{E:clrscr();gotoxy(50,9);printf("Thanks for your time");break;}
	}
	getch();
}
