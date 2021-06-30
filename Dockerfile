FROM mcr.microsoft.com/dotnet/sdk:5.0

# On éxécute toutes les commandes en dessous dans le dossier /app dans le conteneur 
WORKDIR /app

# On copie tous nos fichiers excpeté ceux listé dans .dockerignore
COPY . .

# On installe nos dépendances
RUN dotnet restore


CMD [ "dotnet", "run" ]