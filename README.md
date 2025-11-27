# karat  mission 1

## Description
Application Windows Forms en C# (.NET Framework 4.8) pour la gestion des membres d'un club de karaté. Elle permet de consulter, trier, ajouter, modifier et supprimer des membres, ainsi que de filtrer par club.

## Fonctionnalit s principales
- Affichage des membres dans un DataGridView
- Filtrage par club
- Tri des membres (nom, date de naissance, département, numéro de licence)
- Ajout, modification et suppression de membres
- Connexion à une base de donn es MySQL

## Pr requis
- Visual Studio 2019 ou ult rieur
- .NET Framework 4.8
- MySQL Server
- Biblioth que NuGet : MySql.Data

## Installation
1. Cloner le dépot ou copier les fichiers sources.
2. Ouvrir la solution dans Visual Studio.
3. Restaurer les packages NuGet si n cessaire.
4. Configurer la cha ne de connexion à la base de donn es dans le fichier `BddConnexion.cs`.
5. Compiler et ex cuter le projet.

## Structure du projet
- `Frm_GestionMembre_Cons.cs` : Consultation et tri des membres
- `Frm_GestionMembres_AJ.cs` : Ajout de membres
- `Frm_GestionMembres_MS.cs` : Modification/Suppression de membres
- `BddConnexion.cs` : Gestion de la connexion à la base de donn es

## Licence
Ce projet est usage pédagogique.