# Use the official image as a parent image
FROM mcr.microsoft.com/devcontainers/dotnet:1-8.0-bookworm

# Set the working directory
WORKDIR /workspace

# Copy the current directory contents into the container at /workspace
COPY . /workspace

# Install Docker
RUN apt-get update && \
    apt-get install -y docker.io && \
    apt-get clean

# Restore dependencies
RUN dotnet restore

# Expose ports
EXPOSE 5000
EXPOSE 5001

# Run the application
CMD ["dotnet", "run"]
