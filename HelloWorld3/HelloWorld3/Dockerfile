# Use the official .NET Core SDK as a parent image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
RUN apt update
RUN apt install curl -y 
WORKDIR /app

# Copy the project file and restore any dependencies (use .csproj for the project name)
COPY *.csproj ./
RUN dotnet restore

# Copy the rest of the application code
COPY . .

# Publish the application
RUN dotnet publish -c Release -o out

# Build the runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./


# Expose the port your application will run on
EXPOSE 11130
ENV ASPNETCORE_ENVIRONMENT Development
ENV ASPNETCORE_URLS http://*:11130


ENV USER=YIGIT
# Start the application
ENTRYPOINT ["dotnet", "HelloWorld3.dll"]
