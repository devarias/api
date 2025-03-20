# Usar la imagen base de .NET SDK para compilar
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /api

# Copiar archivos del proyecto y restaurar dependencias
COPY *.csproj ./
RUN dotnet restore

# Copiar el resto del código y compilar
COPY . ./
RUN dotnet publish -c Release -o /out

# Usar la imagen de runtime para ejecutar la aplicación
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /api
COPY --from=build /out .

EXPOSE 8080

# Comando de inicio de la aplicación
ENTRYPOINT ["dotnet", "api.dll"]