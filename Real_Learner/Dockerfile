FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Real_Learner/Real_Learner.csproj", "Real_Learner/"]
RUN dotnet restore "Real_Learner/Real_Learner.csproj"
COPY . .
WORKDIR "/src/Real_Learner"
RUN dotnet build "Real_Learner.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Real_Learner.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Real_Learner.dll"]
