# Docker-workshop
## Pré-requis

Avoir 
- `docker` et `docker-compose` sur sa machine. 
  - Windows : https://docs.docker.com/docker-for-windows/install/
  - Linux : https://docs.docker.com/engine/install/ubuntu/
  - Mac : https://docs.docker.com/docker-for-mac/install/
- Avoir [git](https://git-scm.com/)

Vérifier vos installations avec :
```
docker -v
docker-compose -v
```
## Comment faire ce workshop ?
Vous devez suivre les étapes incluses dans le fichier steps.txt.
Vous pouvez faire la commande 
```
git checkout <no de l'étape>
```
Pour aller directement à une étape ou alors si vous êtes bloqué.

## Démmarrer
```bash
git clone https://github.com/Distil62/docker-workshop.git
cd docker-workshop
git checkout 1
```

# Guides des étapes :

## 1 Mettre en place un stockage local

Fichier à modifier :
- docker-compose.yml

### But :
Sauvegarder les données de votre base de donnée Mongo sur la machine hôte pour ne pas tout perdre lors de la suppression d'un container.

### Lien utile :
- https://docs.docker.com/compose/compose-file/compose-file-v3/#volumes
- https://hub.docker.com/_/mongo (Section "Where to Store Data")

---

## 2 Création de l'application C# local

Fichiers à modifier :
- Dockerfile

### But :
Mettre en place un environnement de développement pour une application .net core dans un environnement conteneurisé. Ce qui va nous permettre de développer notre application sans avoir à installer le SDK .net core sur notre machine physique.

### Liens utiles :
- https://hub.docker.com/_/microsoft-dotnet-sdk
- https://docs.docker.com/engine/reference/builder/#from
- https://docs.mongodb.com/drivers/csharp/

---

## 3 Conteneurisation de l'application C# Et ajout de notre application dans le docker-compose

Fichier à modifier :
- docker-compose.yml
- myApp\Dockerfile

### But :
Mettre notre application dans un container Docker afin de l'éxécuter sans avoir .NET Core installé.

### Attention !
L'application devrait échouer car dans un container elle ne peut pas se connecter à la base de données mongo locale.

### Liens utiles
- https://hub.docker.com/_/microsoft-dotnet-sdk
- https://docs.docker.com/engine/reference/builder/#from

---

## 4 Création d'un réseau virtuel privé

Fichiers à modifier :
- docker-compose.yml

## But :
Apprendre à gérer les réseaux virtuel et comment docker-compose peut nous aider à bien agencer les différents services de notre application.

## Liens utiles :
- https://docs.docker.com/compose/reference/

---

## 5 Publication de notre image sur docker-hub (ou autre)

Fichiers à modifier :
- myApp\Dockerfile

### But 
 Publier notre image sur un repo d'images afin de pouvoir l'utiliser dans nos différents environnements.

### Liens utiles :
- https://docs.docker.com/engine/reference/commandline/login/
- https://docs.docker.com/engine/reference/commandline/push/

---

## 6 Ajout de CI avec Github Action :

### Important !!! 
Pour faire cette partie vous devez fork ce dépôt.
Une fois cela fait, cliquez sur Action, cherchez "Publish Docker Container" et cliquez sur "Set up this workflow"

---

## 7 Ajouter une vérification SonarQube dans la pipeline :

Fichiers à modifier :
- .github\workflows\docker-publish.yml
- myApp\SonarQube.Analysis.xml

### But : 
Vérifier que notre code passe les tests par défaut de Sonarqube en vigueur pour les applications C#.

### Liens utiles :
- https://docs.sonarqube.org/latest/analysis/github-integration/
- https://github.com/SonarSource/sonarqube-quality-gate-action
