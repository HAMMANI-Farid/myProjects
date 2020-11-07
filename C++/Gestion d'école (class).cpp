#include<iostream>
#include<string>
#include<fstream>
#include<cmath>
using namespace std;
class date
{
public:
    int jour;
    int mois;
    int annee;
};
class etudient
{
    public:
    int age;
    string nom;
    string prenom;
    float note[4];
    date dt;
};
void lecture(etudient *t,int n)
{
    int i;
    for ( i = 0; i < n; i++)
    {
        cout << "Donnez nom d'etudient(e) " << i+1 <<": "; cin >> t[i].nom;
        cout << "Donnez prenom d'etudient(e) " << i+1 <<": "; cin >> t[i].prenom;
        cout << "Donnez age d'etudient(e) " << i+1 <<": "; cin >> t[i].age;
        cout << "Donnez date naissance d'etudient(e) " << i+1 << endl;
        cout << "Jour: "; cin >> t[i].dt.jour;
        cout << "Mois: "; cin >> t[i].dt.mois;
        cout << "Annee: "; cin >> t[i].dt.annee;
        for (int j = 0; j < 3; j++)
        {
            cout << "Donnez note " << j+1 << ": ";cin >> t[i].note[j];t[i].note[3]+=t[i].note[j];
        }
        
    }
    
}
void affichage(etudient *t,int n)
{
    int i;
    for ( i = 0; i < n; i++)
    {
        cout << "Etudient(e)"<< i+1 << ": " << t[i].nom+" "+t[i].prenom << " " << t[i].age << " date naissance: " << 
        t[i].dt.jour << "/" << t[i].dt.mois << "/" << t[i].dt.annee << ". Moyenne:" << t[i].note[3]/3 << endl;
    }
    
}
int main()
{
    etudient et[3];
    lecture(et,1);affichage(et,1);
}