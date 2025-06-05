## WebApi
Bardzo proste e-commerce Api

## CI/CD
```
on:
  push:
    branches:
      - main
```
Workflow uruchamiany po pushu na branch main

```
jobs:
  build:
    runs-on: ubuntu-latest
```
Wykonanie budowania aplikacji

```
- uses: actions/checkout@v3
```
Klonowanie kodu do workflow

```
- uses: actions/setup-dotnet@v4
  with:
    dotnet-version: '8.0.x'
```
Instalacja .NET 8.0

```
- run: dotnet restore
```
Pobieranie potrzebnych pakietow

```
- run: dotnet build --configuration Release --no-restore
```
Budowanie aplikacji w trybie release

```
- run: dotnet publish -c Release -o out
```
Generowanie aplikacji w katalogu out

## Azure
Adres aplikacji
https://webapidev-b2g5ana7hvfme5fk.westeurope-01.azurewebsites.net

Dostep do API
ORDERS
```
GET https://webapidev-b2g5ana7hvfme5fk.westeurope-01.azurewebsites.net/api/orders
POST https://webapidev-b2g5ana7hvfme5fk.westeurope-01.azurewebsites.net/api/orders
GET https://webapidev-b2g5ana7hvfme5fk.westeurope-01.azurewebsites.net/api/orders/{id}
DELETE https://webapidev-b2g5ana7hvfme5fk.westeurope-01.azurewebsites.net/api/orders/{id}
```

PRODUCTS
```
GET https://webapidev-b2g5ana7hvfme5fk.westeurope-01.azurewebsites.net/api/products
POST https://webapidev-b2g5ana7hvfme5fk.westeurope-01.azurewebsites.net/api/products
GET https://webapidev-b2g5ana7hvfme5fk.westeurope-01.azurewebsites.net/api/products/{id}
PUT https://webapidev-b2g5ana7hvfme5fk.westeurope-01.azurewebsites.net/api/products/{id}
DELETE https://webapidev-b2g5ana7hvfme5fk.westeurope-01.azurewebsites.net/api/products/{id}
```

Wykorzystane uslugi Azure: App Service, SQL Server, SQL Database
