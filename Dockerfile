FROM mcr.microsoft.com/dotnet/sdk:5.0

WORKDIR /app

COPY . .

RUN dotnet restore

CMD [ "dotnet", "run", "--configuration", "Release" ]