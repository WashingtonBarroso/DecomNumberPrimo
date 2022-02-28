#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/Company.DecomNumber.Api/Company.DecomNumber.Api.csproj", "src/Company.DecomNumber.Api/"]
COPY ["src/Company.DecomNumber.Lib/Company.DecomNumber.Lib.csproj", "src/Company.DecomNumber.Lib/"]
RUN dotnet restore "src/Company.DecomNumber.Api/Company.DecomNumber.Api.csproj"
COPY . .
WORKDIR "/src/src/Company.DecomNumber.Api"
RUN dotnet build "Company.DecomNumber.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Company.DecomNumber.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Company.DecomNumber.Api.dll"]