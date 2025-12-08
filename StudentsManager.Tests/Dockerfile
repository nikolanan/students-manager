FROM endeveit/docker-jq:latest AS config
WORKDIR /src
COPY . .
WORKDIR /src/StudentsManager.Tests
RUN jq '.ConnectionStrings.DefaultConnection = "Server=sqlserver;Database=StudentsManagerDatabase;User Id=sa; Password=strongPassword12!@;MultipleActiveResultSets=true"' appsettings.json > tmp.$$.json && mv tmp.$$.json appsettings.json
RUN cat appsettings.json

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY --from=config /src .
RUN dotnet restore "StudentsManager.Tests/StudentsManager.Tests.csproj"

WORKDIR /src/StudentsManager.Tests
ENTRYPOINT ["dotnet","test"]